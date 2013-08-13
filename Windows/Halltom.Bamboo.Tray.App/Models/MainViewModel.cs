namespace Halltom.Bamboo.Tray.App.Models
{
    public class MainViewModel
    {
        public string ServerName { get; set; }

        public string ProjectName { get; set; }

        public string PlanKey { get; set; }

        public string BuildActivity { get; set; }

        public bool BuildActive { get; set; }

        public string BuildStatus { get; set; }

        public bool BuildBroken { get; set; }

        public string LastBuildTime { get; set; }

        public string LastBuildDuration { get; set; }

        public string LastBuildNumber { get; set; }

        public string LastVcsRevision { get; set; }

        public string SuccessfulTestCount { get; set; }

        public string FailedTestCount { get; set; }
    }
}
