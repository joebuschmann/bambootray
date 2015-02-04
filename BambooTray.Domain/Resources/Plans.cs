using Newtonsoft.Json;

namespace BambooTray.Domain.Resources
{
    // ReSharper disable ClassNeverInstantiated.Global
    // ReSharper disable UnusedAutoPropertyAccessor.Global
    public class Plans
    {
        [JsonProperty("plan")]
        public PlanDetailResonse[] Plan { get; set; }
    }
}