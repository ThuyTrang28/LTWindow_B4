namespace Article_QuanLy
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
            pnlSidebar = new Panel();
            btnLogout = new Button();
            btnSettings = new Button();
            btnRecruit = new Button();
            btnSalary = new Button();
            btnTimekeeping = new Button();
            btnEmployee = new Button();
            pnlLogo = new Panel();
            lblLogo = new Label();
            pnlHeader = new Panel();
            lblWelcome = new Label();
            lblTitle = new Label();
            pnlBody = new Panel();
            pnlBottom = new Panel();
            pnlActivity = new Panel();
            lblActivityList = new Label();
            lblActivityTitle = new Label();
            pnlChart = new Panel();
            lblSales = new Label();
            pgbSales = new ProgressBar();
            lblHR = new Label();
            pgbHR = new ProgressBar();
            lblIT = new Label();
            pgbIT = new ProgressBar();
            lblChartTitle = new Label();
            pnlCards = new Panel();
            card4 = new Panel();
            lblNumContract = new Label();
            lblTitleContract = new Label();
            card3 = new Panel();
            lblNumAbsent = new Label();
            lblTitleAbsent = new Label();
            card2 = new Panel();
            lblNumNew = new Label();
            lblTitleNew = new Label();
            card1 = new Panel();
            lblNumTotal = new Label();
            lblTitleTotal = new Label();
            pnlSidebar.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlBottom.SuspendLayout();
            pnlActivity.SuspendLayout();
            pnlChart.SuspendLayout();
            pnlCards.SuspendLayout();
            card4.SuspendLayout();
            card3.SuspendLayout();
            card2.SuspendLayout();
            card1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.White;
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnSettings);
            pnlSidebar.Controls.Add(btnRecruit);
            pnlSidebar.Controls.Add(btnSalary);
            pnlSidebar.Controls.Add(btnTimekeeping);
            pnlSidebar.Controls.Add(btnEmployee);
            pnlSidebar.Controls.Add(pnlLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(260, 700);
            pnlSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogout.ForeColor = Color.IndianRed;
            btnLogout.Location = new Point(0, 640);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(30, 0, 0, 0);
            btnLogout.Size = new Size(260, 60);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "🚪 Đăng xuất";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 11F);
            btnSettings.ForeColor = Color.FromArgb(64, 64, 64);
            btnSettings.Location = new Point(0, 340);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(30, 0, 0, 0);
            btnSettings.Size = new Size(260, 60);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "⚙  Cài đặt";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnFeature_Click;
            // 
            // btnRecruit
            // 
            btnRecruit.Dock = DockStyle.Top;
            btnRecruit.FlatAppearance.BorderSize = 0;
            btnRecruit.FlatStyle = FlatStyle.Flat;
            btnRecruit.Font = new Font("Segoe UI", 11F);
            btnRecruit.ForeColor = Color.FromArgb(64, 64, 64);
            btnRecruit.Location = new Point(0, 280);
            btnRecruit.Name = "btnRecruit";
            btnRecruit.Padding = new Padding(30, 0, 0, 0);
            btnRecruit.Size = new Size(260, 60);
            btnRecruit.TabIndex = 4;
            btnRecruit.Text = "\U0001f91d  Tuyển dụng";
            btnRecruit.TextAlign = ContentAlignment.MiddleLeft;
            btnRecruit.UseVisualStyleBackColor = true;
            btnRecruit.Click += btnFeature_Click;
            // 
            // btnSalary
            // 
            btnSalary.Dock = DockStyle.Top;
            btnSalary.FlatAppearance.BorderSize = 0;
            btnSalary.FlatStyle = FlatStyle.Flat;
            btnSalary.Font = new Font("Segoe UI", 11F);
            btnSalary.ForeColor = Color.FromArgb(64, 64, 64);
            btnSalary.Location = new Point(0, 220);
            btnSalary.Name = "btnSalary";
            btnSalary.Padding = new Padding(30, 0, 0, 0);
            btnSalary.Size = new Size(260, 60);
            btnSalary.TabIndex = 3;
            btnSalary.Text = "💰  Quản lý Lương";
            btnSalary.TextAlign = ContentAlignment.MiddleLeft;
            btnSalary.UseVisualStyleBackColor = true;
            btnSalary.Click += btnFeature_Click;
            // 
            // btnTimekeeping
            // 
            btnTimekeeping.Dock = DockStyle.Top;
            btnTimekeeping.FlatAppearance.BorderSize = 0;
            btnTimekeeping.FlatStyle = FlatStyle.Flat;
            btnTimekeeping.Font = new Font("Segoe UI", 11F);
            btnTimekeeping.ForeColor = Color.FromArgb(64, 64, 64);
            btnTimekeeping.Location = new Point(0, 160);
            btnTimekeeping.Name = "btnTimekeeping";
            btnTimekeeping.Padding = new Padding(30, 0, 0, 0);
            btnTimekeeping.Size = new Size(260, 60);
            btnTimekeeping.TabIndex = 2;
            btnTimekeeping.Text = "📅  Chấm công";
            btnTimekeeping.TextAlign = ContentAlignment.MiddleLeft;
            btnTimekeeping.UseVisualStyleBackColor = true;
            btnTimekeeping.Click += btnFeature_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Dock = DockStyle.Top;
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Segoe UI", 11F);
            btnEmployee.ForeColor = Color.FromArgb(64, 64, 64);
            btnEmployee.Location = new Point(0, 100);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Padding = new Padding(30, 0, 0, 0);
            btnEmployee.Size = new Size(260, 60);
            btnEmployee.TabIndex = 1;
            btnEmployee.Text = "👥  Quản lý Nhân viên";
            btnEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(lblLogo);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(260, 100);
            pnlLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(255, 148, 166);
            lblLogo.Location = new Point(30, 25);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(173, 50);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Trang🌸";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(260, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(920, 80);
            pnlHeader.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblWelcome.ForeColor = Color.Gray;
            lblWelcome.Location = new Point(750, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(136, 23);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Xin chào, Admin!";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(304, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Dashboard Tổng Quan";
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.WhiteSmoke;
            pnlBody.Controls.Add(pnlBottom);
            pnlBody.Controls.Add(pnlCards);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(260, 80);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(30);
            pnlBody.Size = new Size(920, 620);
            pnlBody.TabIndex = 2;
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(pnlActivity);
            pnlBottom.Controls.Add(pnlChart);
            pnlBottom.Dock = DockStyle.Fill;
            pnlBottom.Location = new Point(30, 190);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(0, 20, 0, 0);
            pnlBottom.Size = new Size(860, 400);
            pnlBottom.TabIndex = 1;
            // 
            // pnlActivity
            // 
            pnlActivity.BackColor = Color.White;
            pnlActivity.Controls.Add(lblActivityList);
            pnlActivity.Controls.Add(lblActivityTitle);
            pnlActivity.Dock = DockStyle.Right;
            pnlActivity.Location = new Point(440, 20);
            pnlActivity.Name = "pnlActivity";
            pnlActivity.Size = new Size(420, 380);
            pnlActivity.TabIndex = 1;
            // 
            // lblActivityList
            // 
            lblActivityList.AutoSize = true;
            lblActivityList.Font = new Font("Segoe UI", 10F);
            lblActivityList.ForeColor = Color.DimGray;
            lblActivityList.Location = new Point(20, 70);
            lblActivityList.Name = "lblActivityList";
            lblActivityList.Size = new Size(348, 161);
            lblActivityList.TabIndex = 0;
            lblActivityList.Text = "• Nguyễn Văn A vừa cập nhật hồ sơ\n\n• Đã phê duyệt nghỉ phép cho Trần Thị B\n\n• Có 3 ứng viên mới nộp hồ sơ vào vị trí Dev\n\n• Hệ thống đã sao lưu dữ liệu lúc 12:00";
            // 
            // lblActivityTitle
            // 
            lblActivityTitle.AutoSize = true;
            lblActivityTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblActivityTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblActivityTitle.Location = new Point(20, 20);
            lblActivityTitle.Name = "lblActivityTitle";
            lblActivityTitle.Size = new Size(195, 28);
            lblActivityTitle.TabIndex = 1;
            lblActivityTitle.Text = "Hoạt động gần đây";
            // 
            // pnlChart
            // 
            pnlChart.BackColor = Color.White;
            pnlChart.Controls.Add(lblSales);
            pnlChart.Controls.Add(pgbSales);
            pnlChart.Controls.Add(lblHR);
            pnlChart.Controls.Add(pgbHR);
            pnlChart.Controls.Add(lblIT);
            pnlChart.Controls.Add(pgbIT);
            pnlChart.Controls.Add(lblChartTitle);
            pnlChart.Dock = DockStyle.Left;
            pnlChart.Location = new Point(0, 20);
            pnlChart.Name = "pnlChart";
            pnlChart.Size = new Size(420, 380);
            pnlChart.TabIndex = 0;
            // 
            // lblSales
            // 
            lblSales.AutoSize = true;
            lblSales.Location = new Point(20, 210);
            lblSales.Name = "lblSales";
            lblSales.Size = new Size(172, 20);
            lblSales.TabIndex = 0;
            lblSales.Text = "Phòng Kinh doanh (35%)";
            // 
            // pgbSales
            // 
            pgbSales.Location = new Point(20, 235);
            pgbSales.Name = "pgbSales";
            pgbSales.Size = new Size(350, 20);
            pgbSales.TabIndex = 1;
            pgbSales.Value = 35;
            // 
            // lblHR
            // 
            lblHR.AutoSize = true;
            lblHR.Location = new Point(20, 140);
            lblHR.Name = "lblHR";
            lblHR.Size = new Size(171, 20);
            lblHR.TabIndex = 2;
            lblHR.Text = "Phòng Hành chính (25%)";
            // 
            // pgbHR
            // 
            pgbHR.Location = new Point(20, 165);
            pgbHR.Name = "pgbHR";
            pgbHR.Size = new Size(350, 20);
            pgbHR.TabIndex = 3;
            pgbHR.Value = 25;
            // 
            // lblIT
            // 
            lblIT.AutoSize = true;
            lblIT.Location = new Point(20, 70);
            lblIT.Name = "lblIT";
            lblIT.Size = new Size(109, 20);
            lblIT.TabIndex = 4;
            lblIT.Text = "Phòng IT (40%)";
            // 
            // pgbIT
            // 
            pgbIT.Location = new Point(20, 95);
            pgbIT.Name = "pgbIT";
            pgbIT.Size = new Size(350, 20);
            pgbIT.TabIndex = 5;
            pgbIT.Value = 40;
            // 
            // lblChartTitle
            // 
            lblChartTitle.AutoSize = true;
            lblChartTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblChartTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblChartTitle.Location = new Point(20, 20);
            lblChartTitle.Name = "lblChartTitle";
            lblChartTitle.Size = new Size(330, 28);
            lblChartTitle.TabIndex = 6;
            lblChartTitle.Text = "Phân bổ Nhân sự theo Phòng ban";
            // 
            // pnlCards
            // 
            pnlCards.Controls.Add(card4);
            pnlCards.Controls.Add(card3);
            pnlCards.Controls.Add(card2);
            pnlCards.Controls.Add(card1);
            pnlCards.Dock = DockStyle.Top;
            pnlCards.Location = new Point(30, 30);
            pnlCards.Name = "pnlCards";
            pnlCards.Size = new Size(860, 160);
            pnlCards.TabIndex = 0;
            // 
            // card4
            // 
            card4.BackColor = Color.White;
            card4.Controls.Add(lblNumContract);
            card4.Controls.Add(lblTitleContract);
            card4.Location = new Point(660, 10);
            card4.Name = "card4";
            card4.Size = new Size(200, 140);
            card4.TabIndex = 3;
            // 
            // lblNumContract
            // 
            lblNumContract.AutoSize = true;
            lblNumContract.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblNumContract.ForeColor = Color.FromArgb(241, 196, 15);
            lblNumContract.Location = new Point(20, 50);
            lblNumContract.Name = "lblNumContract";
            lblNumContract.Size = new Size(54, 62);
            lblNumContract.TabIndex = 0;
            lblNumContract.Text = "4";
            // 
            // lblTitleContract
            // 
            lblTitleContract.AutoSize = true;
            lblTitleContract.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitleContract.ForeColor = Color.Gray;
            lblTitleContract.Location = new Point(20, 20);
            lblTitleContract.Name = "lblTitleContract";
            lblTitleContract.Size = new Size(110, 23);
            lblTitleContract.TabIndex = 1;
            lblTitleContract.Text = "SẮP HẾT HĐ";
            // 
            // card3
            // 
            card3.BackColor = Color.White;
            card3.Controls.Add(lblNumAbsent);
            card3.Controls.Add(lblTitleAbsent);
            card3.Location = new Point(440, 10);
            card3.Name = "card3";
            card3.Size = new Size(200, 140);
            card3.TabIndex = 2;
            // 
            // lblNumAbsent
            // 
            lblNumAbsent.AutoSize = true;
            lblNumAbsent.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblNumAbsent.ForeColor = Color.FromArgb(231, 76, 60);
            lblNumAbsent.Location = new Point(20, 50);
            lblNumAbsent.Name = "lblNumAbsent";
            lblNumAbsent.Size = new Size(54, 62);
            lblNumAbsent.TabIndex = 0;
            lblNumAbsent.Text = "2";
            // 
            // lblTitleAbsent
            // 
            lblTitleAbsent.AutoSize = true;
            lblTitleAbsent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitleAbsent.ForeColor = Color.Gray;
            lblTitleAbsent.Location = new Point(20, 20);
            lblTitleAbsent.Name = "lblTitleAbsent";
            lblTitleAbsent.Size = new Size(144, 23);
            lblTitleAbsent.TabIndex = 1;
            lblTitleAbsent.Text = "VẮNG HÔM NAY";
            // 
            // card2
            // 
            card2.BackColor = Color.White;
            card2.Controls.Add(lblNumNew);
            card2.Controls.Add(lblTitleNew);
            card2.Location = new Point(220, 10);
            card2.Name = "card2";
            card2.Size = new Size(200, 140);
            card2.TabIndex = 1;
            // 
            // lblNumNew
            // 
            lblNumNew.AutoSize = true;
            lblNumNew.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblNumNew.ForeColor = Color.FromArgb(46, 204, 113);
            lblNumNew.Location = new Point(20, 50);
            lblNumNew.Name = "lblNumNew";
            lblNumNew.Size = new Size(54, 62);
            lblNumNew.TabIndex = 0;
            lblNumNew.Text = "5";
            // 
            // lblTitleNew
            // 
            lblTitleNew.AutoSize = true;
            lblTitleNew.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitleNew.ForeColor = Color.Gray;
            lblTitleNew.Location = new Point(20, 20);
            lblTitleNew.Name = "lblTitleNew";
            lblTitleNew.Size = new Size(143, 23);
            lblTitleNew.TabIndex = 1;
            lblTitleNew.Text = "NHÂN VIÊN MỚI";
            // 
            // card1
            // 
            card1.BackColor = Color.White;
            card1.Controls.Add(lblNumTotal);
            card1.Controls.Add(lblTitleTotal);
            card1.Location = new Point(0, 10);
            card1.Name = "card1";
            card1.Size = new Size(200, 140);
            card1.TabIndex = 0;
            // 
            // lblNumTotal
            // 
            lblNumTotal.AutoSize = true;
            lblNumTotal.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblNumTotal.ForeColor = Color.FromArgb(255, 148, 166);
            lblNumTotal.Location = new Point(20, 50);
            lblNumTotal.Name = "lblNumTotal";
            lblNumTotal.Size = new Size(108, 62);
            lblNumTotal.TabIndex = 0;
            lblNumTotal.Text = "128";
            // 
            // lblTitleTotal
            // 
            lblTitleTotal.AutoSize = true;
            lblTitleTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitleTotal.ForeColor = Color.Gray;
            lblTitleTotal.Location = new Point(20, 20);
            lblTitleTotal.Name = "lblTitleTotal";
            lblTitleTotal.Size = new Size(142, 23);
            lblTitleTotal.TabIndex = 1;
            lblTitleTotal.Text = "TỔNG NHÂN SỰ";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 700);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản lý Nhân sự Pro";
            pnlSidebar.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlBottom.ResumeLayout(false);
            pnlActivity.ResumeLayout(false);
            pnlActivity.PerformLayout();
            pnlChart.ResumeLayout(false);
            pnlChart.PerformLayout();
            pnlCards.ResumeLayout(false);
            card4.ResumeLayout(false);
            card4.PerformLayout();
            card3.ResumeLayout(false);
            card3.PerformLayout();
            card2.ResumeLayout(false);
            card2.PerformLayout();
            card1.ResumeLayout(false);
            card1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Biến Control
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnTimekeeping;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnRecruit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;

        // Cards Section
        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Panel card1;
        private System.Windows.Forms.Label lblNumTotal;
        private System.Windows.Forms.Label lblTitleTotal;
        private System.Windows.Forms.Panel card2;
        private System.Windows.Forms.Label lblNumNew;
        private System.Windows.Forms.Label lblTitleNew;
        private System.Windows.Forms.Panel card3;
        private System.Windows.Forms.Label lblNumAbsent;
        private System.Windows.Forms.Label lblTitleAbsent;
        private System.Windows.Forms.Panel card4;
        private System.Windows.Forms.Label lblNumContract;
        private System.Windows.Forms.Label lblTitleContract;

        // Bottom Section
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlChart;
        private System.Windows.Forms.Label lblChartTitle;
        private System.Windows.Forms.Panel pnlActivity;
        private System.Windows.Forms.Label lblActivityTitle;
        private System.Windows.Forms.Label lblActivityList;
        private System.Windows.Forms.ProgressBar pgbIT;
        private System.Windows.Forms.Label lblIT;
        private System.Windows.Forms.ProgressBar pgbHR;
        private System.Windows.Forms.Label lblHR;
        private System.Windows.Forms.ProgressBar pgbSales;
        private System.Windows.Forms.Label lblSales;
    }
}