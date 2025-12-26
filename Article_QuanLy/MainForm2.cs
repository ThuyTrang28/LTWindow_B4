using System;
using System.Linq;
using System.Windows.Forms;

namespace Article_QuanLy
{
    public partial class MainForm2 : Form
    {
        public MainForm2()
        {
            InitializeComponent();
        }

        private void MainForm2_Load(object sender, EventArgs e)
        {
            // 1. Đổ dữ liệu nhân viên vào ComboBox
            cboNhanVien.DataSource = DataGlobal.DanhSachNV;
            cboNhanVien.DisplayMember = "TenNV";
            cboNhanVien.ValueMember = "MaNV";

            // 2. Đăng ký sự kiện: Khi chọn nhân viên -> Tự động nhảy giới tính
            cboNhanVien.SelectedIndexChanged += CboNhanVien_SelectedIndexChanged;

            // 3. Đổ dữ liệu chấm công vào Grid
            dgvChamCong.DataSource = DataGlobal.DanhSachChamCong;

            // 4. Trang trí Grid
            FormatGrid();

            // 5. Chọn mặc định trạng thái đầu tiên
            if (cboTrangThai.Items.Count > 0)
                cboTrangThai.SelectedIndex = 0;

            // 6. Kích hoạt sự kiện lần đầu để hiển thị giới tính người đầu tiên (nếu có)
            if (cboNhanVien.Items.Count > 0)
                CboNhanVien_SelectedIndexChanged(null, null);
        }

        // Sự kiện: Tự động check Nam/Nữ dựa trên thông tin nhân viên đang chọn
        private void CboNhanVien_SelectedIndexChanged(object? sender, EventArgs? e)
        {
            if (cboNhanVien.SelectedValue == null) return;

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string maNV = cboNhanVien.SelectedValue.ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            // Tìm nhân viên trong danh sách gốc để lấy giới tính
            var nv = DataGlobal.DanhSachNV.FirstOrDefault(x => x.MaNV == maNV);

            if (nv != null)
            {
                if (nv.GioiTinh == "Nam") radNam.Checked = true;
                else radNu.Checked = true;
            }
        }

        // Hàm trang trí giao diện bảng
        private void FormatGrid()
        {
            if (dgvChamCong.Columns.Count > 0)
            {
                if (dgvChamCong.Columns["NgayCham"] != null)
                    dgvChamCong.Columns["NgayCham"].DefaultCellStyle.Format = "dd/MM/yyyy";

                dgvChamCong.Columns["MaNV"].HeaderText = "Mã NV";
                dgvChamCong.Columns["TenNV"].HeaderText = "Họ Tên";

                if (dgvChamCong.Columns["GioiTinh"] != null)
                    dgvChamCong.Columns["GioiTinh"].HeaderText = "Giới Tính";

                dgvChamCong.Columns["NgayCham"].HeaderText = "Ngày Chấm";
                dgvChamCong.Columns["TrangThai"].HeaderText = "Trạng Thái";
                dgvChamCong.Columns["GhiChu"].HeaderText = "Ghi Chú";

                dgvChamCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            string maNV = cboNhanVien.SelectedValue.ToString() ?? "";
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            string tenNV = cboNhanVien.Text;
            string gioitinh = radNam.Checked ? "Nam" : "Nữ";
            DateTime ngay = dtpNgay.Value.Date;
            string trangThai = cboTrangThai.Text;
            string ghiChu = txtGhiChu.Text;

            // Kiểm tra trùng lặp
            bool daCham = DataGlobal.DanhSachChamCong.Any(x => x.MaNV == maNV && x.NgayCham.Date == ngay);
            if (daCham)
            {
                MessageBox.Show($"Nhân viên {tenNV} đã chấm công ngày {ngay:dd/MM/yyyy} rồi!",
                                "Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChamCong cc = new ChamCong(maNV, tenNV, gioitinh, ngay, trangThai, ghiChu);
            DataGlobal.DanhSachChamCong.Add(cc);

            MessageBox.Show("Chấm công thành công!", "Thông báo");
            txtGhiChu.Clear();
            txtGhiChu.Focus();
        }

        // --- SỰ KIỆN CLICK VÀO BẢNG ĐỂ LẤY DỮ LIỆU ---
        private void dgvChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ChamCong item = (ChamCong)dgvChamCong.Rows[e.RowIndex].DataBoundItem;

                cboNhanVien.SelectedValue = item.MaNV;
                dtpNgay.Value = item.NgayCham;
                cboTrangThai.Text = item.TrangThai;
                txtGhiChu.Text = item.GhiChu;

                if (item.GioiTinh == "Nam") radNam.Checked = true;
                else radNu.Checked = true;
            }
        }

        // --- SỰ KIỆN NÚT SỬA ---
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvChamCong.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!", "Thông báo");
                return;
            }

            // Lấy đối tượng gốc đang được chọn
            ChamCong item = (ChamCong)dgvChamCong.CurrentRow.DataBoundItem;

            // Cập nhật thông tin mới từ các ô nhập liệu
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8601 // Possible null reference assignment.
            item.MaNV = cboNhanVien.SelectedValue.ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            item.TenNV = cboNhanVien.Text;
            item.GioiTinh = radNam.Checked ? "Nam" : "Nữ";
            item.NgayCham = dtpNgay.Value.Date;
            item.TrangThai = cboTrangThai.Text;
            item.GhiChu = txtGhiChu.Text;

            // Làm mới bảng để hiển thị dữ liệu mới
            dgvChamCong.Refresh();
            MessageBox.Show("Cập nhật thành công!", "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvChamCong.CurrentRow != null)
            {
                if (MessageBox.Show("Bạn muốn xóa dòng chấm công này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ChamCong item = (ChamCong)dgvChamCong.CurrentRow.DataBoundItem;
                    DataGlobal.DanhSachChamCong.Remove(item);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}