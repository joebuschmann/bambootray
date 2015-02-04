namespace BambooTray.Domain.Settings
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [Serializable]
    [XmlRoot("bambooTray")]
    public class TraySettings
    {
        public TraySettings()
        {
            this.Servers = new List<Server>();
        }

        [XmlArray("servers")]
        [XmlArrayItem("server", typeof(Server))]
        public List<Server> Servers { get; private set; }
        
        [XmlAttribute("pollingtime")]
        public int PollTime { get; set; }

        [XmlAttribute("baloonNotifications")]
        public bool EnableBaloonNotifications { get; set; }

        [XmlAttribute("baloonNotificationTimeout")]
        public int BalloonToolTipTimeOut { get; set; }
    }
}
