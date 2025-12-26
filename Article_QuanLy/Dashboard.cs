using System;
using System.Windows.Forms;

namespace Article_QuanLy
{
    public partial class Dashboard : Form
    {
        // Biến cờ để kiểm tra xem có phải đang đăng xuất không
        private bool isLogout = false;

        public Dashboard()
        {
            InitializeComponent();
            DataGlobal.FakeData();

            // Đăng ký sự kiện khi Form đóng
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            this.FormClosed += Dashboard_FormClosed;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
        }

        // --- XỬ LÝ KHI FORM ĐÓNG ---
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Nếu không phải là đăng xuất (tức là bấm nút X đỏ), thì tắt hẳn ứng dụng
            if (!isLogout)
            {
                Application.Exit();
            }
            // Nếu là đăng xuất, form chỉ đóng lại, quyền điều khiển trả về Form1
        }

        // --- NÚT ĐĂNG XUẤT ---
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                isLogout = true; // Đánh dấu là đang đăng xuất
                this.DialogResult = DialogResult.OK; // Gửi tín hiệu OK về Form1
                this.Close(); // Đóng Dashboard
            }
        }

        // --- CÁC NÚT CHỨC NĂNG KHÁC (GIỮ NGUYÊN) ---
        private void Dashboard_Load(object sender, EventArgs e) { }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm(); this.Hide(); frm.ShowDialog(); this.Show();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            MainForm2 frm = new MainForm2(); this.Hide(); frm.ShowDialog(); this.Show();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            MainForm3 frm = new MainForm3(); this.Hide(); frm.ShowDialog(); this.Show();
        }

        private void btnRecruit_Click(object sender, EventArgs e)
        {
            MainForm4 frm = new MainForm4(); this.Hide(); frm.ShowDialog(); this.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MainForm5 frm = new MainForm5(); this.Hide(); frm.ShowDialog(); this.Show();
        }

        private void btnFeature_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show($"Chức năng '{btn.Text.Trim()}' đang được xây dựng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e) { }
    }
}