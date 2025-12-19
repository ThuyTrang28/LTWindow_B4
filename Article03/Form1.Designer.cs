namespace Article03
{
    partial class Form1
    {
        // Sửa: Nên dùng IContainer (Interface) thay vì Container class cụ thể để đúng chuẩn WinForms mới
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // Thêm dòng này để form hiển thị đúng tỉ lệ
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450); // Kích thước mặc định
            this.Name = "Form1";
            this.Text = "Form1";

            // --- PHẦN SỬA LỖI QUAN TRỌNG ---

            // 1. Sự kiện Load
            this.Load += new System.EventHandler(this.Form1_Load);

            // 2. Sự kiện FormClosing (Thay thế cho Closing)
            // Lưu ý: Phải dùng FormClosingEventHandler để khớp với FormClosingEventArgs bên file Form1.cs
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);

            this.ResumeLayout(false);
        }
        #endregion
    }
}