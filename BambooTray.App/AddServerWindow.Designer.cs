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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            okButton = new System.Windows.Forms.Button();
            cancelButton = new System.Windows.Forms.Button();
            testConnectionButton = new System.Windows.Forms.Button();
            addNewServerGroupBox = new System.Windows.Forms.GroupBox();
            optionalLabel3 = new System.Windows.Forms.Label();
            optionalLabel2 = new System.Windows.Forms.Label();
            optionalLabel1 = new System.Windows.Forms.Label();
            FriendlyNameTextBox = new System.Windows.Forms.TextBox();
            friendlyNameLabel = new System.Windows.Forms.Label();
            passwordTextBox = new System.Windows.Forms.TextBox();
            usernameTextBox = new System.Windows.Forms.TextBox();
            serverAddressTextBox = new System.Windows.Forms.TextBox();
            passwordLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            serverAddressLabel = new System.Windows.Forms.Label();
            addNewServerGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Location = new System.Drawing.Point(207, 185);
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.TabIndex = 50;
            okButton.Text = "&OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += new System.EventHandler(OkButtonClick);
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Location = new System.Drawing.Point(290, 185);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.TabIndex = 51;
            cancelButton.Text = "&Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += new System.EventHandler(CancelButtonClick);
            // 
            // testConnectionButton
            // 
            testConnectionButton.Enabled = false;
            testConnectionButton.Location = new System.Drawing.Point(96, 130);
            testConnectionButton.Name = "testConnectionButton";
            testConnectionButton.Size = new System.Drawing.Size(100, 23);
            testConnectionButton.TabIndex = 4;
            testConnectionButton.Text = "&Test Connection";
            testConnectionButton.UseVisualStyleBackColor = true;
            testConnectionButton.Click += new System.EventHandler(TestConnectionButtonClick);
            // 
            // addNewServerGroupBox
            // 
            addNewServerGroupBox.Controls.Add(optionalLabel3);
            addNewServerGroupBox.Controls.Add(optionalLabel2);
            addNewServerGroupBox.Controls.Add(optionalLabel1);
            addNewServerGroupBox.Controls.Add(FriendlyNameTextBox);
            addNewServerGroupBox.Controls.Add(friendlyNameLabel);
            addNewServerGroupBox.Controls.Add(passwordTextBox);
            addNewServerGroupBox.Controls.Add(usernameTextBox);
            addNewServerGroupBox.Controls.Add(serverAddressTextBox);
            addNewServerGroupBox.Controls.Add(passwordLabel);
            addNewServerGroupBox.Controls.Add(usernameLabel);
            addNewServerGroupBox.Controls.Add(serverAddressLabel);
            addNewServerGroupBox.Controls.Add(testConnectionButton);
            addNewServerGroupBox.Location = new System.Drawing.Point(13, 13);
            addNewServerGroupBox.Name = "addNewServerGroupBox";
            addNewServerGroupBox.Size = new System.Drawing.Size(352, 166);
            addNewServerGroupBox.TabIndex = 3;
            addNewServerGroupBox.TabStop = false;
            addNewServerGroupBox.Text = "Add new server";
            // 
            // optionalLabel3
            // 
            optionalLabel3.AutoSize = true;
            optionalLabel3.ForeColor = System.Drawing.Color.Silver;
            optionalLabel3.Location = new System.Drawing.Point(226, 107);
            optionalLabel3.Name = "optionalLabel3";
            optionalLabel3.Size = new System.Drawing.Size(50, 13);
            optionalLabel3.TabIndex = 13;
            optionalLabel3.Text = "(optional)";
            // 
            // optionalLabel2
            // 
            optionalLabel2.AutoSize = true;
            optionalLabel2.ForeColor = System.Drawing.Color.Silver;
            optionalLabel2.Location = new System.Drawing.Point(226, 80);
            optionalLabel2.Name = "optionalLabel2";
            optionalLabel2.Size = new System.Drawing.Size(50, 13);
            optionalLabel2.TabIndex = 12;
            optionalLabel2.Text = "(optional)";
            // 
            // optionalLabel1
            // 
            optionalLabel1.AutoSize = true;
            optionalLabel1.ForeColor = System.Drawing.Color.Silver;
            optionalLabel1.Location = new System.Drawing.Point(226, 53);
            optionalLabel1.Name = "optionalLabel1";
            optionalLabel1.Size = new System.Drawing.Size(50, 13);
            optionalLabel1.TabIndex = 11;
            optionalLabel1.Text = "(optional)";
            // 
            // FriendlyNameTextBox
            // 
            FriendlyNameTextBox.Location = new System.Drawing.Point(96, 50);
            FriendlyNameTextBox.Name = "FriendlyNameTextBox";
            FriendlyNameTextBox.Size = new System.Drawing.Size(124, 20);
            FriendlyNameTextBox.TabIndex = 1;
            FriendlyNameTextBox.Text = "Bamboo";
            // 
            // friendlyNameLabel
            // 
            friendlyNameLabel.AutoSize = true;
            friendlyNameLabel.Location = new System.Drawing.Point(10, 53);
            friendlyNameLabel.Name = "friendlyNameLabel";
            friendlyNameLabel.Size = new System.Drawing.Size(77, 13);
            friendlyNameLabel.TabIndex = 9;
            friendlyNameLabel.Text = "Friendly Name:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new System.Drawing.Point(96, 104);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '●';
            passwordTextBox.Size = new System.Drawing.Size(124, 20);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.Text = "London10";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new System.Drawing.Point(96, 77);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new System.Drawing.Size(124, 20);
            usernameTextBox.TabIndex = 2;
            usernameTextBox.Text = "tom.hall";
            // 
            // serverAddressTextBox
            // 
            serverAddressTextBox.Location = new System.Drawing.Point(96, 24);
            serverAddressTextBox.Name = "serverAddressTextBox";
            serverAddressTextBox.Size = new System.Drawing.Size(241, 20);
            serverAddressTextBox.TabIndex = 0;
            serverAddressTextBox.Text = "http://bamboo.isobardevelopment.com";
            serverAddressTextBox.TextChanged += new System.EventHandler(ServerAddressTextBoxTextChanged);
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(10, 107);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(10, 80);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(58, 13);
            usernameLabel.TabIndex = 4;
            usernameLabel.Text = "Username:";
            // 
            // serverAddressLabel
            // 
            serverAddressLabel.AutoSize = true;
            serverAddressLabel.Location = new System.Drawing.Point(8, 27);
            serverAddressLabel.Name = "serverAddressLabel";
            serverAddressLabel.Size = new System.Drawing.Size(82, 13);
            serverAddressLabel.TabIndex = 3;
            serverAddressLabel.Text = "Server Address:";
            // 
            // AddServer
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new System.Drawing.Size(383, 220);
            ControlBox = false;
            Controls.Add(addNewServerGroupBox);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            Name = "AddServer";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Add new server...";
            TopMost = true;
            addNewServerGroupBox.ResumeLayout(false);
            addNewServerGroupBox.PerformLayout();
            ResumeLayout(false);

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