namespace Article22
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.tBId = new System.Windows.Forms.TextBox();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBAge = new System.Windows.Forms.TextBox();
            this.ckGender = new System.Windows.Forms.CheckBox();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.Size = new System.Drawing.Size(776, 200);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_RowEnter);
            // 
            // tBId
            // 
            this.tBId.Location = new System.Drawing.Point(100, 250);
            this.tBId.Name = "tBId";
            this.tBId.Size = new System.Drawing.Size(150, 27);
            this.tBId.TabIndex = 1;
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(100, 290);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(250, 27);
            this.tBName.TabIndex = 2;
            // 
            // tBAge
            // 
            this.tBAge.Location = new System.Drawing.Point(100, 330);
            this.tBAge.Name = "tBAge";
            this.tBAge.Size = new System.Drawing.Size(50, 27);
            this.tBAge.TabIndex = 3;
            // 
            // ckGender
            // 
            this.ckGender.AutoSize = true;
            this.ckGender.Location = new System.Drawing.Point(180, 332);
            this.ckGender.Name = "ckGender";
            this.ckGender.Size = new System.Drawing.Size(63, 24);
            this.ckGender.TabIndex = 4;
            this.ckGender.Text = "Nam";
            this.ckGender.UseVisualStyleBackColor = true;
            // 
            // btAddNew
            // 
            this.btAddNew.Location = new System.Drawing.Point(450, 390);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(94, 29);
            this.btAddNew.TabIndex = 5;
            this.btAddNew.Text = "Thêm";
            this.btAddNew.UseVisualStyleBackColor = true;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(550, 390);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(94, 29);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(650, 390);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(94, 29);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(30, 253);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(30, 20);
            this.labelId.TabIndex = 8;
            this.labelId.Text = "Mã";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(30, 293);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 20);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Tên";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(30, 333);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(38, 20);
            this.labelAge.TabIndex = 10;
            this.labelAge.Text = "Tuổi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.ckGender);
            this.Controls.Add(this.tBAge);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.tBId);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "Form1";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TextBox tBId;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBAge;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
    }
}