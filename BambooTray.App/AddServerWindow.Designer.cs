namespace BambooTray.App
{
    partial class AddServerWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServerWindow));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.testConnectionButton = new System.Windows.Forms.Button();
            this.addNewServerGroupBox = new System.Windows.Forms.GroupBox();
            this.optionalLabel3 = new System.Windows.Forms.Label();
            this.optionalLabel2 = new System.Windows.Forms.Label();
            this.optionalLabel1 = new System.Windows.Forms.Label();
            this.FriendlyNameTextBox = new System.Windows.Forms.TextBox();
            this.friendlyNameLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.serverAddressTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.serverAddressLabel = new System.Windows.Forms.Label();
            this.addNewServerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(207, 185);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 50;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(290, 185);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 51;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // testConnectionButton
            // 
            this.testConnectionButton.Enabled = false;
            this.testConnectionButton.Location = new System.Drawing.Point(96, 130);
            this.testConnectionButton.Name = "testConnectionButton";
            this.testConnectionButton.Size = new System.Drawing.Size(100, 23);
            this.testConnectionButton.TabIndex = 4;
            this.testConnectionButton.Text = "&Test Connection";
            this.testConnectionButton.UseVisualStyleBackColor = true;
            this.testConnectionButton.Click += new System.EventHandler(this.TestConnectionButtonClick);
            // 
            // addNewServerGroupBox
            // 
            this.addNewServerGroupBox.Controls.Add(this.optionalLabel3);
            this.addNewServerGroupBox.Controls.Add(this.optionalLabel2);
            this.addNewServerGroupBox.Controls.Add(this.optionalLabel1);
            this.addNewServerGroupBox.Controls.Add(this.FriendlyNameTextBox);
            this.addNewServerGroupBox.Controls.Add(this.friendlyNameLabel);
            this.addNewServerGroupBox.Controls.Add(this.passwordTextBox);
            this.addNewServerGroupBox.Controls.Add(this.usernameTextBox);
            this.addNewServerGroupBox.Controls.Add(this.serverAddressTextBox);
            this.addNewServerGroupBox.Controls.Add(this.passwordLabel);
            this.addNewServerGroupBox.Controls.Add(this.usernameLabel);
            this.addNewServerGroupBox.Controls.Add(this.serverAddressLabel);
            this.addNewServerGroupBox.Controls.Add(this.testConnectionButton);
            this.addNewServerGroupBox.Location = new System.Drawing.Point(13, 13);
            this.addNewServerGroupBox.Name = "addNewServerGroupBox";
            this.addNewServerGroupBox.Size = new System.Drawing.Size(352, 166);
            this.addNewServerGroupBox.TabIndex = 3;
            this.addNewServerGroupBox.TabStop = false;
            this.addNewServerGroupBox.Text = "Add new server";
            // 
            // optionalLabel3
            // 
            this.optionalLabel3.AutoSize = true;
            this.optionalLabel3.ForeColor = System.Drawing.Color.Silver;
            this.optionalLabel3.Location = new System.Drawing.Point(226, 107);
            this.optionalLabel3.Name = "optionalLabel3";
            this.optionalLabel3.Size = new System.Drawing.Size(50, 13);
            this.optionalLabel3.TabIndex = 13;
            this.optionalLabel3.Text = "(optional)";
            // 
            // optionalLabel2
            // 
            this.optionalLabel2.AutoSize = true;
            this.optionalLabel2.ForeColor = System.Drawing.Color.Silver;
            this.optionalLabel2.Location = new System.Drawing.Point(226, 80);
            this.optionalLabel2.Name = "optionalLabel2";
            this.optionalLabel2.Size = new System.Drawing.Size(50, 13);
            this.optionalLabel2.TabIndex = 12;
            this.optionalLabel2.Text = "(optional)";
            // 
            // optionalLabel1
            // 
            this.optionalLabel1.AutoSize = true;
            this.optionalLabel1.ForeColor = System.Drawing.Color.Silver;
            this.optionalLabel1.Location = new System.Drawing.Point(226, 53);
            this.optionalLabel1.Name = "optionalLabel1";
            this.optionalLabel1.Size = new System.Drawing.Size(50, 13);
            this.optionalLabel1.TabIndex = 11;
            this.optionalLabel1.Text = "(optional)";
            // 
            // FriendlyNameTextBox
            // 
            this.FriendlyNameTextBox.Location = new System.Drawing.Point(96, 50);
            this.FriendlyNameTextBox.Name = "FriendlyNameTextBox";
            this.FriendlyNameTextBox.Size = new System.Drawing.Size(124, 20);
            this.FriendlyNameTextBox.TabIndex = 1;
            this.FriendlyNameTextBox.Text = "Bamboo";
            // 
            // friendlyNameLabel
            // 
            this.friendlyNameLabel.AutoSize = true;
            this.friendlyNameLabel.Location = new System.Drawing.Point(10, 53);
            this.friendlyNameLabel.Name = "friendlyNameLabel";
            this.friendlyNameLabel.Size = new System.Drawing.Size(77, 13);
            this.friendlyNameLabel.TabIndex = 9;
            this.friendlyNameLabel.Text = "Friendly Name:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(96, 104);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(124, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Text = "London10";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(96, 77);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(124, 20);
            this.usernameTextBox.TabIndex = 2;
            this.usernameTextBox.Text = "tom.hall";
            // 
            // serverAddressTextBox
            // 
            this.serverAddressTextBox.Location = new System.Drawing.Point(96, 24);
            this.serverAddressTextBox.Name = "serverAddressTextBox";
            this.serverAddressTextBox.Size = new System.Drawing.Size(241, 20);
            this.serverAddressTextBox.TabIndex = 0;
            this.serverAddressTextBox.Text = "http://bamboo.isobardevelopment.com";
            this.serverAddressTextBox.TextChanged += new System.EventHandler(this.ServerAddressTextBoxTextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(10, 107);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(10, 80);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username:";
            // 
            // serverAddressLabel
            // 
            this.serverAddressLabel.AutoSize = true;
            this.serverAddressLabel.Location = new System.Drawing.Point(8, 27);
            this.serverAddressLabel.Name = "serverAddressLabel";
            this.serverAddressLabel.Size = new System.Drawing.Size(82, 13);
            this.serverAddressLabel.TabIndex = 3;
            this.serverAddressLabel.Text = "Server Address:";
            // 
            // AddServer
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(383, 220);
            this.ControlBox = false;
            this.Controls.Add(this.addNewServerGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddServer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add new server...";
            this.TopMost = true;
            this.addNewServerGroupBox.ResumeLayout(false);
            this.addNewServerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button testConnectionButton;
        private System.Windows.Forms.GroupBox addNewServerGroupBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox serverAddressTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label serverAddressLabel;
        private System.Windows.Forms.Label optionalLabel3;
        private System.Windows.Forms.Label optionalLabel2;
        private System.Windows.Forms.Label optionalLabel1;
        private System.Windows.Forms.TextBox FriendlyNameTextBox;
        private System.Windows.Forms.Label friendlyNameLabel;
    }
}