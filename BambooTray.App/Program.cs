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
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var settingsService = new SettingsService("Settings.config");

            Application.Run(new MainWindow(settingsService));
        }
    }
}
