namespace Article_QuanLy
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            dgvNhanVien = new DataGridView();
            pnlInput = new Panel();
            dtpNgaySinh = new DateTimePicker();
            lblNgaySinh = new Label();
            radNu = new RadioButton();
            radNam = new RadioButton();
            lblGioiTinh = new Label();
            picAvatar = new PictureBox();
            btnChonAnh = new Button();
            txtDienThoai = new TextBox();
            lblDienThoai = new Label();
            txtChucVu = new TextBox();
            lblChucVu = new Label();
            txtTenNV = new TextBox();
            lblTenNV = new Label();
            txtMaNV = new TextBox();
            lblMaNV = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            pnlButtons = new Panel();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(255, 148, 166);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(950, 60);
            pnlHeader.TabIndex = 0;
            pnlHeader.Paint += pnlHeader_Paint;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(291, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 230, 235);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhanVien.ColumnHeadersHeight = 30;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.Location = new Point(0, 340);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(950, 260);
            dgvNhanVien.TabIndex = 3;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // pnlInput
            // 
            pnlInput.BackColor = Color.White;
            pnlInput.Controls.Add(dtpNgaySinh);
            pnlInput.Controls.Add(lblNgaySinh);
            pnlInput.Controls.Add(radNu);
            pnlInput.Controls.Add(radNam);
            pnlInput.Controls.Add(lblGioiTinh);
            pnlInput.Controls.Add(picAvatar);
            pnlInput.Controls.Add(btnChonAnh);
            pnlInput.Controls.Add(txtDienThoai);
            pnlInput.Controls.Add(lblDienThoai);
            pnlInput.Controls.Add(txtChucVu);
            pnlInput.Controls.Add(lblChucVu);
            pnlInput.Controls.Add(txtTenNV);
            pnlInput.Controls.Add(lblTenNV);
            pnlInput.Controls.Add(txtMaNV);
            pnlInput.Controls.Add(lblMaNV);
            pnlInput.Dock = DockStyle.Top;
            pnlInput.Location = new Point(0, 60);
            pnlInput.Name = "pnlInput";
            pnlInput.Size = new Size(950, 220);
            pnlInput.TabIndex = 1;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(280, 175);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(200, 27);
            dtpNgaySinh.TabIndex = 0;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(280, 150);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(79, 20);
            lblNgaySinh.TabIndex = 1;
            lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(100, 175);
            radNu.Name = "radNu";
            radNu.Size = new Size(50, 24);
            radNu.TabIndex = 2;
            radNu.Text = "Nữ";
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Checked = true;
            radNam.Location = new Point(30, 175);
            radNam.Name = "radNam";
            radNam.Size = new Size(62, 24);
            radNam.TabIndex = 3;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 10F);
            lblGioiTinh.Location = new Point(30, 150);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(79, 23);
            lblGioiTinh.TabIndex = 4;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(780, 20);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(140, 140);
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvatar.TabIndex = 8;
            picAvatar.TabStop = false;
            // 
            // btnChonAnh
            // 
            btnChonAnh.BackColor = Color.WhiteSmoke;
            btnChonAnh.FlatStyle = FlatStyle.Flat;
            btnChonAnh.Location = new Point(780, 170);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(140, 30);
            btnChonAnh.TabIndex = 9;
            btnChonAnh.Text = "Chọn Ảnh...";
            btnChonAnh.UseVisualStyleBackColor = false;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(280, 110);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(200, 27);
            txtDienThoai.TabIndex = 10;
            // 
            // lblDienThoai
            // 
            lblDienThoai.AutoSize = true;
            lblDienThoai.Location = new Point(280, 85);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new Size(84, 20);
            lblDienThoai.TabIndex = 11;
            lblDienThoai.Text = "Điện Thoại:";
            // 
            // txtChucVu
            // 
            txtChucVu.Location = new Point(280, 45);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(200, 27);
            txtChucVu.TabIndex = 12;
            // 
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Location = new Point(280, 20);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(66, 20);
            lblChucVu.TabIndex = 13;
            lblChucVu.Text = "Chức Vụ:";
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(30, 110);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(200, 27);
            txtTenNV.TabIndex = 14;
            // 
            // lblTenNV
            // 
            lblTenNV.AutoSize = true;
            lblTenNV.Font = new Font("Segoe UI", 10F);
            lblTenNV.Location = new Point(30, 85);
            lblTenNV.Name = "lblTenNV";
            lblTenNV.Size = new Size(89, 23);
            lblTenNV.TabIndex = 15;
            lblTenNV.Text = "Họ và Tên:";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(30, 45);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(200, 27);
            txtMaNV.TabIndex = 16;
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Font = new Font("Segoe UI", 10F);
            lblMaNV.Location = new Point(30, 20);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(124, 23);
            lblMaNV.TabIndex = 17;
            lblMaNV.Text = "Mã Nhân Viên:";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(255, 148, 166);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(30, 10);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 40);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(108, 92, 231);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(150, 10);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 40);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.IndianRed;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(270, 10);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 40);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Gray;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(820, 10);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 40);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.WhiteSmoke;
            pnlButtons.Controls.Add(btnThem);
            pnlButtons.Controls.Add(btnSua);
            pnlButtons.Controls.Add(btnXoa);
            pnlButtons.Controls.Add(btnThoat);
            pnlButtons.Dock = DockStyle.Top;
            pnlButtons.Location = new Point(0, 280);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(950, 60);
            pnlButtons.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 600);
            Controls.Add(dgvNhanVien);
            Controls.Add(pnlButtons);
            Controls.Add(pnlInput);
            Controls.Add(pnlHeader);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Nhân sự";
            Load += MainForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        // Controls
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lblDienThoai;
        // Mới thêm
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        // Ảnh và Nút
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}