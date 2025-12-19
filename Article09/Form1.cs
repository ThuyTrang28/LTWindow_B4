using System;
using System.IO; // Thêm thư viện này để sử dụng StreamWriter
using System.Windows.Forms;

namespace Article09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Các thiết lập ban đầu cho Form có thể đặt ở đây
        }

        // ----------------------------------------------------
        // 3. LOGIC XỬ LÝ SỰ KIỆN (EVENT HANDLERS)
        // ----------------------------------------------------

        // Hàm xử lý khi nhấn nút "Cộng"
        private void btCong_Click(object sender, EventArgs e)
        {
            // Xử lý lỗi nếu người dùng không nhập hoặc nhập ký tự không phải số
            try
            {
                int x = int.Parse(tbSoX.Text);
                int y = int.Parse(tbSoY.Text);
                int kq = x + y;

                // Ghi kết quả vào TextBox kết quả, thêm ký tự xuống dòng "\r\n"
                tbKetQua.Text = tbKetQua.Text + x.ToString() + " + " + y.ToString() +
                                " = " + kq.ToString() + "\r\n";
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ vào cả hai ô.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm xử lý khi nhấn nút "Nhân"
        private void btNhan_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(tbSoX.Text);
                int y = int.Parse(tbSoY.Text);
                int kq = x * y;

                // Ghi kết quả vào TextBox kết quả, thêm ký tự xuống dòng "\r\n"
                tbKetQua.Text = tbKetQua.Text + x.ToString() + " * " + y.ToString() +
                                " = " + kq.ToString() + "\r\n";
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ vào cả hai ô.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm xử lý khi nhấn nút "Lưu"
        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo StreamWriter để ghi vào file "Caculator.txt"
                // Tham số 'true' đảm bảo nội dung được thêm vào (append) cuối file
                using (StreamWriter sw = new StreamWriter("Caculator.txt", true))
                {
                    // Ghi nội dung của TextBox kết quả vào file
                    sw.Write(tbKetQua.Text);
                }
                MessageBox.Show("Đã lưu kết quả thành công vào file Caculator.txt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cần thêm hàm btThoat_Click nếu có, thường là Application.Exit(); hoặc this.Close();
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}