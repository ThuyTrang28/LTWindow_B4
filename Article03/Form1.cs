using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;                // Thư viện quản lý file
using System.Xml.Serialization; // Thư viện chuyển đổi đối tượng sang XML

namespace Article03
{
    public partial class Form1 : Form
    {
        // Đường dẫn file lưu cấu hình (theo Slide 39)
        // Lưu ý: Nếu máy bạn không có ổ D, hãy đổi thành @"C:\form.xml" hoặc đường dẫn khác
        string path = @"E:\form.xml";

        InfoWindows iw = new InfoWindows();

        public Form1()
        {
            InitializeComponent();
        }

        // Hàm Ghi file (Serialize) - Slide 38
        public void Write(InfoWindows iw)
        {
#pragma warning disable IDE0059 // Unnecessary assignment of a value
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
                using (StreamWriter file = new StreamWriter(path))
                {
                    writer.Serialize(file, iw);
                    file.Close();
                }
            }
            catch (Exception)
            {
                // Bỏ qua lỗi hoặc hiển thị nếu cần thiết
                // MessageBox.Show(ex.Message);
            }
#pragma warning restore IDE0059 // Unnecessary assignment of a value
        }

        // Hàm Đọc file (Deserialize) - Slide 38
        public InfoWindows? Read()
        {
            try
            {
                if (!File.Exists(path)) return null; // Kiểm tra file tồn tại

                XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
                using (StreamReader file = new StreamReader(path))
                {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    InfoWindows result = (InfoWindows)reader.Deserialize(file);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    file.Close();
                    return result;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Sự kiện khi Form bắt đầu chạy (Load) - Slide 39
        private void Form1_Load(object sender, EventArgs e)
        {
#pragma warning disable CS8601 // Possible null reference assignment.
            iw = Read();
#pragma warning restore CS8601 // Possible null reference assignment.

            // Nếu đọc được file cũ thì gán lại kích thước và vị trí
            if (iw != null)
            {
                this.Width = iw.Width;
                this.Height = iw.Height;
                this.Location = iw.Location;
            }
            else
            {
                // Nếu chưa có file (lần chạy đầu), khởi tạo đối tượng mới
                iw = new InfoWindows();
            }
        }

        // Sự kiện khi Form đang đóng (FormClosing) - Slide 39
        // Lưu ý: Bạn cần gán sự kiện này trong bảng Properties (biểu tượng sấm sét)
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cập nhật thông tin hiện tại vào đối tượng iw
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            iw.Location = this.Location;

            // Ghi xuống file
            Write(iw);
        }
    }
}