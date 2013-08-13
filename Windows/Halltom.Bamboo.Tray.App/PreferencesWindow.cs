namespace Halltom.Bamboo.Tray.App
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

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
                var server = new Server
                                 {
                                     Name = addServerWindow.Model.FriendlyName,
                                     Address = addServerWindow.Model.ServerAddress.AbsoluteUri,
                                     Username = addServerWindow.Model.Username,
                                     Password = addServerWindow.Model.Password,
                                 };
                this.settingsService.TraySettings.Servers.Add(server);
                this.settingsService.SaveTraySettings();
                this.serversListBox.DataSource = this.settingsService.TraySettings.Servers;
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
