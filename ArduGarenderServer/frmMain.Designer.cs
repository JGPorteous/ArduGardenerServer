namespace ArduGarenderServer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label baudRateLabel;
            System.Windows.Forms.Label stopBitsLabel;
            System.Windows.Forms.Label dataBitsLabel;
            System.Windows.Forms.Label portNameLabel;
            System.Windows.Forms.Label parityLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbStatusSetting = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbStopBits = new System.Windows.Forms.Label();
            this.lbDataBits = new System.Windows.Forms.Label();
            this.lbParity = new System.Windows.Forms.Label();
            this.lbBaudRate = new System.Windows.Forms.Label();
            this.lbPortName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefreshAvailableSettings = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.portNameComboBox = new System.Windows.Forms.ComboBox();
            this.dataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lbPortNameSetting = new System.Windows.Forms.Label();
            this.lbBaudRateSetting = new System.Windows.Forms.Label();
            this.lbParitySetting = new System.Windows.Forms.Label();
            this.lbStopBitsSetting = new System.Windows.Forms.Label();
            this.lbDataBitsSetting = new System.Windows.Forms.Label();
            this.cbAutoConnect = new System.Windows.Forms.CheckBox();
            baudRateLabel = new System.Windows.Forms.Label();
            stopBitsLabel = new System.Windows.Forms.Label();
            dataBitsLabel = new System.Windows.Forms.Label();
            portNameLabel = new System.Windows.Forms.Label();
            parityLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // baudRateLabel
            // 
            baudRateLabel.AutoSize = true;
            baudRateLabel.Location = new System.Drawing.Point(10, 59);
            baudRateLabel.Name = "baudRateLabel";
            baudRateLabel.Size = new System.Drawing.Size(61, 13);
            baudRateLabel.TabIndex = 1;
            baudRateLabel.Text = "Baud Rate:";
            // 
            // stopBitsLabel
            // 
            stopBitsLabel.AutoSize = true;
            stopBitsLabel.Location = new System.Drawing.Point(213, 59);
            stopBitsLabel.Name = "stopBitsLabel";
            stopBitsLabel.Size = new System.Drawing.Size(52, 13);
            stopBitsLabel.TabIndex = 9;
            stopBitsLabel.Text = "Stop Bits:";
            // 
            // dataBitsLabel
            // 
            dataBitsLabel.AutoSize = true;
            dataBitsLabel.Location = new System.Drawing.Point(212, 32);
            dataBitsLabel.Name = "dataBitsLabel";
            dataBitsLabel.Size = new System.Drawing.Size(53, 13);
            dataBitsLabel.TabIndex = 3;
            dataBitsLabel.Text = "Data Bits:";
            // 
            // portNameLabel
            // 
            portNameLabel.AutoSize = true;
            portNameLabel.Location = new System.Drawing.Point(10, 32);
            portNameLabel.Name = "portNameLabel";
            portNameLabel.Size = new System.Drawing.Size(60, 13);
            portNameLabel.TabIndex = 7;
            portNameLabel.Text = "Port Name:";
            // 
            // parityLabel
            // 
            parityLabel.AutoSize = true;
            parityLabel.Location = new System.Drawing.Point(10, 86);
            parityLabel.Name = "parityLabel";
            parityLabel.Size = new System.Drawing.Size(36, 13);
            parityLabel.TabIndex = 5;
            parityLabel.Text = "Parity:";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "[Balloon Text when Minimized]";
            this.notifyIcon.BalloonTipTitle = "[Balloon Title when Minimized]";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "[Message shown when hovering over tray icon]";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbDataBitsSetting);
            this.groupBox1.Controls.Add(this.lbStopBitsSetting);
            this.groupBox1.Controls.Add(this.lbParitySetting);
            this.groupBox1.Controls.Add(this.lbBaudRateSetting);
            this.groupBox1.Controls.Add(this.lbPortNameSetting);
            this.groupBox1.Controls.Add(this.lbStatusSetting);
            this.groupBox1.Controls.Add(this.lbStatus);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbStopBits);
            this.groupBox1.Controls.Add(this.lbDataBits);
            this.groupBox1.Controls.Add(this.lbParity);
            this.groupBox1.Controls.Add(this.lbBaudRate);
            this.groupBox1.Controls.Add(this.lbPortName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbStatusSetting
            // 
            this.lbStatusSetting.AutoSize = true;
            this.lbStatusSetting.Location = new System.Drawing.Point(272, 80);
            this.lbStatusSetting.Name = "lbStatusSetting";
            this.lbStatusSetting.Size = new System.Drawing.Size(25, 13);
            this.lbStatusSetting.TabIndex = 7;
            this.lbStatusSetting.Text = "------";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(217, 80);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 6;
            this.lbStatus.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Current Settings";
            // 
            // lbStopBits
            // 
            this.lbStopBits.AutoSize = true;
            this.lbStopBits.Location = new System.Drawing.Point(216, 58);
            this.lbStopBits.Name = "lbStopBits";
            this.lbStopBits.Size = new System.Drawing.Size(49, 13);
            this.lbStopBits.TabIndex = 4;
            this.lbStopBits.Text = "Stop Bits";
            // 
            // lbDataBits
            // 
            this.lbDataBits.AutoSize = true;
            this.lbDataBits.Location = new System.Drawing.Point(6, 80);
            this.lbDataBits.Name = "lbDataBits";
            this.lbDataBits.Size = new System.Drawing.Size(33, 13);
            this.lbDataBits.TabIndex = 3;
            this.lbDataBits.Text = "Parity";
            // 
            // lbParity
            // 
            this.lbParity.AutoSize = true;
            this.lbParity.Location = new System.Drawing.Point(216, 35);
            this.lbParity.Name = "lbParity";
            this.lbParity.Size = new System.Drawing.Size(50, 13);
            this.lbParity.TabIndex = 2;
            this.lbParity.Text = "Data Bits";
            // 
            // lbBaudRate
            // 
            this.lbBaudRate.AutoSize = true;
            this.lbBaudRate.Location = new System.Drawing.Point(6, 58);
            this.lbBaudRate.Name = "lbBaudRate";
            this.lbBaudRate.Size = new System.Drawing.Size(58, 13);
            this.lbBaudRate.TabIndex = 1;
            this.lbBaudRate.Text = "Baud Rate";
            // 
            // lbPortName
            // 
            this.lbPortName.AutoSize = true;
            this.lbPortName.Location = new System.Drawing.Point(6, 35);
            this.lbPortName.Name = "lbPortName";
            this.lbPortName.Size = new System.Drawing.Size(53, 13);
            this.lbPortName.TabIndex = 0;
            this.lbPortName.Text = "COM Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbAutoConnect);
            this.groupBox2.Controls.Add(this.btnRefreshAvailableSettings);
            this.groupBox2.Controls.Add(this.btnSaveSettings);
            this.groupBox2.Controls.Add(this.baudRateComboBox);
            this.groupBox2.Controls.Add(baudRateLabel);
            this.groupBox2.Controls.Add(this.stopBitsComboBox);
            this.groupBox2.Controls.Add(stopBitsLabel);
            this.groupBox2.Controls.Add(dataBitsLabel);
            this.groupBox2.Controls.Add(this.portNameComboBox);
            this.groupBox2.Controls.Add(this.dataBitsComboBox);
            this.groupBox2.Controls.Add(portNameLabel);
            this.groupBox2.Controls.Add(parityLabel);
            this.groupBox2.Controls.Add(this.parityComboBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 138);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Port Settings";
            // 
            // btnRefreshAvailableSettings
            // 
            this.btnRefreshAvailableSettings.Location = new System.Drawing.Point(7, 108);
            this.btnRefreshAvailableSettings.Name = "btnRefreshAvailableSettings";
            this.btnRefreshAvailableSettings.Size = new System.Drawing.Size(168, 23);
            this.btnRefreshAvailableSettings.TabIndex = 12;
            this.btnRefreshAvailableSettings.Text = "Refresh Available Settings";
            this.btnRefreshAvailableSettings.UseVisualStyleBackColor = true;
            this.btnRefreshAvailableSettings.Click += new System.EventHandler(this.btnRefreshAvailableSettings_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(407, 109);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettings.TabIndex = 11;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Location = new System.Drawing.Point(77, 56);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(121, 21);
            this.baudRateComboBox.TabIndex = 2;
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.FormattingEnabled = true;
            this.stopBitsComboBox.Location = new System.Drawing.Point(275, 56);
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Size = new System.Drawing.Size(121, 21);
            this.stopBitsComboBox.TabIndex = 10;
            // 
            // portNameComboBox
            // 
            this.portNameComboBox.FormattingEnabled = true;
            this.portNameComboBox.Location = new System.Drawing.Point(77, 29);
            this.portNameComboBox.Name = "portNameComboBox";
            this.portNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.portNameComboBox.TabIndex = 8;
            // 
            // dataBitsComboBox
            // 
            this.dataBitsComboBox.FormattingEnabled = true;
            this.dataBitsComboBox.Location = new System.Drawing.Point(275, 29);
            this.dataBitsComboBox.Name = "dataBitsComboBox";
            this.dataBitsComboBox.Size = new System.Drawing.Size(121, 21);
            this.dataBitsComboBox.TabIndex = 4;
            // 
            // parityComboBox
            // 
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Location = new System.Drawing.Point(77, 83);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new System.Drawing.Size(121, 21);
            this.parityComboBox.TabIndex = 6;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(319, 278);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 13;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(419, 278);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 14;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lbPortNameSetting
            // 
            this.lbPortNameSetting.AutoSize = true;
            this.lbPortNameSetting.Location = new System.Drawing.Point(74, 35);
            this.lbPortNameSetting.Name = "lbPortNameSetting";
            this.lbPortNameSetting.Size = new System.Drawing.Size(53, 13);
            this.lbPortNameSetting.TabIndex = 8;
            this.lbPortNameSetting.Text = "COM Port";
            // 
            // lbBaudRateSetting
            // 
            this.lbBaudRateSetting.AutoSize = true;
            this.lbBaudRateSetting.Location = new System.Drawing.Point(74, 58);
            this.lbBaudRateSetting.Name = "lbBaudRateSetting";
            this.lbBaudRateSetting.Size = new System.Drawing.Size(58, 13);
            this.lbBaudRateSetting.TabIndex = 9;
            this.lbBaudRateSetting.Text = "Baud Rate";
            // 
            // lbParitySetting
            // 
            this.lbParitySetting.AutoSize = true;
            this.lbParitySetting.Location = new System.Drawing.Point(74, 80);
            this.lbParitySetting.Name = "lbParitySetting";
            this.lbParitySetting.Size = new System.Drawing.Size(33, 13);
            this.lbParitySetting.TabIndex = 10;
            this.lbParitySetting.Text = "Parity";
            // 
            // lbStopBitsSetting
            // 
            this.lbStopBitsSetting.AutoSize = true;
            this.lbStopBitsSetting.Location = new System.Drawing.Point(271, 58);
            this.lbStopBitsSetting.Name = "lbStopBitsSetting";
            this.lbStopBitsSetting.Size = new System.Drawing.Size(49, 13);
            this.lbStopBitsSetting.TabIndex = 11;
            this.lbStopBitsSetting.Text = "Stop Bits";
            // 
            // lbDataBitsSetting
            // 
            this.lbDataBitsSetting.AutoSize = true;
            this.lbDataBitsSetting.Location = new System.Drawing.Point(272, 35);
            this.lbDataBitsSetting.Name = "lbDataBitsSetting";
            this.lbDataBitsSetting.Size = new System.Drawing.Size(50, 13);
            this.lbDataBitsSetting.TabIndex = 12;
            this.lbDataBitsSetting.Text = "Data Bits";
            // 
            // cbAutoConnect
            // 
            this.cbAutoConnect.AutoSize = true;
            this.cbAutoConnect.Location = new System.Drawing.Point(275, 87);
            this.cbAutoConnect.Name = "cbAutoConnect";
            this.cbAutoConnect.Size = new System.Drawing.Size(145, 17);
            this.cbAutoConnect.TabIndex = 13;
            this.cbAutoConnect.Text = "Auto Connect on StartUp";
            this.cbAutoConnect.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 333);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Ardu-Gardener Server";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbStopBits;
        private System.Windows.Forms.Label lbDataBits;
        private System.Windows.Forms.Label lbParity;
        private System.Windows.Forms.Label lbBaudRate;
        private System.Windows.Forms.Label lbPortName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.ComboBox stopBitsComboBox;
        private System.Windows.Forms.ComboBox portNameComboBox;
        private System.Windows.Forms.ComboBox dataBitsComboBox;
        private System.Windows.Forms.ComboBox parityComboBox;
        private System.Windows.Forms.Label lbStatusSetting;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRefreshAvailableSettings;
        private System.Windows.Forms.Label lbDataBitsSetting;
        private System.Windows.Forms.Label lbStopBitsSetting;
        private System.Windows.Forms.Label lbParitySetting;
        private System.Windows.Forms.Label lbBaudRateSetting;
        private System.Windows.Forms.Label lbPortNameSetting;
        private System.Windows.Forms.CheckBox cbAutoConnect;
    }
}

