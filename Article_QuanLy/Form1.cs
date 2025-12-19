using System;
using System.Drawing;
using System.Windows.Forms;

namespace Article_QuanLy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện click nút Đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            // 1. Kiểm tra rỗng
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra tài khoản (Demo)
            if (email == "trang@admin.com" && password == "280405")
            {
                // Thông báo nhẹ (có thể bỏ dòng này nếu muốn vào thẳng luôn)
                // MessageBox.Show("Đăng nhập thành công!", "Thông báo");

                // --- PHẦN LOGIC CHUYỂN TRANG ---

                // Ẩn form đăng nhập đi
                this.Hide();

                // Khởi tạo Dashboard
                Dashboard dash = new Dashboard();

                // Hiển thị Dashboard và đợi kết quả khi nó đóng lại
                DialogResult result = dash.ShowDialog();

                // --- XỬ LÝ KHI DASHBOARD ĐÓNG ---

                if (result == DialogResult.OK)
                {
                    // Nếu người dùng bấm "Đăng xuất" (DialogResult.OK), hiện lại Form đăng nhập
                    this.Show();
                    txtPassword.Clear(); // Xóa pass cũ
                    txtEmail.Focus();
                }
                else
                {
                    // Nếu người dùng bấm nút X tắt Dashboard, thì tắt luôn chương trình
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Email hoặc mật khẩu không chính xác!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtEmail.Focus();
            }
        }

        // Sự kiện nút Tắt Form
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}