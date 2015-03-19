﻿namespace BambooTray.Domain.Settings
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
            Servers = new List<Server>();
            PollTime = 20000;
            EnableBaloonNotifications = true;
            BalloonToolTipTimeOut = 2000;
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
