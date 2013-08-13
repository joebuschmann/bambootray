namespace Halltom.Bamboo.Tray.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using CuttingEdge.Conditions;

    using Halltom.Bamboo.Tray.Domain.Resources;

    public class BambooService : IBambooService
    {
        private const string InfoServiceEndPoint = "/rest/api/latest/info";

        private const string PlanServiceEndPoint = "/rest/api/latest/plan";

        private const string PlanDetailServiceEndPoint = "/rest/api/latest/plan/{0}";

        private const string PlanResultServiceEndPoint = "/rest/api/latest/result/{0}";
        
        private readonly ServiceInvoker serviceInvoker;

        public BambooService(Uri serverAddress, string username, string password)
        {
            this.serviceInvoker = new ServiceInvoker(serverAddress, username, password);
        }

        public InfoResponse GetServerInfo()
        {
            return this.serviceInvoker.Invoke<InfoResponse>(new InvokeServiceRequest(InfoServiceEndPoint));
        }

        public IList<PlanDetailResonse> GetAllPlans()
        {
            var plans = this.serviceInvoker.Invoke<PlanResponse>(new InvokeServiceRequest(PlanServiceEndPoint)).Plans.Plan;
            return
                plans.Select(
                    plan =>
                    this.GetPlanDetail(plan.Key)).ToList();
        }

        public PlanDetailResonse GetPlanDetail(string key)
        {
            Condition.Requires(key).IsNotNullOrEmpty();

            return
                this.serviceInvoker.Invoke<PlanDetailResonse>(
                    new InvokeServiceRequest(string.Format(PlanDetailServiceEndPoint, key)));
        }

        public IList<Result> GetPlanResults(string key)
        {
            Condition.Requires(key).IsNotNullOrEmpty();

            return
                this.serviceInvoker.Invoke<ResultResponse>(
                    new InvokeServiceRequest(string.Format(PlanResultServiceEndPoint, key))).Results.Result;
        }

        public ResultDetailResponse GetResultDetail(string key)
        {
            Condition.Requires(key).IsNotNullOrEmpty();

            return
                this.serviceInvoker.Invoke<ResultDetailResponse>(
                    new InvokeServiceRequest(string.Format(PlanResultServiceEndPoint, key)));
        }
    }
}
