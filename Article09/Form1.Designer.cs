namespace Article09
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 58);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "Số x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 105);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 1;
            label2.Text = "Số y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 158);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Kết quả";
            // 
            // tbSoX
            // 
            tbSoX.Location = new Point(120, 58);
            tbSoX.Name = "tbSoX";
            tbSoX.Size = new Size(648, 27);
            tbSoX.TabIndex = 3;
            tbSoX.TextChanged += textBox1_TextChanged;
            // 
            // tbSoY
            // 
            tbSoY.Location = new Point(120, 105);
            tbSoY.Name = "tbSoY";
            tbSoY.Size = new Size(648, 27);
            tbSoY.TabIndex = 4;
            // 
            // tbKetQua
            // 
            tbKetQua.Location = new Point(120, 169);
            tbKetQua.Multiline = true;
            tbKetQua.Name = "tbKetQua";
            tbKetQua.Size = new Size(648, 209);
            tbKetQua.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(23, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btLuu_Click;
            // 
            // button2
            // 
            button2.Location = new Point(457, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Cộng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btCong_Click;
            // 
            // button3
            // 
            button3.Location = new Point(567, 409);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 8;
            button3.Text = "Nhân";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btNhan_Click;
            // 
            // button4
            // 
            button4.Location = new Point(674, 409);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 9;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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

        // Add this method to the Form1 partial class to resolve the missing event handler error.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // You can leave this empty or add logic as needed.
        }
    }
}
