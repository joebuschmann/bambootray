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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesWindow));
            this.preferencesTabControl = new System.Windows.Forms.TabControl();
            this.buildsTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buildPlansListView = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serversListBox = new System.Windows.Forms.ListBox();
            this.serverViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addServerButton = new System.Windows.Forms.Button();
            this.configureServerButton = new System.Windows.Forms.Button();
            this.removeServerButton = new System.Windows.Forms.Button();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.preferencesTabControl.SuspendLayout();
            this.buildsTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // preferencesTabControl
            // 
            this.preferencesTabControl.Controls.Add(this.buildsTabPage);
            this.preferencesTabControl.Controls.Add(this.generalTabPage);
            this.preferencesTabControl.Location = new System.Drawing.Point(12, 12);
            this.preferencesTabControl.Name = "preferencesTabControl";
            this.preferencesTabControl.SelectedIndex = 0;
            this.preferencesTabControl.Size = new System.Drawing.Size(626, 283);
            this.preferencesTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.preferencesTabControl.TabIndex = 0;
            // 
            // buildsTabPage
            // 
            this.buildsTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.buildsTabPage.Controls.Add(this.groupBox2);
            this.buildsTabPage.Controls.Add(this.groupBox1);
            this.buildsTabPage.Location = new System.Drawing.Point(4, 22);
            this.buildsTabPage.Name = "buildsTabPage";
            this.buildsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.buildsTabPage.Size = new System.Drawing.Size(618, 257);
            this.buildsTabPage.TabIndex = 1;
            this.buildsTabPage.Text = "Builds";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buildPlansListView);
            this.groupBox2.Location = new System.Drawing.Point(312, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 228);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Build Plans";
            // 
            // buildPlansListView
            // 
            this.buildPlansListView.CheckBoxes = true;
            this.buildPlansListView.FullRowSelect = true;
            this.buildPlansListView.Location = new System.Drawing.Point(7, 20);
            this.buildPlansListView.Name = "buildPlansListView";
            this.buildPlansListView.Size = new System.Drawing.Size(287, 172);
            this.buildPlansListView.TabIndex = 0;
            this.buildPlansListView.UseCompatibleStateImageBehavior = false;
            this.buildPlansListView.View = System.Windows.Forms.View.List;
            this.buildPlansListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.BuildPlansListViewItemChecked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serversListBox);
            this.groupBox1.Controls.Add(this.addServerButton);
            this.groupBox1.Controls.Add(this.configureServerButton);
            this.groupBox1.Controls.Add(this.removeServerButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 228);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Build Servers";
            // 
            // serversListBox
            // 
            this.serversListBox.DataSource = this.serverViewModelBindingSource;
            this.serversListBox.DisplayMember = "Name";
            this.serversListBox.FormattingEnabled = true;
            this.serversListBox.Location = new System.Drawing.Point(6, 19);
            this.serversListBox.Name = "serversListBox";
            this.serversListBox.Size = new System.Drawing.Size(288, 173);
            this.serversListBox.TabIndex = 6;
            this.serversListBox.ValueMember = "Address";
            // 
            // serverViewModelBindingSource
            // 
            this.serverViewModelBindingSource.DataSource = typeof(BambooTray.Domain.Settings.Server);
            // 
            // addServerButton
            // 
            this.addServerButton.Location = new System.Drawing.Point(28, 199);
            this.addServerButton.Name = "addServerButton";
            this.addServerButton.Size = new System.Drawing.Size(75, 23);
            this.addServerButton.TabIndex = 2;
            this.addServerButton.Text = "&Add";
            this.addServerButton.UseVisualStyleBackColor = true;
            this.addServerButton.Click += new System.EventHandler(this.AddServerButtonClick);
            // 
            // configureServerButton
            // 
            this.configureServerButton.Location = new System.Drawing.Point(190, 199);
            this.configureServerButton.Name = "configureServerButton";
            this.configureServerButton.Size = new System.Drawing.Size(75, 23);
            this.configureServerButton.TabIndex = 5;
            this.configureServerButton.Text = "&Configure";
            this.configureServerButton.UseVisualStyleBackColor = true;
            this.configureServerButton.Click += new System.EventHandler(this.ConfigureServerButtonClick);
            // 
            // removeServerButton
            // 
            this.removeServerButton.Location = new System.Drawing.Point(109, 199);
            this.removeServerButton.Name = "removeServerButton";
            this.removeServerButton.Size = new System.Drawing.Size(75, 23);
            this.removeServerButton.TabIndex = 4;
            this.removeServerButton.Text = "&Remove";
            this.removeServerButton.UseVisualStyleBackColor = true;
            this.removeServerButton.Click += new System.EventHandler(this.RemoveServerButtonClick);
            // 
            // generalTabPage
            // 
            this.generalTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalTabPage.Size = new System.Drawing.Size(618, 257);
            this.generalTabPage.TabIndex = 0;
            this.generalTabPage.Text = "General";
            // 
            // PreferencesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 307);
            this.Controls.Add(this.preferencesTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreferencesWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bamboo Tray Preferences";
            this.TopMost = true;
            this.preferencesTabControl.ResumeLayout(false);
            this.buildsTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serverViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

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