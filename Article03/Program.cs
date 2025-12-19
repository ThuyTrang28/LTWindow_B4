using System;
using System.Windows.Forms;

namespace Article03
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Kiểm tra xem đang chạy bản .NET nào để gọi hàm khởi tạo phù hợp
            // Nếu bạn dùng .NET Framework cũ, hãy xóa dòng ApplicationConfiguration và bỏ comment 2 dòng dưới

            // Cách khởi tạo cho .NET 6, 7, 8 trở lên:
            try
            {
                // Nếu dòng này báo lỗi đỏ, hãy XÓA nó và dùng 2 dòng Application phía dưới
                ApplicationConfiguration.Initialize();
            }
            catch
            {
                // Dự phòng cho .NET cũ
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
            }

            // Chạy Form1
            Application.Run(new Form1());
        }
    }
}