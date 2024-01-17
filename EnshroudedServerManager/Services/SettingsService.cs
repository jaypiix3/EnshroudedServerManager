using EnshroudedServerManager.Models;
using Newtonsoft.Json;

namespace EnshroudedServerManager.Services
{
    public class SettingsService
    {
        public Settings? LoadSettings(string filePath)
        {
            Settings? settings = null;

            var settingsString = File.ReadAllText(filePath);
            if (!string.IsNullOrEmpty(settingsString))
            {
                settings = JsonConvert.DeserializeObject<Settings>(settingsString);
            }

            return settings;
        }

        public void SaveSettings(Settings settings, string filePath)
        {
            if (settings != null)
            {
                try
                {
                    string serializedSettings = JsonConvert.SerializeObject(settings);
                    File.WriteAllText(filePath, serializedSettings);
                }
                catch (Exception)
                {
                    CustomMessageBox cmb = new CustomMessageBox("Error while saving", "An error appeared while saving the settings.");
                    cmb.Show();
                }
                
            }
        }

        public void CopySettings(string sourceFilePath, string destinationFilePath)
        {
            try
            {
                File.Copy(sourceFilePath, destinationFilePath);
            }
            catch (Exception)
            {
                CustomMessageBox cmb = new CustomMessageBox("Error while transfering", "An error appeared while transfering the settings.");
                cmb.Show();
            }
        }
    }
}
