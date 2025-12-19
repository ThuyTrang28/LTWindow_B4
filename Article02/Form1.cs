using System;
using System.IO; // Cần thiết cho Stream
using System.Windows.Forms;
using System.Xml.Serialization; // Cần thiết cho XML

namespace Article02
{
    public partial class Form1 : Form
    {
        // SỬA LỖI 1: Dùng đường dẫn tương đối (lưu ngay cạnh file .exe) để tránh lỗi quyền truy cập ổ C:
        string path = "form.xml";

        public Form1()
        {
            InitializeComponent();
        }

        public void Write(InfoWindows iw)
        {
            // SỬA LỖI: Dùng 'using' để tự động đóng file và giải phóng bộ nhớ an toàn hơn
            using (StreamWriter file = new StreamWriter(path))
            {
                XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
                writer.Serialize(file, iw);
            }
        }

        public InfoWindows Read()
        {
            InfoWindows iw = new InfoWindows();

            // SỬA LỖI 2: Kiểm tra file có tồn tại không trước khi đọc
            if (File.Exists(path))
            {
                using (StreamReader file = new StreamReader(path))
                {
                    XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    iw = (InfoWindows)reader.Deserialize(file);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                }
            }
#pragma warning disable CS8603 // Possible null reference return.
            return iw;
#pragma warning restore CS8603 // Possible null reference return.
        }

        // Sự kiện khi thay đổi kích thước xong
        void Form1_ResizeEnd(object sender, System.EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Width;
            iw.Height = this.Height;
            Write(iw);
        }

        // Sự kiện khi Form load
        void Form1_Load(object sender, System.EventArgs e)
        {
            // Đọc cấu hình
            InfoWindows iw = Read();

            // SỬA LỖI 3: Chỉ gán kích thước nếu dữ liệu đọc về hợp lệ (khác 0)
            if (iw != null && iw.Width > 0 && iw.Height > 0)
            {
                this.Width = iw.Width;
                this.Height = iw.Height;
            }
        }
    }
}