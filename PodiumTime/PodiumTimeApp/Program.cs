using System;
using System.Linq;
using System.Windows.Forms;

namespace PodiumTimeApp {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PodiumTimeModels.Connection.connectionString = Properties.Settings.Default.connectionString;
            Application.Run(new forms.frmPrincipal());
        }
    }
}