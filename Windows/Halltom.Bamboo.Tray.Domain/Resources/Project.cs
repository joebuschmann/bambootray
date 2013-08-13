namespace Halltom.Bamboo.Tray.Domain.Resources
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using Newtonsoft.Json;

    public class Project
    {
        public Project()
        {
            this.Plans = new Collection<PlanDetailResonse>();
        }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public ICollection<PlanDetailResonse> Plans { get; set; }
    }
}