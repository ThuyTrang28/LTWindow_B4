using System;
using System.Windows.Forms;

namespace Article02 // <--- Namespace này PHẢI GIỐNG với namespace trong Form1.cs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread] // <--- Bắt buộc phải có dòng này cho WinForms
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Đảm bảo Form1 đã được khai báo public trong namespace Article02
            Application.Run(new Form1());
        }
    }
}