namespace BambooTray.Domain.Resources
{
    using Newtonsoft.Json;

    public class ProjectResponse
    {
        [JsonProperty("projects")]
        public Projects Projects { get; set; }
    }
}
