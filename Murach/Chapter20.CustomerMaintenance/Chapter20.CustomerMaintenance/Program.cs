using System;
using System.Windows.Forms;
using Controller = Chapter20.CustomerMaintenance.Controller;

namespace Chapter20.CustomerMaintenance
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
            Application.Run(new Controller::Controller().Run());
        }
    }
}
