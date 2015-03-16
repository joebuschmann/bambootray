using BambooTray.Services;

namespace BambooTray.App
{
    using System;
    using System.Windows.Forms;

    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static int Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SettingsService settingsService = null;

            try
            {
                settingsService = new SettingsService("Settings.config");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to load the settings file.");
                return 1;
            }

            Application.Run(new MainWindow(settingsService));
            return 0;
        }
    }
}
