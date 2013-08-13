namespace Halltom.Bamboo.Tray.Services
{
    using System.IO;
    using System.Xml.Serialization;

    using Halltom.Bamboo.Tray.Domain.Settings;

    public class SettingsService : ISettingsService
    {
        private readonly string settingsPath;
        
        public SettingsService(string settingsPath)
        {
            this.settingsPath = settingsPath;
            var serializer = new XmlSerializer(typeof(TraySettings));
            using (var streamReader = new StreamReader(settingsPath))
            {
                this.TraySettings = (TraySettings)serializer.Deserialize(streamReader);
            }
        }

        public TraySettings TraySettings { get; set; }
     
        public bool SaveTraySettings()
        {
            var serializer = new XmlSerializer(typeof(TraySettings));
            using (var streamWriter = new StreamWriter(this.settingsPath))
            {
                serializer.Serialize(streamWriter, TraySettings);
            }

            return true;
        }
    }
}
