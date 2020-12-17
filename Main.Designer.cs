
namespace 串口助手
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.BtnOpen = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.checkBoxAutoLine = new System.Windows.Forms.CheckBox();
            this.checkBoxAddTime = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnOpen
            // 
            this.BtnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnOpen.Location = new System.Drawing.Point(141, 431);
            this.BtnOpen.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(59, 20);
            this.BtnOpen.TabIndex = 0;
            this.BtnOpen.Text = "打开";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.Location = new System.Drawing.Point(12, 12);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(504, 413);
            this.textBoxResult.TabIndex = 1;
            // 
            // textBoxSend
            // 
            this.textBoxSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSend.Location = new System.Drawing.Point(12, 459);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSend.Size = new System.Drawing.Size(504, 102);
            this.textBoxSend.TabIndex = 2;
            this.textBoxSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSend_KeyPress);
            this.textBoxSend.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSend_KeyUp);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(12, 431);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(60, 20);
            this.comboBoxPorts.TabIndex = 3;
            this.comboBoxPorts.Tag = "";
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.Location = new System.Drawing.Point(405, 533);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(109, 26);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "发送(Ctrl+Enter)";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(78, 431);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(60, 20);
            this.comboBoxBaudRate.TabIndex = 3;
            this.comboBoxBaudRate.Tag = "";
            this.comboBoxBaudRate.Text = "9600";
            // 
            // checkBoxAutoLine
            // 
            this.checkBoxAutoLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAutoLine.AutoSize = true;
            this.checkBoxAutoLine.Location = new System.Drawing.Point(228, 433);
            this.checkBoxAutoLine.Name = "checkBoxAutoLine";
            this.checkBoxAutoLine.Size = new System.Drawing.Size(72, 16);
            this.checkBoxAutoLine.TabIndex = 5;
            this.checkBoxAutoLine.Text = "自动换行";
            this.checkBoxAutoLine.UseVisualStyleBackColor = true;
            // 
            // checkBoxAddTime
            // 
            this.checkBoxAddTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAddTime.AutoSize = true;
            this.checkBoxAddTime.Location = new System.Drawing.Point(306, 433);
            this.checkBoxAddTime.Name = "checkBoxAddTime";
            this.checkBoxAddTime.Size = new System.Drawing.Size(72, 16);
            this.checkBoxAddTime.TabIndex = 5;
            this.checkBoxAddTime.Text = "添加时间";
            this.checkBoxAddTime.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 582);
            this.Controls.Add(this.checkBoxAddTime);
            this.Controls.Add(this.checkBoxAutoLine);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxSend);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "串口助手";
            this.Load += new System.EventHandler(this.Main_Load);
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.CheckBox checkBoxAutoLine;
        private System.Windows.Forms.CheckBox checkBoxAddTime;
    }
}

