using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Article01
{
    public partial class SalaryForm : Form
    {
        string connStr = @"Data Source=LAPTOP-6EIPC5N4\SQLNEW;Initial Catalog=sale;Integrated Security=True;TrustServerCertificate=True";
        string originalMaPhieu = "";

        public SalaryForm()
        {
            InitializeComponent();
        }

        private void SalaryForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxNhanVien();
            LoadData();
        }

        private void LoadComboBoxNhanVien()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT MaNV, HoTen, LuongCoBan FROM NhanVien", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbNhanVien.DataSource = dt;
                    cbNhanVien.DisplayMember = "HoTen";
                    cbNhanVien.ValueMember = "MaNV";
                    cbNhanVien.SelectedIndex = -1; // Chưa chọn ai
                }
                catch (Exception ex) { MessageBox.Show("Lỗi load nhân viên: " + ex.Message); }
            }
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    // Join 2 bảng để lấy tên nhân viên hiển thị cho đẹp
                    string sql = @"SELECT b.MaPhieu, n.HoTen, b.ThangNam, b.LuongCoBan, b.PhuCap, b.Thuong, b.KhauTru, b.ThucLanh, b.MaNV 
                                   FROM BangLuong b 
                                   JOIN NhanVien n ON b.MaNV = n.MaNV";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvBangLuong.DataSource = dt;

                    dgvBangLuong.Columns["MaPhieu"].HeaderText = "Mã Phiếu";
                    dgvBangLuong.Columns["HoTen"].HeaderText = "Nhân Viên";
                    dgvBangLuong.Columns["ThangNam"].HeaderText = "Tháng";
                    dgvBangLuong.Columns["LuongCoBan"].HeaderText = "Lương CB";
                    dgvBangLuong.Columns["PhuCap"].HeaderText = "Phụ Cấp";
                    dgvBangLuong.Columns["Thuong"].HeaderText = "Thưởng";
                    dgvBangLuong.Columns["KhauTru"].HeaderText = "Khấu Trừ";
                    dgvBangLuong.Columns["ThucLanh"].HeaderText = "Thực Lãnh";
                    dgvBangLuong.Columns["MaNV"].Visible = false;

                    // Format tiền tệ
                    string fmt = "N0";
                    dgvBangLuong.Columns["LuongCoBan"].DefaultCellStyle.Format = fmt;
                    dgvBangLuong.Columns["PhuCap"].DefaultCellStyle.Format = fmt;
                    dgvBangLuong.Columns["Thuong"].DefaultCellStyle.Format = fmt;
                    dgvBangLuong.Columns["KhauTru"].DefaultCellStyle.Format = fmt;
                    dgvBangLuong.Columns["ThucLanh"].DefaultCellStyle.Format = fmt;
                }
                catch (Exception ex) { MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message); }
            }
        }

        // Tự động điền lương cơ bản khi chọn nhân viên
        private void cbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNhanVien.SelectedIndex != -1)
            {
                DataRowView row = cbNhanVien.SelectedItem as DataRowView;
                if (row != null)
                {
                    txtLuongCoBan.Text = row["LuongCoBan"].ToString();
                    CalculateSalary(); // Tính lại ngay khi đổi nhân viên
                }
            }
        }

        private void CalculateSalary()
        {
            try
            {
                decimal luongCB = 0, phuCap = 0, thuong = 0, khauTru = 0;

                decimal.TryParse(txtLuongCoBan.Text, out luongCB);
                decimal.TryParse(txtPhuCap.Text, out phuCap);
                decimal.TryParse(txtThuong.Text, out thuong);
                decimal.TryParse(txtKhauTru.Text, out khauTru);

                decimal thucLanh = luongCB + phuCap + thuong - khauTru;
                txtThucLanh.Text = thucLanh.ToString("N0"); // Hiển thị format đẹp
            }
            catch { txtThucLanh.Text = "0"; }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateSalary();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text) || cbNhanVien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập Mã Phiếu và chọn Nhân Viên!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra số
            if (!Regex.IsMatch(txtPhuCap.Text, @"^\d+$") || !Regex.IsMatch(txtThuong.Text, @"^\d+$") || !Regex.IsMatch(txtKhauTru.Text, @"^\d+$"))
            {
                MessageBox.Show("Các trường tiền (Phụ cấp, Thưởng, Khấu trừ) phải là số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            CalculateSalary(); // Đảm bảo tính toán mới nhất

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = @"INSERT INTO BangLuong (MaPhieu, MaNV, ThangNam, LuongCoBan, PhuCap, Thuong, KhauTru, ThucLanh)
                                   VALUES (@id, @manv, @thang, @lcb, @pc, @thuong, @kt, @tl)";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", txtMaPhieu.Text);
                    cmd.Parameters.AddWithValue("@manv", cbNhanVien.SelectedValue);
                    cmd.Parameters.AddWithValue("@thang", dtpThang.Text); // Lấy chuỗi MM/yyyy
                    cmd.Parameters.AddWithValue("@lcb", decimal.Parse(txtLuongCoBan.Text));
                    cmd.Parameters.AddWithValue("@pc", decimal.Parse(txtPhuCap.Text));
                    cmd.Parameters.AddWithValue("@thuong", decimal.Parse(txtThuong.Text));
                    cmd.Parameters.AddWithValue("@kt", decimal.Parse(txtKhauTru.Text));
                    // Parse lại từ txtThucLanh (đang có dấu phẩy) nên cần style number
                    cmd.Parameters.AddWithValue("@tl", decimal.Parse(txtThucLanh.Text, System.Globalization.NumberStyles.Currency));

                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Lập phiếu lương thành công!");
                    btnReset_Click(sender, e);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) MessageBox.Show("Mã phiếu lương đã tồn tại!");
                    else MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(originalMaPhieu))
            {
                MessageBox.Show("Chọn phiếu lương cần sửa!"); return;
            }
            if (!ValidateInput()) return;
            CalculateSalary();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    // Cho phép sửa Mã Phiếu (giống logic form Employee)
                    if (txtMaPhieu.Text != originalMaPhieu)
                    {
                        SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM BangLuong WHERE MaPhieu = @newID", conn);
                        cmdCheck.Parameters.AddWithValue("@newID", txtMaPhieu.Text);
                        if ((int)cmdCheck.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Mã phiếu mới đã tồn tại!"); return;
                        }
                    }

                    string sql = @"UPDATE BangLuong SET MaPhieu=@newId, MaNV=@manv, ThangNam=@thang, 
                                   LuongCoBan=@lcb, PhuCap=@pc, Thuong=@thuong, KhauTru=@kt, ThucLanh=@tl 
                                   WHERE MaPhieu=@oldId";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@newId", txtMaPhieu.Text);
                    cmd.Parameters.AddWithValue("@oldId", originalMaPhieu);
                    cmd.Parameters.AddWithValue("@manv", cbNhanVien.SelectedValue);
                    cmd.Parameters.AddWithValue("@thang", dtpThang.Text);
                    cmd.Parameters.AddWithValue("@lcb", decimal.Parse(txtLuongCoBan.Text));
                    cmd.Parameters.AddWithValue("@pc", decimal.Parse(txtPhuCap.Text));
                    cmd.Parameters.AddWithValue("@thuong", decimal.Parse(txtThuong.Text));
                    cmd.Parameters.AddWithValue("@kt", decimal.Parse(txtKhauTru.Text));
                    cmd.Parameters.AddWithValue("@tl", decimal.Parse(txtThucLanh.Text, System.Globalization.NumberStyles.Currency));

                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Cập nhật thành công!");
                    originalMaPhieu = txtMaPhieu.Text;
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(originalMaPhieu)) return;
            if (MessageBox.Show("Xóa phiếu lương này?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM BangLuong WHERE MaPhieu=@id", conn);
                    cmd.Parameters.AddWithValue("@id", originalMaPhieu);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    btnReset_Click(sender, e);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            originalMaPhieu = "";
            txtMaPhieu.Clear(); cbNhanVien.SelectedIndex = -1;
            txtLuongCoBan.Text = "0"; txtPhuCap.Text = "0"; txtThuong.Text = "0"; txtKhauTru.Text = "0"; txtThucLanh.Text = "0";
            dtpThang.Value = DateTime.Now;
        }

        private void dgvBangLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBangLuong.Rows[e.RowIndex];
                originalMaPhieu = row.Cells["MaPhieu"].Value.ToString();
                txtMaPhieu.Text = originalMaPhieu;

                // Chọn lại Combobox đúng nhân viên
                cbNhanVien.SelectedValue = row.Cells["MaNV"].Value.ToString();

                // Parse ngày tháng (định dạng MM/yyyy -> cần thêm ngày 01 để convert sang Date)
                try { dtpThang.Value = DateTime.ParseExact("01/" + row.Cells["ThangNam"].Value.ToString(), "dd/MM/yyyy", null); } catch { }

                txtLuongCoBan.Text = row.Cells["LuongCoBan"].Value.ToString();
                txtPhuCap.Text = row.Cells["PhuCap"].Value.ToString();
                txtThuong.Text = row.Cells["Thuong"].Value.ToString();
                txtKhauTru.Text = row.Cells["KhauTru"].Value.ToString();

                CalculateSalary(); // Tính lại để hiện thị số đẹp
            }
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}