using System;
using System.Windows.Forms;

namespace Exercise._02.MultipleInvoices
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
            Application.Run(new Perspectives.frmMultipleInvoices());
        }
    }
}
