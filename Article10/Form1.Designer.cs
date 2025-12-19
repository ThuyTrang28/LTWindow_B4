namespace Article10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // ********* KHAI BÁO CÁC CONTROL CẦN THIẾT (BỔ SUNG bt3 và btDot) *********
        // TextBox để hiển thị (tbDisplay)
        private System.Windows.Forms.TextBox tbDisplay;

        // Các nút bấm số
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3; // <--- KHAI BÁO NÚT 3 MỚI
        // ... (thêm các nút số khác nếu cần, ví dụ bt4, ...)

        // Các nút toán tử và nút bằng
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btMul; // Nút Nhân
        private System.Windows.Forms.Button btDot; // <--- KHAI BÁO NÚT DẤU CHẤM MỚI
        private System.Windows.Forms.Button btEquals;
        // *************************************************

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
        ///  
        /// </summary>
        private void InitializeComponent()
        {
            tbDisplay = new TextBox();
            bt0 = new Button();
            bt1 = new Button();
            bt2 = new Button();
            bt3 = new Button();
            btPlus = new Button();
            btMul = new Button();
            btDot = new Button();
            btEquals = new Button();
            SuspendLayout();
            // 
            // tbDisplay
            // 
            tbDisplay.Location = new Point(12, 12);
            tbDisplay.Multiline = true;
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(451, 114);
            tbDisplay.TabIndex = 0;
            tbDisplay.Text = "0";
            tbDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // bt0
            // 
            bt0.Location = new Point(12, 132);
            bt0.Name = "bt0";
            bt0.Size = new Size(109, 94);
            bt0.TabIndex = 1;
            bt0.Text = "0";
            bt0.UseVisualStyleBackColor = true;
            bt0.Click += bt0_Click;
            // 
            // bt1
            // 
            bt1.Location = new Point(127, 132);
            bt1.Name = "bt1";
            bt1.Size = new Size(113, 94);
            bt1.TabIndex = 2;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // bt2
            // 
            bt2.Location = new Point(246, 132);
            bt2.Name = "bt2";
            bt2.Size = new Size(110, 94);
            bt2.TabIndex = 3;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += bt2_Click;
            // 
            // bt3
            // 
            bt3.Location = new Point(358, 132);
            bt3.Name = "bt3";
            bt3.Size = new Size(105, 94);
            bt3.TabIndex = 7;
            bt3.Text = "3";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += bt3_Click;
            // 
            // btPlus
            // 
            btPlus.Location = new Point(12, 240);
            btPlus.Name = "btPlus";
            btPlus.Size = new Size(109, 96);
            btPlus.TabIndex = 4;
            btPlus.Text = "+";
            btPlus.UseVisualStyleBackColor = true;
            btPlus.Click += btPlus_Click;
            // 
            // btMul
            // 
            btMul.Location = new Point(127, 240);
            btMul.Name = "btMul";
            btMul.Size = new Size(113, 96);
            btMul.TabIndex = 5;
            btMul.Text = "*";
            btMul.UseVisualStyleBackColor = true;
            btMul.Click += btMul_Click;
            // 
            // btDot
            // 
            btDot.Location = new Point(246, 240);
            btDot.Name = "btDot";
            btDot.Size = new Size(110, 96);
            btDot.TabIndex = 8;
            btDot.Text = ".";
            btDot.UseVisualStyleBackColor = true;
            btDot.Click += btDot_Click;
            // 
            // btEquals
            // 
            btEquals.Location = new Point(358, 240);
            btEquals.Name = "btEquals";
            btEquals.Size = new Size(105, 96);
            btEquals.TabIndex = 6;
            btEquals.Text = "=";
            btEquals.UseVisualStyleBackColor = true;
            btEquals.Click += btEquals_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 348);
            Controls.Add(btDot);
            Controls.Add(bt3);
            Controls.Add(btEquals);
            Controls.Add(btMul);
            Controls.Add(btPlus);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Controls.Add(bt0);
            Controls.Add(tbDisplay);
            Name = "Form1";
            Text = "Simple Caculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}