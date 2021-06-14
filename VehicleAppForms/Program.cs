using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleAppLibrary;

namespace VehicleAppForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize the Database connection (This is where you choose Sql or Text connection)
            VehicleAppLibrary.GlobalConfig.InitializeConnections(DatabaseType.TextFile);

            Application.Run(new MainForm());
        }
    }
}