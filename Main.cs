using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 串口助手
{

    public partial class Main : Form
    {
        private SerialPort sp = new SerialPort();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.GetPorts();

            this.sp.DataReceived += new SerialDataReceivedEventHandler(DataReceived);
            comboBoxBaudRate.SelectedIndex = 0;
        }

        private void GetPorts()
        {
            String[] ports = SerialPort.GetPortNames();
            comboBoxPorts.Items.Clear();
            comboBoxPorts.Items.AddRange(ports);
            if (ports.Length >= 1)
            {
                comboBoxPorts.SelectedIndex = 0;
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (BtnOpen.Text == "打开")
            {
                BtnOpen.Text = "关闭";
                comboBoxPorts.Enabled = false;
                comboBoxBaudRate.Enabled = false;
                this.openSerial();
            }
            else
            {
                BtnOpen.Text = "打开";
                comboBoxPorts.Enabled = true;
                comboBoxBaudRate.Enabled = true;
                this.closeSerial();
            }
        }

        private void openSerial()
        {
            this.closeSerial();
            sp.PortName = comboBoxPorts.Text;
            sp.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
            sp.DataBits = 8;
            if (!sp.IsOpen)
            {
                try
                {
                    sp.Open();
                }
                catch (Exception)
                {
                    BtnOpen.Text = "打开";
                    comboBoxPorts.Enabled = true;
                    comboBoxBaudRate.Enabled = true;
                    MessageBox.Show("串口" + sp.PortName + "打开失败, 貌似被占用了!");
                }

            }
        }
        private void closeSerial()
        {
            if (sp.IsOpen)
            {
                sp.Close();
            }
        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e)//串口数据接收事件
        {
            CheckForIllegalCrossThreadCalls = false;
            string str = sp.ReadExisting();

            if (checkBoxAutoLine.Checked)
            {
                str += "\r\n";
            }

            if (checkBoxAddTime.Checked)
            {
                str = "[" + DateTime.Now.ToLocalTime().ToString() + "] " + str;
            }
            textBoxResult.AppendText(str);
        }

        private void sendSerial()
        {
            if (!sp.IsOpen)
            {
                MessageBox.Show("还没有打开端口");
                return;
            }
            if (textBoxSend.Text.Length >= 1)
            {
                sp.Write(textBoxSend.Text);
                textBoxSend.Text = "";
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            sendSerial();
        }

        private void textBoxSend_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBoxSend_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                sendSerial();
            }
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
        }
    }
}
