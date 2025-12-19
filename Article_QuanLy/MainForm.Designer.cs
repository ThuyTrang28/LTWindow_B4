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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlHeader (Thanh tiêu đề màu hồng)
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(166)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(950, 60);
            this.pnlHeader.TabIndex = 0;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "QUẢN LÝ NHÂN VIÊN";

            // 
            // pnlInput (Khu vực nhập liệu)
            // 
            this.pnlInput.BackColor = System.Drawing.Color.White;
            this.pnlInput.Controls.Add(this.dtpNgaySinh);
            this.pnlInput.Controls.Add(this.lblNgaySinh);
            this.pnlInput.Controls.Add(this.radNu);
            this.pnlInput.Controls.Add(this.radNam);
            this.pnlInput.Controls.Add(this.lblGioiTinh);
            this.pnlInput.Controls.Add(this.picAvatar);
            this.pnlInput.Controls.Add(this.btnChonAnh);
            this.pnlInput.Controls.Add(this.txtDienThoai);
            this.pnlInput.Controls.Add(this.lblDienThoai);
            this.pnlInput.Controls.Add(this.txtChucVu);
            this.pnlInput.Controls.Add(this.lblChucVu);
            this.pnlInput.Controls.Add(this.txtTenNV);
            this.pnlInput.Controls.Add(this.lblTenNV);
            this.pnlInput.Controls.Add(this.txtMaNV);
            this.pnlInput.Controls.Add(this.lblMaNV);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(0, 60);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(950, 220);
            this.pnlInput.TabIndex = 1;

            // picAvatar
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(780, 20);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(140, 140);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 8;
            this.picAvatar.TabStop = false;

            // btnChonAnh
            this.btnChonAnh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnChonAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonAnh.Location = new System.Drawing.Point(780, 170);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(140, 30);
            this.btnChonAnh.TabIndex = 9;
            this.btnChonAnh.Text = "Chọn Ảnh...";
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);

            // --- Cột 1 ---
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaNV.Location = new System.Drawing.Point(30, 20);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Text = "Mã Nhân Viên:";
            this.txtMaNV.Location = new System.Drawing.Point(30, 45);
            this.txtMaNV.Size = new System.Drawing.Size(200, 27);

            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTenNV.Location = new System.Drawing.Point(30, 85);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Text = "Họ và Tên:";
            this.txtTenNV.Location = new System.Drawing.Point(30, 110);
            this.txtTenNV.Size = new System.Drawing.Size(200, 27);

            // Giới tính (Radio)
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGioiTinh.Location = new System.Drawing.Point(30, 150);
            this.lblGioiTinh.Text = "Giới tính:";

            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Location = new System.Drawing.Point(30, 175);
            this.radNam.Name = "radNam";
            this.radNam.Text = "Nam";

            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(100, 175);
            this.radNu.Name = "radNu";
            this.radNu.Text = "Nữ";

            // --- Cột 2 ---
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(280, 20);
            this.lblChucVu.Text = "Chức Vụ:";
            this.txtChucVu.Location = new System.Drawing.Point(280, 45);
            this.txtChucVu.Size = new System.Drawing.Size(200, 27);

            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(280, 85);
            this.lblDienThoai.Text = "Điện Thoại:";
            this.txtDienThoai.Location = new System.Drawing.Point(280, 110);
            this.txtDienThoai.Size = new System.Drawing.Size(200, 27);

            // Ngày sinh (DateTimePicker)
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(280, 150);
            this.lblNgaySinh.Text = "Ngày Sinh:";

            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(280, 175);
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 27);

            // 
            // pnlButtons (Khu vực nút bấm)
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Controls.Add(this.btnThoat);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(0, 280);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(950, 60);
            this.pnlButtons.TabIndex = 2;

            // Style nút bấm
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(166)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(30, 10);
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(150, 10);
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(270, 10);
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnThoat.BackColor = System.Drawing.Color.Gray;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(820, 10);
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(235))))); // Header hồng nhạt
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.ColumnHeadersHeight = 30;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 340);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 29;
            this.dgvNhanVien.Size = new System.Drawing.Size(950, 260);
            this.dgvNhanVien.TabIndex = 3;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlHeader);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Nhân sự";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
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