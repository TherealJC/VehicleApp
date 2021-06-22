// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// Author : Jamie Crowther
// Published Date : 22/06/2021

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