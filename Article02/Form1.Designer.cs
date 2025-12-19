namespace Article02
{
    partial class Form1
    {
        private System.ComponentModel.Container components = null;

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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450); // Kích thước mặc định
            this.Name = "Form1";
            this.Text = "Lưu trạng thái Form";

            // Đăng ký sự kiện (Wiring up events)
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);

            this.ResumeLayout(false);
        }
        #endregion
    }
}