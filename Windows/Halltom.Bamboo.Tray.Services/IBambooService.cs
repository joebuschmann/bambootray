namespace Halltom.Bamboo.Tray.Services
{
    using System.Collections.Generic;

    using Halltom.Bamboo.Tray.Domain.Resources;

    public interface IBambooService
    {
        InfoResponse GetServerInfo();

        IList<PlanDetailResonse> GetAllPlans();

        PlanDetailResonse GetPlanDetail(string key);

        IList<Result> GetPlanResults(string key);

        ResultDetailResponse GetResultDetail(string key);
    }
}