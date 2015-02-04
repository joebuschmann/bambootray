using Newtonsoft.Json;

namespace BambooTray.Domain.Resources
{
    // ReSharper disable ClassNeverInstantiated.Global
    // ReSharper disable UnusedAutoPropertyAccessor.Global
    // ReSharper disable UnusedMember.Global
    public class Projects
    {
        [JsonProperty("project")]
        public Project[] Project { get; set; }
    }
}