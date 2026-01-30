namespace Article01
{
    partial class Dashboard
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            // Khai báo các nút
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();     // Nút Nghỉ Phép (Mới)
            this.btnInsurance = new System.Windows.Forms.Button();
            this.btnContract = new System.Windows.Forms.Button();
            this.btnReward = new System.Windows.Forms.Button();
            this.btnRecruit = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlShadow = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(139)))));
            this.pnlSidebar.Controls.Add(this.btnLogOut); // Dock Bottom

            // --- THỨ TỰ ADD CONTROLS (QUAN TRỌNG) ---
            // Add ngược từ dưới lên để hiển thị đúng vị trí (do dùng Dock = Top)
            // Hiển thị: Logo -> Employee -> Salary -> Attendance -> Recruit -> Reward -> Contract -> Insurance -> Leave -> Settings

            this.pnlSidebar.Controls.Add(this.btnSettings);
            this.pnlSidebar.Controls.Add(this.btnLeave);      // <-- Thêm nút Nghỉ Phép (Mới)
            this.pnlSidebar.Controls.Add(this.btnInsurance);
            this.pnlSidebar.Controls.Add(this.btnContract);
            this.pnlSidebar.Controls.Add(this.btnReward);
            this.pnlSidebar.Controls.Add(this.btnRecruit);
            this.pnlSidebar.Controls.Add(this.btnAttendance);
            this.pnlSidebar.Controls.Add(this.btnSalary);
            this.pnlSidebar.Controls.Add(this.btnEmployee);
            this.pnlSidebar.Controls.Add(this.pnlLogo);       // Logo trên cùng

            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(260, 750);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnLogOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogOut.Location = new System.Drawing.Point(0, 690);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(260, 60);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Đăng Xuất";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(0, 660); // Vị trí tự động
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(260, 60);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "Hệ Thống";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLeave (Nút Mới)
            // 
            this.btnLeave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLeave.FlatAppearance.BorderSize = 0;
            this.btnLeave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.btnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeave.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnLeave.ForeColor = System.Drawing.Color.White;
            this.btnLeave.Location = new System.Drawing.Point(0, 600);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLeave.Size = new System.Drawing.Size(260, 60);
            this.btnLeave.TabIndex = 8;
            this.btnLeave.Text = "Nghỉ Phép";
            this.btnLeave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // btnInsurance
            // 
            this.btnInsurance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsurance.FlatAppearance.BorderSize = 0;
            this.btnInsurance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.btnInsurance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsurance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnInsurance.ForeColor = System.Drawing.Color.White;
            this.btnInsurance.Location = new System.Drawing.Point(0, 540);
            this.btnInsurance.Name = "btnInsurance";
            this.btnInsurance.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnInsurance.Size = new System.Drawing.Size(260, 60);
            this.btnInsurance.TabIndex = 7;
            this.btnInsurance.Text = "Bảo Hiểm";
            this.btnInsurance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsurance.UseVisualStyleBackColor = true;
            this.btnInsurance.Click += new System.EventHandler(this.btnInsurance_Click);
            // 
            // btnContract
            // 
            this.btnContract.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContract.FlatAppearance.BorderSize = 0;
            this.btnContract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.btnContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContract.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnContract.ForeColor = System.Drawing.Color.White;
            this.btnContract.Location = new System.Drawing.Point(0, 480);
            this.btnContract.Name = "btnContract";
            this.btnContract.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnContract.Size = new System.Drawing.Size(260, 60);
            this.btnContract.TabIndex = 6;
            this.btnContract.Text = "Hợp Đồng Lao Động";
            this.btnContract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContract.UseVisualStyleBackColor = true;
            this.btnContract.Click += new System.EventHandler(this.btnContract_Click);
            // 
            // btnReward
            // 
            this.btnReward.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReward.FlatAppearance.BorderSize = 0;
            this.btnReward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.btnReward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReward.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnReward.ForeColor = System.Drawing.Color.White;
            this.btnReward.Location = new System.Drawing.Point(0, 420);
            this.btnReward.Name = "btnReward";
            this.btnReward.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnReward.Size = new System.Drawing.Size(260, 60);
            this.btnReward.TabIndex = 5;
            this.btnReward.Text = "Khen Thưởng / Kỷ Luật";
            this.btnReward.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReward.UseVisualStyleBackColor = true;
            this.btnReward.Click += new System.EventHandler(this.btnReward_Click);
            // 
            // btnRecruit
            // 
            this.btnRecruit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecruit.FlatAppearance.BorderSize = 0;
            this.btnRecruit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.btnRecruit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecruit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnRecruit.ForeColor = System.Drawing.Color.White;
            this.btnRecruit.Location = new System.Drawing.Point(0, 360);
            this.btnRecruit.Name = "btnRecruit";
            this.btnRecruit.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnRecruit.Size = new System.Drawing.Size(260, 60);
            this.btnRecruit.TabIndex = 4;
            this.btnRecruit.Text = "Tuyển Dụng";
            this.btnRecruit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecruit.UseVisualStyleBackColor = true;
            this.btnRecruit.Click += new System.EventHandler(this.btnRecruit_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Location = new System.Drawing.Point(0, 300);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAttendance.Size = new System.Drawing.Size(260, 60);
            this.btnAttendance.TabIndex = 3;
            this.btnAttendance.Text = "Chấm Công";
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalary.FlatAppearance.BorderSize = 0;
            this.btnSalary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.btnSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalary.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSalary.ForeColor = System.Drawing.Color.White;
            this.btnSalary.Location = new System.Drawing.Point(0, 240);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSalary.Size = new System.Drawing.Size(260, 60);
            this.btnSalary.TabIndex = 2;
            this.btnSalary.Text = "Bảng Lương";
            this.btnSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Location = new System.Drawing.Point(0, 180);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(260, 60);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "Quản Lý Nhân Viên";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            this.pnlLogo.Controls.Add(this.lblBrand);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(260, 180);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblBrand
            // 
            this.lblBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(0, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(260, 180);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "HR\r\nMANAGER";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(260, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(940, 80);
            this.pnlTop.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(146, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Trang Chủ";
            // 
            // pnlShadow
            // 
            this.pnlShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShadow.Location = new System.Drawing.Point(260, 80);
            this.pnlShadow.Name = "pnlShadow";
            this.pnlShadow.Size = new System.Drawing.Size(940, 5);
            this.pnlShadow.TabIndex = 2;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(260, 85);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(940, 665);
            this.pnlContent.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlShadow);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Nhân Sự";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblBrand;
        // Khai báo đầy đủ các nút
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnRecruit;
        private System.Windows.Forms.Button btnReward;
        private System.Windows.Forms.Button btnContract;
        private System.Windows.Forms.Button btnInsurance;
        private System.Windows.Forms.Button btnLeave; // Nút mới thêm

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlShadow;
    }
}