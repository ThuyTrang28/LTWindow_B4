using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Article_QuanLy
{
    public partial class MainForm : Form
    {
        BindingList<NhanVien> danhSachNV = new BindingList<NhanVien>();
        private string currentImagePath = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = danhSachNV;

            // Định dạng cột Ngày sinh cho dễ nhìn
            dgvNhanVien.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Ẩn cột đường dẫn ảnh nếu muốn
            dgvNhanVien.Columns["HinhAnh"].Visible = false;

            // Data mẫu
            danhSachNV.Add(new NhanVien("NV01", "Trần Văn A", "Nam", new DateTime(1995, 5, 20), "Giám đốc", "090123", ""));
            danhSachNV.Add(new NhanVien("NV02", "Nguyễn Thị B", "Nữ", new DateTime(2000, 10, 15), "Kế toán", "090456", ""));
        }

        // --- CÁC NÚT CHỨC NĂNG ---

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã và Tên!", "Cảnh báo");
                return;
            }

            // Lấy giới tính
            string gioitinh = radNam.Checked ? "Nam" : "Nữ";

            // Tạo nhân viên mới với đầy đủ thông tin
            NhanVien nv = new NhanVien(
                txtMaNV.Text,
                txtTenNV.Text,
                gioitinh,
                dtpNgaySinh.Value, // Lấy ngày từ DateTimePicker
                txtChucVu.Text,
                txtDienThoai.Text,
                currentImagePath
            );

            danhSachNV.Add(nv);
            ResetInput();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;

            NhanVien nv = (NhanVien)dgvNhanVien.CurrentRow.DataBoundItem;

            nv.TenNV = txtTenNV.Text;
            nv.ChucVu = txtChucVu.Text;
            nv.DienThoai = txtDienThoai.Text;

            // Cập nhật thông tin mới
            nv.GioiTinh = radNam.Checked ? "Nam" : "Nữ";
            nv.NgaySinh = dtpNgaySinh.Value;
            nv.HinhAnh = currentImagePath;

            dgvNhanVien.Refresh();
            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null &&
                MessageBox.Show("Xóa nhân viên này?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                danhSachNV.Remove((NhanVien)dgvNhanVien.CurrentRow.DataBoundItem);
                ResetInput();
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtTenNV.Text = row.Cells["TenNV"].Value.ToString();
                txtChucVu.Text = row.Cells["ChucVu"].Value?.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString();

                // Load Giới tính
                string? gt = row.Cells["GioiTinh"].Value?.ToString();
                if (gt == "Nam") radNam.Checked = true;
                else radNu.Checked = true;

                // Load Ngày sinh
                if (row.Cells["NgaySinh"].Value != null)
                {
                    dtpNgaySinh.Value = (DateTime)row.Cells["NgaySinh"].Value;
                }

                // Load Ảnh
                string? path = row.Cells["HinhAnh"].Value?.ToString();
#pragma warning disable CS8601 // Possible null reference assignment.
                currentImagePath = path;
#pragma warning restore CS8601 // Possible null reference assignment.
                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                    picAvatar.Image = Image.FromFile(path);
                else
                    picAvatar.Image = null;

                txtMaNV.Enabled = false;
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.png;*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                currentImagePath = open.FileName;
                picAvatar.Image = Image.FromFile(currentImagePath);
            }
        }

        private void ResetInput()
        {
            txtMaNV.Clear(); txtTenNV.Clear(); txtChucVu.Clear(); txtDienThoai.Clear();
            radNam.Checked = true;
            dtpNgaySinh.Value = DateTime.Now;
            picAvatar.Image = null;
            currentImagePath = "";
            txtMaNV.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e) => this.Close();
    }
}