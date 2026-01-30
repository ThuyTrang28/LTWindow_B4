using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions; // Thư viện Regex
using System.Windows.Forms;

namespace Article01
{
    public partial class RecruitForm : Form
    {
        string connStr = @"Data Source=LAPTOP-6EIPC5N4\SQLNEW;Initial Catalog=sale;Integrated Security=True;TrustServerCertificate=True";

        // Biến lưu Mã UV gốc để xử lý khi sửa đổi khóa chính
        string originalMaUV = "";

        public RecruitForm()
        {
            InitializeComponent();
        }

        private void RecruitForm_Load(object sender, EventArgs e)
        {
            LoadData();
            cbTrangThai.SelectedIndex = 0;
        }

        // --- 1. HÀM KIỂM TRA RÀNG BUỘC (VALIDATION) ---
        private bool ValidateInput()
        {
            // Kiểm tra các trường bắt buộc (Bao gồm cả ID và Email)
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtViTri.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin (ID, Tên, SĐT, Email, Vị trí)!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra Họ Tên: Không chứa số
            if (Regex.IsMatch(txtHoTen.Text, @"\d"))
            {
                MessageBox.Show("Họ tên không được chứa số!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }

            // Kiểm tra SĐT: Phải là số
            if (!Regex.IsMatch(txtSDT.Text, @"^\d+$") || txtSDT.Text.Length < 9 || txtSDT.Text.Length > 11)
            {
                MessageBox.Show("Số điện thoại phải là số (9-11 ký tự)!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }

            // Kiểm tra định dạng Email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                MessageBox.Show("Email không đúng định dạng! (Ví dụ: ungvien@gmail.com)", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM UngVien", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUngVien.DataSource = dt;

                    // Cấu hình bảng
                    dgvUngVien.Columns["MaUV"].HeaderText = "Mã UV";
                    dgvUngVien.Columns["MaUV"].Width = 80;
                    dgvUngVien.Columns["HoTen"].HeaderText = "Họ Tên";
                    dgvUngVien.Columns["ViTriUngTuyen"].HeaderText = "Vị Trí";
                    dgvUngVien.Columns["SDT"].HeaderText = "SĐT";
                    dgvUngVien.Columns["Email"].HeaderText = "Email";
                    dgvUngVien.Columns["NgayNopHoSo"].HeaderText = "Ngày Nộp";
                    dgvUngVien.Columns["NgayPhongVan"].HeaderText = "Ngày PV";
                    dgvUngVien.Columns["TrangThai"].HeaderText = "Trạng Thái";

                    if (dgvUngVien.Columns.Contains("GhiChu"))
                        dgvUngVien.Columns["GhiChu"].Visible = false;
                }
                catch (Exception ex) { MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message); }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // 1. Kiểm tra trùng ID trước khi thêm
                    SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM UngVien WHERE MaUV = @id", conn);
                    cmdCheck.Parameters.AddWithValue("@id", txtID.Text.Trim());
                    int count = (int)cmdCheck.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show($"Mã ứng viên '{txtID.Text}' đã tồn tại! Vui lòng nhập mã khác.", "Trùng ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtID.Focus();
                        return;
                    }

                    // 2. Thêm mới
                    string sql = @"INSERT INTO UngVien (MaUV, HoTen, ViTriUngTuyen, SDT, Email, NgayNopHoSo, NgayPhongVan, TrangThai)
                                   VALUES (@id, @ten, @vitri, @sdt, @email, @nop, @pv, @tt)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", txtID.Text.Trim());
                    cmd.Parameters.AddWithValue("@ten", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@vitri", txtViTri.Text);
                    cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@nop", DateTime.Now);
                    cmd.Parameters.AddWithValue("@pv", dtpNgayPV.Value);
                    cmd.Parameters.AddWithValue("@tt", cbTrangThai.Text);

                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Thêm ứng viên thành công!", "Thông báo");
                    btnReset_Click(sender, e);
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(originalMaUV))
            {
                MessageBox.Show("Vui lòng chọn ứng viên từ danh sách để sửa!", "Chưa chọn");
                return;
            }

            if (!ValidateInput()) return;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // 1. Nếu người dùng đổi ID, kiểm tra ID mới có trùng không
                    if (txtID.Text.Trim() != originalMaUV)
                    {
                        SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM UngVien WHERE MaUV = @newID", conn);
                        cmdCheck.Parameters.AddWithValue("@newID", txtID.Text.Trim());
                        int count = (int)cmdCheck.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show($"Mã ứng viên mới '{txtID.Text}' đã bị trùng! Vui lòng chọn mã khác.", "Trùng ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // 2. Cập nhật (Update theo Mã Cũ)
                    string sql = @"UPDATE UngVien SET 
                                    MaUV=@newId, 
                                    HoTen=@ten, ViTriUngTuyen=@vitri, SDT=@sdt, Email=@email, NgayPhongVan=@pv, TrangThai=@tt 
                                   WHERE MaUV=@oldId";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@newId", txtID.Text.Trim());
                    cmd.Parameters.AddWithValue("@oldId", originalMaUV); // Điều kiện tìm dòng cũ
                    cmd.Parameters.AddWithValue("@ten", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@vitri", txtViTri.Text);
                    cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@pv", dtpNgayPV.Value);
                    cmd.Parameters.AddWithValue("@tt", cbTrangThai.Text);

                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");

                    // Cập nhật lại mã gốc
                    originalMaUV = txtID.Text.Trim();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(originalMaUV))
            {
                MessageBox.Show("Vui lòng chọn ứng viên cần xóa!", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn chắc chắn muốn xóa hồ sơ này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM UngVien WHERE MaUV=@id", conn);
                    cmd.Parameters.AddWithValue("@id", originalMaUV);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    btnReset_Click(sender, e);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            originalMaUV = ""; // Reset biến nhớ
            txtID.Clear(); txtID.Enabled = true; // Cho phép nhập lại ID
            txtHoTen.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtViTri.Clear();
            cbTrangThai.SelectedIndex = 0;
            dtpNgayPV.Value = DateTime.Now;
            dgvUngVien.ClearSelection();
        }

        private void dgvUngVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUngVien.Rows[e.RowIndex];

                // Lưu mã cũ vào biến
                originalMaUV = row.Cells["MaUV"].Value.ToString();

                // Hiển thị lên giao diện
                txtID.Text = originalMaUV;
                txtID.Enabled = true; // Vẫn cho phép sửa ID nếu muốn

                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtViTri.Text = row.Cells["ViTriUngTuyen"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                cbTrangThai.Text = row.Cells["TrangThai"].Value.ToString();

                if (row.Cells["NgayPhongVan"].Value != DBNull.Value)
                    dtpNgayPV.Value = Convert.ToDateTime(row.Cells["NgayPhongVan"].Value);
            }
        }
    }
}