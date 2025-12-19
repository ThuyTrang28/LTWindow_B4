namespace Article20
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
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.labelMa = new System.Windows.Forms.Label();
            this.labelTen = new System.Windows.Forms.Label();
            this.labelTuoi = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.ckGender = new System.Windows.Forms.CheckBox();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();

            //
            // dgvEmployee (DataGridView)
            //
            this.dgvEmployee.AllowUserToAddRows = true;
            this.dgvEmployee.AllowUserToDeleteRows = true;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true; // Cho phép đọc để chọn hàng
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 29;
            this.dgvEmployee.Size = new System.Drawing.Size(776, 250);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_RowEnter);

            // Thêm các cột (Unbound columns)
            this.dgvEmployee.Columns.Add("MaNV", "Mã nhân viên"); // Cột 0
            this.dgvEmployee.Columns.Add("TenNV", "Tên nhân viên"); // Cột 1
            this.dgvEmployee.Columns.Add("Tuoi", "Tuổi"); // Cột 2

            System.Windows.Forms.DataGridViewCheckBoxColumn checkCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            checkCol.Name = "GioiTinh";
            checkCol.HeaderText = "Giới tính (Nam)";
            this.dgvEmployee.Columns.Add(checkCol); // Cột 3

            // 
            // labelMa
            // 
            this.labelMa.AutoSize = true;
            this.labelMa.Location = new System.Drawing.Point(20, 300);
            this.labelMa.Name = "labelMa";
            this.labelMa.Size = new System.Drawing.Size(35, 20);
            this.labelMa.TabIndex = 1;
            this.labelMa.Text = "Mã:";

            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(80, 297);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(200, 27);
            this.tbID.TabIndex = 2;

            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Location = new System.Drawing.Point(20, 340);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(35, 20);
            this.labelTen.TabIndex = 3;
            this.labelTen.Text = "Tên:";

            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(80, 337);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 27);
            this.tbName.TabIndex = 4;

            // 
            // labelTuoi
            // 
            this.labelTuoi.AutoSize = true;
            this.labelTuoi.Location = new System.Drawing.Point(20, 380);
            this.labelTuoi.Name = "labelTuoi";
            this.labelTuoi.Size = new System.Drawing.Size(41, 20);
            this.labelTuoi.TabIndex = 5;
            this.labelTuoi.Text = "Tuổi:";

            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(80, 377);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(60, 27);
            this.tbAge.TabIndex = 6;

            // 
            // ckGender (Nam)
            // 
            this.ckGender.AutoSize = true;
            this.ckGender.Location = new System.Drawing.Point(150, 380);
            this.ckGender.Name = "ckGender";
            this.ckGender.Size = new System.Drawing.Size(60, 24);
            this.ckGender.TabIndex = 7;
            this.ckGender.Text = "Nam";
            this.ckGender.UseVisualStyleBackColor = true;

            // 
            // btAddNew (Thêm)
            // 
            this.btAddNew.Location = new System.Drawing.Point(500, 377);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(94, 29);
            this.btAddNew.TabIndex = 8;
            this.btAddNew.Text = "Thêm";
            this.btAddNew.UseVisualStyleBackColor = true;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);

            // 
            // btDelete (Xóa)
            // 
            this.btDelete.Location = new System.Drawing.Point(600, 377);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(94, 29);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);

            // 
            // btExit (Thoát)
            // 
            this.btExit.Location = new System.Drawing.Point(700, 377);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(94, 29);
            this.btExit.TabIndex = 10;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.ckGender);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.labelTuoi);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.labelTen);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.labelMa);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Label labelMa;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.Label labelTuoi;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btExit;
    }
}