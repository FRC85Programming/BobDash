using System;

namespace BobDash
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var app = new App();
            app.InitializeComponent();
            app.Run();
        }
    }
}
