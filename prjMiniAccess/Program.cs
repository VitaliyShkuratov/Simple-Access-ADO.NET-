using System;
using System.Windows.Forms;
using prjMiniAccess.GUI;

namespace prjMiniAccess
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
            Application.Run(new frmMain());
            //Application.Run(new frmSaveAs());
        }
    }
}
