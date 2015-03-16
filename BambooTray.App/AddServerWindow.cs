using System;
using System.Windows.Forms;
using BambooTray.App.Models;
using BambooTray.Services;

namespace BambooTray.App
{
    /// <summary>
    /// The Add Server Window
    /// </summary>
    public partial class AddServerWindow : Form
    {
        private IBambooService _service;

        public AddServerWindow()
            : this(new ServerViewModel() { Id = Guid.NewGuid() })
        {
        }

        public AddServerWindow(ServerViewModel model)
        {
            InitializeComponent();
            Model = model;
            PopulateView();
        }

        public ServerViewModel Model { get; private set; }

        private void TestConnectionButtonClick(object sender, EventArgs e)
        {
            PopulateViewModel();
            _service = new BambooService(Model.ServerAddress, Model.Username, Model.Password);
            try
            {
                var result = _service.GetAllPlans();
                MessageBox.Show(
                    string.Format("Successfully connected to {0}\n\n", Model.ServerAddress),
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
            Close();
        }

        private void ServerAddressTextBoxTextChanged(object sender, EventArgs e)
        {
            testConnectionButton.Enabled = !string.IsNullOrEmpty(serverAddressTextBox.Text);
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            PopulateViewModel();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void PopulateViewModel()
        {
            Model.ServerAddress = new Uri(serverAddressTextBox.Text);
            Model.FriendlyName = FriendlyNameTextBox.Text;
            Model.Username = usernameTextBox.Text;
            Model.Password = passwordTextBox.Text;
        }

        private void PopulateView()
        {
            serverAddressTextBox.Text = Model.ServerAddress != null
                                                 ? Model.ServerAddress.AbsoluteUri
                                                 : string.Empty;
            FriendlyNameTextBox.Text = Model.FriendlyName;
            usernameTextBox.Text = Model.Username;
            passwordTextBox.Text = Model.Password;
        }
    }
}
