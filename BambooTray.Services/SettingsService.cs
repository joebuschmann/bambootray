using BambooTray.Domain.Settings;

namespace BambooTray.Services
{
    using System.IO;
    using System.Xml.Serialization;

    public class SettingsService : ISettingsService
    {
        private readonly string _settingsPath;
        
        public SettingsService(string settingsPath)
        {
            _settingsPath = settingsPath;

            if (!File.Exists(settingsPath))
            {
                TraySettings = new TraySettings();
                SaveTraySettings();
                return;
            }

            var serializer = new XmlSerializer(typeof(TraySettings));
            using (var streamReader = new StreamReader(settingsPath))
                TraySettings = (TraySettings)serializer.Deserialize(streamReader);
        }

        public TraySettings TraySettings { get; set; }
     
        public bool SaveTraySettings()
        {
            var serializer = new XmlSerializer(typeof(TraySettings));
            using (var streamWriter = new StreamWriter(_settingsPath))
            {
                serializer.Serialize(streamWriter, TraySettings);
            }

            return true;
        }
    }
}
