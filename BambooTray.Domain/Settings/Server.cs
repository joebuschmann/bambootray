namespace BambooTray.Domain.Settings
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [Serializable]
    public class Server
    {
        private string _password;

        public Server()
        {
            BuildPlans = new List<BuildPlan>();
        }

        [XmlAttribute("id")]
        public Guid Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("address")]
        public string Address { get; set; }

        [XmlAttribute("username")]
        public string Username { get; set; }

        [XmlAttribute("password")]
        public string Password
        {
            get
            {
                return HashHelper.Decrypt(_password);
            }

            set
            {
                _password = value.EndsWith("==") ? value : HashHelper.Encrypt(value);
            }
        }

        public string PlaintextPassword
        {
            get
            {
                return HashHelper.Decrypt(_password);
            }
        }

        [XmlArray("buildplans")]
        [XmlArrayItem("buildplan", typeof(BuildPlan))]
        public List<BuildPlan> BuildPlans { get; private set; }
    }
}