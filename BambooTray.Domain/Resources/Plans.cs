namespace BambooTray.Domain.Resources
{
    using Newtonsoft.Json;

    public class Plans
    {
        [JsonProperty("plan")]
        public PlanDetailResonse[] Plan { get; set; }
    }
}