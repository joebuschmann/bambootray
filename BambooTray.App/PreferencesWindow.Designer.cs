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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesWindow));
            this.preferencesTabControl = new System.Windows.Forms.TabControl();
            this.buildsTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buildPlansListView = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serversListBox = new System.Windows.Forms.ListBox();
            this.serverViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.addServerButton = new System.Windows.Forms.Button();
            this.configureServerButton = new System.Windows.Forms.Button();
            this.removeServerButton = new System.Windows.Forms.Button();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkboxEnableBalloonNotifications = new System.Windows.Forms.CheckBox();
            this.numericPollTime = new System.Windows.Forms.NumericUpDown();
            this.numericBalloonTooltipTimeout = new System.Windows.Forms.NumericUpDown();
            this.preferencesTabControl.SuspendLayout();
            this.buildsTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverViewModelBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPollTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBalloonTooltipTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // preferencesTabControl
            // 
            this.preferencesTabControl.Controls.Add(this.buildsTabPage);
            this.preferencesTabControl.Controls.Add(this.generalTabPage);
            this.preferencesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preferencesTabControl.Location = new System.Drawing.Point(0, 0);
            this.preferencesTabControl.Name = "preferencesTabControl";
            this.preferencesTabControl.SelectedIndex = 0;
            this.preferencesTabControl.Size = new System.Drawing.Size(649, 307);
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
            this.buildsTabPage.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.buildsTabPage.Size = new System.Drawing.Size(641, 281);
            this.buildsTabPage.TabIndex = 1;
            this.buildsTabPage.Text = "Builds";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buildPlansListView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(269, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 268);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Build Plans";
            // 
            // buildPlansListView
            // 
            this.buildPlansListView.CheckBoxes = true;
            this.buildPlansListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildPlansListView.FullRowSelect = true;
            this.buildPlansListView.Location = new System.Drawing.Point(3, 16);
            this.buildPlansListView.Name = "buildPlansListView";
            this.buildPlansListView.Size = new System.Drawing.Size(363, 249);
            this.buildPlansListView.TabIndex = 0;
            this.buildPlansListView.UseCompatibleStateImageBehavior = false;
            this.buildPlansListView.View = System.Windows.Forms.View.List;
            this.buildPlansListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.BuildPlansListViewItemChecked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serversListBox);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 268);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Build Servers";
            // 
            // serversListBox
            // 
            this.serversListBox.DataSource = this.serverViewModelBindingSource;
            this.serversListBox.DisplayMember = "Name";
            this.serversListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serversListBox.FormattingEnabled = true;
            this.serversListBox.Location = new System.Drawing.Point(3, 16);
            this.serversListBox.Name = "serversListBox";
            this.serversListBox.Size = new System.Drawing.Size(260, 213);
            this.serversListBox.TabIndex = 6;
            this.serversListBox.ValueMember = "Address";
            // 
            // serverViewModelBindingSource
            // 
            this.serverViewModelBindingSource.DataSource = typeof(BambooTray.Domain.Settings.Server);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addServerButton);
            this.panel1.Controls.Add(this.configureServerButton);
            this.panel1.Controls.Add(this.removeServerButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 36);
            this.panel1.TabIndex = 9;
            // 
            // addServerButton
            // 
            this.addServerButton.Location = new System.Drawing.Point(10, 6);
            this.addServerButton.Name = "addServerButton";
            this.addServerButton.Size = new System.Drawing.Size(75, 23);
            this.addServerButton.TabIndex = 6;
            this.addServerButton.Text = "&Add";
            this.addServerButton.UseVisualStyleBackColor = true;
            this.addServerButton.Click += new System.EventHandler(this.AddServerButtonClick);
            // 
            // configureServerButton
            // 
            this.configureServerButton.Location = new System.Drawing.Point(172, 6);
            this.configureServerButton.Name = "configureServerButton";
            this.configureServerButton.Size = new System.Drawing.Size(75, 23);
            this.configureServerButton.TabIndex = 8;
            this.configureServerButton.Text = "&Configure";
            this.configureServerButton.UseVisualStyleBackColor = true;
            this.configureServerButton.Click += new System.EventHandler(this.ConfigureServerButtonClick);
            // 
            // removeServerButton
            // 
            this.removeServerButton.Location = new System.Drawing.Point(91, 6);
            this.removeServerButton.Name = "removeServerButton";
            this.removeServerButton.Size = new System.Drawing.Size(75, 23);
            this.removeServerButton.TabIndex = 7;
            this.removeServerButton.Text = "&Remove";
            this.removeServerButton.UseVisualStyleBackColor = true;
            this.removeServerButton.Click += new System.EventHandler(this.RemoveServerButtonClick);
            // 
            // generalTabPage
            // 
            this.generalTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.generalTabPage.Controls.Add(this.numericBalloonTooltipTimeout);
            this.generalTabPage.Controls.Add(this.numericPollTime);
            this.generalTabPage.Controls.Add(this.checkboxEnableBalloonNotifications);
            this.generalTabPage.Controls.Add(this.label2);
            this.generalTabPage.Controls.Add(this.label1);
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalTabPage.Size = new System.Drawing.Size(641, 281);
            this.generalTabPage.TabIndex = 0;
            this.generalTabPage.Text = "General";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poll Time (in seconds):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Balloon Tooltip Timeout (in seconds):";
            // 
            // checkboxEnableBalloonNotifications
            // 
            this.checkboxEnableBalloonNotifications.AutoSize = true;
            this.checkboxEnableBalloonNotifications.Location = new System.Drawing.Point(12, 42);
            this.checkboxEnableBalloonNotifications.Name = "checkboxEnableBalloonNotifications";
            this.checkboxEnableBalloonNotifications.Size = new System.Drawing.Size(158, 17);
            this.checkboxEnableBalloonNotifications.TabIndex = 2;
            this.checkboxEnableBalloonNotifications.Text = "Enable Balloon Notifications";
            this.checkboxEnableBalloonNotifications.UseVisualStyleBackColor = true;
            // 
            // numericPollTime
            // 
            this.numericPollTime.Location = new System.Drawing.Point(199, 22);
            this.numericPollTime.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericPollTime.Name = "numericPollTime";
            this.numericPollTime.Size = new System.Drawing.Size(51, 20);
            this.numericPollTime.TabIndex = 5;
            // 
            // numericBalloonTooltipTimeout
            // 
            this.numericBalloonTooltipTimeout.Location = new System.Drawing.Point(199, 66);
            this.numericBalloonTooltipTimeout.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericBalloonTooltipTimeout.Name = "numericBalloonTooltipTimeout";
            this.numericBalloonTooltipTimeout.Size = new System.Drawing.Size(51, 20);
            this.numericBalloonTooltipTimeout.TabIndex = 6;
            // 
            // PreferencesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 307);
            this.Controls.Add(this.preferencesTabControl);
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
            this.panel1.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.generalTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPollTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBalloonTooltipTimeout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl preferencesTabControl;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.TabPage buildsTabPage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox serversListBox;
        private System.Windows.Forms.BindingSource serverViewModelBindingSource;
        private System.Windows.Forms.ListView buildPlansListView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addServerButton;
        private System.Windows.Forms.Button configureServerButton;
        private System.Windows.Forms.Button removeServerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkboxEnableBalloonNotifications;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericBalloonTooltipTimeout;
        private System.Windows.Forms.NumericUpDown numericPollTime;
    }
}