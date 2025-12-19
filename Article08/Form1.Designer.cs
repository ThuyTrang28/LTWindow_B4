namespace Article08
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbSoX = new TextBox();
            tbSoY = new TextBox();
            tbKetQua = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 99);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "Số x";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 153);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 1;
            label2.Text = "Số y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 206);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Kết quả";
            // 
            // tbSoX
            // 
            tbSoX.Location = new Point(150, 99);
            tbSoX.Name = "tbSoX";
            tbSoX.Size = new Size(257, 27);
            tbSoX.TabIndex = 3;
            // 
            // tbSoY
            // 
            tbSoY.Location = new Point(150, 156);
            tbSoY.Name = "tbSoY";
            tbSoY.Size = new Size(257, 27);
            tbSoY.TabIndex = 4;
            // 
            // tbKetQua
            // 
            tbKetQua.Location = new Point(150, 206);
            tbKetQua.Name = "tbKetQua";
            tbKetQua.Size = new Size(257, 27);
            tbKetQua.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(75, 268);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(103, 39);
            button1.TabIndex = 6;
            button1.Text = "Cộng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btCong_Click;
            // 
            // button2
            // 
            button2.Location = new Point(197, 268);
            button2.Name = "button2";
            button2.Size = new Size(95, 39);
            button2.TabIndex = 7;
            button2.Text = "Nhân";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btNhan_Click;
            // 
            // button3
            // 
            button3.Location = new Point(336, 268);
            button3.Name = "button3";
            button3.Size = new Size(102, 39);
            button3.TabIndex = 8;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btThoat_Click;
            // 
            // button4
            // 
            button4.Location = new Point(75, 266);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 6;
            button4.Text = "Cộng";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btCong_Click;
            // 
            // button5
            // 
            button5.Location = new Point(204, 266);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 7;
            button5.Text = "Nhân";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btNhan_Click;
            // 
            // button6
            // 
            button6.Location = new Point(346, 266);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 8;
            button6.Text = "Thoát";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(tbKetQua);
            Controls.Add(tbSoY);
            Controls.Add(tbSoX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbSoX;
        private TextBox tbSoY;
        private TextBox tbKetQua;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
