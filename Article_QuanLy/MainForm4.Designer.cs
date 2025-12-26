namespace Article_QuanLy
{
    partial class MainForm4
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
            this.pnlInput = new System.Windows.Forms.Panel();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.dtpNgayNop = new System.Windows.Forms.DateTimePicker();
            this.lblNgayNop = new System.Windows.Forms.Label();
            this.txtKinhNghiem = new System.Windows.Forms.TextBox();
            this.lblKinhNghiem = new System.Windows.Forms.Label();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.lblViTri = new System.Windows.Forms.Label();
            this.txtTenUV = new System.Windows.Forms.TextBox();
            this.lblTenUV = new System.Windows.Forms.Label();
            this.txtMaUV = new System.Windows.Forms.TextBox();
            this.lblMaUV = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvUngVien = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUngVien)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(166)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(950, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(309, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ TUYỂN DỤNG";
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.White;
            this.pnlInput.Controls.Add(this.cboTrangThai);
            this.pnlInput.Controls.Add(this.lblTrangThai);
            this.pnlInput.Controls.Add(this.dtpNgayNop);
            this.pnlInput.Controls.Add(this.lblNgayNop);
            this.pnlInput.Controls.Add(this.txtKinhNghiem);
            this.pnlInput.Controls.Add(this.lblKinhNghiem);
            this.pnlInput.Controls.Add(this.txtViTri);
            this.pnlInput.Controls.Add(this.lblViTri);
            this.pnlInput.Controls.Add(this.txtTenUV);
            this.pnlInput.Controls.Add(this.lblTenUV);
            this.pnlInput.Controls.Add(this.txtMaUV);
            this.pnlInput.Controls.Add(this.lblMaUV);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(0, 60);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(950, 160);
            this.pnlInput.TabIndex = 1;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Chờ phỏng vấn",
            "Đang phỏng vấn",
            "Đạt",
            "Trượt",
            "Lưu hồ sơ"});
            this.cboTrangThai.Location = new System.Drawing.Point(650, 110);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(200, 28);
            this.cboTrangThai.TabIndex = 11;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTrangThai.Location = new System.Drawing.Point(650, 85);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(91, 23);
            this.lblTrangThai.TabIndex = 10;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // dtpNgayNop
            // 
            this.dtpNgayNop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNop.Location = new System.Drawing.Point(650, 45);
            this.dtpNgayNop.Name = "dtpNgayNop";
            this.dtpNgayNop.Size = new System.Drawing.Size(200, 27);
            this.dtpNgayNop.TabIndex = 9;
            // 
            // lblNgayNop
            // 
            this.lblNgayNop.AutoSize = true;
            this.lblNgayNop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNgayNop.Location = new System.Drawing.Point(650, 20);
            this.lblNgayNop.Name = "lblNgayNop";
            this.lblNgayNop.Size = new System.Drawing.Size(142, 23);
            this.lblNgayNop.TabIndex = 8;
            this.lblNgayNop.Text = "Ngày nộp hồ sơ:";
            // 
            // txtKinhNghiem
            // 
            this.txtKinhNghiem.Location = new System.Drawing.Point(340, 110);
            this.txtKinhNghiem.Name = "txtKinhNghiem";
            this.txtKinhNghiem.Size = new System.Drawing.Size(250, 27);
            this.txtKinhNghiem.TabIndex = 7;
            // 
            // lblKinhNghiem
            // 
            this.lblKinhNghiem.AutoSize = true;
            this.lblKinhNghiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKinhNghiem.Location = new System.Drawing.Point(340, 85);
            this.lblKinhNghiem.Name = "lblKinhNghiem";
            this.lblKinhNghiem.Size = new System.Drawing.Size(110, 23);
            this.lblKinhNghiem.TabIndex = 6;
            this.lblKinhNghiem.Text = "Kinh nghiệm:";
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(340, 45);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(250, 27);
            this.txtViTri.TabIndex = 5;
            // 
            // lblViTri
            // 
            this.lblViTri.AutoSize = true;
            this.lblViTri.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblViTri.Location = new System.Drawing.Point(340, 20);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(129, 23);
            this.lblViTri.TabIndex = 4;
            this.lblViTri.Text = "Vị trí ứng tuyển:";
            // 
            // txtTenUV
            // 
            this.txtTenUV.Location = new System.Drawing.Point(30, 110);
            this.txtTenUV.Name = "txtTenUV";
            this.txtTenUV.Size = new System.Drawing.Size(250, 27);
            this.txtTenUV.TabIndex = 3;
            // 
            // lblTenUV
            // 
            this.lblTenUV.AutoSize = true;
            this.lblTenUV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTenUV.Location = new System.Drawing.Point(30, 85);
            this.lblTenUV.Name = "lblTenUV";
            this.lblTenUV.Size = new System.Drawing.Size(111, 23);
            this.lblTenUV.TabIndex = 2;
            this.lblTenUV.Text = "Tên Ứng viên:";
            // 
            // txtMaUV
            // 
            this.txtMaUV.Location = new System.Drawing.Point(30, 45);
            this.txtMaUV.Name = "txtMaUV";
            this.txtMaUV.Size = new System.Drawing.Size(250, 27);
            this.txtMaUV.TabIndex = 1;
            // 
            // lblMaUV
            // 
            this.lblMaUV.AutoSize = true;
            this.lblMaUV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaUV.Location = new System.Drawing.Point(30, 20);
            this.lblMaUV.Name = "lblMaUV";
            this.lblMaUV.Size = new System.Drawing.Size(109, 23);
            this.lblMaUV.TabIndex = 0;
            this.lblMaUV.Text = "Mã Ứng viên:";
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Controls.Add(this.btnThoat);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(0, 220);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(950, 60);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(166)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(30, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(150, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(270, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Gray;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(820, 10);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvUngVien
            // 
            this.dgvUngVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvUngVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUngVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUngVien.ColumnHeadersHeight = 30;
            this.dgvUngVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUngVien.EnableHeadersVisualStyles = false;
            this.dgvUngVien.Location = new System.Drawing.Point(0, 280);
            this.dgvUngVien.Name = "dgvUngVien";
            this.dgvUngVien.RowHeadersWidth = 51;
            this.dgvUngVien.Size = new System.Drawing.Size(950, 320);
            this.dgvUngVien.TabIndex = 3;
            this.dgvUngVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUngVien_CellClick);
            // 
            // MainForm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.dgvUngVien);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlHeader);
            this.Name = "MainForm4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Tuyển dụng";
            this.Load += new System.EventHandler(this.MainForm4_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUngVien)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.DataGridView dgvUngVien;

        // Input Controls
        private System.Windows.Forms.TextBox txtMaUV;
        private System.Windows.Forms.Label lblMaUV;
        private System.Windows.Forms.TextBox txtTenUV;
        private System.Windows.Forms.Label lblTenUV;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.Label lblViTri;
        private System.Windows.Forms.TextBox txtKinhNghiem;
        private System.Windows.Forms.Label lblKinhNghiem;
        private System.Windows.Forms.DateTimePicker dtpNgayNop;
        private System.Windows.Forms.Label lblNgayNop;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblTrangThai;

        // Buttons
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}