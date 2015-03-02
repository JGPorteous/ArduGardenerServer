using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Collections;
using System.Configuration;

namespace ArduGarenderServer
{
    public class SerialPortSettings
    {
        public string PortName;
        public int BaudRate;
        public Parity Parity;
        public StopBits StopBits;
        public int DataBits;
        public Handshake Handshake;
        public bool AutoConnect;

        public SerialPortSettings()
        {
            LoadSavedSettings();
        }

        public void UpdateAllSettings(string PortName, string BaudRate, string Parity, string StopBits, string DataBits, string AutoConnect)
        {
            //Only Save non null values
            if (PortName != null)
                this.PortName = PortName.ToString();
            if (BaudRate != null)
                int.TryParse(BaudRate.ToString(), out this.BaudRate);
            if (Parity != null)
                this.Parity = ParseParityFromString(Parity.ToString());
            if (StopBits != null)
                this.StopBits = ParseStopBitsFromString(StopBits.ToString());
            if (DataBits != null)
                int.TryParse(DataBits.ToString(), out this.DataBits);
           
            bool.TryParse(AutoConnect, out this.AutoConnect);

            SaveAllSettings();
        }

        public void LoadSavedSettings()
        {
            UpdateAllSettings(ReadSetting("PortName"), ReadSetting("BaudRate"), ReadSetting("Parity"), ReadSetting("StopBits"), ReadSetting("DataBits"), ReadSetting("AutoConnect"));
        }

        public void SaveAllSettings()
        {
            AddUpdateAppSettings("Parity", Parity.ToString());
            AddUpdateAppSettings("BaudRate", BaudRate.ToString());
            AddUpdateAppSettings("StopBits", StopBits.ToString());
            AddUpdateAppSettings("DataBits", DataBits.ToString());
            AddUpdateAppSettings("PortName", PortName);
            AddUpdateAppSettings("AutoConnect", AutoConnect.ToString());
        }
        
        public ArrayList AvailableParity()
        {
            ArrayList availablePartiy = new ArrayList();
            foreach (string parityOption in Enum.GetNames(typeof(Parity)))
                availablePartiy.Add(parityOption);

            return availablePartiy;
        }

        public ArrayList AvailableStopBits()
        {
            ArrayList availableStopBits = new ArrayList();
            foreach (string stopBitOptions in Enum.GetNames(typeof(StopBits)))
                availableStopBits.Add(stopBitOptions);

            return availableStopBits;
        }

        public ArrayList AvailableDataBits()
        {
            int[] dataBits = { 5, 6, 7, 8 };
            ArrayList availableDataBits = new ArrayList(dataBits);

            return availableDataBits;
        }

        public ArrayList AvailablePortNames()
        {
            ArrayList availablePortNames = new ArrayList(SerialPort.GetPortNames());
            return availablePortNames;

        }

        public ArrayList AvailableBaudRates()
        {
            int[] baudRate = { 4800, 9600, 19200, 38400, 57600, 115200, 230400 };
            ArrayList availableBaudRates = new ArrayList(baudRate);

            return availableBaudRates;
        }

        public Parity ParseParityFromString(string parity)
        {
            return (Parity)Enum.Parse(typeof(Parity), parity, true);
        }

        public StopBits ParseStopBitsFromString(string stopBits)
        {
            return (StopBits)Enum.Parse(typeof(StopBits), stopBits, true);
        }

        static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                throw new Exception("Error writing app settings");
            }
        }

        static string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                return "";
            }
        }
          
    }
}
