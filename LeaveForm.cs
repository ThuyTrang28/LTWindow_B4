using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Article01
{
    public partial class LeaveForm : Form
    {
        string connStr = @"Data Source=LAPTOP-6EIPC5N4\SQLNEW;Initial Catalog=sale;Integrated Security=True;TrustServerCertificate=True";
        string originalMaDon = "";

        public LeaveForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.LeaveForm_Load);
        }

        private void LeaveForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxNhanVien();
            LoadData();
            cbLoaiNghi.SelectedIndex = 0;
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
                    string sql = @"SELECT np.MaDon, n.HoTen, np.LoaiNghi, np.TuNgay, np.DenNgay, np.LyDo, np.TrangThai, np.MaNV 
                                   FROM NghiPhep np 
                                   JOIN NhanVien n ON np.MaNV = n.MaNV";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvLeave.DataSource = dt;

                    dgvLeave.Columns["MaDon"].HeaderText = "Mã Đơn";
                    dgvLeave.Columns["HoTen"].HeaderText = "Nhân Viên";
                    dgvLeave.Columns["LoaiNghi"].HeaderText = "Loại Nghỉ";
                    dgvLeave.Columns["TuNgay"].HeaderText = "Từ Ngày";
                    dgvLeave.Columns["DenNgay"].HeaderText = "Đến Ngày";
                    dgvLeave.Columns["LyDo"].HeaderText = "Lý Do";
                    dgvLeave.Columns["TrangThai"].HeaderText = "Trạng Thái";
                    dgvLeave.Columns["MaNV"].Visible = false;
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaDon.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã đơn!", "Thiếu thông tin"); return false;
            }
            if (cbNhanVien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thiếu thông tin"); return false;
            }
            if (dtpDenNgay.Value < dtpTuNgay.Value)
            {
                MessageBox.Show("Ngày đến phải lớn hơn hoặc bằng ngày từ!", "Lỗi ngày tháng"); return false;
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
                    SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM NghiPhep WHERE MaDon=@id", conn);
                    cmdCheck.Parameters.AddWithValue("@id", txtMaDon.Text);
                    if ((int)cmdCheck.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Mã đơn đã tồn tại!", "Trùng mã"); return;
                    }

                    string sql = @"INSERT INTO NghiPhep (MaDon, MaNV, LoaiNghi, TuNgay, DenNgay, LyDo, TrangThai)
                                   VALUES (@id, @manv, @loai, @tu, @den, @lydo, @tt)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", txtMaDon.Text);
                    cmd.Parameters.AddWithValue("@manv", cbNhanVien.SelectedValue);
                    cmd.Parameters.AddWithValue("@loai", cbLoaiNghi.Text);
                    cmd.Parameters.AddWithValue("@tu", dtpTuNgay.Value);
                    cmd.Parameters.AddWithValue("@den", dtpDenNgay.Value);
                    cmd.Parameters.AddWithValue("@lydo", txtLyDo.Text);
                    cmd.Parameters.AddWithValue("@tt", cbTrangThai.Text);

                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Tạo đơn nghỉ phép thành công!");
                    btnReset_Click(sender, e);
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(originalMaDon)) { MessageBox.Show("Chọn đơn cần sửa!"); return; }
            if (!ValidateInput()) return;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    if (txtMaDon.Text != originalMaDon)
                    {
                        SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM NghiPhep WHERE MaDon=@id", conn);
                        cmdCheck.Parameters.AddWithValue("@id", txtMaDon.Text);
                        if ((int)cmdCheck.ExecuteScalar() > 0) { MessageBox.Show("Mã mới đã tồn tại!"); return; }
                    }

                    string sql = @"UPDATE NghiPhep SET MaDon=@newId, MaNV=@manv, LoaiNghi=@loai, TuNgay=@tu, DenNgay=@den, LyDo=@lydo, TrangThai=@tt 
                                   WHERE MaDon=@oldId";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@newId", txtMaDon.Text);
                    cmd.Parameters.AddWithValue("@oldId", originalMaDon);
                    cmd.Parameters.AddWithValue("@manv", cbNhanVien.SelectedValue);
                    cmd.Parameters.AddWithValue("@loai", cbLoaiNghi.Text);
                    cmd.Parameters.AddWithValue("@tu", dtpTuNgay.Value);
                    cmd.Parameters.AddWithValue("@den", dtpDenNgay.Value);
                    cmd.Parameters.AddWithValue("@lydo", txtLyDo.Text);
                    cmd.Parameters.AddWithValue("@tt", cbTrangThai.Text);

                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Cập nhật thành công!");
                    originalMaDon = txtMaDon.Text;
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(originalMaDon)) return;
            if (MessageBox.Show("Xóa đơn nghỉ phép này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM NghiPhep WHERE MaDon=@id", conn);
                    cmd.Parameters.AddWithValue("@id", originalMaDon);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    btnReset_Click(sender, e);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            originalMaDon = "";
            txtMaDon.Clear(); txtLyDo.Clear();
            cbNhanVien.SelectedIndex = -1;
            cbLoaiNghi.SelectedIndex = 0;
            cbTrangThai.SelectedIndex = 0;
            dtpTuNgay.Value = DateTime.Now;
            dtpDenNgay.Value = DateTime.Now;
            dgvLeave.ClearSelection();
        }

        private void dgvLeave_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLeave.Rows[e.RowIndex];
                originalMaDon = row.Cells["MaDon"].Value.ToString();
                txtMaDon.Text = originalMaDon;
                cbNhanVien.SelectedValue = row.Cells["MaNV"].Value.ToString();
                cbLoaiNghi.Text = row.Cells["LoaiNghi"].Value.ToString();
                dtpTuNgay.Value = Convert.ToDateTime(row.Cells["TuNgay"].Value);
                dtpDenNgay.Value = Convert.ToDateTime(row.Cells["DenNgay"].Value);
                txtLyDo.Text = row.Cells["LyDo"].Value.ToString();
                cbTrangThai.Text = row.Cells["TrangThai"].Value.ToString();
            }
        }
    }
}