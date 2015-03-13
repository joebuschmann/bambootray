using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BambooTray.App.Models;
using BambooTray.Domain.Resources;
using BambooTray.Domain.Settings;
using BambooTray.Services;

namespace BambooTray.App
{
    /// <summary>
    ///     Preferences Window
    /// </summary>
    public partial class PreferencesWindow : Form
    {
        private readonly ISettingsService _settingsService;
        private IBambooService _service;

        public PreferencesWindow(ISettingsService settingsService)
        {
            InitializeComponent();
            _settingsService = settingsService;
            PopulateServerListView();
            serversListBox.SelectedIndexChanged += ServersListBoxOnSelectedIndexChanged;
            PopulateGeneralSettings();
        }

        private void PopulateGeneralSettings()
        {
            TraySettings traySettings = _settingsService.TraySettings;

            numericPollTime.Value = ToSeconds(traySettings.PollTime, (int)numericPollTime.Minimum, (int)numericPollTime.Maximum);
            numericBalloonTooltipTimeout.Value = ToSeconds(traySettings.BalloonToolTipTimeOut, (int)numericBalloonTooltipTimeout.Minimum, (int)numericBalloonTooltipTimeout.Maximum);
            checkboxEnableBalloonNotifications.Checked = traySettings.EnableBaloonNotifications;

            numericPollTime.ValueChanged += (sender, args) =>
            {
                traySettings.PollTime = ToMilliseconds((int) numericPollTime.Value);
                _settingsService.SaveTraySettings();
            };

            numericBalloonTooltipTimeout.ValueChanged += (sender, args) =>
            {
                traySettings.BalloonToolTipTimeOut = ToMilliseconds((int) numericBalloonTooltipTimeout.Value);
                _settingsService.SaveTraySettings();
            };

            checkboxEnableBalloonNotifications.CheckedChanged += (sender, args) =>
            {
                traySettings.EnableBaloonNotifications = checkboxEnableBalloonNotifications.Checked;
                _settingsService.SaveTraySettings();
            };
        }

        private int ToSeconds(int milliseconds, int min, int max)
        {
            int timeInSeconds = milliseconds/1000;
            return Math.Min(Math.Max(timeInSeconds, min), max);
        }

        private int ToMilliseconds(int seconds)
        {
            return seconds*1000;
        }

        private static Server GetServerFromViewModel(ServerViewModel serverViewModel)
        {
            return new Server
            {
                Id = serverViewModel.Id,
                Name = serverViewModel.FriendlyName,
                Address = serverViewModel.ServerAddress.AbsoluteUri,
                Username = serverViewModel.Username,
                Password = serverViewModel.Password
            };
        }

        private static void UpdateServerModel(Server oldModel, Server newModel)
        {
            oldModel.Id = newModel.Id;
            oldModel.Name = newModel.Name;
            oldModel.Address = newModel.Address;
            oldModel.Username = newModel.Username;
            oldModel.Password = newModel.PlaintextPassword;
        }

        private void ServersListBoxOnSelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            PopulateBuildListView(serversListBox.SelectedItem as Server);
        }

        private void PopulateServerListView()
        {
            if (_settingsService.TraySettings.Servers.Count > 0)
            {
                serversListBox.DataSource = _settingsService.TraySettings.Servers;
                PopulateBuildListView(serversListBox.SelectedItem as Server);
            }
        }

        private void AddServerButtonClick(object sender, EventArgs e)
        {
            var addServerWindow = new AddServerWindow();
            addServerWindow.ShowDialog(this);

            if (addServerWindow.DialogResult == DialogResult.OK)
            {
                var server = GetServerFromViewModel(addServerWindow.Model);
                _settingsService.TraySettings.Servers.Add(server);
                _settingsService.SaveTraySettings();
                serversListBox.DataSource = _settingsService.TraySettings.Servers;
            }
        }

