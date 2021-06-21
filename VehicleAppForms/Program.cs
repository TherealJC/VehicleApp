using System;
using System.Windows.Forms;

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
            Run();
        }

        //Moving Application.Run into a separate method
        //stops the MainForm instance from being instantiated
        //before Application.SetCompatibleTextRenderingDefault
        static void Run()
        {
            //Runs the instance set on Main Form
            Application.Run(MainForm.Instance);
        }
    }
}