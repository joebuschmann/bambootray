using System.Collections.Generic;
using Newtonsoft.Json;

// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable UnusedMember.Global
namespace BambooTray.Domain.Resources
{
    public class PlanDetailResonse
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("projectKey")]
        public string ProjectKey { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("shortKey")]
        public string ShortKey { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("isFavourite")]
        public bool IsFavourite { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("isBuilding")]
        public bool IsBuilding { get; set; }

        [JsonProperty("averageBuildTimeInSeconds")]
        public double AverageBuildTimeInSeconds { get; set; }

        public IList<Result> Results { get; set; }
    }
}