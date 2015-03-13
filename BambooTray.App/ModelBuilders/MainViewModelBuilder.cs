using System.Linq;
using BambooTray.App.Models;
using BambooTray.Domain.Resources;
using BambooTray.Domain.Settings;

namespace BambooTray.App.ModelBuilders
{
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

            var planSummaryUrl = string.Format("{0}/browse/{1}", server.Address.TrimEnd('/'), plan.Key);

            return new MainViewModel
                       {
                           ServerName = string.IsNullOrEmpty(server.Name) ? server.Address : server.Name,
                           ProjectName = plan.ProjectName,
                           PlanKey = plan.Key,
                           PlanName = plan.Name,
                           ShortPlanName = plan.ShortName,
                           PlanSummaryUrl = planSummaryUrl,
                           LatestResultUrl = string.Concat(planSummaryUrl, "/latest"),
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
