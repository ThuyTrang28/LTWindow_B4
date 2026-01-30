using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Article01
{
    public partial class ContractForm : Form
    {
        string connStr = @"Data Source=LAPTOP-6EIPC5N4\SQLNEW;Initial Catalog=sale;Integrated Security=True;TrustServerCertificate=True";
        string originalMaHD = ""; // Lưu mã gốc để sửa

        public ContractForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ContractForm_Load);
        }

        private void ContractForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxNhanVien();
            LoadData();
            cbLoaiHD.SelectedIndex = 0;
            cbTrangThai.SelectedIndex = 0;
        }

        private void LoadComboBoxNhanVien()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT MaNV, HoTen FROM NhanVien", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cbNhanVien.DataSource = dt;
                    cbNhanVien.DisplayMember = "HoTen";
                    cbNhanVien.ValueMember = "MaNV";
                }
                catch { }
            }
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT h.MaHD, n.HoTen, h.LoaiHD, h.NgayBatDau, h.NgayKetThuc, h.TrangThai, h.NoiDung, h.MaNV 
                                   FROM HopDongLaoDong h 
                                   JOIN NhanVien n ON h.MaNV = n.MaNV";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvContract.DataSource = dt;

                    dgvContract.Columns["MaHD"].HeaderText = "Mã HĐ";
                    dgvContract.Columns["HoTen"].HeaderText = "Nhân Viên";
                    dgvContract.Columns["LoaiHD"].HeaderText = "Loại HĐ";
                    dgvContract.Columns["NgayBatDau"].HeaderText = "Ngày Bắt Đầu";
                    dgvContract.Columns["NgayKetThuc"].HeaderText = "Ngày Kết Thúc";
                    dgvContract.Columns["TrangThai"].HeaderText = "Trạng Thái";
                    dgvContract.Columns["NoiDung"].HeaderText = "Nội Dung";
                    dgvContract.Columns["MaNV"].Visible = false;
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaHD.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Hợp Đồng!", "Thiếu thông tin"); return false;
            }
            if (cbNhanVien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thiếu thông tin"); return false;
            }
            if (dtpKetThuc.Value < dtpBatDau.Value)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu!", "Lỗi ngày tháng"); return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    // Kiểm tra trùng mã
                    SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM HopDongLaoDong WHERE MaHD=@id", conn);
                    cmdCheck.Parameters.AddWithValue("@id", txtMaHD.Text);
                    if ((int)cmdCheck.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Mã hợp đồng đã tồn tại!", "Trùng mã"); return;
                    }

                    string sql = @"INSERT INTO HopDongLaoDong (MaHD, MaNV, LoaiHD, NgayBatDau, NgayKetThuc, TrangThai, NoiDung)
                                   VALUES (@id, @manv, @loai, @bd, @kt, @tt, @nd)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", txtMaHD.Text);
                    cmd.Parameters.AddWithValue("@manv", cbNhanVien.SelectedValue);
                    cmd.Parameters.AddWithValue("@loai", cbLoaiHD.Text);
                    cmd.Parameters.AddWithValue("@bd", dtpBatDau.Value);
                    cmd.Parameters.AddWithValue("@kt", dtpKetThuc.Value);
                    cmd.Parameters.AddWithValue("@tt", cbTrangThai.Text);
                    cmd.Parameters.AddWithValue("@nd", txtNoiDung.Text);

                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Thêm hợp đồng thành công!");
                    btnReset_Click(sender, e);
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(originalMaHD)) { MessageBox.Show("Chọn hợp đồng cần sửa!"); return; }
            if (!ValidateInput()) return;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    // Nếu đổi mã, kiểm tra trùng
                    if (txtMaHD.Text != originalMaHD)
                    {
                        SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM HopDongLaoDong WHERE MaHD=@id", conn);
                        cmdCheck.Parameters.AddWithValue("@id", txtMaHD.Text);
                        if ((int)cmdCheck.ExecuteScalar() > 0) { MessageBox.Show("Mã mới đã tồn tại!"); return; }
                    }

                    string sql = @"UPDATE HopDongLaoDong SET MaHD=@newId, MaNV=@manv, LoaiHD=@loai, 
                                   NgayBatDau=@bd, NgayKetThuc=@kt, TrangThai=@tt, NoiDung=@nd 
                                   WHERE MaHD=@oldId";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@newId", txtMaHD.Text);
                    cmd.Parameters.AddWithValue("@oldId", originalMaHD);
                    cmd.Parameters.AddWithValue("@manv", cbNhanVien.SelectedValue);
                    cmd.Parameters.AddWithValue("@loai", cbLoaiHD.Text);
                    cmd.Parameters.AddWithValue("@bd", dtpBatDau.Value);
                    cmd.Parameters.AddWithValue("@kt", dtpKetThuc.Value);
                    cmd.Parameters.AddWithValue("@tt", cbTrangThai.Text);
                    cmd.Parameters.AddWithValue("@nd", txtNoiDung.Text);

                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Cập nhật thành công!");
                    originalMaHD = txtMaHD.Text;
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(originalMaHD)) return;
            if (MessageBox.Show("Xóa hợp đồng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM HopDongLaoDong WHERE MaHD=@id", conn);
                    cmd.Parameters.AddWithValue("@id", originalMaHD);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    btnReset_Click(sender, e);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            originalMaHD = "";
            txtMaHD.Clear(); txtNoiDung.Clear();
            cbNhanVien.SelectedIndex = -1;
            cbLoaiHD.SelectedIndex = 0;
            cbTrangThai.SelectedIndex = 0;
            dtpBatDau.Value = DateTime.Now;
            dtpKetThuc.Value = DateTime.Now.AddYears(1);
            dgvContract.ClearSelection();
        }

        private void dgvContract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvContract.Rows[e.RowIndex];
                originalMaHD = row.Cells["MaHD"].Value.ToString();
                txtMaHD.Text = originalMaHD;
                cbNhanVien.SelectedValue = row.Cells["MaNV"].Value.ToString();
                cbLoaiHD.Text = row.Cells["LoaiHD"].Value.ToString();
                cbTrangThai.Text = row.Cells["TrangThai"].Value.ToString();
                txtNoiDung.Text = row.Cells["NoiDung"].Value.ToString();
                dtpBatDau.Value = Convert.ToDateTime(row.Cells["NgayBatDau"].Value);
                if (row.Cells["NgayKetThuc"].Value != DBNull.Value)
                    dtpKetThuc.Value = Convert.ToDateTime(row.Cells["NgayKetThuc"].Value);
            }
        }
    }
}