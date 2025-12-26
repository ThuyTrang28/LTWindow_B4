using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Article_QuanLy
{
    public partial class MainForm : Form
    {
        private string currentImagePath = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 1. Cấu hình bảng trước khi đổ dữ liệu
            dgvNhanVien.AutoGenerateColumns = true; // Cho phép tự tạo cột từ Class
            dgvNhanVien.RowTemplate.Height = 80;    // Tăng chiều cao hàng để chứa ảnh
            dgvNhanVien.AllowUserToAddRows = false; // Không cho user tự thêm dòng trắng

            // 2. Liên kết dữ liệu
            dgvNhanVien.DataSource = DataGlobal.DanhSachNV;

            // 3. Xử lý giao diện cột
            if (dgvNhanVien.Columns.Count > 0)
            {
                // Format ngày sinh
                dgvNhanVien.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";

                // --- ẨN CỘT ĐƯỜNG DẪN GỐC (Text) ---
                if (dgvNhanVien.Columns.Contains("HinhAnh"))
                {
                    dgvNhanVien.Columns["HinhAnh"].Visible = false;
                }

                // --- THÊM CỘT ẢNH MỚI (Image) NẾU CHƯA CÓ ---
                if (!dgvNhanVien.Columns.Contains("colAnhHienThi"))
                {
                    DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                    imgCol.Name = "colAnhHienThi";
                    imgCol.HeaderText = "Ảnh Chân Dung";
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom; // Co giãn ảnh vừa ô
                    imgCol.Width = 100;

                    // Thêm cột ảnh vào vị trí đầu tiên (index 0)
                    dgvNhanVien.Columns.Insert(0, imgCol);
                }

                // Đặt tên tiếng Việt cho các cột khác
                dgvNhanVien.Columns["MaNV"].HeaderText = "Mã NV";
                dgvNhanVien.Columns["TenNV"].HeaderText = "Họ Tên";
                dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
                dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức Vụ";
                dgvNhanVien.Columns["DienThoai"].HeaderText = "Điện Thoại";

                dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            // 4. Đăng ký sự kiện để vẽ ảnh lên ô
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            dgvNhanVien.CellFormatting += DgvNhanVien_CellFormatting;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
        }

        // --- SỰ KIỆN QUAN TRỌNG: BIẾN ĐƯỜNG DẪN THÀNH ẢNH ---
        private void DgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Chỉ xử lý nếu đang ở cột "colAnhHienThi" và hàng hợp lệ
            if (dgvNhanVien.Columns[e.ColumnIndex].Name == "colAnhHienThi" && e.RowIndex >= 0)
            {
                // Lấy đối tượng Nhân viên tại dòng đó
                NhanVien? nv = dgvNhanVien.Rows[e.RowIndex].DataBoundItem as NhanVien;

                if (nv != null && !string.IsNullOrEmpty(nv.HinhAnh) && File.Exists(nv.HinhAnh))
                {
                    try
                    {
                        // Load ảnh từ file (Dùng FileStream để không bị khóa file, tránh lỗi khi xóa/sửa)
                        using (FileStream fs = new FileStream(nv.HinhAnh, FileMode.Open, FileAccess.Read))
                        {
                            // Tạo ảnh thumbnail nhỏ để hiển thị cho nhẹ bảng
                            // (Resize về chiều cao 80px để khớp với bảng)
                            using (Image original = Image.FromStream(fs))
                            {
                                // Clone ảnh để gán vào bảng (Tránh lỗi GDI+)
                                e.Value = new Bitmap(original);
                            }
                        }
                    }
                    catch
                    {
                        e.Value = null; // Lỗi thì để trống
                    }
                }
                else
                {
                    e.Value = null; // Không có ảnh hoặc đường dẫn sai
                }
            }
        }

        // --- CÁC NÚT CHỨC NĂNG ---

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã và Tên!", "Cảnh báo");
                return;
            }

            string gioitinh = radNam.Checked ? "Nam" : "Nữ";

            NhanVien nv = new NhanVien(
                txtMaNV.Text,
                txtTenNV.Text,
                gioitinh,
                dtpNgaySinh.Value,
                txtChucVu.Text,
                txtDienThoai.Text,
                currentImagePath
            );

            DataGlobal.DanhSachNV.Add(nv);

            MessageBox.Show("Thêm thành công!");
            ResetInput();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;

            NhanVien nv = (NhanVien)dgvNhanVien.CurrentRow.DataBoundItem;

            nv.TenNV = txtTenNV.Text;
            nv.ChucVu = txtChucVu.Text;
            nv.DienThoai = txtDienThoai.Text;
            nv.GioiTinh = radNam.Checked ? "Nam" : "Nữ";
            nv.NgaySinh = dtpNgaySinh.Value;

            if (!string.IsNullOrEmpty(currentImagePath))
            {
                nv.HinhAnh = currentImagePath;
            }

            dgvNhanVien.Refresh(); // Làm mới bảng để cập nhật ảnh
            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null &&
                MessageBox.Show("Xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                NhanVien nv = (NhanVien)dgvNhanVien.CurrentRow.DataBoundItem;
                DataGlobal.DanhSachNV.Remove(nv);

                ResetInput();
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                // Lấy đối tượng dữ liệu gốc (Code gọn hơn lấy từng cell)
                NhanVien nv = (NhanVien)row.DataBoundItem;

                txtMaNV.Text = nv.MaNV;
                txtTenNV.Text = nv.TenNV;
                txtChucVu.Text = nv.ChucVu;
                txtDienThoai.Text = nv.DienThoai;

                if (nv.GioiTinh == "Nam") radNam.Checked = true;
                else radNu.Checked = true;

                dtpNgaySinh.Value = nv.NgaySinh;

                // Load Ảnh lên PictureBox bên phải
                currentImagePath = nv.HinhAnh;
                if (!string.IsNullOrEmpty(currentImagePath) && File.Exists(currentImagePath))
                {
                    try
                    {
                        using (FileStream fs = new FileStream(currentImagePath, FileMode.Open, FileAccess.Read))
                        {
                            picAvatar.Image = Image.FromStream(fs);
                        }
                    }
                    catch
                    {
                        picAvatar.Image = null;
                    }
                }
                else
                {
                    picAvatar.Image = null;
                }

                txtMaNV.Enabled = false;
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.png;*.bmp;*.jpeg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                currentImagePath = open.FileName;
                picAvatar.Image = Image.FromFile(currentImagePath);
            }
        }

        private void ResetInput()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtChucVu.Clear();
            txtDienThoai.Clear();
            radNam.Checked = true;
            dtpNgaySinh.Value = DateTime.Now;
            picAvatar.Image = null;
            currentImagePath = "";
            txtMaNV.Enabled = true;
            txtMaNV.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e) => this.Close();

        private void pnlHeader_Paint(object sender, PaintEventArgs e) { }
    }
}