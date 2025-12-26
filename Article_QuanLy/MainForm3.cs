using System;
using System.Linq;
using System.Windows.Forms;

namespace Article_QuanLy
{
    public partial class MainForm3 : Form
    {
        public MainForm3()
        {
            InitializeComponent();
        }

        private void MainForm3_Load(object sender, EventArgs e)
        {
            // 1. Đổ danh sách nhân viên vào ComboBox
            cboNhanVien.DataSource = DataGlobal.DanhSachNV;
            cboNhanVien.DisplayMember = "TenNV";
            cboNhanVien.ValueMember = "MaNV";

            // 2. Đổ danh sách lương vào Grid
            dgvLuong.DataSource = DataGlobal.DanhSachLuong;

            // 3. Trang trí bảng cho đẹp
            FormatGrid();
        }

        private void FormatGrid()
        {
            if (dgvLuong.Columns.Count > 0)
            {
                dgvLuong.Columns["MaNV"].HeaderText = "Mã NV";
                dgvLuong.Columns["TenNV"].HeaderText = "Họ Tên";
                dgvLuong.Columns["LuongCoBan"].HeaderText = "Lương CB";
                dgvLuong.Columns["PhuCap"].HeaderText = "Phụ Cấp";
                dgvLuong.Columns["Thuong"].HeaderText = "Thưởng";
                dgvLuong.Columns["KhauTru"].HeaderText = "Khấu Trừ";
                dgvLuong.Columns["TongLuong"].HeaderText = "TỔNG NHẬN";

                string formatTien = "#,##0";
                dgvLuong.Columns["LuongCoBan"].DefaultCellStyle.Format = formatTien;
                dgvLuong.Columns["PhuCap"].DefaultCellStyle.Format = formatTien;
                dgvLuong.Columns["Thuong"].DefaultCellStyle.Format = formatTien;
                dgvLuong.Columns["KhauTru"].DefaultCellStyle.Format = formatTien;
                dgvLuong.Columns["TongLuong"].DefaultCellStyle.Format = formatTien;
                dgvLuong.Columns["TongLuong"].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
                dgvLuong.Columns["TongLuong"].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;

                dgvLuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần tính lương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            string maNV = cboNhanVien.SelectedValue.ToString() ?? "";
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            string tenNV = cboNhanVien.Text;

            decimal luongCB = 0, phuCap = 0, thuong = 0, khauTru = 0;
            decimal.TryParse(txtLuongCB.Text, out luongCB);
            decimal.TryParse(txtPhuCap.Text, out phuCap);
            decimal.TryParse(txtThuong.Text, out thuong);
            decimal.TryParse(txtKhauTru.Text, out khauTru);

            var luongCu = DataGlobal.DanhSachLuong.FirstOrDefault(x => x.MaNV == maNV);
            if (luongCu != null)
            {
                if (MessageBox.Show($"Nhân viên {tenNV} đã có trong bảng lương. Bạn có muốn cập nhật lại không?",
                                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGlobal.DanhSachLuong.Remove(luongCu);
                }
                else
                {
                    return;
                }
            }

            Luong lg = new Luong(maNV, tenNV, luongCB, phuCap, thuong, khauTru);
            DataGlobal.DanhSachLuong.Add(lg);

            MessageBox.Show($"Đã tính lương thành công!\nTổng thực nhận: {lg.TongLuong:N0} VNĐ", "Thành công");
            ResetInput();
        }

        // --- SỰ KIỆN CLICK VÀO BẢNG ĐỂ LẤY DỮ LIỆU ---
        private void dgvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Luong item = (Luong)dgvLuong.Rows[e.RowIndex].DataBoundItem;

                cboNhanVien.SelectedValue = item.MaNV;
                txtLuongCB.Text = item.LuongCoBan.ToString();
                txtPhuCap.Text = item.PhuCap.ToString();
                txtThuong.Text = item.Thuong.ToString();
                txtKhauTru.Text = item.KhauTru.ToString();
            }
        }

        // --- SỰ KIỆN NÚT SỬA ---
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLuong.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!", "Thông báo");
                return;
            }

            Luong item = (Luong)dgvLuong.CurrentRow.DataBoundItem;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8601 // Possible null reference assignment.
            item.MaNV = cboNhanVien.SelectedValue.ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            item.TenNV = cboNhanVien.Text;

            decimal.TryParse(txtLuongCB.Text, out decimal luongCB);
            decimal.TryParse(txtPhuCap.Text, out decimal phuCap);
            decimal.TryParse(txtThuong.Text, out decimal thuong);
            decimal.TryParse(txtKhauTru.Text, out decimal khauTru);

            item.LuongCoBan = luongCB;
            item.PhuCap = phuCap;
            item.Thuong = thuong;
            item.KhauTru = khauTru;

            dgvLuong.Refresh();
            MessageBox.Show("Cập nhật lương thành công!", "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLuong.CurrentRow != null)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa phiếu lương này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Luong item = (Luong)dgvLuong.CurrentRow.DataBoundItem;
                    DataGlobal.DanhSachLuong.Remove(item);
                }
            }
        }

        private void ResetInput()
        {
            txtLuongCB.Text = "0";
            txtPhuCap.Text = "0";
            txtThuong.Text = "0";
            txtKhauTru.Text = "0";
            txtLuongCB.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}