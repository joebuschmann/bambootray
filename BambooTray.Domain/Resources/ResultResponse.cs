namespace BambooTray.Domain.Resources
{
    using Newtonsoft.Json;

    public class ResultResponse
    {
        [JsonProperty("results")]
        public Results Results { get; set; }
    }
}
