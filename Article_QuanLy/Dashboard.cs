using System;
using System.Windows.Forms;

namespace Article_QuanLy
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        // 1. Mở Form Quản lý Hồ sơ
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        // 2. Các nút chức năng chưa có (Hiện thông báo)
        private void btnFeature_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show($"Chức năng '{btn.Text.Trim()}' đang được xây dựng!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 3. Đăng xuất
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}