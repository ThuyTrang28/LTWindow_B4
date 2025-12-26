using System;
using System.Windows.Forms;

namespace Article_QuanLy
{
    public partial class MainForm5 : Form
    {
        public MainForm5()
        {
            InitializeComponent();
        }

        private void MainForm5_Load(object sender, EventArgs e)
        {
            // Load thông tin từ DataGlobal lên các ô nhập
            txtName.Text = DataGlobal.TenCongTy;
            txtAddress.Text = DataGlobal.DiaChi;
            txtPhone.Text = DataGlobal.DienThoai;
            txtEmail.Text = DataGlobal.Email;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Cập nhật thông tin mới vào DataGlobal
            DataGlobal.TenCongTy = txtName.Text;
            DataGlobal.DiaChi = txtAddress.Text;
            DataGlobal.DienThoai = txtPhone.Text;
            DataGlobal.Email = txtEmail.Text;

            MessageBox.Show("Đã lưu cấu hình hệ thống thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatKhauCu.Text) || string.IsNullOrEmpty(txtMatKhauMoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mật khẩu!", "Cảnh báo");
                return;
            }

            // Demo chức năng đổi mật khẩu (vì chưa có Database thật)
            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo");
            txtMatKhauCu.Clear();
            txtMatKhauMoi.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}