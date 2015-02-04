using Newtonsoft.Json;

namespace BambooTray.Domain.Resources
{
    // ReSharper disable ClassNeverInstantiated.Global
    // ReSharper disable UnusedAutoPropertyAccessor.Global
    // ReSharper disable UnusedMember.Global
    public class ProjectResponse
    {
        [JsonProperty("projects")]
        public Projects Projects { get; set; }
    }
}
