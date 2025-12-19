namespace Menu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // KHAI BÁO CÁC CONTROL
        private System.Windows.Forms.FlowLayoutPanel pnlMenu;
        private System.Windows.Forms.Panel pnlHeader; // Thanh tiêu đề
        private System.Windows.Forms.Label lblTitle;  // Chữ tiêu đề

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
            this.pnlMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlHeader (Thanh tiêu đề phía trên)
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94))))); // Màu xanh đậm hiện đại
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 70); // Chiều cao 70px
            this.pnlHeader.TabIndex = 1;

            // 
            // lblTitle (Chữ tiêu đề)
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White; // Chữ trắng
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(900, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH SÁCH BÀI TẬP (ARTICLES)";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pnlMenu (Khu vực chứa nút)
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241))))); // Màu xám nhạt dịu mắt
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 70); // Nằm dưới Header
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Padding = new System.Windows.Forms.Padding(20); // Cách lề 20px cho thoáng
            this.pnlMenu.Size = new System.Drawing.Size(900, 530);
            this.pnlMenu.TabIndex = 0;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600); // Tăng kích thước mặc định
            this.Controls.Add(this.pnlMenu);   // Add pnlMenu trước (Dock Fill)
            this.Controls.Add(this.pnlHeader); // Add Header sau (Dock Top)
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Hiện giữa màn hình
            this.Text = "Menu Articles Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}