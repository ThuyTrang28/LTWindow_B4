using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;                // Thư viện để đọc/ghi file
using System.Xml.Serialization; // Thư viện để chuyển đổi đối tượng sang XML

namespace Article02
{
    public partial class Form1 : Form
    {
        // Đường dẫn file lưu cấu hình. 
        // Lưu ý: Nếu máy bạn không có ổ D, hãy đổi thành @"C:\form.xml" hoặc đường dẫn khác
        string path = @"E:\form.xml";

        public Form1()
        {
            InitializeComponent();
        }

        // --- HÀM GHI DỮ LIỆU (Slide 33) ---
        public void Write(InfoWindows iw)
        {
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
                StreamWriter file = new StreamWriter(path);
                writer.Serialize(file, iw);
                file.Close();
            }
            catch (Exception ex)
            {
                // Bắt lỗi nếu ổ đĩa không tồn tại hoặc không có quyền ghi
                MessageBox.Show("Lỗi ghi file: " + ex.Message);
            }
        }

        // --- HÀM ĐỌC DỮ LIỆU (Slide 33) ---
        public InfoWindows? Read()
        {
            // Kiểm tra file có tồn tại không trước khi đọc
            if (!File.Exists(path)) return null;

            try
            {
                XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
                StreamReader file = new StreamReader(path);
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                InfoWindows iw = (InfoWindows)reader.Deserialize(file);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                file.Close();
                return iw;
            }
            catch
            {
                return null;
            }
        }

        // --- SỰ KIỆN RESIZE END (Slide 34) ---
        // Sự kiện này chạy khi bạn kéo thả kích thước form xong và thả chuột ra
        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;   // Lấy chiều rộng hiện tại của Form
            iw.Height = this.Size.Height; // Lấy chiều cao hiện tại của Form
            Write(iw); // Lưu xuống file

            // Dòng này để test chơi, cho title form hiện chữ "Đã lưu" để bạn biết nó chạy
            this.Text = "Đã lưu kích thước: " + iw.Width + "x" + iw.Height;
        }

        // --- SỰ KIỆN LOAD (Slide 34) ---
        // Sự kiện này chạy khi Form bắt đầu hiện lên
        private void Form1_Load(object sender, EventArgs e)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            InfoWindows iw = Read(); // Đọc file cũ lên
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            if (iw != null)
            {
                this.Width = iw.Width;   // Khôi phục chiều rộng
                this.Height = iw.Height; // Khôi phục chiều cao
            }
        }
    }
}