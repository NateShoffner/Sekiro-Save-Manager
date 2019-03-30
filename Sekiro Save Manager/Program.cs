using System;
using System.Configuration;
using System.Windows.Forms;
using Sekiro_Save_Manager.Forms;
using Sekiro_Save_Manager.Properties;

namespace Sekiro_Save_Manager
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            InitializeSettings();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static void InitializeSettings()
        {
            Settings.Default.Upgrade();
            var provider = new PortableSettingsProvider();
            Settings.Default.Providers.Add(provider);
            foreach (SettingsProperty property in Settings.Default.Properties)
            {
                property.Provider = provider;
            }
        }
    }
}