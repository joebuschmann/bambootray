namespace BambooTray.Domain.Resources
{
    using Newtonsoft.Json;

    public class PlanResponse
    {
        [JsonProperty("plans")]
        public Plans Plans { get; set; }
    }
}