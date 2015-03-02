namespace ArduGarenderServer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        ///// <summary>
        ///// Clean up any resources being used.
        ///// </summary>
        ///// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label baudRateLabel;
            System.Windows.Forms.Label stopBitsLabel;
            System.Windows.Forms.Label dataBitsLabel;
            System.Windows.Forms.Label portNameLabel;
            System.Windows.Forms.Label parityLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gbCurrentSettings = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lbDataBitsSetting = new System.Windows.Forms.Label();
            this.lbStopBitsSetting = new System.Windows.Forms.Label();
            this.lbParitySetting = new System.Windows.Forms.Label();
            this.lbBaudRateSetting = new System.Windows.Forms.Label();
            this.lbPortNameSetting = new System.Windows.Forms.Label();
            this.lbStatusSetting = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbStopBits = new System.Windows.Forms.Label();
            this.lbDataBits = new System.Windows.Forms.Label();
            this.lbParity = new System.Windows.Forms.Label();
            this.lbBaudRate = new System.Windows.Forms.Label();
            this.lbPortName = new System.Windows.Forms.Label();
            this.gbSerialPortSettings = new System.Windows.Forms.GroupBox();
            this.cbAutoConnect = new System.Windows.Forms.CheckBox();
            this.btnRefreshAvailableSettings = new System.Windows.Forms.Button();
            this.btnSaveSerialPortSettings = new System.Windows.Forms.Button();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.portNameComboBox = new System.Windows.Forms.ComboBox();
            this.dataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.gbCloudSettings = new System.Windows.Forms.GroupBox();
            this.btnTestCloudSettings = new System.Windows.Forms.Button();
            this.btnSaveCloudSettings = new System.Windows.Forms.Button();
            this.tbCloudAuthToken = new System.Windows.Forms.TextBox();
            this.tbCloudUserCode = new System.Windows.Forms.TextBox();
            this.tbCloudServiceUrl = new System.Windows.Forms.TextBox();
            this.lbAuthenticationToken = new System.Windows.Forms.Label();
            this.lbUserCode = new System.Windows.Forms.Label();
            this.lbCloudServiceUrl = new System.Windows.Forms.Label();
            baudRateLabel = new System.Windows.Forms.Label();
            stopBitsLabel = new System.Windows.Forms.Label();
            dataBitsLabel = new System.Windows.Forms.Label();
            portNameLabel = new System.Windows.Forms.Label();
            parityLabel = new System.Windows.Forms.Label();
            this.gbCurrentSettings.SuspendLayout();
            this.gbSerialPortSettings.SuspendLayout();
            this.gbCloudSettings.SuspendLayout();
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
            // gbCurrentSettings
            // 
            this.gbCurrentSettings.Controls.Add(this.btnDisconnect);
            this.gbCurrentSettings.Controls.Add(this.btnConnect);
            this.gbCurrentSettings.Controls.Add(this.lbDataBitsSetting);
            this.gbCurrentSettings.Controls.Add(this.lbStopBitsSetting);
            this.gbCurrentSettings.Controls.Add(this.lbParitySetting);
            this.gbCurrentSettings.Controls.Add(this.lbBaudRateSetting);
            this.gbCurrentSettings.Controls.Add(this.lbPortNameSetting);
            this.gbCurrentSettings.Controls.Add(this.lbStatusSetting);
            this.gbCurrentSettings.Controls.Add(this.lbStatus);
            this.gbCurrentSettings.Controls.Add(this.lbStopBits);
            this.gbCurrentSettings.Controls.Add(this.lbDataBits);
            this.gbCurrentSettings.Controls.Add(this.lbParity);
            this.gbCurrentSettings.Controls.Add(this.lbBaudRate);
            this.gbCurrentSettings.Controls.Add(this.lbPortName);
            this.gbCurrentSettings.Location = new System.Drawing.Point(12, 12);
            this.gbCurrentSettings.Name = "gbCurrentSettings";
            this.gbCurrentSettings.Size = new System.Drawing.Size(488, 122);
            this.gbCurrentSettings.TabIndex = 0;
            this.gbCurrentSettings.TabStop = false;
            this.gbCurrentSettings.Text = "Current Settings";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(303, 91);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 13;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(384, 91);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 14;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lbDataBitsSetting
            // 
            this.lbDataBitsSetting.AutoSize = true;
            this.lbDataBitsSetting.Location = new System.Drawing.Point(273, 26);
            this.lbDataBitsSetting.Name = "lbDataBitsSetting";
            this.lbDataBitsSetting.Size = new System.Drawing.Size(50, 13);
            this.lbDataBitsSetting.TabIndex = 12;
            this.lbDataBitsSetting.Text = "Data Bits";
            // 
            // lbStopBitsSetting
            // 
            this.lbStopBitsSetting.AutoSize = true;
            this.lbStopBitsSetting.Location = new System.Drawing.Point(272, 49);
            this.lbStopBitsSetting.Name = "lbStopBitsSetting";
            this.lbStopBitsSetting.Size = new System.Drawing.Size(49, 13);
            this.lbStopBitsSetting.TabIndex = 11;
            this.lbStopBitsSetting.Text = "Stop Bits";
            // 
            // lbParitySetting
            // 
            this.lbParitySetting.AutoSize = true;
            this.lbParitySetting.Location = new System.Drawing.Point(75, 71);
            this.lbParitySetting.Name = "lbParitySetting";
            this.lbParitySetting.Size = new System.Drawing.Size(33, 13);
            this.lbParitySetting.TabIndex = 10;
            this.lbParitySetting.Text = "Parity";
            // 
            // lbBaudRateSetting
            // 
            this.lbBaudRateSetting.AutoSize = true;
            this.lbBaudRateSetting.Location = new System.Drawing.Point(75, 49);
            this.lbBaudRateSetting.Name = "lbBaudRateSetting";
            this.lbBaudRateSetting.Size = new System.Drawing.Size(58, 13);
            this.lbBaudRateSetting.TabIndex = 9;
            this.lbBaudRateSetting.Text = "Baud Rate";
            // 
            // lbPortNameSetting
            // 
            this.lbPortNameSetting.AutoSize = true;
            this.lbPortNameSetting.Location = new System.Drawing.Point(75, 26);
            this.lbPortNameSetting.Name = "lbPortNameSetting";
            this.lbPortNameSetting.Size = new System.Drawing.Size(53, 13);
            this.lbPortNameSetting.TabIndex = 8;
            this.lbPortNameSetting.Text = "COM Port";
            // 
            // lbStatusSetting
            // 
            this.lbStatusSetting.AutoSize = true;
            this.lbStatusSetting.Location = new System.Drawing.Point(273, 71);
            this.lbStatusSetting.Name = "lbStatusSetting";
            this.lbStatusSetting.Size = new System.Drawing.Size(25, 13);
            this.lbStatusSetting.TabIndex = 7;
            this.lbStatusSetting.Text = "------";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(218, 71);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 6;
            this.lbStatus.Text = "Status";
            // 
            // lbStopBits
            // 
            this.lbStopBits.AutoSize = true;
            this.lbStopBits.Location = new System.Drawing.Point(217, 49);
            this.lbStopBits.Name = "lbStopBits";
            this.lbStopBits.Size = new System.Drawing.Size(49, 13);
            this.lbStopBits.TabIndex = 4;
            this.lbStopBits.Text = "Stop Bits";
            // 
            // lbDataBits
            // 
            this.lbDataBits.AutoSize = true;
            this.lbDataBits.Location = new System.Drawing.Point(7, 71);
            this.lbDataBits.Name = "lbDataBits";
            this.lbDataBits.Size = new System.Drawing.Size(33, 13);
            this.lbDataBits.TabIndex = 3;
            this.lbDataBits.Text = "Parity";
            // 
            // lbParity
            // 
            this.lbParity.AutoSize = true;
            this.lbParity.Location = new System.Drawing.Point(217, 26);
            this.lbParity.Name = "lbParity";
            this.lbParity.Size = new System.Drawing.Size(50, 13);
            this.lbParity.TabIndex = 2;
            this.lbParity.Text = "Data Bits";
            // 
            // lbBaudRate
            // 
            this.lbBaudRate.AutoSize = true;
            this.lbBaudRate.Location = new System.Drawing.Point(7, 49);
            this.lbBaudRate.Name = "lbBaudRate";
            this.lbBaudRate.Size = new System.Drawing.Size(58, 13);
            this.lbBaudRate.TabIndex = 1;
            this.lbBaudRate.Text = "Baud Rate";
            // 
            // lbPortName
            // 
            this.lbPortName.AutoSize = true;
            this.lbPortName.Location = new System.Drawing.Point(7, 26);
            this.lbPortName.Name = "lbPortName";
            this.lbPortName.Size = new System.Drawing.Size(53, 13);
            this.lbPortName.TabIndex = 0;
            this.lbPortName.Text = "COM Port";
            // 
            // gbSerialPortSettings
            // 
            this.gbSerialPortSettings.Controls.Add(this.cbAutoConnect);
            this.gbSerialPortSettings.Controls.Add(this.btnRefreshAvailableSettings);
            this.gbSerialPortSettings.Controls.Add(this.btnSaveSerialPortSettings);
            this.gbSerialPortSettings.Controls.Add(this.baudRateComboBox);
            this.gbSerialPortSettings.Controls.Add(baudRateLabel);
            this.gbSerialPortSettings.Controls.Add(this.stopBitsComboBox);
            this.gbSerialPortSettings.Controls.Add(stopBitsLabel);
            this.gbSerialPortSettings.Controls.Add(dataBitsLabel);
            this.gbSerialPortSettings.Controls.Add(this.portNameComboBox);
            this.gbSerialPortSettings.Controls.Add(this.dataBitsComboBox);
            this.gbSerialPortSettings.Controls.Add(portNameLabel);
            this.gbSerialPortSettings.Controls.Add(parityLabel);
            this.gbSerialPortSettings.Controls.Add(this.parityComboBox);
            this.gbSerialPortSettings.Location = new System.Drawing.Point(12, 140);
            this.gbSerialPortSettings.Name = "gbSerialPortSettings";
            this.gbSerialPortSettings.Size = new System.Drawing.Size(488, 138);
            this.gbSerialPortSettings.TabIndex = 12;
            this.gbSerialPortSettings.TabStop = false;
            this.gbSerialPortSettings.Text = "Serial Port Settings";
            this.gbSerialPortSettings.Enter += new System.EventHandler(this.gbSerialPortSettings_Enter);
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
            // btnSaveSerialPortSettings
            // 
            this.btnSaveSerialPortSettings.Location = new System.Drawing.Point(372, 109);
            this.btnSaveSerialPortSettings.Name = "btnSaveSerialPortSettings";
            this.btnSaveSerialPortSettings.Size = new System.Drawing.Size(110, 23);
            this.btnSaveSerialPortSettings.TabIndex = 11;
            this.btnSaveSerialPortSettings.Text = "Save Settings";
            this.btnSaveSerialPortSettings.UseVisualStyleBackColor = true;
            this.btnSaveSerialPortSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
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
            // gbCloudSettings
            // 
            this.gbCloudSettings.Controls.Add(this.btnTestCloudSettings);
            this.gbCloudSettings.Controls.Add(this.btnSaveCloudSettings);
            this.gbCloudSettings.Controls.Add(this.tbCloudAuthToken);
            this.gbCloudSettings.Controls.Add(this.tbCloudUserCode);
            this.gbCloudSettings.Controls.Add(this.tbCloudServiceUrl);
            this.gbCloudSettings.Controls.Add(this.lbAuthenticationToken);
            this.gbCloudSettings.Controls.Add(this.lbUserCode);
            this.gbCloudSettings.Controls.Add(this.lbCloudServiceUrl);
            this.gbCloudSettings.Location = new System.Drawing.Point(12, 284);
            this.gbCloudSettings.Name = "gbCloudSettings";
            this.gbCloudSettings.Size = new System.Drawing.Size(488, 147);
            this.gbCloudSettings.TabIndex = 13;
            this.gbCloudSettings.TabStop = false;
            this.gbCloudSettings.Text = "Cloud Settings";
            // 
            // btnTestCloudSettings
            // 
            this.btnTestCloudSettings.Location = new System.Drawing.Point(206, 108);
            this.btnTestCloudSettings.Name = "btnTestCloudSettings";
            this.btnTestCloudSettings.Size = new System.Drawing.Size(130, 23);
            this.btnTestCloudSettings.TabIndex = 13;
            this.btnTestCloudSettings.Text = "Test CloudSettings";
            this.btnTestCloudSettings.UseVisualStyleBackColor = true;
            this.btnTestCloudSettings.Click += new System.EventHandler(this.btnTestCloudSettings_Click);
            // 
            // btnSaveCloudSettings
            // 
            this.btnSaveCloudSettings.Location = new System.Drawing.Point(342, 108);
            this.btnSaveCloudSettings.Name = "btnSaveCloudSettings";
            this.btnSaveCloudSettings.Size = new System.Drawing.Size(140, 23);
            this.btnSaveCloudSettings.TabIndex = 12;
            this.btnSaveCloudSettings.Text = "Save Cloud Settings";
            this.btnSaveCloudSettings.UseVisualStyleBackColor = true;
            this.btnSaveCloudSettings.Click += new System.EventHandler(this.btnSaveCloudSettings_Click);
            // 
            // tbCloudAuthToken
            // 
            this.tbCloudAuthToken.Location = new System.Drawing.Point(137, 73);
            this.tbCloudAuthToken.Name = "tbCloudAuthToken";
            this.tbCloudAuthToken.Size = new System.Drawing.Size(345, 20);
            this.tbCloudAuthToken.TabIndex = 5;
            // 
            // tbCloudUserCode
            // 
            this.tbCloudUserCode.Location = new System.Drawing.Point(137, 47);
            this.tbCloudUserCode.Name = "tbCloudUserCode";
            this.tbCloudUserCode.Size = new System.Drawing.Size(345, 20);
            this.tbCloudUserCode.TabIndex = 4;
            // 
            // tbCloudServiceUrl
            // 
            this.tbCloudServiceUrl.Location = new System.Drawing.Point(137, 21);
            this.tbCloudServiceUrl.Name = "tbCloudServiceUrl";
            this.tbCloudServiceUrl.Size = new System.Drawing.Size(345, 20);
            this.tbCloudServiceUrl.TabIndex = 3;
            // 
            // lbAuthenticationToken
            // 
            this.lbAuthenticationToken.AutoSize = true;
            this.lbAuthenticationToken.Location = new System.Drawing.Point(11, 76);
            this.lbAuthenticationToken.Name = "lbAuthenticationToken";
            this.lbAuthenticationToken.Size = new System.Drawing.Size(109, 13);
            this.lbAuthenticationToken.TabIndex = 2;
            this.lbAuthenticationToken.Text = "Authentication Token";
            // 
            // lbUserCode
            // 
            this.lbUserCode.AutoSize = true;
            this.lbUserCode.Location = new System.Drawing.Point(10, 50);
            this.lbUserCode.Name = "lbUserCode";
            this.lbUserCode.Size = new System.Drawing.Size(57, 13);
            this.lbUserCode.TabIndex = 1;
            this.lbUserCode.Text = "User Code";
            // 
            // lbCloudServiceUrl
            // 
            this.lbCloudServiceUrl.AutoSize = true;
            this.lbCloudServiceUrl.Location = new System.Drawing.Point(11, 21);
            this.lbCloudServiceUrl.Name = "lbCloudServiceUrl";
            this.lbCloudServiceUrl.Size = new System.Drawing.Size(98, 13);
            this.lbCloudServiceUrl.TabIndex = 0;
            this.lbCloudServiceUrl.Text = "Cloud Service URL";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 472);
            this.Controls.Add(this.gbCloudSettings);
            this.Controls.Add(this.gbSerialPortSettings);
            this.Controls.Add(this.gbCurrentSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Ardu-Gardener Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_Closing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.gbCurrentSettings.ResumeLayout(false);
            this.gbCurrentSettings.PerformLayout();
            this.gbSerialPortSettings.ResumeLayout(false);
            this.gbSerialPortSettings.PerformLayout();
            this.gbCloudSettings.ResumeLayout(false);
            this.gbCloudSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCurrentSettings;
        private System.Windows.Forms.Label lbStopBits;
        private System.Windows.Forms.Label lbDataBits;
        private System.Windows.Forms.Label lbParity;
        private System.Windows.Forms.Label lbBaudRate;
        private System.Windows.Forms.Label lbPortName;
        private System.Windows.Forms.GroupBox gbSerialPortSettings;
        private System.Windows.Forms.Button btnSaveSerialPortSettings;
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
        private System.Windows.Forms.GroupBox gbCloudSettings;
        private System.Windows.Forms.Label lbAuthenticationToken;
        private System.Windows.Forms.Label lbUserCode;
        private System.Windows.Forms.Label lbCloudServiceUrl;
        private System.Windows.Forms.Button btnTestCloudSettings;
        private System.Windows.Forms.Button btnSaveCloudSettings;
        private System.Windows.Forms.TextBox tbCloudAuthToken;
        private System.Windows.Forms.TextBox tbCloudUserCode;
        private System.Windows.Forms.TextBox tbCloudServiceUrl;
    }
}

