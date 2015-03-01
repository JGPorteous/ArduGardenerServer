using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduGarenderServer
{
    public partial class frmMain : Form
    {
        SerialPortManager spManager = new SerialPortManager();

        public frmMain()
        {
            InitializeComponent();

            InitializeUser();
            GetCurrentSettings();
        }

        private void InitializeUser()
        {
            //Get Available Values
            parityComboBox.DataSource = spManager.Settings.AvailableParity();
            stopBitsComboBox.DataSource = spManager.Settings.AvailableStopBits();
            portNameComboBox.DataSource = spManager.Settings.AvailablePortNames();
            baudRateComboBox.DataSource = spManager.Settings.AvailableBaudRates();
            dataBitsComboBox.DataSource = spManager.Settings.AvailableDataBits();

            ////Clear Selected Items if list is empty
            if (portNameComboBox.Items.Count == 0)  
                portNameComboBox.Text = String.Empty;
            if (parityComboBox.Items.Count == 0)
                parityComboBox.Text = String.Empty;
            if (stopBitsComboBox.Items.Count == 0)
                stopBitsComboBox.Text = String.Empty;
            if (baudRateComboBox.Items.Count == 0)
                baudRateComboBox.Text = String.Empty;
            if (dataBitsComboBox.Items.Count == 0)
                dataBitsComboBox.Text = String.Empty;
   
            try {
                parityComboBox.SelectedIndex = parityComboBox.FindString(spManager.Settings.Parity.ToString());
                stopBitsComboBox.SelectedIndex = stopBitsComboBox.FindString(spManager.Settings.StopBits.ToString());
                baudRateComboBox.SelectedIndex = baudRateComboBox.FindString(spManager.Settings.BaudRate.ToString());
                dataBitsComboBox.SelectedIndex = dataBitsComboBox.FindString(spManager.Settings.DataBits.ToString());
                portNameComboBox.SelectedIndex = portNameComboBox.FindStringExact(spManager.Settings.PortName);

            }
            catch (Exception thisException)
            {
                //Do Nothing
                thisException = null;
            }
        }

        private void GetCurrentSettings()
        { 
             
        }
      
        private void frmMain_Closing(object sender, FormClosingEventArgs e)
        {
           
        }
        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }
         

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

     
        private void frmMain_Load(object sender, EventArgs e)
        {
            UpdateCurrentSettingsDisplay();
            if (spManager.Settings.AutoConnect)
                if (!spManager.Connect())
                    MessageBox.Show(spManager.LastException().Message,"Error Connecting to COM Port!");

            lbStatusSetting.Text = spManager.Status();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            spManager.Settings.UpdateAllSettings(portNameComboBox.SelectedItem.ToString(), baudRateComboBox.SelectedItem.ToString(), parityComboBox.SelectedItem.ToString(), stopBitsComboBox.SelectedItem.ToString(), dataBitsComboBox.SelectedItem.ToString(),cbAutoConnect.Checked.ToString());
            spManager.Settings.AutoConnect = cbAutoConnect.Checked;
 
            UpdateCurrentSettingsDisplay();
        }

        private void UpdateCurrentSettingsDisplay()
        {
            lbBaudRateSetting.Text = spManager.Settings.BaudRate.ToString();
            lbDataBitsSetting.Text = spManager.Settings.DataBits.ToString();
            lbPortNameSetting.Text = spManager.Settings.PortName;
            lbParitySetting.Text = spManager.Settings.Parity.ToString();
            lbStopBitsSetting.Text = spManager.Settings.StopBits.ToString();
            cbAutoConnect.Checked = spManager.Settings.AutoConnect;
        }

        
        private void btnRefreshAvailableSettings_Click(object sender, EventArgs e)
        {
            InitializeUser();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!spManager.Connect())
                MessageBox.Show(spManager.LastException().Message);
            lbStatusSetting.Text = spManager.Status();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            spManager.Disconnect();
            lbStatusSetting.Text = spManager.Status();
        }

    }
}
