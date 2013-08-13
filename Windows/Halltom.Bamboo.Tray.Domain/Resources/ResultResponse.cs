namespace Halltom.Bamboo.Tray.Domain.Resources
{
    using Newtonsoft.Json;

    public class ResultResponse
    {
        [JsonProperty("results")]
        public Results Results { get; set; }
    }
}
