using System;
using System.Windows.Forms;
using CountAnything.Forms;
using CountAnything.Properties;

namespace CountAnything {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CounterForm());
        }

        public static CounterConfig LoadConfig()
        {
            return Settings.Default.Config ?? CounterConfig.Default;
        }

        public static void SaveConfig(CounterConfig config)
        {
            Settings.Default.Config = config;
            Settings.Default.Save();
        }
    }
}
