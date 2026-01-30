using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Article01
{
    public partial class EmployeeForm : Form
    {
        // CẤU HÌNH KẾT NỐI
        string connStr = @"Data Source=LAPTOP-6EIPC5N4\SQLNEW;Initial Catalog=sale;Integrated Security=True;TrustServerCertificate=True";
        string currentAvatarPath = "";
        string originalMaNV = "";

        public EmployeeForm()
        {
            InitializeComponent();
            dgvNhanVien.CellFormatting += dgvNhanVien_CellFormatting;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            dgvNhanVien.RowTemplate.Height = 80;

            // 1. Tải dữ liệu lên bảng
            LoadData();

            // 2. Setup dữ liệu cho input (nếu Designer chưa có)
            if (cbChucVu.Items.Count == 0)
                cbChucVu.Items.AddRange(new object[] { "Nhân Viên", "Trưởng Nhóm", "Phó Phòng", "Trưởng Phòng", "Giám Đốc" });
            cbChucVu.SelectedIndex = 0;

            if (cbPhongBan.Items.Count == 0)
                cbPhongBan.Items.AddRange(new object[] { "Phòng Kinh Doanh", "Phòng Kế Toán", "Phòng Nhân Sự", "Phòng IT", "Phòng Marketing" });
            cbPhongBan.SelectedIndex = 0;

            // 3. Khởi tạo bộ lọc (Copy từ input sang filter)
            InitializeFilters();
        }

        // =================================================================================
        // PHẦN 1: LOGIC KIỂM TRA DỮ LIỆU (VALIDATION) - THEO YÊU CẦU CỦA BẠN
        // =================================================================================

        // 1. Hàm kiểm tra trùng ID trong Database
        private bool CheckDuplicateID(string maNV)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", maNV);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // Trả về true nếu mã đã tồn tại
                }
                catch { return false; }
            }
        }

        // 2. Hàm kiểm tra nhập liệu (Bắt buộc nhập + Định dạng)
        private bool ValidateInput()
        {
            // --- 1. KIỂM TRA BẮT BUỘC NHẬP (KHÔNG ĐƯỢC ĐỂ TRỐNG) ---
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã nhân viên!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ tên!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập Email!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập Địa chỉ!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập Lương cơ bản!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuong.Focus();
                return false;
            }

            // --- 2. KIỂM TRA ĐỊNH DẠNG (REGEX) ---

            // [MỚI] Kiểm tra Họ tên: Không chứa số VÀ Không chứa ký tự đặc biệt
            // Giải thích Regex: ^[\p{L}\s]+$ 
            // \p{L}: Chấp nhận mọi chữ cái (bao gồm tiếng Việt có dấu)
            // \s: Chấp nhận khoảng trắng
            // Nếu chuỗi chứa bất kỳ ký tự nào KHÔNG PHẢI chữ hoặc khoảng trắng -> Báo lỗi
            if (!Regex.IsMatch(txtHoTen.Text, @"^[\p{L}\s]+$"))
            {
                MessageBox.Show("Họ tên không hợp lệ!\n(Không được chứa số hoặc ký tự đặc biệt).", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }

            // [MỚI] Kiểm tra định dạng Email
            // Giải thích: Phải có dạng abc@xyz.com
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                MessageBox.Show("Email không đúng định dạng!\nVí dụ đúng: user@gmail.com", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            // Kiểm tra Lương (Chỉ được nhập số)
            if (!Regex.IsMatch(txtLuong.Text, @"^\d+$"))
            {
                MessageBox.Show("Lương cơ bản KHÔNG được chứa chữ cái hoặc ký tự đặc biệt!\nVui lòng chỉ nhập số dương.",
                                "Lỗi định dạng lương", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLuong.Focus();
                return false;
            }

            // Kiểm tra SĐT (Bắt đầu bằng 0, 10-11 số)
            if (!Regex.IsMatch(txtSDT.Text, @"^0\d{9,10}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ (Phải bắt đầu bằng 0 và có 10-11 số)!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }

            return true;
        }

        // =================================================================================
        // PHẦN 2: CÁC NÚT CHỨC NĂNG (THÊM, SỬA, XÓA, RESET, UPLOAD)
        // =================================================================================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            // -> Kiểm tra trùng mã trước khi Thêm
            if (CheckDuplicateID(txtMaNV.Text.Trim()))
            {
                MessageBox.Show($"Mã nhân viên '{txtMaNV.Text}' đã tồn tại!\nVui lòng nhập mã khác.", "Trùng Mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus();
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = @"INSERT INTO NhanVien (MaNV, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Email, ChucVu, PhongBan, NgayVaoLam, LuongCoBan, HinhAnh)
                                   VALUES (@id, @name, @dob, @gender, @addr, @phone, @email, @pos, @dept, @hired, @sal, @img)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SetupParameters(cmd); // Gọi hàm setup tham số cho gọn code
                    cmd.ExecuteNonQuery();
                    LoadData();

                    // Reset bộ lọc để thấy nhân viên mới
                    ResetFilters();
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                    btnReset_Click(sender, e);
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(originalMaNV)) { MessageBox.Show("Chọn nhân viên cần sửa!"); return; }
            if (!ValidateInput()) return;

            // -> Kiểm tra trùng mã nếu người dùng thay đổi Mã NV
            if (txtMaNV.Text.Trim() != originalMaNV)
            {
                if (CheckDuplicateID(txtMaNV.Text.Trim()))
                {
                    MessageBox.Show($"Mã mới '{txtMaNV.Text}' bị trùng với nhân viên khác!", "Trùng Mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaNV.Focus();
                    return;
                }
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = @"UPDATE NhanVien SET MaNV=@id, HoTen=@name, NgaySinh=@dob, GioiTinh=@gender, DiaChi=@addr, 
                                   SoDienThoai=@phone, Email=@email, ChucVu=@pos, PhongBan=@dept, NgayVaoLam=@hired, LuongCoBan=@sal, HinhAnh=@img 
                                   WHERE MaNV=@oldId";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SetupParameters(cmd);
                    cmd.Parameters.AddWithValue("@oldId", originalMaNV);

                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                    originalMaNV = txtMaNV.Text.Trim();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        // Hàm phụ để gán tham số cho Add và Edit đỡ phải viết lặp lại
        private void SetupParameters(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@id", txtMaNV.Text.Trim());
            cmd.Parameters.AddWithValue("@name", txtHoTen.Text.Trim());
            cmd.Parameters.AddWithValue("@dob", dtpNgaySinh.Value);
            cmd.Parameters.AddWithValue("@gender", radNam.Checked ? "Nam" : "Nữ");
            cmd.Parameters.AddWithValue("@addr", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("@phone", txtSDT.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@pos", cbChucVu.Text);
            cmd.Parameters.AddWithValue("@dept", cbPhongBan.Text);
            cmd.Parameters.AddWithValue("@hired", dtpNgayVaoLam.Value);
            cmd.Parameters.AddWithValue("@sal", decimal.Parse(txtLuong.Text)); // Đã validate là số ở trên
            cmd.Parameters.AddWithValue("@img", currentAvatarPath);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(originalMaNV)) return;
            if (MessageBox.Show("Xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM NhanVien WHERE MaNV=@id", conn);
                    cmd.Parameters.AddWithValue("@id", originalMaNV);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    btnReset_Click(sender, e);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            originalMaNV = "";
            txtMaNV.Clear(); txtMaNV.Enabled = true;
            txtHoTen.Clear(); txtDiaChi.Clear(); txtSDT.Clear(); txtEmail.Clear(); txtLuong.Clear();
            dtpNgaySinh.Value = DateTime.Now; picAvatar.Image = null; currentAvatarPath = "";

            ResetFilters(); // Reset cả ô tìm kiếm và lọc
            dgvNhanVien.ClearSelection();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image|*.jpg;*.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentAvatarPath = ofd.FileName;
                    picAvatar.Image = LoadImageSafe(currentAvatarPath);
                }
            }
        }

        // =================================================================================
        // PHẦN 3: LOGIC TÌM KIẾM VÀ LỌC DỮ LIỆU
        // =================================================================================

        private void InitializeFilters()
        {
            // Nạp dữ liệu vào ComboBox lọc
            cboFilterChucVu.Items.Clear(); cboFilterChucVu.Items.Add("Tất cả");
            foreach (var item in cbChucVu.Items) cboFilterChucVu.Items.Add(item);
            cboFilterChucVu.SelectedIndex = 0;

            cboFilterPhongBan.Items.Clear(); cboFilterPhongBan.Items.Add("Tất cả");
            foreach (var item in cbPhongBan.Items) cboFilterPhongBan.Items.Add(item);
            cboFilterPhongBan.SelectedIndex = 0;

            cboFilterGioiTinh.Items.Clear(); cboFilterGioiTinh.Items.AddRange(new object[] { "Tất cả", "Nam", "Nữ" });
            cboFilterGioiTinh.SelectedIndex = 0;
        }

        private void ResetFilters()
        {
            txtSearch.Clear();
            if (cboFilterChucVu.Items.Count > 0) cboFilterChucVu.SelectedIndex = 0;
            if (cboFilterPhongBan.Items.Count > 0) cboFilterPhongBan.SelectedIndex = 0;
            if (cboFilterGioiTinh.Items.Count > 0) cboFilterGioiTinh.SelectedIndex = 0;
        }

        private void ApplyFilters()
        {
            DataTable dt = dgvNhanVien.DataSource as DataTable;
            if (dt == null) return;

            List<string> filters = new List<string>();
            string keyword = txtSearch.Text.Trim().Replace("'", "''");

            // Tìm kiếm
            if (!string.IsNullOrEmpty(keyword))
                filters.Add($"(HoTen LIKE '%{keyword}%' OR MaNV LIKE '%{keyword}%')");

            // Lọc Chức vụ
            if (cboFilterChucVu.SelectedIndex > 0 && cboFilterChucVu.SelectedItem != null)
                filters.Add($"ChucVu = '{cboFilterChucVu.SelectedItem}'");

            // Lọc Phòng ban
            if (cboFilterPhongBan.SelectedIndex > 0 && cboFilterPhongBan.SelectedItem != null)
                filters.Add($"PhongBan = '{cboFilterPhongBan.SelectedItem}'");

            // Lọc Giới tính
            if (cboFilterGioiTinh.SelectedIndex > 0 && cboFilterGioiTinh.SelectedItem != null)
                filters.Add($"GioiTinh = '{cboFilterGioiTinh.SelectedItem}'");

            try
            {
                if (filters.Count > 0) dt.DefaultView.RowFilter = string.Join(" AND ", filters);
                else dt.DefaultView.RowFilter = "";
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        // Sự kiện Lọc (Được Designer gọi)
        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e) { ApplyFilters(); }
        private void txtSearch_TextChanged(object sender, EventArgs e) { ApplyFilters(); }

        // =================================================================================
        // PHẦN 4: HỖ TRỢ HIỂN THỊ VÀ XUẤT EXCEL
        // =================================================================================

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhanVien", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvNhanVien.DataSource = dt;

                    // Cấu hình cột
                    if (!dgvNhanVien.Columns.Contains("imgAvatar"))
                    {
                        DataGridViewImageColumn imgCol = new DataGridViewImageColumn() { Name = "imgAvatar", HeaderText = "Hình Ảnh", ImageLayout = DataGridViewImageCellLayout.Zoom, Width = 80 };
                        dgvNhanVien.Columns.Insert(0, imgCol);
                    }
                    if (dgvNhanVien.Columns.Contains("HinhAnh")) dgvNhanVien.Columns["HinhAnh"].Visible = false;

                    // Đặt tên Header tiếng Việt
                    dgvNhanVien.Columns["MaNV"].HeaderText = "Mã NV";
                    dgvNhanVien.Columns["HoTen"].HeaderText = "Họ Tên";
                    dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                    dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
                    dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức Vụ";
                    dgvNhanVien.Columns["PhongBan"].HeaderText = "Phòng Ban";
                    dgvNhanVien.Columns["LuongCoBan"].HeaderText = "Lương CB";
                    dgvNhanVien.Columns["LuongCoBan"].DefaultCellStyle.Format = "N0"; // Định dạng tiền tệ
                }
                catch (Exception ex) { MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message); }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.Rows.Count == 0) { MessageBox.Show("Không có dữ liệu!", "Thông báo"); return; }
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel CSV (*.csv)|*.csv", FileName = "DS_NhanVien_" + DateTime.Now.ToString("ddMMyyyy_HHmm") + ".csv" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < dgvNhanVien.Columns.Count; i++)
                        if (dgvNhanVien.Columns[i].Visible) sb.Append(dgvNhanVien.Columns[i].HeaderText + ",");
                    sb.AppendLine();
                    foreach (DataGridViewRow row in dgvNhanVien.Rows)
                    {
                        if (!row.IsNewRow && row.Visible)
                        {
                            for (int i = 0; i < dgvNhanVien.Columns.Count; i++)
                            {
                                if (dgvNhanVien.Columns[i].Visible)
                                {
                                    string val = row.Cells[i].Value?.ToString() ?? "";
                                    if (val.Contains(",")) val = "\"" + val + "\"";
                                    sb.Append(val + ",");
                                }
                            }
                            sb.AppendLine();
                        }
                    }
                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Xuất file thành công!\n" + sfd.FileName, "Thông báo");
                }
                catch (Exception ex) { MessageBox.Show("Lỗi xuất file: " + ex.Message); }
            }
        }

        private Image LoadImageSafe(string path)
        {
            try { if (File.Exists(path)) return Image.FromStream(new MemoryStream(File.ReadAllBytes(path))); } catch { }
            return null;
        }

        private void dgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvNhanVien.Columns[e.ColumnIndex].Name == "imgAvatar" && e.RowIndex >= 0)
            {
                var row = dgvNhanVien.Rows[e.RowIndex];
                if (row.Cells["HinhAnh"].Value != null) e.Value = LoadImageSafe(row.Cells["HinhAnh"].Value.ToString());
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                originalMaNV = row.Cells["MaNV"].Value.ToString();
                txtMaNV.Text = originalMaNV; txtMaNV.Enabled = true;
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                if (row.Cells["NgaySinh"].Value != DBNull.Value) dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                if (row.Cells["GioiTinh"].Value.ToString() == "Nam") radNam.Checked = true; else radNu.Checked = true;
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                cbChucVu.Text = row.Cells["ChucVu"].Value.ToString();
                cbPhongBan.Text = row.Cells["PhongBan"].Value.ToString();
                if (row.Cells["NgayVaoLam"].Value != DBNull.Value) dtpNgayVaoLam.Value = Convert.ToDateTime(row.Cells["NgayVaoLam"].Value);
                txtLuong.Text = row.Cells["LuongCoBan"].Value.ToString();
                currentAvatarPath = row.Cells["HinhAnh"].Value.ToString();
                picAvatar.Image = LoadImageSafe(currentAvatarPath);
            }
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e) { }

        private void txtLuong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}