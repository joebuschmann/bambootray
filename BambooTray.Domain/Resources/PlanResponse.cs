using Newtonsoft.Json;

namespace BambooTray.Domain.Resources
{
    // ReSharper disable UnusedAutoPropertyAccessor.Global
    public class PlanResponse
    {
        [JsonProperty("plans")]
        public Plans Plans { get; set; }
    }
}