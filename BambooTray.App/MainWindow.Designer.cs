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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            buildsListView = new System.Windows.Forms.ListView();
            serverColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            projectColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            planColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            buildActivityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            buildStatusColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lastBuildTimeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lastBuildDurationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lastBuildNumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lastVcsRevisionColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            successfulTestCountColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            failedTestCountColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            notifyIcon = new System.Windows.Forms.NotifyIcon(components);
            updateTimer = new System.Windows.Forms.Timer(components);
            iconTimer = new System.Windows.Forms.Timer(components);
            mainViewModelBindingSource = new System.Windows.Forms.BindingSource(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(mainViewModelBindingSource)).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            fileToolStripMenuItem,
            helpToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(896, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            preferencesToolStripMenuItem,
            exitToolStripMenuItem});
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // preferencesToolStripMenuItem
            // 
            preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            preferencesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            preferencesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            preferencesToolStripMenuItem.Text = "&Preferences...";
            preferencesToolStripMenuItem.Click += new System.EventHandler(PreferencesToolStripMenuItemClick);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            exitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += new System.EventHandler(ExitToolStripMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            aboutToolStripMenuItem});
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += new System.EventHandler(AboutToolStripMenuItemClick);
            // 
            // buildsListView
            // 
            buildsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            serverColumnHeader,
            projectColumnHeader,
            planColumnHeader,
            buildActivityColumnHeader,
            buildStatusColumnHeader,
            lastBuildTimeColumnHeader,
            lastBuildDurationColumnHeader,
            lastBuildNumberColumnHeader,
            lastVcsRevisionColumnHeader,
            successfulTestCountColumnHeader,
            failedTestCountColumnHeader});
            buildsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            buildsListView.FullRowSelect = true;
            buildsListView.Location = new System.Drawing.Point(0, 24);
            buildsListView.Name = "buildsListView";
            buildsListView.Size = new System.Drawing.Size(896, 200);
            buildsListView.TabIndex = 3;
            buildsListView.UseCompatibleStateImageBehavior = false;
            buildsListView.View = System.Windows.Forms.View.Details;
            // 
            // serverColumnHeader
            // 
            serverColumnHeader.Text = "Server";
            serverColumnHeader.Width = 100;
            // 
            // projectColumnHeader
            // 
            projectColumnHeader.Text = "Project";
            projectColumnHeader.Width = 100;
            // 
            // planColumnHeader
            // 
            planColumnHeader.Text = "Plan";
            // 
            // buildActivityColumnHeader
            // 
            buildActivityColumnHeader.Text = "Activity";
            // 
            // buildStatusColumnHeader
            // 
            buildStatusColumnHeader.Text = "Status";
            buildStatusColumnHeader.Width = 70;
            // 
            // lastBuildTimeColumnHeader
            // 
            lastBuildTimeColumnHeader.Text = "Last Build";
            lastBuildTimeColumnHeader.Width = 85;
            // 
            // lastBuildDurationColumnHeader
            // 
            lastBuildDurationColumnHeader.Text = "Duration";
            lastBuildDurationColumnHeader.Width = 80;
            // 
            // lastBuildNumberColumnHeader
            // 
            lastBuildNumberColumnHeader.Text = "Build Number";
            lastBuildNumberColumnHeader.Width = 80;
            // 
            // lastVcsRevisionColumnHeader
            // 
            lastVcsRevisionColumnHeader.Text = "VCS Revision";
            lastVcsRevisionColumnHeader.Width = 80;
            // 
            // successfulTestCountColumnHeader
            // 
            successfulTestCountColumnHeader.Text = "Passing Tests";
            successfulTestCountColumnHeader.Width = 80;
            // 
            // failedTestCountColumnHeader
            // 
            failedTestCountColumnHeader.Text = "Failing Tests";
            failedTestCountColumnHeader.Width = 80;
            // 
            // notifyIcon
            // 
            notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            notifyIcon.Text = "Bamboo Tray";
            notifyIcon.Visible = true;
            notifyIcon.Click += new System.EventHandler(NotifyIconClick);
            // 
            // updateTimer
            // 
            updateTimer.Enabled = true;
            updateTimer.Interval = 20000;
            updateTimer.Tick += new System.EventHandler(UpdateTimerTick);
            // 
            // iconTimer
            // 
            iconTimer.Interval = 200;
            iconTimer.Tick += new System.EventHandler(BuildIconTimerTick);
            // 
            // mainViewModelBindingSource
            // 
            mainViewModelBindingSource.DataSource = typeof(MainViewModel);
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(896, 224);
            Controls.Add(buildsListView);
            Controls.Add(menuStrip1);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainWindow";
            Text = "Bamboo Tray";
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(MainFormClosing);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(mainViewModelBindingSource)).EndInit();
            ResumeLayout(false);
            PerformLayout();

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

