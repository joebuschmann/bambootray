using BambooTray.Domain.Resources;

namespace BambooTray.Services
{
    using System.Collections.Generic;

    public interface IBambooService
    {
        InfoResponse GetServerInfo();

        IList<PlanDetailResonse> GetAllPlans();

        PlanDetailResonse GetPlanDetail(string key);

        IList<Result> GetPlanResults(string key);

        ResultDetailResponse GetResultDetail(string key);
    }
}