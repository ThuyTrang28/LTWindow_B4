using System;
using System.Windows.Forms;

namespace Article01
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

            // THAY ĐỔI Ở ĐÂY: Chạy LoginForm thay vì Form1
            Application.Run(new LoginForm());
        }
    }
}