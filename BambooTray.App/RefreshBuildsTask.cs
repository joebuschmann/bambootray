using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BambooTray.App.ModelBuilders;
using BambooTray.App.Models;
using BambooTray.Domain.Settings;
using BambooTray.Services;

namespace BambooTray.App
{
    public class RefreshBuildsTask
    {
        private readonly ISettingsService _settingsService;
        private readonly Action<List<MainViewModel>> _onSuccess;
        private readonly Action<Exception> _onError;
        private bool _firstTime = true;

        public RefreshBuildsTask(ISettingsService settingsService, Action<List<MainViewModel>> onSuccess, Action<Exception> onError)
        {
            _settingsService = settingsService;
            _onSuccess = onSuccess;
            _onError = onError;
        }

        public async void Run()
        {
            if (_firstTime)
                _firstTime = false;
            else
                await Task.Delay(_settingsService.TraySettings.PollTime);

            DoWorkResults doWorkResults = await Task.Run(() => DoWork(_settingsService.CreateCopy()));

            if (doWorkResults.MainViewModels != null)
                _onSuccess(doWorkResults.MainViewModels);
            else
                _onError(doWorkResults.Exception);

            Run();
        }

        private DoWorkResults DoWork(TraySettings traySettings)
        {
            var mainViewModels = new List<MainViewModel>();
            List<Server> servers =
                traySettings.Servers.Where(server => server.BuildPlans.Count > 0).ToList();

            foreach (var server in servers)
            {
                try
                {
                    var bambooService = new BambooService(new Uri(server.Address), server.Username,
                        server.PlaintextPassword);

                    foreach (var buildPlan in server.BuildPlans)
                    {
                        var planDetail = bambooService.GetPlanDetail(buildPlan.Key);
                        planDetail.Results = bambooService.GetPlanResults(buildPlan.Key);

                        var resultDetail = planDetail.Results.FirstOrDefault();

                        if (resultDetail != null)
                        {
                            var firstOrDefault = planDetail.Results.FirstOrDefault();
                            if (firstOrDefault != null)
                                firstOrDefault.Detail = bambooService.GetResultDetail(resultDetail.Key);
                        }

                        mainViewModels.Add(MainViewModelBuilder.Build(planDetail, server));
                    }
                }
                catch (BambooRequestException e)
                {
                    return new DoWorkResults(e);
                }
            }

            return new DoWorkResults(mainViewModels);
        }

        private class DoWorkResults
        {
            public DoWorkResults(List<MainViewModel> mainViewModels)
            {
                MainViewModels = mainViewModels;
                Exception = null;
            }

            public DoWorkResults(BambooRequestException exception)
            {
                MainViewModels = null;
                Exception = exception;
            }

            public List<MainViewModel> MainViewModels { get; private set; }
            public Exception Exception { get; private set; }
        }
    }
}
