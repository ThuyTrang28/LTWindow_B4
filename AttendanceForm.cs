using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Article01
{
    public partial class AttendanceForm : Form
    {
        string connStr = @"Data Source=LAPTOP-6EIPC5N4\SQLNEW;Initial Catalog=sale;Integrated Security=True;TrustServerCertificate=True";

        public AttendanceForm()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadData(dtpNgayChamCong.Value);
        }

        private void LoadData(DateTime ngay)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // 1. Kiểm tra xem ngày này đã chấm công chưa?
                    string sqlCheck = "SELECT COUNT(*) FROM ChamCong WHERE Ngay = @ngay";
                    SqlCommand cmdCheck = new SqlCommand(sqlCheck, conn);
                    cmdCheck.Parameters.AddWithValue("@ngay", ngay.Date);
                    int count = (int)cmdCheck.ExecuteScalar();

                    DataTable dt = new DataTable();

                    if (count > 0)
                    {
                        // TH1: Đã chấm công -> Load dữ liệu từ bảng ChamCong + NhanVien
                        string sqlLoad = @"SELECT c.MaNV, n.HoTen, n.ChucVu, c.TrangThai, c.GhiChu 
                                           FROM ChamCong c 
                                           JOIN NhanVien n ON c.MaNV = n.MaNV 
                                           WHERE c.Ngay = @ngay";
                        SqlDataAdapter da = new SqlDataAdapter(sqlLoad, conn);
                        da.SelectCommand.Parameters.AddWithValue("@ngay", ngay.Date);
                        da.Fill(dt);
                    }
                    else
                    {
                        // TH2: Chưa chấm công -> Load danh sách nhân viên và tạo dòng mới
                        string sqlNew = "SELECT MaNV, HoTen, ChucVu, N'Có mặt' AS TrangThai, '' AS GhiChu FROM NhanVien";
                        SqlDataAdapter da = new SqlDataAdapter(sqlNew, conn);
                        da.Fill(dt);
                    }

                    dgvChamCong.DataSource = dt;
                    ConfigGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void ConfigGrid()
        {
            // Xóa cột Combobox cũ nếu có để tránh duplicate
            if (dgvChamCong.Columns.Contains("colTrangThai")) dgvChamCong.Columns.Remove("colTrangThai");

            dgvChamCong.Columns["MaNV"].HeaderText = "Mã NV";
            dgvChamCong.Columns["MaNV"].ReadOnly = true;

            dgvChamCong.Columns["HoTen"].HeaderText = "Họ Tên";
            dgvChamCong.Columns["HoTen"].ReadOnly = true;
            dgvChamCong.Columns["HoTen"].Width = 200;

            dgvChamCong.Columns["ChucVu"].HeaderText = "Chức Vụ";
            dgvChamCong.Columns["ChucVu"].ReadOnly = true;

            // Ẩn cột TrangThai dạng text cũ đi, thay bằng Combobox cho chuyên nghiệp
            if (dgvChamCong.Columns.Contains("TrangThai")) dgvChamCong.Columns["TrangThai"].Visible = false;

            // Tạo cột Combobox Trạng Thái
            DataGridViewComboBoxColumn cmbCol = new DataGridViewComboBoxColumn();
            cmbCol.HeaderText = "Trạng Thái";
            cmbCol.Name = "colTrangThai";
            cmbCol.Items.AddRange("Có mặt", "Vắng", "Đi muộn", "Nghỉ phép");
            cmbCol.DataPropertyName = "TrangThai"; // Bind dữ liệu vào cột này
            dgvChamCong.Columns.Insert(3, cmbCol); // Chèn vào vị trí số 3

            dgvChamCong.Columns["GhiChu"].HeaderText = "Ghi Chú";
            dgvChamCong.Columns["GhiChu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    DateTime ngay = dtpNgayChamCong.Value.Date;

                    // Xóa dữ liệu cũ của ngày đó (nếu có) để lưu lại cái mới (Cách đơn giản nhất)
                    string sqlDel = "DELETE FROM ChamCong WHERE Ngay = @ngay";
                    SqlCommand cmdDel = new SqlCommand(sqlDel, conn);
                    cmdDel.Parameters.AddWithValue("@ngay", ngay);
                    cmdDel.ExecuteNonQuery();

                    // Duyệt từng dòng trên lưới và Insert lại
                    foreach (DataGridViewRow row in dgvChamCong.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string maNV = row.Cells["MaNV"].Value.ToString();
                        // Lấy giá trị từ cột Combobox (colTrangThai) hoặc cột dữ liệu (TrangThai)
                        string trangThai = row.Cells["colTrangThai"].Value?.ToString() ?? "Có mặt";
                        string ghiChu = row.Cells["GhiChu"].Value?.ToString() ?? "";

                        string sqlInsert = @"INSERT INTO ChamCong (MaNV, Ngay, TrangThai, GhiChu) 
                                             VALUES (@manv, @ngay, @tt, @gc)";
                        SqlCommand cmd = new SqlCommand(sqlInsert, conn);
                        cmd.Parameters.AddWithValue("@manv", maNV);
                        cmd.Parameters.AddWithValue("@ngay", ngay);
                        cmd.Parameters.AddWithValue("@tt", trangThai);
                        cmd.Parameters.AddWithValue("@gc", ghiChu);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Lưu dữ liệu chấm công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu: " + ex.Message);
                }
            }
        }
    }
}