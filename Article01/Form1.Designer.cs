namespace Article01
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // [QUAN TRỌNG]: Code sửa lỗi không tắt được Form
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing); // Phải có dòng này!
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";

            // Đăng ký sự kiện (Match với file Form1.cs)
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);

            this.ResumeLayout(false);
        }

        #endregion
    }
}