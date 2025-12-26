using System;
using System.Windows.Forms;
using System.IO;                // Cần thiết để dùng StreamWriter
using System.Xml.Serialization; // Cần thiết để dùng XmlSerializer

namespace Article01
{
    public partial class Form1 : Form
    {
        // Đường dẫn file lưu trữ (như trong Slide 28)
        // Lưu ý: Đảm bảo ổ D: tồn tại và bạn có quyền ghi file, 
        // nếu không hãy đổi thành @"C:\temp\form.xml" hoặc đường dẫn khác.
        string path = @"E:\form.xml";

        public Form1()
        {
            InitializeComponent();
        }

        // Hàm ghi dữ liệu xuống file XML (Slide 28)
        public void Write(InfoWindows iw)
        {
            try
            {
                // Khởi tạo Serializer cho kiểu InfoWindows
                XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));

                // Tạo file và ghi dữ liệu
                using (StreamWriter file = new StreamWriter(path))
                {
                    writer.Serialize(file, iw);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi ghi file: " + ex.Message);
            }
        }

        // Sự kiện khi người dùng kết thúc việc thay đổi kích thước Form (Slide 29)
        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            Write(iw); // Gọi hàm Write để lưu
        }

        // Sự kiện khi Form bắt đầu chạy (Slide 29)
        private void Form1_Load(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            Write(iw); // Gọi hàm Write để lưu
        }
    }
}