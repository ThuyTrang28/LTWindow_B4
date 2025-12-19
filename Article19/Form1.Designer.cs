namespace Article19
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // 1. Khởi tạo Controls
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label(); // Mã nhân viên
            this.label2 = new System.Windows.Forms.Label(); // Tên nhân viên
            this.label3 = new System.Windows.Forms.Label(); // Ảnh 3x4

            this.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();


            // 
            // label1 (Mã nhân viên)
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã nhân viên";

            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(130, 27);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(250, 27);
            this.txtMaNhanVien.TabIndex = 2;
            this.txtMaNhanVien.Text = "03152482001"; // Dữ liệu mẫu

            // 
            // label2 (Tên nhân viên)
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên nhân viên";

            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(130, 67);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(250, 27);
            this.txtTenNhanVien.TabIndex = 3;
            this.txtTenNhanVien.Text = "Nguyễn Văn Hùng";

            // 
            // label3 (Ảnh 3x4)
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ảnh 3 x 4";


            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(130, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 160); // Kích thước xấp xỉ 3x4
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // Gán Event Click cho PictureBox
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // Gán Event Validating
            this.pictureBox1.Validating += new System.ComponentModel.CancelEventHandler(this.pictureBox1_Validating);


            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(260, 280);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(95, 30);
            this.btnChonAnh.TabIndex = 1;
            this.btnChonAnh.Text = "Chọn ảnh...";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            // Gán Event Click cho Button
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);


            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 350); // Thu nhỏ kích thước Form
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Quản lý nhân sự"; // Đổi Text Form
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout(); // Cần có cho Label/TextBox
        }

        #endregion

        // 2. Khai báo các Controls
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}