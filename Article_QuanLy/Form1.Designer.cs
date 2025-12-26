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
            panelLeft = new Panel();
            lblWelcome = new Label();
            lblIcon = new Label();
            panelRight = new Panel();
            btnClose = new Button();
            btnLogin = new Button();
            pnlPassLine = new Panel();
            txtPassword = new TextBox();
            lblPassword = new Label();
            pnlUserLine = new Panel();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblLoginTitle = new Label();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(255, 182, 193);
            panelLeft.Controls.Add(lblWelcome);
            panelLeft.Controls.Add(lblIcon);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(320, 550);
            panelLeft.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI Light", 18F);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(27, 280);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(268, 82);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Chào mừng đến với\nQuản Lý Nhân Sự";
            // 
            // lblIcon
            // 
            lblIcon.AutoSize = true;
            lblIcon.Font = new Font("Segoe UI", 80F, FontStyle.Bold);
            lblIcon.ForeColor = Color.White;
            lblIcon.Location = new Point(27, 96);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(250, 177);
            lblIcon.TabIndex = 1;
            lblIcon.Text = "🌸";
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(btnClose);
            panelRight.Controls.Add(btnLogin);
            panelRight.Controls.Add(pnlPassLine);
            panelRight.Controls.Add(txtPassword);
            panelRight.Controls.Add(lblPassword);
            panelRight.Controls.Add(pnlUserLine);
            panelRight.Controls.Add(txtEmail);
            panelRight.Controls.Add(lblEmail);
            panelRight.Controls.Add(lblLoginTitle);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(320, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(480, 550);
            panelRight.TabIndex = 1;
            panelRight.Paint += panelRight_Paint;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Verdana", 16F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(255, 182, 193);
            btnClose.Location = new Point(430, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 50);
            btnClose.TabIndex = 8;
            btnClose.Text = "×";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 182, 193);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(50, 380);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(380, 50);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN NOW";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pnlPassLine
            // 
            pnlPassLine.BackColor = Color.FromArgb(255, 182, 193);
            pnlPassLine.Location = new Point(50, 315);
            pnlPassLine.Name = "pnlPassLine";
            pnlPassLine.Size = new Size(380, 2);
            pnlPassLine.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 13F);
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Location = new Point(50, 280);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(380, 29);
            txtPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPassword.ForeColor = Color.Gray;
            lblPassword.Location = new Point(50, 250);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(105, 23);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "PASSWORD";
            // 
            // pnlUserLine
            // 
            pnlUserLine.BackColor = Color.FromArgb(255, 182, 193);
            pnlUserLine.Location = new Point(50, 215);
            pnlUserLine.Name = "pnlUserLine";
            pnlUserLine.Size = new Size(380, 2);
            pnlUserLine.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 13F);
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Location = new Point(50, 180);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(380, 29);
            txtEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.ForeColor = Color.Gray;
            lblEmail.Location = new Point(50, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(144, 23);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "EMAIL ADDRESS";
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblLoginTitle.ForeColor = Color.FromArgb(255, 182, 193);
            lblLoginTitle.Location = new Point(45, 60);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(268, 54);
            lblLoginTitle.TabIndex = 11;
            lblLoginTitle.Text = "ĐĂNG NHẬP";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            ControlBox = false;
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Đăng nhập";
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
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