namespace Halltom.Bamboo.Tray.Domain.Resources
{
    using Newtonsoft.Json;

    public class PlanResponse
    {
        [JsonProperty("plans")]
        public Plans Plans { get; set; }
    }
}