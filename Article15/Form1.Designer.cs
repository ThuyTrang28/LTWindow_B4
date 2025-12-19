namespace Article15
{
    partial class Form1
    {
        // Khai báo các Controls
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label labelGioiTinh;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.Label labelKhoa;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label labelTrangThai;
        private System.Windows.Forms.ListBox lstSinhVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBoxGioiTinh; // Dùng GroupBox để nhóm RadioButton

        // ... (Phần code Dispose giữ nguyên)

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // 1. Khởi tạo các Controls
            labelHoTen = new System.Windows.Forms.Label();
            txtHoTen = new System.Windows.Forms.TextBox();
            labelNgaySinh = new System.Windows.Forms.Label();
            dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            labelGioiTinh = new System.Windows.Forms.Label();
            rdbNam = new System.Windows.Forms.RadioButton();
            rdbNu = new System.Windows.Forms.RadioButton();
            groupBoxGioiTinh = new System.Windows.Forms.GroupBox(); // Khởi tạo GroupBox
            labelKhoa = new System.Windows.Forms.Label();
            cboKhoa = new System.Windows.Forms.ComboBox();
            labelTrangThai = new System.Windows.Forms.Label();
            lstSinhVien = new System.Windows.Forms.ListBox();
            btnThem = new System.Windows.Forms.Button();
            btnThoat = new System.Windows.Forms.Button();

            // Bắt đầu gán thuộc tính cho GroupBox và thêm RadioButtons vào đó
            groupBoxGioiTinh.SuspendLayout();
            SuspendLayout();

            // ----------------------------------------------------------------------
            // labelHoTen
            // ----------------------------------------------------------------------
            labelHoTen.AutoSize = true;
            labelHoTen.Location = new System.Drawing.Point(30, 30);
            labelHoTen.Name = "labelHoTen";
            labelHoTen.Size = new System.Drawing.Size(73, 20);
            labelHoTen.Text = "Họ và tên";

            // ----------------------------------------------------------------------
            // txtHoTen
            // ----------------------------------------------------------------------
            txtHoTen.Location = new System.Drawing.Point(130, 27);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new System.Drawing.Size(250, 27);

            // ----------------------------------------------------------------------
            // labelNgaySinh
            // ----------------------------------------------------------------------
            labelNgaySinh.AutoSize = true;
            labelNgaySinh.Location = new System.Drawing.Point(30, 70);
            labelNgaySinh.Name = "labelNgaySinh";
            labelNgaySinh.Size = new System.Drawing.Size(78, 20);
            labelNgaySinh.Text = "Ngày Sinh";

            // ----------------------------------------------------------------------
            // dtpNgaySinh
            // ----------------------------------------------------------------------
            dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new System.Drawing.Point(130, 67);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new System.Drawing.Size(120, 27);
            dtpNgaySinh.Value = new System.DateTime(1994, 7, 10); // Giá trị mẫu từ ảnh

            // ----------------------------------------------------------------------
            // groupBoxGioiTinh (Nhóm RadioButtons)
            // ----------------------------------------------------------------------
            groupBoxGioiTinh.Controls.Add(rdbNu);
            groupBoxGioiTinh.Controls.Add(rdbNam);
            groupBoxGioiTinh.Location = new System.Drawing.Point(30, 100);
            groupBoxGioiTinh.Name = "groupBoxGioiTinh";
            groupBoxGioiTinh.Size = new System.Drawing.Size(350, 60);
            groupBoxGioiTinh.TabStop = false;
            groupBoxGioiTinh.Text = "Giới tính";

            // ----------------------------------------------------------------------
            // rdbNam
            // ----------------------------------------------------------------------
            rdbNam.AutoSize = true;
            rdbNam.Location = new System.Drawing.Point(100, 25);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new System.Drawing.Size(62, 24);
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;

            // ----------------------------------------------------------------------
            // rdbNu
            // ----------------------------------------------------------------------
            rdbNu.AutoSize = true;
            rdbNu.Checked = true; // Giá trị mẫu từ ảnh
            rdbNu.Location = new System.Drawing.Point(190, 25);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new System.Drawing.Size(50, 24);
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;

            // ----------------------------------------------------------------------
            // labelKhoa
            // ----------------------------------------------------------------------
            labelKhoa.AutoSize = true;
            labelKhoa.Location = new System.Drawing.Point(30, 180);
            labelKhoa.Name = "labelKhoa";
            labelKhoa.Size = new System.Drawing.Size(43, 20);
            labelKhoa.Text = "Khoa";

            // ----------------------------------------------------------------------
            // cboKhoa
            // ----------------------------------------------------------------------
            cboKhoa.FormattingEnabled = true;
            // Thêm mục 'Công nghệ thông tin' vào ComboBox tại runtime hoặc trong Form_Load
            // cboKhoa.Items.AddRange(new object[] { "Công nghệ thông tin", "..." }); 
            cboKhoa.Location = new System.Drawing.Point(130, 177);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new System.Drawing.Size(250, 28);

            // ----------------------------------------------------------------------
            // labelTrangThai
            // ----------------------------------------------------------------------
            labelTrangThai.AutoSize = true;
            labelTrangThai.Location = new System.Drawing.Point(30, 220);
            labelTrangThai.Name = "labelTrangThai";
            labelTrangThai.Size = new System.Drawing.Size(75, 20);
            labelTrangThai.Text = "Trạng thái";

            // ----------------------------------------------------------------------
            // lstSinhVien
            // ----------------------------------------------------------------------
            lstSinhVien.FormattingEnabled = true;
            lstSinhVien.ItemHeight = 20;
            lstSinhVien.Location = new System.Drawing.Point(130, 220);
            lstSinhVien.Name = "lstSinhVien";
            lstSinhVien.Size = new System.Drawing.Size(250, 140);
            // Dữ liệu trong ListBox sẽ được thêm bằng code C# trong sự kiện btnThem_Click

            // ----------------------------------------------------------------------
            // btnThem
            // ----------------------------------------------------------------------
            btnThem.Location = new System.Drawing.Point(160, 380);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(90, 30);
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // Thêm sự kiện Click cho nút Thêm
            // btnThem.Click += new System.EventHandler(this.btnThem_Click); 

            // ----------------------------------------------------------------------
            // btnThoat
            // ----------------------------------------------------------------------
            btnThoat.Location = new System.Drawing.Point(270, 380);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(90, 30);
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // Thêm sự kiện Click cho nút Thoát
            // btnThoat.Click += new System.EventHandler(this.btnThoat_Click); 

            // ----------------------------------------------------------------------
            // Form1
            // ----------------------------------------------------------------------
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(420, 450); // Thay đổi kích thước phù hợp với nội dung
            Name = "Form1";
            Text = "Quản lý sinh viên"; // Đặt lại tiêu đề Form

            // Thêm tất cả Controls vào Form
            Controls.Add(btnThoat);
            Controls.Add(btnThem);
            Controls.Add(lstSinhVien);
            Controls.Add(labelTrangThai);
            Controls.Add(cboKhoa);
            Controls.Add(labelKhoa);
            Controls.Add(groupBoxGioiTinh); // Thêm GroupBox thay vì RadioButton riêng lẻ
            Controls.Add(dtpNgaySinh);
            Controls.Add(labelNgaySinh);
            Controls.Add(txtHoTen);
            Controls.Add(labelHoTen);

            // Ghi nhận thay đổi GroupBox và Form
            groupBoxGioiTinh.ResumeLayout(false);
            groupBoxGioiTinh.PerformLayout();
            Load += new System.EventHandler(Form1_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
    }
}