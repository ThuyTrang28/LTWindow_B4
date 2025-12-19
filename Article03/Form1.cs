using System;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Article03
{
    public partial class Form1 : Form
    {
        // Khai báo đường dẫn file XML
        // Lưu ý: Đảm bảo ổ đĩa E: tồn tại, nếu không hãy đổi sang ổ C hoặc D
        string path = @"E:\form.xml";

        // Khai báo biến thành viên
        InfoWindows iw = new InfoWindows();

        public Form1()
        {
            InitializeComponent();

            // QUAN TRỌNG: Gán sự kiện FormClosing (nếu chưa gán trong giao diện Design)
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            this.FormClosing += Form1_FormClosing;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
        }

        // --- PHƯƠNG THỨC GHI (WRITE) ĐÃ SỬA ---
        public void Write(InfoWindows iw)
        {
            try
            {
                // Sử dụng 'using' để file tự động đóng sau khi ghi xong
                using (StreamWriter file = new StreamWriter(path))
                {
                    XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
                    writer.Serialize(file, iw);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu file: " + ex.Message);
            }
        }

        // --- PHƯƠNG THỨC ĐỌC (READ) ĐÃ SỬA ---
        public InfoWindows Read()
        {
            // 1. Kiểm tra file có tồn tại không. Nếu KHÔNG -> Trả về mặc định, KHÔNG ĐỌC file
            if (!File.Exists(path))
            {
                return new InfoWindows();
            }

            try
            {
                // 2. Sử dụng 'using' để đảm bảo an toàn file
                using (StreamReader file = new StreamReader(path))
                {
                    XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
                    InfoWindows? result = reader.Deserialize(file) as InfoWindows;

                    if (result != null)
                        return result;
                }
            }
            catch (Exception)
            {
                // Nếu file bị lỗi cấu trúc (corrupt), trả về mặc định thay vì crash phần mềm
                return new InfoWindows();
            }

            return new InfoWindows();
        }

        // Sự kiện xảy ra khi Form được tải
        private void Form1_Load(object sender, EventArgs e)
        {
            // Đọc dữ liệu từ file (nếu có)
            iw = Read();

            // Kiểm tra: Chỉ gán kích thước nếu dữ liệu hợp lệ (tránh form bị thu nhỏ về 0)
            if (iw.Width > 0 && iw.Height > 0)
            {
                this.Width = iw.Width;
                this.Height = iw.Height;
                this.Location = iw.Location;
            }
        }

        // Sự kiện xảy ra trước khi đóng Form
        // Lưu ý: Sự kiện chuẩn là FormClosingEventArgs
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cập nhật trạng thái hiện tại vào biến iw
            iw.Width = this.Width;
            iw.Height = this.Height;
            iw.Location = this.Location;

            // Ghi ra file
            Write(iw);
        }
    }
}