using System.Linq;
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
            var serializer = new XmlSerializer(typeof(TraySettings));
            using (var streamReader = new StreamReader(settingsPath))
            {
                TraySettings = (TraySettings)serializer.Deserialize(streamReader);
            }
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

        public TraySettings CreateCopy()
        {
            TraySettings original = TraySettings;

            var copy = new TraySettings
            {
                BalloonToolTipTimeOut = original.BalloonToolTipTimeOut,
                EnableBaloonNotifications = original.EnableBaloonNotifications,
                PollTime = original.PollTime,
            };

            foreach (var originalServer in original.Servers)
            {
                var newServer = new Server()
                {
                    Id = originalServer.Id,
                    Address = originalServer.Address,
                    Name = originalServer.Name,
                    Username = originalServer.Username,
                    Password = originalServer.Password
                };

                newServer.BuildPlans.AddRange(originalServer.BuildPlans.Select(p => new BuildPlan() {Key = p.Key}));

                copy.Servers.Add(newServer);
            }

            return copy;
        }
    }
}
