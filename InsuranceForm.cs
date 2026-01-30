using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Article01
{
    public partial class InsuranceForm : Form
    {
        string connStr = @"Data Source=LAPTOP-6EIPC5N4\SQLNEW;Initial Catalog=sale;Integrated Security=True;TrustServerCertificate=True";
        string originalMaBH = ""; // Lưu mã gốc để sửa

        public InsuranceForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.InsuranceForm_Load);
        }

        private void InsuranceForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxNhanVien();
            LoadData();
            cbLoaiBH.SelectedIndex = 0;
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
                    string sql = @"SELECT b.MaBH, n.HoTen, b.LoaiBH, b.NgayCap, b.NoiCap, b.PhiBaoHiem, b.MaNV 
                                   FROM BaoHiem b 
                                   JOIN NhanVien n ON b.MaNV = n.MaNV";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvInsurance.DataSource = dt;

                    dgvInsurance.Columns["MaBH"].HeaderText = "Số Thẻ BH";
                    dgvInsurance.Columns["HoTen"].HeaderText = "Nhân Viên";
                    dgvInsurance.Columns["LoaiBH"].HeaderText = "Loại BH";
                    dgvInsurance.Columns["NgayCap"].HeaderText = "Ngày Cấp";
                    dgvInsurance.Columns["NoiCap"].HeaderText = "Nơi Cấp";
                    dgvInsurance.Columns["NoiCap"].Width = 200;
                    dgvInsurance.Columns["PhiBaoHiem"].HeaderText = "Phí Đóng";
                    dgvInsurance.Columns["PhiBaoHiem"].DefaultCellStyle.Format = "N0";
                    dgvInsurance.Columns["MaNV"].Visible = false;
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaBH.Text))
            {
                MessageBox.Show("Vui lòng nhập Số thẻ bảo hiểm!", "Thiếu thông tin"); return false;
            }
            if (cbNhanVien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thiếu thông tin"); return false;
            }
            if (!Regex.IsMatch(txtPhi.Text, @"^\d+$"))
            {
                MessageBox.Show("Phí bảo hiểm phải là số!", "Lỗi định dạng"); return false;
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
                    SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM BaoHiem WHERE MaBH=@id", conn);
                    cmdCheck.Parameters.AddWithValue("@id", txtMaBH.Text);
                    if ((int)cmdCheck.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Số thẻ bảo hiểm đã tồn tại!", "Trùng mã"); return;
                    }

                    string sql = @"INSERT INTO BaoHiem (MaBH, MaNV, LoaiBH, NgayCap, NoiCap, PhiBaoHiem)
                                   VALUES (@id, @manv, @loai, @ngay, @noi, @phi)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", txtMaBH.Text);
                    cmd.Parameters.AddWithValue("@manv", cbNhanVien.SelectedValue);
                    cmd.Parameters.AddWithValue("@loai", cbLoaiBH.Text);
                    cmd.Parameters.AddWithValue("@ngay", dtpNgayCap.Value);
                    cmd.Parameters.AddWithValue("@noi", txtNoiCap.Text);
                    cmd.Parameters.AddWithValue("@phi", decimal.Parse(txtPhi.Text));

                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Thêm bảo hiểm thành công!");
                    btnReset_Click(sender, e);
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(originalMaBH)) { MessageBox.Show("Chọn dòng cần sửa!"); return; }
            if (!ValidateInput()) return;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    // Nếu đổi mã, kiểm tra trùng
                    if (txtMaBH.Text != originalMaBH)
                    {
                        SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM BaoHiem WHERE MaBH=@id", conn);
                        cmdCheck.Parameters.AddWithValue("@id", txtMaBH.Text);
                        if ((int)cmdCheck.ExecuteScalar() > 0) { MessageBox.Show("Mã mới đã tồn tại!"); return; }
                    }

                    string sql = @"UPDATE BaoHiem SET MaBH=@newId, MaNV=@manv, LoaiBH=@loai, NgayCap=@ngay, NoiCap=@noi, PhiBaoHiem=@phi 
                                   WHERE MaBH=@oldId";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@newId", txtMaBH.Text);
                    cmd.Parameters.AddWithValue("@oldId", originalMaBH);
                    cmd.Parameters.AddWithValue("@manv", cbNhanVien.SelectedValue);
                    cmd.Parameters.AddWithValue("@loai", cbLoaiBH.Text);
                    cmd.Parameters.AddWithValue("@ngay", dtpNgayCap.Value);
                    cmd.Parameters.AddWithValue("@noi", txtNoiCap.Text);
                    cmd.Parameters.AddWithValue("@phi", decimal.Parse(txtPhi.Text));

                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Cập nhật thành công!");
                    originalMaBH = txtMaBH.Text;
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(originalMaBH)) return;
            if (MessageBox.Show("Xóa bảo hiểm này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM BaoHiem WHERE MaBH=@id", conn);
                    cmd.Parameters.AddWithValue("@id", originalMaBH);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    btnReset_Click(sender, e);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            originalMaBH = "";
            txtMaBH.Clear(); txtNoiCap.Clear(); txtPhi.Text = "0";
            cbNhanVien.SelectedIndex = -1;
            cbLoaiBH.SelectedIndex = 0;
            dtpNgayCap.Value = DateTime.Now;
            dgvInsurance.ClearSelection();
        }

        private void dgvInsurance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInsurance.Rows[e.RowIndex];
                originalMaBH = row.Cells["MaBH"].Value.ToString();
                txtMaBH.Text = originalMaBH;
                cbNhanVien.SelectedValue = row.Cells["MaNV"].Value.ToString();
                cbLoaiBH.Text = row.Cells["LoaiBH"].Value.ToString();
                if (row.Cells["NgayCap"].Value != DBNull.Value)
                    dtpNgayCap.Value = Convert.ToDateTime(row.Cells["NgayCap"].Value);
                txtNoiCap.Text = row.Cells["NoiCap"].Value.ToString();
                txtPhi.Text = row.Cells["PhiBaoHiem"].Value.ToString();
            }
        }
    }
}