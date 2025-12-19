namespace Article23
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
            // 1. Khởi tạo các nút bấm
            this.btLeft = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.btFile = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // Cấu hình nút btLeft (Nút Trái)
            // 
            this.btLeft.Location = new System.Drawing.Point(250, 350); // Vị trí
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(60, 40); // Kích thước
            this.btLeft.TabIndex = 0;
            this.btLeft.Text = "<-";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click); // Gán sự kiện

            // 
            // Cấu hình nút btRight (Nút Phải)
            // 
            this.btRight.Location = new System.Drawing.Point(320, 350); // Vị trí bên cạnh nút trái
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(60, 40);
            this.btRight.TabIndex = 1;
            this.btRight.Text = "->";
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.btRight_Click); // Gán sự kiện

            // 
            // Cấu hình nút btFile (Nút Chọn Ảnh)
            // 
            this.btFile.Location = new System.Drawing.Point(450, 350); // Vị trí xa hơn một chút
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(100, 40);
            this.btFile.TabIndex = 2;
            this.btFile.Text = "File ...";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click); // Gán sự kiện

            // 
            // Cấu hình Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);

            // Thêm các nút vào Form
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.btRight);
            this.Controls.Add(this.btLeft);

            this.Name = "Form1";
            this.Text = "Simple Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        #endregion

        // 2. Khai báo biến các nút bấm để code bên Form1.cs nhận diện được
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button btFile;
    }
}