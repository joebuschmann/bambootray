using Newtonsoft.Json;

namespace BambooTray.Domain.Resources
{
    // ReSharper disable ClassNeverInstantiated.Global
    // ReSharper disable UnusedAutoPropertyAccessor.Global
    // ReSharper disable UnusedMember.Global
    public class Result
    {
        [JsonProperty("plan")]
        public PlanDetailResonse Plan { get; set; }

        [JsonProperty("lifeCycleState")]
        public string LifeCycleState { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        public ResultDetailResponse Detail { get; set; }
    }
}