namespace Halltom.Bamboo.Tray.Domain.Settings
{
    using System;
    using System.Collections.Generic;
    using System.Security.Policy;
    using System.Xml.Serialization;

    [Serializable]
    public class Server
    {
        private string password;

        public Server()
        {
            this.BuildPlans = new List<BuildPlan>();
        }

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
                return this.password;
            }
            set
            {
                this.password = HashHelper.Encrypt(value);
            }
        }

        public string PlaintextPassword
        {
            get
            {
                return HashHelper.Decrypt(this.Password);
            }
        }

        [XmlArray("buildplans")]
        [XmlArrayItem("buildplan", typeof(BuildPlan))]
        public List<BuildPlan> BuildPlans { get; private set; }
    }
}