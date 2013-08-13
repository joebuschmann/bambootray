namespace Halltom.Bamboo.Tray.App
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    using Halltom.Bamboo.Tray.App.Models;
    using Halltom.Bamboo.Tray.Domain.Resources;
    using Halltom.Bamboo.Tray.Domain.Settings;
    using Halltom.Bamboo.Tray.Services;

    /// <summary>
    /// Preferences Window
    /// </summary>
    public partial class PreferencesWindow : Form
    {
        private readonly ISettingsService settingsService;

        private IBambooService service;
        
        public PreferencesWindow(ISettingsService settingsService)
        {
            this.InitializeComponent();
            this.settingsService = settingsService;
            this.PopulateServerListView();
            this.serversListBox.SelectedIndexChanged += this.ServersListBoxOnSelectedIndexChanged;
        }

        private static Server GetServerFromViewModel(ServerViewModel serverViewModel)
        {
            return new Server
            {
                Id = serverViewModel.Id,
                Name = serverViewModel.FriendlyName,
                Address = serverViewModel.ServerAddress.AbsoluteUri,
                Username = serverViewModel.Username,
                Password = serverViewModel.Password,
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
            this.PopulateBuildListView(this.serversListBox.SelectedItem as Server);
        }

        private void PopulateServerListView()
        {
            if (this.settingsService.TraySettings.Servers.Count > 0)
            {
                this.serversListBox.DataSource = this.settingsService.TraySettings.Servers;
                this.PopulateBuildListView(this.serversListBox.SelectedItem as Server);
            }
        }

        private void AddServerButtonClick(object sender, EventArgs e)
        {
            var addServerWindow = new AddServerWindow();
            addServerWindow.ShowDialog(this);

            if (addServerWindow.DialogResult == DialogResult.OK)
            {
                var server = GetServerFromViewModel(addServerWindow.Model);
                this.settingsService.TraySettings.Servers.Add(server);
                this.settingsService.SaveTraySettings();
                this.serversListBox.DataSource = this.settingsService.TraySettings.Servers;
            }
        }

        private void ConfigureServerButtonClick(object sender, EventArgs e)
        {
            if (this.serversListBox.SelectedItem != null)
            {
                var server = this.serversListBox.SelectedItem as Server;
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
                    var oldServerDetails = this.settingsService.TraySettings.Servers.FirstOrDefault(x => x.Id == newServerDetails.Id);
                    UpdateServerModel(oldServerDetails, newServerDetails);
                    this.settingsService.SaveTraySettings();
                    this.serversListBox.DataSource = null;
                    this.serversListBox.DisplayMember = "Name";
                    this.serversListBox.DataSource = this.settingsService.TraySettings.Servers;
                }
            }
        }

        private void PopulateBuildListView(Server model)
        {
            try
            {
                if (model != null)
                {
                    this.service = new BambooService(new Uri(model.Address), model.Username, model.PlaintextPassword);

                    var plans = this.service.GetAllPlans();

                    this.GetPlanListViewData(plans);
                }
            }
            catch (BambooRequestException ex)
            {
                MessageBox.Show(
                    string.Format("An error occurred whilst connecting to the server.\nPlease check your details and try again: \n\n{0}", ex.Message),
                    "Unsuccessful!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void GetPlanListViewData(IEnumerable<PlanDetailResonse> list)
        {
            Server currentServer = null;
            if (this.serversListBox.SelectedItem != null)
            {
                currentServer = this.settingsService.TraySettings.Servers.FirstOrDefault(x => x.Name == ((Server)this.serversListBox.SelectedItem).Name);
            }
            
            this.buildPlansListView.Items.Clear();
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

                var lv = new ListViewItem { Text = p.Name, Tag = p, Checked = selected };
                this.buildPlansListView.Items.Add(lv);
            }
        }

        private void RemoveServerButtonClick(object sender, EventArgs e)
        {
            if (this.serversListBox.SelectedItem != null)
            {
                this.settingsService.TraySettings.Servers.Remove(this.serversListBox.SelectedItem as Server);
                this.settingsService.SaveTraySettings();
                this.serversListBox.DataSource = null;
                this.serversListBox.DataSource = this.settingsService.TraySettings.Servers;
            }
        }

        private void BuildPlansListViewItemChecked(object sender, ItemCheckedEventArgs e)
        {
            var server = this.serversListBox.SelectedItem as Server;
            if (server != null)
            {
                var buildPlan = e.Item.Tag as PlanDetailResonse;
                var serverSettings = this.settingsService.TraySettings.Servers.FirstOrDefault(x => x.Name == server.Name);
                if (serverSettings != null && buildPlan != null && e.Item.Checked)
                {
                    serverSettings.BuildPlans.Add(new BuildPlan { Key = buildPlan.Key });
                }
                else if (serverSettings != null & buildPlan != null)
                {
                    var index = serverSettings.BuildPlans.FindIndex(x => x.Key == buildPlan.Key);
                    if (index >= 0)
                    {
                        serverSettings.BuildPlans.RemoveAt(index);
                    }
                }

                this.settingsService.SaveTraySettings();
            }
        }
    }
}