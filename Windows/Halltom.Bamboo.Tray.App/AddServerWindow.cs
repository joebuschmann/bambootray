namespace Halltom.Bamboo.Tray.App
{
    using System;
    using System.Windows.Forms;

    using Halltom.Bamboo.Tray.App.Models;
    using Halltom.Bamboo.Tray.Services;

    /// <summary>
    /// The Add Server Window
    /// </summary>
    public partial class AddServerWindow : Form
    {
        private IBambooService service;

        public AddServerWindow()
            : this(new ServerViewModel() { Id = Guid.NewGuid() })
        {
        }

        public AddServerWindow(ServerViewModel model)
        {
            this.InitializeComponent();
            this.Model = model;
            this.PopulateView();
        }

        public ServerViewModel Model { get; private set; }

        private void TestConnectionButtonClick(object sender, EventArgs e)
        {
            this.PopulateViewModel();
            this.service = new BambooService(this.Model.ServerAddress, this.Model.Username, this.Model.Password);
            try
            {
                var result = this.service.GetServerInfo();
                MessageBox.Show(
                    string.Format(
                        "Successfully connected to {0}\n\nServer version is Bamboo {1}, build {2}.",
                        this.Model.ServerAddress,
                        result.Version,
                        result.BuildNumber),
                    "Success!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
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

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ServerAddressTextBoxTextChanged(object sender, EventArgs e)
        {
            this.testConnectionButton.Enabled = !string.IsNullOrEmpty(this.serverAddressTextBox.Text);
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            this.PopulateViewModel();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PopulateViewModel()
        {
            this.Model.ServerAddress = new Uri(this.serverAddressTextBox.Text);
            this.Model.FriendlyName = this.FriendlyNameTextBox.Text;
            this.Model.Username = this.usernameTextBox.Text;
            this.Model.Password = this.passwordTextBox.Text;
        }

        private void PopulateView()
        {
            this.serverAddressTextBox.Text = this.Model.ServerAddress != null
                                                 ? this.Model.ServerAddress.AbsoluteUri
                                                 : string.Empty;
            this.FriendlyNameTextBox.Text = this.Model.FriendlyName;
            this.usernameTextBox.Text = this.Model.Username;
            this.passwordTextBox.Text = this.Model.Password;
        }
    }
}
