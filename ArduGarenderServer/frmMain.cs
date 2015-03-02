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
        CloudService cloudService = new CloudService();
        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;
        bool keepAppOpen = true;

        public frmMain()
        {
            InitializeComponent();
            InitializeSystemTrayMenu();
            InitializeUser();
            GetCurrentSettings();
        }

        private void InitializeSystemTrayMenu()
        { 
            // Create a sytem tray menu 
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Exit", OnExit);
            trayMenu.MenuItems.Add("Open", ShowWindow);
            // Create a tray icon. In this example we use a
            // standard system icon for simplicity, but you
            // can of course use your own custom icon too.
            trayIcon = new NotifyIcon();
            trayIcon.Text = "ArduGardener Server";
            trayIcon.Icon = new Icon("Resources\\ArduGardener.ico", 40, 40);

            // Add menu to tray icon and show it.
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible = true; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.

            base.OnLoad(e);
        }

        private void ShowWindow(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void OnExit(object sender, EventArgs e)
        {
            keepAppOpen = false;
            Application.Exit();
        }

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                // Release the icon resource.
                trayIcon.Dispose();
                if (components != null)
                    components.Dispose();
            }

            base.Dispose(isDisposing);
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

                tbCloudAuthToken.Text = cloudService.Settings.Token;
                tbCloudServiceUrl.Text = cloudService.Settings.Url;
                tbCloudUserCode.Text = cloudService.Settings.User;
                    
                }
                catch (Exception thisException)
                {
 
                }
        }

        private void GetCurrentSettings()
        { 
             
        }
      
        private void frmMain_Closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = keepAppOpen;
            this.WindowState = FormWindowState.Minimized;
            //Visible = false;

            //if (FormWindowState.Minimized == WindowState)
             //   Hide();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
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

        private void gbSerialPortSettings_Enter(object sender, EventArgs e)
        {

        }

        private void btnTestCloudSettings_Click(object sender, EventArgs e)
        {
            if (!cloudService.TestConnection())
                MessageBox.Show(cloudService.LastException.Message, "Test Cloud Services");
            else
                MessageBox.Show("Connected!", "Test Cloud Services");

        }

        private void btnSaveCloudSettings_Click(object sender, EventArgs e)
        {
            cloudService.Settings.UpdateAllSettings(tbCloudServiceUrl.Text, tbCloudUserCode.Text, tbCloudAuthToken.Text);
        }



    }
}
