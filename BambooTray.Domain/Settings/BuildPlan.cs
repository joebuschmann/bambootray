namespace BambooTray.Domain.Settings
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class BuildPlan
    {
        [XmlAttribute("key")]
        public string Key { get; set; }
    }
}