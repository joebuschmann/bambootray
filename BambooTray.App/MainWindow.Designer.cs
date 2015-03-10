using BambooTray.App.Models;

namespace BambooTray.App
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildsListView = new System.Windows.Forms.ListView();
            this.serverColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projectColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.planColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buildActivityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buildStatusColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastBuildTimeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastBuildDurationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastBuildNumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastVcsRevisionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.successfulTestCountColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.failedTestCountColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.iconTimer = new System.Windows.Forms.Timer(this.components);
            this.mainViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.preferencesToolStripMenuItem.Text = "&Preferences...";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.PreferencesToolStripMenuItemClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // buildsListView
            // 
            this.buildsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serverColumnHeader,
            this.projectColumnHeader,
            this.planColumnHeader,
            this.buildActivityColumnHeader,
            this.buildStatusColumnHeader,
            this.lastBuildTimeColumnHeader,
            this.lastBuildDurationColumnHeader,
            this.lastBuildNumberColumnHeader,
            this.lastVcsRevisionColumnHeader,
            this.successfulTestCountColumnHeader,
            this.failedTestCountColumnHeader});
            this.buildsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildsListView.FullRowSelect = true;
            this.buildsListView.Location = new System.Drawing.Point(0, 24);
            this.buildsListView.Name = "buildsListView";
            this.buildsListView.Size = new System.Drawing.Size(896, 200);
            this.buildsListView.TabIndex = 3;
            this.buildsListView.UseCompatibleStateImageBehavior = false;
            this.buildsListView.View = System.Windows.Forms.View.Details;
            this.buildsListView.DoubleClick += new System.EventHandler(this.ListViewDoubleClick);
            // 
            // serverColumnHeader
            // 
            this.serverColumnHeader.Text = "Server";
            this.serverColumnHeader.Width = 100;
            // 
            // projectColumnHeader
            // 
            this.projectColumnHeader.Text = "Project";
            this.projectColumnHeader.Width = 100;
            // 
            // planColumnHeader
            // 
            this.planColumnHeader.Text = "Plan";
            // 
            // buildActivityColumnHeader
            // 
            this.buildActivityColumnHeader.Text = "Activity";
            // 
            // buildStatusColumnHeader
            // 
            this.buildStatusColumnHeader.Text = "Status";
            this.buildStatusColumnHeader.Width = 70;
            // 
            // lastBuildTimeColumnHeader
            // 
            this.lastBuildTimeColumnHeader.Text = "Last Build";
            this.lastBuildTimeColumnHeader.Width = 85;
            // 
            // lastBuildDurationColumnHeader
            // 
            this.lastBuildDurationColumnHeader.Text = "Duration";
            this.lastBuildDurationColumnHeader.Width = 80;
            // 
            // lastBuildNumberColumnHeader
            // 
            this.lastBuildNumberColumnHeader.Text = "Build Number";
            this.lastBuildNumberColumnHeader.Width = 80;
            // 
            // lastVcsRevisionColumnHeader
            // 
            this.lastVcsRevisionColumnHeader.Text = "VCS Revision";
            this.lastVcsRevisionColumnHeader.Width = 80;
            // 
            // successfulTestCountColumnHeader
            // 
            this.successfulTestCountColumnHeader.Text = "Passing Tests";
            this.successfulTestCountColumnHeader.Width = 80;
            // 
            // failedTestCountColumnHeader
            // 
            this.failedTestCountColumnHeader.Text = "Failing Tests";
            this.failedTestCountColumnHeader.Width = 80;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Bamboo Tray";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.NotifyIconClick);
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 20000;
            this.updateTimer.Tick += new System.EventHandler(this.UpdateTimerTick);
            // 
            // iconTimer
            // 
            this.iconTimer.Interval = 200;
            this.iconTimer.Tick += new System.EventHandler(this.BuildIconTimerTick);
            // 
            // mainViewModelBindingSource
            // 
            this.mainViewModelBindingSource.DataSource = typeof(BambooTray.App.Models.MainViewModel);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 224);
            this.Controls.Add(this.buildsListView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Bamboo Tray";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.BindingSource mainViewModelBindingSource;
        private System.Windows.Forms.ListView buildsListView;
        private System.Windows.Forms.ColumnHeader serverColumnHeader;
        private System.Windows.Forms.ColumnHeader projectColumnHeader;
        private System.Windows.Forms.ColumnHeader planColumnHeader;
        private System.Windows.Forms.ColumnHeader buildActivityColumnHeader;
        private System.Windows.Forms.ColumnHeader buildStatusColumnHeader;
        private System.Windows.Forms.ColumnHeader lastBuildTimeColumnHeader;
        private System.Windows.Forms.ColumnHeader lastBuildDurationColumnHeader;
        private System.Windows.Forms.ColumnHeader lastBuildNumberColumnHeader;
        private System.Windows.Forms.ColumnHeader lastVcsRevisionColumnHeader;
        private System.Windows.Forms.ColumnHeader successfulTestCountColumnHeader;
        private System.Windows.Forms.ColumnHeader failedTestCountColumnHeader;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer iconTimer;
    }
}

