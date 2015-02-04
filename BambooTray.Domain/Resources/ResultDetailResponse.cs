using Newtonsoft.Json;

namespace BambooTray.Domain.Resources
{
    // ReSharper disable ClassNeverInstantiated.Global
    // ReSharper disable UnusedAutoPropertyAccessor.Global
    // ReSharper disable UnusedMember.Global
    public class ResultDetailResponse
    {
        [JsonProperty("plan")]
        public PlanDetailResonse Plan { get; set; }

        [JsonProperty("planName")]
        public string PlanName { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("lifeCycleState")]
        public string LifeCycleState { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("buildStartedTime")]
        public string BuildStartedTime { get; set; }

        [JsonProperty("prettyBuildStartedTime")]
        public string PrettyBuildStartedTime { get; set; }

        [JsonProperty("buildCompletedTime")]
        public string BuildCompletedTime { get; set; }

        [JsonProperty("prettyBuildCompletedTime")]
        public string PrettyBuildCompletedTime { get; set; }

        [JsonProperty("buildDurationInSeconds")]
        public int BuildDurationInSeconds { get; set; }

        [JsonProperty("buildDuration")]
        public int BuildDuration { get; set; }

        [JsonProperty("buildDurationDescription")]
        public string BuildDurationDescription { get; set; }

        [JsonProperty("buildRelativeTime")]
        public string BuildRelativeTime { get; set; }

        [JsonProperty("vcsRevisionKey")]
        public string VcsRevisionKey { get; set; }

        [JsonProperty("buildTestSummary")]
        public string BuildTestSummary { get; set; }

        [JsonProperty("successfulTestCount")]
        public int SuccessfulTestCount { get; set; }

        [JsonProperty("failedTestCount")]
        public int FailedTestCount { get; set; }

        [JsonProperty("quarantinedTestCount")]
        public int QuarantinedTestCount { get; set; }

        [JsonProperty("continuable")]
        public bool Continuable { get; set; }

        [JsonProperty("onceOff")]
        public bool OnceOff { get; set; }

        [JsonProperty("restartable")]
        public bool Restartable { get; set; }

        [JsonProperty("buildReason")]
        public string BuildReason { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }
    }
}
