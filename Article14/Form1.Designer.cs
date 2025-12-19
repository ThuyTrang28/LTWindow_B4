namespace Article14
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // **********************************************
        // KHAI BÁO CÁC CONTROLS CẦN THIẾT
        // **********************************************
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.CheckBox ckDiscount;
        private System.Windows.Forms.TextBox tbDiscount; // Textbox hiển thị mức giảm giá (7 trên slide 105)
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox tbResult; // Textbox hiển thị kết quả "Ông/Bà... được giảm..."
        // **********************************************

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
            tbName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            ckDiscount = new CheckBox();
            tbDiscount = new TextBox();
            btRun = new Button();
            btExit = new Button();
            tbResult = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(140, 30);
            tbName.Name = "tbName";
            tbName.Size = new Size(250, 27);
            tbName.TabIndex = 0;
            tbName.Text = "Nguyễn Văn A";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 33);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 1;
            label1.Text = "Nguyễn Văn A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 80);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 2;
            label2.Text = "Giới tính";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Location = new Point(140, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 50);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(100, 19);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(50, 24);
            rbFemale.TabIndex = 1;
            rbFemale.Text = "Nữ";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.Location = new Point(10, 19);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(62, 24);
            rbMale.TabIndex = 0;
            rbMale.TabStop = true;
            rbMale.Text = "Nam";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // ckDiscount
            // 
            ckDiscount.AutoSize = true;
            ckDiscount.Location = new Point(20, 135);
            ckDiscount.Name = "ckDiscount";
            ckDiscount.Size = new Size(91, 24);
            ckDiscount.TabIndex = 4;
            ckDiscount.Text = "Giảm giá";
            ckDiscount.UseVisualStyleBackColor = true;
            ckDiscount.CheckedChanged += ckDiscount_CheckedChanged;
            // 
            // tbDiscount
            // 
            tbDiscount.Enabled = false;
            tbDiscount.Location = new Point(140, 133);
            tbDiscount.Name = "tbDiscount";
            tbDiscount.Size = new Size(50, 27);
            tbDiscount.TabIndex = 5;
            tbDiscount.Text = "7";
            tbDiscount.TextAlign = HorizontalAlignment.Right;
            // 
            // btRun
            // 
            btRun.Location = new Point(180, 310);
            btRun.Name = "btRun";
            btRun.Size = new Size(100, 35);
            btRun.TabIndex = 7;
            btRun.Text = "Tính tiền";
            btRun.UseVisualStyleBackColor = true;
            btRun.Click += btRun_Click;
            // 
            // btExit
            // 
            btExit.Location = new Point(290, 310);
            btExit.Name = "btExit";
            btExit.Size = new Size(100, 35);
            btExit.TabIndex = 8;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // tbResult
            // 
            tbResult.Location = new Point(20, 180);
            tbResult.Multiline = true;
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(370, 100);
            tbResult.TabIndex = 6;
            tbResult.Text = "Ông Nguyễn Văn A được giảm 7%";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 370);
            Controls.Add(btExit);
            Controls.Add(btRun);
            Controls.Add(tbResult);
            Controls.Add(tbDiscount);
            Controls.Add(ckDiscount);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
    }
}