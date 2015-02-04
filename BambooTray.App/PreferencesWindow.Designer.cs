namespace BambooTray.App
{
    partial class PreferencesWindow
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesWindow));
            preferencesTabControl = new System.Windows.Forms.TabControl();
            buildsTabPage = new System.Windows.Forms.TabPage();
            groupBox2 = new System.Windows.Forms.GroupBox();
            buildPlansListView = new System.Windows.Forms.ListView();
            groupBox1 = new System.Windows.Forms.GroupBox();
            serversListBox = new System.Windows.Forms.ListBox();
            serverViewModelBindingSource = new System.Windows.Forms.BindingSource(components);
            addServerButton = new System.Windows.Forms.Button();
            configureServerButton = new System.Windows.Forms.Button();
            removeServerButton = new System.Windows.Forms.Button();
            generalTabPage = new System.Windows.Forms.TabPage();
            preferencesTabControl.SuspendLayout();
            buildsTabPage.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(serverViewModelBindingSource)).BeginInit();
            SuspendLayout();
            // 
            // preferencesTabControl
            // 
            preferencesTabControl.Controls.Add(buildsTabPage);
            preferencesTabControl.Controls.Add(generalTabPage);
            preferencesTabControl.Location = new System.Drawing.Point(12, 12);
            preferencesTabControl.Name = "preferencesTabControl";
            preferencesTabControl.SelectedIndex = 0;
            preferencesTabControl.Size = new System.Drawing.Size(626, 283);
            preferencesTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            preferencesTabControl.TabIndex = 0;
            // 
            // buildsTabPage
            // 
            buildsTabPage.BackColor = System.Drawing.SystemColors.Control;
            buildsTabPage.Controls.Add(groupBox2);
            buildsTabPage.Controls.Add(groupBox1);
            buildsTabPage.Location = new System.Drawing.Point(4, 22);
            buildsTabPage.Name = "buildsTabPage";
            buildsTabPage.Padding = new System.Windows.Forms.Padding(3);
            buildsTabPage.Size = new System.Drawing.Size(618, 257);
            buildsTabPage.TabIndex = 1;
            buildsTabPage.Text = "Builds";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buildPlansListView);
            groupBox2.Location = new System.Drawing.Point(312, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(300, 228);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Build Plans";
            // 
            // buildPlansListView
            // 
            buildPlansListView.CheckBoxes = true;
            buildPlansListView.FullRowSelect = true;
            buildPlansListView.Location = new System.Drawing.Point(7, 20);
            buildPlansListView.Name = "buildPlansListView";
            buildPlansListView.Size = new System.Drawing.Size(287, 172);
            buildPlansListView.TabIndex = 0;
            buildPlansListView.UseCompatibleStateImageBehavior = false;
            buildPlansListView.View = System.Windows.Forms.View.List;
            buildPlansListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(BuildPlansListViewItemChecked);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(serversListBox);
            groupBox1.Controls.Add(addServerButton);
            groupBox1.Controls.Add(configureServerButton);
            groupBox1.Controls.Add(removeServerButton);
            groupBox1.Location = new System.Drawing.Point(6, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(300, 228);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Build Servers";
            // 
            // serversListBox
            // 
            serversListBox.DataSource = serverViewModelBindingSource;
            serversListBox.DisplayMember = "Name";
            serversListBox.FormattingEnabled = true;
            serversListBox.Location = new System.Drawing.Point(6, 19);
            serversListBox.Name = "serversListBox";
            serversListBox.Size = new System.Drawing.Size(288, 173);
            serversListBox.TabIndex = 6;
            serversListBox.ValueMember = "Address";
            // 
            // serverViewModelBindingSource
            // 
            serverViewModelBindingSource.DataSource = typeof(BambooTray.Domain.Settings.Server);
            // 
            // addServerButton
            // 
            addServerButton.Location = new System.Drawing.Point(28, 199);
            addServerButton.Name = "addServerButton";
            addServerButton.Size = new System.Drawing.Size(75, 23);
            addServerButton.TabIndex = 2;
            addServerButton.Text = "&Add";
            addServerButton.UseVisualStyleBackColor = true;
            addServerButton.Click += new System.EventHandler(AddServerButtonClick);
            // 
            // configureServerButton
            // 
            configureServerButton.Location = new System.Drawing.Point(190, 199);
            configureServerButton.Name = "configureServerButton";
            configureServerButton.Size = new System.Drawing.Size(75, 23);
            configureServerButton.TabIndex = 5;
            configureServerButton.Text = "&Configure";
            configureServerButton.UseVisualStyleBackColor = true;
            configureServerButton.Click += new System.EventHandler(ConfigureServerButtonClick);
            // 
            // removeServerButton
            // 
            removeServerButton.Location = new System.Drawing.Point(109, 199);
            removeServerButton.Name = "removeServerButton";
            removeServerButton.Size = new System.Drawing.Size(75, 23);
            removeServerButton.TabIndex = 4;
            removeServerButton.Text = "&Remove";
            removeServerButton.UseVisualStyleBackColor = true;
            removeServerButton.Click += new System.EventHandler(RemoveServerButtonClick);
            // 
            // generalTabPage
            // 
            generalTabPage.BackColor = System.Drawing.SystemColors.Control;
            generalTabPage.Location = new System.Drawing.Point(4, 22);
            generalTabPage.Name = "generalTabPage";
            generalTabPage.Padding = new System.Windows.Forms.Padding(3);
            generalTabPage.Size = new System.Drawing.Size(618, 257);
            generalTabPage.TabIndex = 0;
            generalTabPage.Text = "General";
            // 
            // PreferencesWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(649, 307);
            Controls.Add(preferencesTabControl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PreferencesWindow";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Bamboo Tray Preferences";
            TopMost = true;
            preferencesTabControl.ResumeLayout(false);
            buildsTabPage.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(serverViewModelBindingSource)).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl preferencesTabControl;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.TabPage buildsTabPage;
        private System.Windows.Forms.Button removeServerButton;
        private System.Windows.Forms.Button addServerButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox serversListBox;
        private System.Windows.Forms.Button configureServerButton;
        private System.Windows.Forms.BindingSource serverViewModelBindingSource;
        private System.Windows.Forms.ListView buildPlansListView;
    }
}