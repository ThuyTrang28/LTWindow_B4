using System;
using System.IO; // Bắt buộc có để dùng StreamWriter/Directory
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Article01
{
    public partial class Form1 : Form
    {
        // Đường dẫn file lưu trữ
        string path = @"E:\form_info.xml";

        public Form1()
        {
            InitializeComponent();
        }

        // Hàm ghi file
        public void Write(InfoWindows iw)
        {
            try
            {
                // 1. Kiểm tra và tạo thư mục nếu chưa có
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string folder = Path.GetDirectoryName(path);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                if (!Directory.Exists(folder))
                {
#pragma warning disable CS8604 // Possible null reference argument.
                    Directory.CreateDirectory(folder);
#pragma warning restore CS8604 // Possible null reference argument.
                }

                // 2. Ghi file XML (Dùng 'using' để an toàn)
                XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
                using (StreamWriter file = new StreamWriter(path))
                {
                    writer.Serialize(file, iw);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message);
            }
        }

        // Sự kiện Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            Write(iw);
        }

        // Sự kiện khi kéo thả xong kích thước Form
        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            Write(iw);
        }
    }
}