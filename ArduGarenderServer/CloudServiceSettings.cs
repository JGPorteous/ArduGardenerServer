using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduGarenderServer
{
    class CloudServiceSettings
    {
        public string Url;
        public string User;
        public string Token;

        public CloudServiceSettings()
        {
            LoadSavedSettings();
        }

        public void UpdateAllSettings(string Url, string User, string Token)
        {
            //Only Save non null values
            if (Url != null)
                this.Url = Url.ToString();
            if (User != null)
                this.User = User.ToString();
            if (Token != null)
                this.Token = Token.ToString();
            
            SaveAllSettings();
        }

        public void LoadSavedSettings()
        {
            UpdateAllSettings(ReadSetting("CloudUrl"), ReadSetting("CloudUser"), ReadSetting("CloudToken"));
        }

        public void SaveAllSettings()
        {
            AddUpdateAppSettings("CloudUrl", Url.ToString());
            AddUpdateAppSettings("CloudUser", User.ToString());
            AddUpdateAppSettings("CloudToken", Token.ToString());
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
