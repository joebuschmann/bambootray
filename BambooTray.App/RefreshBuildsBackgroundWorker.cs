using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using BambooTray.App.ModelBuilders;
using BambooTray.App.Models;
using BambooTray.Domain.Settings;
using BambooTray.Services;

namespace BambooTray.App
{
    public class RefreshBuildsBackgroundWorker
    {
        private readonly ISettingsService _settingsService;
        private readonly Action<List<MainViewModel>> _onSuccess;
        private readonly Action<Exception> _onError;
        private bool _firstTime = true;

        private readonly BackgroundWorker _backgroundWorker = new BackgroundWorker()
        {
            WorkerReportsProgress = false,
            WorkerSupportsCancellation = false
        };

        public RefreshBuildsBackgroundWorker(ISettingsService settingsService, Action<List<MainViewModel>> onSuccess, Action<Exception> onError)
        {
            _settingsService = settingsService;
            _onSuccess = onSuccess;
            _onError = onError;
            _backgroundWorker.DoWork += DoWork;
            _backgroundWorker.RunWorkerCompleted += OnCompleted;
        }

        public void Run()
        {
            // Pass in a copy of the tray settings to avoid synchronization issues.
            var arguments = new DoWorkArguments(_settingsService.CreateCopy());
            _backgroundWorker.RunWorkerAsync(arguments);
        }

        private void DoWork(object sender, DoWorkEventArgs args)
        {
            var arguments = (DoWorkArguments)args.Argument;

            if (_firstTime)
                _firstTime = false;
            else
                Thread.Sleep(arguments.PollTime);

            var mainViewModels = new List<MainViewModel>();
            List<Server> servers =
                arguments.Servers.Where(server => server.BuildPlans.Count > 0).ToList();

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
                    args.Result = new DoWorkResults(e);
                    return;
                }
            }

            args.Result = new DoWorkResults(mainViewModels);
        }

        private void OnCompleted(object sender, RunWorkerCompletedEventArgs runWorkerCompletedEventArgs)
        {
            var doWorkResults = runWorkerCompletedEventArgs.Result as DoWorkResults;

            if (doWorkResults != null)
            {
                if (doWorkResults.MainViewModels != null)
                    _onSuccess(doWorkResults.MainViewModels);
                else
                    _onError(doWorkResults.Exception);
            }
            
            Run();
        }

        private class DoWorkArguments
        {
            public DoWorkArguments(TraySettings traySettings)
            {
                PollTime = traySettings.PollTime;
                Servers = new List<Server>(traySettings.Servers);
            }

            public int PollTime { get; private set; }
            public List<Server> Servers { get; private set; }
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
