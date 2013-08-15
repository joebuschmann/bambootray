namespace Halltom.Bamboo.Tray.App
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    using Halltom.Bamboo.Tray.App.ModelBuilders;
    using Halltom.Bamboo.Tray.App.Models;
    using Halltom.Bamboo.Tray.App.Properties;
    using Halltom.Bamboo.Tray.Domain.Settings;
    using Halltom.Bamboo.Tray.Services;

    /// <summary>
    /// Main Window
    /// </summary>
    public partial class MainWindow : Form
    {
        private readonly SettingsService settingsService;
        
        private int currentBuildIcon = 1;

        private bool applicationIsExiting;

        private List<MainViewModel> lastBuildData;

        public MainWindow(SettingsService settingsService)
        {
            this.InitializeComponent();
            this.settingsService = settingsService;

            this.notifyIcon.Icon = Icon.FromHandle(Resources.BambooGrey.GetHicon());
            this.lastBuildData = new List<MainViewModel>();
            this.buildsListView.SmallImageList = GetSmallImages();
            this.updateTimer.Interval = this.Settings.PollTime;
            this.RefreshBuilds();
        }

        protected TraySettings Settings
        {
            get
            {
                return this.settingsService.TraySettings;
            }
        }

        private static ImageList GetSmallImages()
        {
            var imageList = new ImageList();
            imageList.Images.Add("Successful", Resources.BambooGreen);
            imageList.Images.Add("Failed", Resources.BambooRed);
            imageList.Images.Add("Building", Resources.BambooYellow1);
            imageList.Images.Add("Offline", Resources.BambooGrey);
            return imageList;
        }

        private void RefreshBuilds()
        {
            var plans = new List<MainViewModel>();
            this.buildsListView.Items.Clear();
            foreach (var server in this.Settings.Servers)
            {
                if (server.BuildPlans.Count > 0)
                {
                    var bambooService = new BambooService(new Uri(server.Address), server.Username, server.PlaintextPassword);

                    foreach (var buildPlan in server.BuildPlans)
                    {
                        var planDetail = bambooService.GetPlanDetail(buildPlan.Key);
                        planDetail.Results = bambooService.GetPlanResults(buildPlan.Key);
                        var resultDetail = planDetail.Results.FirstOrDefault();
                        if (resultDetail != null)
                        {
                            planDetail.Results.FirstOrDefault().Detail = bambooService.GetResultDetail(resultDetail.Key);
                        }

                        plans.Add(MainViewModelBuilder.Build(planDetail, server));
                    }

                    this.GetPlansListViewData(plans);
                    this.DoNotifications(plans);
                    this.UpdateTrayIcon(plans);
                    this.lastBuildData = plans;
                }
            }
        }

        private void UpdateTrayIcon(IEnumerable<MainViewModel> currentBuildData)
        {
            var building = false;
            var broken = false;
            foreach (var plan in currentBuildData)
            {
                if (plan.BuildActive)
                {
                    building = true;
                }

                if (plan.BuildBroken)
                {
                    broken = true;
                }
            }

            this.iconTimer.Enabled = building;

            this.notifyIcon.Icon = broken
                                       ? Icon.FromHandle(Resources.BambooRed.GetHicon())
                                       : Icon.FromHandle(Resources.BambooGreen.GetHicon());
        }

        private void DoNotifications(IEnumerable<MainViewModel> currentBuildData)
        {
            foreach (var currentBuild in currentBuildData)
            {
                var lastBuild = this.lastBuildData.FirstOrDefault(x => x.PlanKey == currentBuild.PlanKey);
                if (lastBuild != null)
                {
                    if (lastBuild.BuildActive && !currentBuild.BuildActive)
                    {
                        // Build Status has just changed... 
                        if (lastBuild.BuildBroken && !currentBuild.BuildBroken)
                        {
                            this.notifyIcon.ShowBalloonTip(
                                this.settingsService.TraySettings.BalloonToolTipTimeOut,
                                string.Format("{0} {1}: Fixed!", currentBuild.ProjectName, currentBuild.PlanKey),
                                "Recent checkins have fixed the build.", 
                                ToolTipIcon.Info);
                        }
                        else if (!lastBuild.BuildBroken && currentBuild.BuildBroken)
                        {
                            this.notifyIcon.ShowBalloonTip(
                                this.settingsService.TraySettings.BalloonToolTipTimeOut,
                                string.Format("{0} {1}: Broken!", currentBuild.ProjectName, currentBuild.PlanKey),
                                "Recent checkins have broken the build.",
                                ToolTipIcon.Error);
                        }
                        else if (!lastBuild.BuildBroken && !currentBuild.BuildBroken)
                        {
                            this.notifyIcon.ShowBalloonTip(
                                this.settingsService.TraySettings.BalloonToolTipTimeOut,
                                string.Format("{0} {1}: Build Successful!", currentBuild.ProjectName, currentBuild.PlanKey),
                                "Yet another successful build.",
                                ToolTipIcon.Info);
                        }
                        else if (lastBuild.BuildBroken && currentBuild.BuildBroken)
                        {
                            this.notifyIcon.ShowBalloonTip(
                                this.settingsService.TraySettings.BalloonToolTipTimeOut,
                                string.Format("{0} {1}: Broken!", currentBuild.ProjectName, currentBuild.PlanKey),
                                "The build is still broken.",
                                ToolTipIcon.Error);
                        }
                    }
                }
            }
        }

        private void GetPlansListViewData(IEnumerable<MainViewModel> currentBuildData)
        {
            this.buildsListView.Items.Clear();
            foreach (var p in currentBuildData)
            {
                var lv = new ListViewItem { Text = p.ServerName };
                lv.ImageKey = p.BuildActivity == "Building" ? p.BuildActivity : (string.IsNullOrEmpty(p.BuildStatus) ? "Offline" : p.BuildStatus);
                lv.SubItems.Add(p.ProjectName);
                lv.SubItems.Add(p.PlanKey);
                lv.SubItems.Add(p.BuildActivity);
                lv.SubItems.Add(p.BuildStatus);
                lv.SubItems.Add(p.LastBuildTime);
                lv.SubItems.Add(p.LastBuildDuration);
                lv.SubItems.Add(p.LastBuildNumber);
                lv.SubItems.Add(p.LastVcsRevision);
                lv.SubItems.Add(p.SuccessfulTestCount);
                lv.SubItems.Add(p.FailedTestCount);
                this.buildsListView.Items.Add(lv);
            }
        }

        private void PreferencesToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open the Preferences Window
            var preferencesWindow = new PreferencesWindow(this.settingsService);
            preferencesWindow.ShowDialog(this);
        }

        private void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open the about Window
            var aboutBox = new AboutWindow();
            aboutBox.ShowDialog(this);
        }

        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // User has clicked Exit or Keyed ALT+F4
            this.applicationIsExiting = true;
            this.notifyIcon.Visible = false;
            Application.Exit();
        }

        private void MainFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.applicationIsExiting)
            {
                this.Hide();
                e.Cancel = true;
            }
        }

        private void NotifyIconClick(object sender, EventArgs e)
        {
            // When tray icon is clicked, show main window and bring to front
            this.Show();
            this.Activate();
            this.BringToFront();
        }

        private void BuildIconTimerTick(object sender, EventArgs e)
        {
            // This isn't very nice, but to animate the tray icon when a build is in progress.
            var bitmap = (Bitmap)Resources.ResourceManager.GetObject("BambooYellow" + this.currentBuildIcon);
            if (bitmap != null)
            {
                this.notifyIcon.Icon = Icon.FromHandle(bitmap.GetHicon());
            }

            this.currentBuildIcon++;
            if (this.currentBuildIcon == 4)
            {
                this.currentBuildIcon = 1;
            }
        }

        private void UpdateTimerTick(object sender, EventArgs e)
        {
            try
            {
                this.RefreshBuilds();
            }
            catch (BambooRequestException)
            {
                this.notifyIcon.Icon = Icon.FromHandle(Resources.BambooGrey.GetHicon());
                foreach (ListViewItem item in this.buildsListView.Items)
                {
                    item.ImageKey = "Offline";
                }
            }
        }
    }
}
