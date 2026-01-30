using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Article01
{
    public partial class SettingsForm : Form
    {
        string connStr = @"Data Source=LAPTOP-6EIPC5N4\SQLNEW;Initial Catalog=sale;Integrated Security=True;TrustServerCertificate=True";

        // Giả sử tài khoản đang đăng nhập là admin
        string currentUser = "admin";

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOldPass.Text) || string.IsNullOrWhiteSpace(txtNewPass.Text) || string.IsNullOrWhiteSpace(txtReNewPass.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNewPass.Text != txtReNewPass.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    // 1. Kiểm tra mật khẩu cũ có đúng không
                    string sqlCheck = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @user AND MatKhau = @pass";
                    SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn);
                    cmdCheck.Parameters.AddWithValue("@user", currentUser);
                    cmdCheck.Parameters.AddWithValue("@pass", txtOldPass.Text);

                    int count = (int)cmdCheck.ExecuteScalar();

                    if (count > 0)
                    {
                        // 2. Cập nhật mật khẩu mới
                        string sqlUpdate = "UPDATE TaiKhoan SET MatKhau = @newPass WHERE TenDangNhap = @user";
                        SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn);
                        cmdUpdate.Parameters.AddWithValue("@newPass", txtNewPass.Text);
                        cmdUpdate.Parameters.AddWithValue("@user", currentUser);

                        cmdUpdate.ExecuteNonQuery();
                        MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear text box
                        txtOldPass.Clear(); txtNewPass.Clear(); txtReNewPass.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "SQL Server Backup|*.bak";
            sfd.FileName = "Backup_SaleDB_" + DateTime.Now.ToString("ddMMyyyy_HHmm");

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        // Lệnh Backup Database
                        string sql = $"BACKUP DATABASE [sale] TO DISK = '{sfd.FileName}'";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Sao lưu dữ liệu thành công!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblBackupStatus.Text = "Lần sao lưu cuối: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        lblBackupStatus.ForeColor = System.Drawing.Color.Green;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi Backup (Có thể do quyền truy cập folder): " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}