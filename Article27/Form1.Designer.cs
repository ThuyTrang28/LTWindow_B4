namespace Article27
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeftArrow;
        private System.Windows.Forms.Button btnRightArrow;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeftArrow = new System.Windows.Forms.Button();
            this.btnRightArrow = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // =========================================================
            // CẤU HÌNH KÍCH THƯỚC VÀ VỊ TRÍ
            // =========================================================
            int btnSize = 70;
            int gap = 10;
            int centerX = 365; // (800 / 2) - (70 / 2)
            int bottomY = 480;
            int topY = bottomY - btnSize - gap;

            // Cấu hình Font và Màu cho nút bấm
            System.Drawing.Font arrowFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            System.Drawing.Color btnColor = System.Drawing.Color.Silver;

            // 
            // btnUp (Nút Lên)
            // 
            this.btnUp.BackColor = btnColor;
            this.btnUp.Font = arrowFont;
            this.btnUp.Location = new System.Drawing.Point(centerX, topY);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(btnSize, btnSize);
            this.btnUp.TabIndex = 0;
            this.btnUp.Text = "⬆";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);

            // 
            // btnDown (Nút Xuống)
            // 
            this.btnDown.BackColor = btnColor;
            this.btnDown.Font = arrowFont;
            this.btnDown.Location = new System.Drawing.Point(centerX, bottomY);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(btnSize, btnSize);
            this.btnDown.TabIndex = 1;
            this.btnDown.Text = "⬇";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);

            // 
            // btnLeftArrow (Nút Trái)
            // 
            this.btnLeftArrow.BackColor = btnColor;
            this.btnLeftArrow.Font = arrowFont;
            this.btnLeftArrow.Location = new System.Drawing.Point(centerX - btnSize - gap, bottomY);
            this.btnLeftArrow.Name = "btnLeftArrow";
            this.btnLeftArrow.Size = new System.Drawing.Size(btnSize, btnSize);
            this.btnLeftArrow.TabIndex = 2;
            this.btnLeftArrow.Text = "⬅";
            this.btnLeftArrow.UseVisualStyleBackColor = false;
            this.btnLeftArrow.Click += new System.EventHandler(this.btnLeftArrow_Click);

            // 
            // btnRightArrow (Nút Phải)
            // 
            this.btnRightArrow.BackColor = btnColor;
            this.btnRightArrow.Font = arrowFont;
            this.btnRightArrow.Location = new System.Drawing.Point(centerX + btnSize + gap, bottomY);
            this.btnRightArrow.Name = "btnRightArrow";
            this.btnRightArrow.Size = new System.Drawing.Size(btnSize, btnSize);
            this.btnRightArrow.TabIndex = 3;
            this.btnRightArrow.Text = "➡";
            this.btnRightArrow.UseVisualStyleBackColor = false;
            this.btnRightArrow.Click += new System.EventHandler(this.btnRightArrow_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            // --- THAY ĐỔI MÀU NỀN TẠI ĐÂY ---
            // Sử dụng màu xám nhạt (RGB 240, 240, 240) giống ảnh mẫu thứ 2
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));

            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeftArrow);
            this.Controls.Add(this.btnRightArrow);
            this.Name = "Form1";
            this.Text = "Game Hứng Trứng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
        }

        #endregion
    }
}