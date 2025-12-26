using System;
using System.Windows.Forms;

namespace Article_QuanLy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // SỰ KIỆN NÚT ĐĂNG NHẬP
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            // 1. Kiểm tra rỗng
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra tài khoản (Demo)
            if (email == "trang@admin.com" && password == "280405")
            {
                // Ẩn Form đăng nhập
                this.Hide();

                // Khởi tạo và mở Dashboard
                Dashboard dash = new Dashboard();

                // --- QUAN TRỌNG: Dùng ShowDialog để chương trình dừng ở đây chờ Dashboard đóng ---
                DialogResult result = dash.ShowDialog();

                // --- XỬ LÝ KHI DASHBOARD ĐÓNG LẠI ---

                if (result == DialogResult.OK)
                {
                    // Trường hợp 1: Dashboard trả về OK (Do bấm nút Đăng xuất)
                    this.Show();          // Hiện lại Form đăng nhập
                    txtPassword.Clear();  // Xóa mật khẩu cũ
                    txtEmail.Focus();     // Đưa con trỏ về ô Email
                }
                else
                {
                    // Trường hợp 2: Dashboard đóng do bấm nút X (Không phải đăng xuất)
                    Application.Exit();   // Thoát hoàn toàn chương trình
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtEmail.Focus();
            }
        }

        // Nút tắt chương trình ở màn hình đăng nhập
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelRight_Paint(object sender, PaintEventArgs e) { }
    }
}