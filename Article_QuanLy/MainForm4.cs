using System;
using System.Linq;
using System.Windows.Forms;

namespace Article_QuanLy
{
    public partial class MainForm4 : Form
    {
        public MainForm4()
        {
            InitializeComponent();
        }

        private void MainForm4_Load(object sender, EventArgs e)
        {
            // 1. Liên kết Grid với danh sách Ứng viên toàn cục
            dgvUngVien.DataSource = DataGlobal.DanhSachUngVien;

            // 2. Chọn mặc định trạng thái
            if (cboTrangThai.Items.Count > 0) cboTrangThai.SelectedIndex = 0;

            // 3. Trang trí bảng
            FormatGrid();
        }

        private void FormatGrid()
        {
            if (dgvUngVien.Columns.Count > 0)
            {
                // Format ngày nộp
                if (dgvUngVien.Columns["NgayNopHoSo"] != null)
                    dgvUngVien.Columns["NgayNopHoSo"].DefaultCellStyle.Format = "dd/MM/yyyy";

                // Đổi tên cột
                dgvUngVien.Columns["MaUV"].HeaderText = "Mã UV";
                dgvUngVien.Columns["TenUV"].HeaderText = "Họ Tên";
                dgvUngVien.Columns["ViTriUngTuyen"].HeaderText = "Vị Trí";
                dgvUngVien.Columns["KinhNghiem"].HeaderText = "Kinh Nghiệm";
                dgvUngVien.Columns["NgayNopHoSo"].HeaderText = "Ngày Nộp";
                dgvUngVien.Columns["TrangThai"].HeaderText = "Trạng Thái";

                dgvUngVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(txtMaUV.Text) || string.IsNullOrEmpty(txtTenUV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã và Tên ứng viên!", "Cảnh báo");
                return;
            }

            // Kiểm tra trùng Mã
            if (DataGlobal.DanhSachUngVien.Any(x => x.MaUV == txtMaUV.Text))
            {
                MessageBox.Show("Mã ứng viên này đã tồn tại!", "Lỗi trùng lặp");
                return;
            }

            // Tạo và thêm
            UngVien uv = new UngVien(
                txtMaUV.Text,
                txtTenUV.Text,
                txtViTri.Text,
                txtKinhNghiem.Text,
                dtpNgayNop.Value,
                cboTrangThai.Text
            );

            DataGlobal.DanhSachUngVien.Add(uv);

            MessageBox.Show("Thêm ứng viên thành công!");
            ResetInput();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvUngVien.CurrentRow == null) return;

            UngVien uv = (UngVien)dgvUngVien.CurrentRow.DataBoundItem;

            // Cập nhật thông tin
            uv.TenUV = txtTenUV.Text;
            uv.ViTriUngTuyen = txtViTri.Text;
            uv.KinhNghiem = txtKinhNghiem.Text;
            uv.NgayNopHoSo = dtpNgayNop.Value;
            uv.TrangThai = cboTrangThai.Text;

            dgvUngVien.Refresh(); // Làm mới hiển thị
            MessageBox.Show("Cập nhật thông tin thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvUngVien.CurrentRow != null)
            {
                if (MessageBox.Show("Xóa ứng viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGlobal.DanhSachUngVien.Remove((UngVien)dgvUngVien.CurrentRow.DataBoundItem);
                    ResetInput();
                }
            }
        }

        private void dgvUngVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUngVien.Rows[e.RowIndex];

                // Đổ dữ liệu lên các ô nhập
                txtMaUV.Text = row.Cells["MaUV"].Value.ToString();
                txtTenUV.Text = row.Cells["TenUV"].Value.ToString();
                txtViTri.Text = row.Cells["ViTriUngTuyen"].Value?.ToString();
                txtKinhNghiem.Text = row.Cells["KinhNghiem"].Value?.ToString();
                cboTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();

                if (row.Cells["NgayNopHoSo"].Value != null)
                    dtpNgayNop.Value = (DateTime)row.Cells["NgayNopHoSo"].Value;

                txtMaUV.Enabled = false; // Không cho sửa mã khi đang chọn
            }
        }

        private void ResetInput()
        {
            txtMaUV.Clear();
            txtTenUV.Clear();
            txtViTri.Clear();
            txtKinhNghiem.Clear();
            dtpNgayNop.Value = DateTime.Now;
            if (cboTrangThai.Items.Count > 0) cboTrangThai.SelectedIndex = 0;

            txtMaUV.Enabled = true; // Mở lại ô Mã
            txtMaUV.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e) => this.Close();
    }
}