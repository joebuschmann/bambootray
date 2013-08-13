namespace Halltom.Bamboo.Tray.App.ModelBuilders
{
    using System.Linq;

    using Halltom.Bamboo.Tray.App.Models;
    using Halltom.Bamboo.Tray.Domain.Resources;
    using Halltom.Bamboo.Tray.Domain.Settings;

    public static class MainViewModelBuilder
    {
        public static MainViewModel Build(PlanDetailResonse plan, Server server)
        {
            var lastResult = plan.Results.FirstOrDefault();
            ResultDetailResponse lastResultDetail = null;
            if (lastResult != null)
            {
                lastResultDetail = lastResult.Detail;
            }

            return new MainViewModel
                       {
                           ServerName = string.IsNullOrEmpty(server.Name) ? server.Address : server.Name,
                           ProjectName = plan.ProjectName,
                           PlanKey = plan.Key,
                           BuildActivity = plan.IsActive ? "Building" : "Sleeping",
                           BuildActive = plan.IsActive,
                           BuildStatus = lastResult != null ? lastResult.State : string.Empty,
                           BuildBroken = lastResult != null && lastResult.State == "Failed",
                           LastBuildTime =
                               lastResultDetail != null ? lastResultDetail.BuildRelativeTime : string.Empty,
                           LastBuildDuration =
                               lastResultDetail != null
                                   ? lastResultDetail.BuildDurationDescription
                                   : string.Empty,
                           LastBuildNumber =
                               lastResultDetail != null ? lastResultDetail.Number.ToString() : string.Empty,
                           LastVcsRevision =
                               lastResultDetail != null ? lastResultDetail.VcsRevisionKey : string.Empty,
                           SuccessfulTestCount =
                               lastResultDetail != null
                                   ? lastResultDetail.SuccessfulTestCount.ToString()
                                   : string.Empty,
                           FailedTestCount =
                               lastResultDetail != null
                                   ? lastResultDetail.FailedTestCount.ToString()
                                   : string.Empty
                       };
        }
    }
}
