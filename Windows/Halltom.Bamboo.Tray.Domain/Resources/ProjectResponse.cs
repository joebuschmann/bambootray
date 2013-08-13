namespace Halltom.Bamboo.Tray.Domain.Resources
{
    using Newtonsoft.Json;

    public class ProjectResponse
    {
        [JsonProperty("projects")]
        public Projects Projects { get; set; }
    }
}
