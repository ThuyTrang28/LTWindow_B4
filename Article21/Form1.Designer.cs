namespace Article21
{
    partial class Form1
    {
        // ... (các phần khác giữ nguyên)

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // Khai báo các Controls
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.ckGender = new System.Windows.Forms.CheckBox();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lbMa = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbTuoi = new System.Windows.Forms.Label();

            // Định nghĩa các cột cho DataGridView (Dựa trên Slide 142)
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGender = new System.Windows.Forms.DataGridViewCheckBoxColumn();


            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.ColumnId,
                this.ColumnName,
                this.ColumnAge,
                this.ColumnGender
            });
            this.dgvEmployee.Location = new System.Drawing.Point(12, 12); // Vị trí tùy chỉnh
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.Size = new System.Drawing.Size(776, 200); // Kích thước tùy chỉnh
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_RowEnter); // Gắn sự kiện RowEnter

            // Cấu hình các cột (Dựa trên thiết lập trong Slide 142)
            // ColumnId (Mã nhân viên)
            this.ColumnId.HeaderText = "Mã nhân viên";
            this.ColumnId.Name = "Column1";
            this.ColumnId.DataPropertyName = "Id";
            this.ColumnId.ReadOnly = true;

            // ColumnName (Tên nhân viên)
            this.ColumnName.HeaderText = "Tên nhân viên";
            this.ColumnName.Name = "Column2";
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.ReadOnly = true;

            // ColumnAge (Tuổi)
            this.ColumnAge.HeaderText = "Tuổi";
            this.ColumnAge.Name = "Column3";
            this.ColumnAge.DataPropertyName = "Age";
            this.ColumnAge.ReadOnly = true;

            // ColumnGender (Giới tính (Nam))
            this.ColumnGender.HeaderText = "Giới tính (Nam)";
            this.ColumnGender.Name = "Column4";
            this.ColumnGender.DataPropertyName = "Gender";
            this.ColumnGender.ReadOnly = true;

            // 
            // lbMa, lbTen, lbTuoi
            // Khai báo các Label (không bắt buộc nhưng có trong hình ảnh)
            // ... (Cần xác định vị trí và kích thước cụ thể)

            //
            // tbId, tbName, tbAge
            //
            this.tbId.Name = "tbId";
            this.tbId.Location = new System.Drawing.Point(100, 240); // Vị trí mẫu
            this.tbName.Name = "tbName";
            this.tbName.Location = new System.Drawing.Point(100, 280); // Vị trí mẫu
            this.tbAge.Name = "tbAge";
            this.tbAge.Location = new System.Drawing.Point(100, 320); // Vị trí mẫu

            //
            // ckGender (Nam)
            //
            this.ckGender.Text = "Nam";
            this.ckGender.Name = "ckGender";
            this.ckGender.Location = new System.Drawing.Point(100, 360); // Vị trí mẫu
            this.ckGender.Size = new System.Drawing.Size(55, 24);

            //
            // btAddNew (Thêm)
            //
            this.btAddNew.Text = "Thêm";
            this.btAddNew.Location = new System.Drawing.Point(400, 380); // Vị trí mẫu
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(94, 29);
            this.btAddNew.TabIndex = 5;
            this.btAddNew.UseVisualStyleBackColor = true;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click); // Gắn sự kiện Click

            //
            // btDelete (Xóa)
            //
            this.btDelete.Text = "Xóa";
            this.btDelete.Location = new System.Drawing.Point(500, 380); // Vị trí mẫu
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(94, 29);
            this.btDelete.TabIndex = 6;
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click); // Gắn sự kiện Click

            //
            // btExit (Thoát)
            //
            this.btExit.Text = "Thoát";
            this.btExit.Location = new System.Drawing.Point(600, 380); // Vị trí mẫu
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(94, 29);
            this.btExit.TabIndex = 7;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += (sender, e) => this.Close(); // Thoát Form


            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);

            // Thêm tất cả các controls vào Form
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.ckGender);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btExit);
            // ... (Các Label nếu có)

            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // Khai báo các đối tượng Control
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btExit; // Thêm nút Thoát
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbTuoi;

        // Khai báo các cột
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAge;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnGender;
    }
}