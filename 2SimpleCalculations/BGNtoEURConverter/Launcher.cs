using System;
using System.Windows.Forms;

namespace BGNtoEURConverter
{
    static class Launcher
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormConverter());
        }
    }
}
