using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Article01
{
    public partial class RewardForm : Form
    {
        string connStr = @"Data Source=LAPTOP-6EIPC5N4\SQLNEW;Initial Catalog=sale;Integrated Security=True;TrustServerCertificate=True";
        int selectedID = 0;

        public RewardForm()
        {
            InitializeComponent();
            // Đăng ký sự kiện Load để tránh lỗi quên hook
            this.Load += new System.EventHandler(this.RewardForm_Load);
        }

        private void RewardForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxNhanVien();
            LoadData();
            cbLoai.SelectedIndex = 0; // Mặc định là Khen thưởng
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
                    string sql = @"SELECT k.MaQD, n.HoTen, k.Loai, k.NgayQuyetDinh, k.SoTien, k.LyDo, k.MaNV 
                                   FROM KhenThuongKyLuat k 
                                   JOIN NhanVien n ON k.MaNV = n.MaNV";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvReward.DataSource = dt;

                    dgvReward.Columns["MaQD"].HeaderText = "Mã QĐ";
                    dgvReward.Columns["MaQD"].Width = 80;
                    dgvReward.Columns["HoTen"].HeaderText = "Nhân Viên";
                    dgvReward.Columns["Loai"].HeaderText = "Hình Thức";
                    dgvReward.Columns["NgayQuyetDinh"].HeaderText = "Ngày";
                    dgvReward.Columns["SoTien"].HeaderText = "Số Tiền";
                    dgvReward.Columns["SoTien"].DefaultCellStyle.Format = "N0";
                    dgvReward.Columns["LyDo"].HeaderText = "Lý Do";
                    dgvReward.Columns["LyDo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReward.Columns["MaNV"].Visible = false; // Ẩn Mã NV
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private bool ValidateInput()
        {
            if (cbNhanVien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSoTien.Text) || !Regex.IsMatch(txtSoTien.Text, @"^\d+$"))
            {
                MessageBox.Show("Số tiền phải là số hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTien.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLyDo.Text))
            {
                MessageBox.Show("Vui lòng nhập lý do!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLyDo.Focus();
                return false;
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
                    string sql = @"INSERT INTO KhenThuongKyLuat (MaNV, Loai, NgayQuyetDinh, SoTien, LyDo)
                                   VALUES (@manv, @loai, @ngay, @tien, @lydo)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@manv", cbNhanVien.SelectedValue);
                    cmd.Parameters.AddWithValue("@loai", cbLoai.Text);
                    cmd.Parameters.AddWithValue("@ngay", dtpNgay.Value);
                    cmd.Parameters.AddWithValue("@tien", decimal.Parse(txtSoTien.Text));
                    cmd.Parameters.AddWithValue("@lydo", txtLyDo.Text);

                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Thêm quyết định thành công!", "Thông báo");
                    btnReset_Click(sender, e);
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedID == 0) { MessageBox.Show("Chọn dòng cần sửa!"); return; }
            if (!ValidateInput()) return;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = @"UPDATE KhenThuongKyLuat SET MaNV=@manv, Loai=@loai, NgayQuyetDinh=@ngay, SoTien=@tien, LyDo=@lydo 
                                   WHERE MaQD=@id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", selectedID);
                    cmd.Parameters.AddWithValue("@manv", cbNhanVien.SelectedValue);
                    cmd.Parameters.AddWithValue("@loai", cbLoai.Text);
                    cmd.Parameters.AddWithValue("@ngay", dtpNgay.Value);
                    cmd.Parameters.AddWithValue("@tien", decimal.Parse(txtSoTien.Text));
                    cmd.Parameters.AddWithValue("@lydo", txtLyDo.Text);

                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Cập nhật thành công!");
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedID == 0) return;
            if (MessageBox.Show("Xóa quyết định này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM KhenThuongKyLuat WHERE MaQD=@id", conn);
                    cmd.Parameters.AddWithValue("@id", selectedID);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    btnReset_Click(sender, e);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            selectedID = 0;
            cbNhanVien.SelectedIndex = -1;
            cbLoai.SelectedIndex = 0;
            txtSoTien.Text = "0";
            txtLyDo.Clear();
            dtpNgay.Value = DateTime.Now;
            dgvReward.ClearSelection();
        }

        private void dgvReward_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvReward.Rows[e.RowIndex];

                    // Lấy ID (chắc chắn có)
                    selectedID = Convert.ToInt32(row.Cells["MaQD"].Value);

                    // Lấy các giá trị khác (Kiểm tra null trước khi gán)
                    cbNhanVien.SelectedValue = row.Cells["MaNV"].Value?.ToString();
                    cbLoai.Text = row.Cells["Loai"].Value?.ToString();

                    // Xử lý SỐ TIỀN: Nếu null thì gán bằng 0
                    if (row.Cells["SoTien"].Value == DBNull.Value || row.Cells["SoTien"].Value == null)
                        txtSoTien.Text = "0";
                    else
                        txtSoTien.Text = row.Cells["SoTien"].Value.ToString();

                    txtLyDo.Text = row.Cells["LyDo"].Value?.ToString();

                    // Xử lý NGÀY THÁNG: Kiểm tra null quan trọng nhất (Nguyên nhân chính gây lỗi hình 3)
                    if (row.Cells["NgayQuyetDinh"].Value != DBNull.Value && row.Cells["NgayQuyetDinh"].Value != null)
                    {
                        dtpNgay.Value = Convert.ToDateTime(row.Cells["NgayQuyetDinh"].Value);
                    }
                    else
                    {
                        dtpNgay.Value = DateTime.Now; // Nếu null thì lấy ngày hiện tại
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hiển thị: " + ex.Message);
                }
            }
        }
    }
}