        private void ConfigureServerButtonClick(object sender, EventArgs e)
        {
            if (serversListBox.SelectedItem != null)
            {
                var server = serversListBox.SelectedItem as Server;
                if (server == null) 
                    return;

                var addServerWindow =
                    new AddServerWindow(
                        new ServerViewModel
                        {
                            Id = server.Id,
                            ServerAddress = new Uri(server.Address),
                            FriendlyName = server.Name,
                            Username = server.Username,
                            Password = server.PlaintextPassword
                        });
                addServerWindow.ShowDialog(this);

                if (addServerWindow.DialogResult == DialogResult.OK)
                {
                    var newServerDetails = GetServerFromViewModel(addServerWindow.Model);
                    var oldServerDetails =
                        _settingsService.TraySettings.Servers.FirstOrDefault(x => x.Id == newServerDetails.Id);
                    UpdateServerModel(oldServerDetails, newServerDetails);
                    _settingsService.SaveTraySettings();
                    serversListBox.DataSource = null;
                    serversListBox.DisplayMember = "Name";
                    serversListBox.DataSource = _settingsService.TraySettings.Servers;
                }
            }
        }

        private void PopulateBuildListView(Server model)
        {
            try
            {
                if (model != null)
                {
                    _service = new BambooService(new Uri(model.Address), model.Username, model.PlaintextPassword);

                    var plans = _service.GetAllPlans();

                    GetPlanListViewData(plans);
                }
            }
            catch (BambooRequestException ex)
            {
                MessageBox.Show(
                    string.Format(
                        "An error occurred whilst connecting to the server.\nPlease check your details and try again: \n\n{0}",
                        ex.Message),
                    "Unsuccessful!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void GetPlanListViewData(IEnumerable<PlanDetailResonse> list)
        {
            Server currentServer = null;
            if (serversListBox.SelectedItem != null)
            {
                currentServer =
                    _settingsService.TraySettings.Servers.FirstOrDefault(
                        x => x.Name == ((Server) serversListBox.SelectedItem).Name);
            }

            buildPlansListView.Items.Clear();
            foreach (var p in list)
            {
                var selected = false;
                BuildPlan buildPlan = null;
                if (currentServer != null && currentServer.BuildPlans.Count > 0)
                {
                    buildPlan = currentServer.BuildPlans.FirstOrDefault(b => b != null && b.Key == p.Key);
                }

                if (buildPlan != null)
                {
                    selected = true;
                }

                var lv = new ListViewItem {Text = p.Name, Tag = p, Checked = selected};
                buildPlansListView.Items.Add(lv);
            }
        }

        private void RemoveServerButtonClick(object sender, EventArgs e)
        {
            if (serversListBox.SelectedItem != null)
            {
                _settingsService.TraySettings.Servers.Remove(serversListBox.SelectedItem as Server);
                _settingsService.SaveTraySettings();
                serversListBox.DataSource = null;
                serversListBox.DataSource = _settingsService.TraySettings.Servers;
            }
        }

        private void BuildPlansListViewItemChecked(object sender, ItemCheckedEventArgs e)
        {
            var server = serversListBox.SelectedItem as Server;
            if (server != null)
            {
                var buildPlan = e.Item.Tag as PlanDetailResonse;
                var serverSettings = _settingsService.TraySettings.Servers.FirstOrDefault(x => x.Name == server.Name);
                if (serverSettings != null && buildPlan != null && e.Item.Checked)
                {
                    serverSettings.BuildPlans.Add(new BuildPlan {Key = buildPlan.Key});
                }
                else if (serverSettings != null & buildPlan != null)
                {
                    var index = serverSettings.BuildPlans.FindIndex(x => x.Key == buildPlan.Key);
                    if (index >= 0)
                    {
                        serverSettings.BuildPlans.RemoveAt(index);
                    }
                }

                _settingsService.SaveTraySettings();
            }
        }
    }
}