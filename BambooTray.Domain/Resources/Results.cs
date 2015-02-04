namespace BambooTray.Domain.Resources
{
    using Newtonsoft.Json;

    public class Results
    {
        [JsonProperty("result")]
        public Result[] Result { get; set; }
    }
}