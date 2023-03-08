using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BobDash
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var bobDash = new BobDash())
            {
                if (args.Length > 0 && args.Contains("--autoselectonly") )
                {
                    bobDash.AutoSelectOnly = true;
                }
                Application.Run(bobDash);
            }
        }
    }
}
