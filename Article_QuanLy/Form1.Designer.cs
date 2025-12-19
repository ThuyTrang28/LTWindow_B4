namespace Article_QuanLy
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // Khởi tạo các màu Pastel
            // Màu hồng pastel chủ đạo (Light Pink)
            System.Drawing.Color pastelPink = System.Drawing.Color.FromArgb(255, 182, 193);
            // Màu xám nhạt cho chữ (để dễ đọc trên nền trắng)
            System.Drawing.Color textGray = System.Drawing.Color.Gray;

            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlPassLine = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlUserLine = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = pastelPink; // Áp dụng màu Pastel
            this.panelLeft.Controls.Add(this.lblWelcome);
            this.panelLeft.Controls.Add(this.lblIcon);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(320, 550);
            this.panelLeft.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(27, 280);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(268, 82);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Chào mừng đến với\nQuản Lý Nhân Sự";
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Font = new System.Drawing.Font("Segoe UI", 80F, System.Drawing.FontStyle.Bold);
            this.lblIcon.ForeColor = System.Drawing.Color.White;
            this.lblIcon.Location = new System.Drawing.Point(27, 96);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(250, 177);
            this.lblIcon.TabIndex = 1;
            this.lblIcon.Text = "🌸";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.btnClose);
            this.panelRight.Controls.Add(this.btnLogin);
            this.panelRight.Controls.Add(this.pnlPassLine);
            this.panelRight.Controls.Add(this.txtPassword);
            this.panelRight.Controls.Add(this.lblPassword);
            this.panelRight.Controls.Add(this.pnlUserLine);
            this.panelRight.Controls.Add(this.txtEmail);
            this.panelRight.Controls.Add(this.lblEmail);
            this.panelRight.Controls.Add(this.lblLoginTitle);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(320, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(480, 550);
            this.panelRight.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = pastelPink; // Màu nút X pastel
            this.btnClose.Location = new System.Drawing.Point(430, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = pastelPink; // Nền nút pastel
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(50, 380);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(380, 50);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN NOW";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlPassLine
            // 
            this.pnlPassLine.BackColor = pastelPink; // Đường kẻ pastel
            this.pnlPassLine.Location = new System.Drawing.Point(50, 315);
            this.pnlPassLine.Name = "pnlPassLine";
            this.pnlPassLine.Size = new System.Drawing.Size(380, 2);
            this.pnlPassLine.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtPassword.ForeColor = textGray;
            this.txtPassword.Location = new System.Drawing.Point(50, 280);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(380, 24);
            this.txtPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = textGray;
            this.lblPassword.Location = new System.Drawing.Point(50, 250);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(85, 19);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "PASSWORD";
            // 
            // pnlUserLine
            // 
            this.pnlUserLine.BackColor = pastelPink; // Đường kẻ pastel
            this.pnlUserLine.Location = new System.Drawing.Point(50, 215);
            this.pnlUserLine.Name = "pnlUserLine";
            this.pnlUserLine.Size = new System.Drawing.Size(380, 2);
            this.pnlUserLine.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtEmail.ForeColor = textGray;
            this.txtEmail.Location = new System.Drawing.Point(50, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(380, 24);
            this.txtEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = textGray;
            this.lblEmail.Location = new System.Drawing.Point(50, 150);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(117, 19);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "EMAIL ADDRESS";
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblLoginTitle.ForeColor = pastelPink; // Tiêu đề pastel
            this.lblLoginTitle.Location = new System.Drawing.Point(45, 60);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(217, 45);
            this.lblLoginTitle.TabIndex = 11;
            this.lblLoginTitle.Text = "ĐĂNG NHẬP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.ControlBox = false;
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Đăng nhập";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlUserLine;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlPassLine;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClose;
    }
}