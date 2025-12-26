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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnRecruit = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlActivity = new System.Windows.Forms.Panel();
            this.lblActivityList = new System.Windows.Forms.Label();
            this.lblActivityTitle = new System.Windows.Forms.Label();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.lblSales = new System.Windows.Forms.Label();
            this.pgbSales = new System.Windows.Forms.ProgressBar();
            this.lblHR = new System.Windows.Forms.Label();
            this.pgbHR = new System.Windows.Forms.ProgressBar();
            this.lblIT = new System.Windows.Forms.Label();
            this.pgbIT = new System.Windows.Forms.ProgressBar();
            this.lblChartTitle = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.Panel();
            this.card4 = new System.Windows.Forms.Panel();
            this.lblNumContract = new System.Windows.Forms.Label();
            this.lblTitleContract = new System.Windows.Forms.Label();
            this.card3 = new System.Windows.Forms.Panel();
            this.lblNumAbsent = new System.Windows.Forms.Label();
            this.lblTitleAbsent = new System.Windows.Forms.Label();
            this.card2 = new System.Windows.Forms.Panel();
            this.lblNumNew = new System.Windows.Forms.Label();
            this.lblTitleNew = new System.Windows.Forms.Label();
            this.card1 = new System.Windows.Forms.Panel();
            this.lblNumTotal = new System.Windows.Forms.Label();
            this.lblTitleTotal = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlActivity.SuspendLayout();
            this.pnlChart.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.card4.SuspendLayout();
            this.card3.SuspendLayout();
            this.card2.SuspendLayout();
            this.card1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnSettings);
            this.pnlSidebar.Controls.Add(this.btnRecruit);
            this.pnlSidebar.Controls.Add(this.btnSalary);
            this.pnlSidebar.Controls.Add(this.btnChamCong);
            this.pnlSidebar.Controls.Add(this.btnEmployee);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(260, 700);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.IndianRed;
            this.btnLogout.Location = new System.Drawing.Point(0, 640);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(260, 60);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "🚪 Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSettings.Location = new System.Drawing.Point(0, 340);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(260, 60);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "⚙  Cài đặt";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = true;
            // --- QUAN TRỌNG: Gán sự kiện cho nút Cài đặt ---
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnRecruit
            // 
            this.btnRecruit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecruit.FlatAppearance.BorderSize = 0;
            this.btnRecruit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecruit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnRecruit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRecruit.Location = new System.Drawing.Point(0, 280);
            this.btnRecruit.Name = "btnRecruit";
            this.btnRecruit.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnRecruit.Size = new System.Drawing.Size(260, 60);
            this.btnRecruit.TabIndex = 4;
            this.btnRecruit.Text = "🤝  Tuyển dụng";
            this.btnRecruit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecruit.UseVisualStyleBackColor = true;
            this.btnRecruit.Click += new System.EventHandler(this.btnRecruit_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalary.FlatAppearance.BorderSize = 0;
            this.btnSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalary.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalary.Location = new System.Drawing.Point(0, 220);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSalary.Size = new System.Drawing.Size(260, 60);
            this.btnSalary.TabIndex = 3;
            this.btnSalary.Text = "💰  Quản lý Lương";
            this.btnSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnChamCong
            // 
            this.btnChamCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChamCong.FlatAppearance.BorderSize = 0;
            this.btnChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamCong.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnChamCong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChamCong.Location = new System.Drawing.Point(0, 160);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnChamCong.Size = new System.Drawing.Size(260, 60);
            this.btnChamCong.TabIndex = 2;
            this.btnChamCong.Text = "📅  Quản lý Chấm công";
            this.btnChamCong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamCong.UseVisualStyleBackColor = true;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEmployee.Location = new System.Drawing.Point(0, 100);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(260, 60);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "👥  Quản lý Nhân viên";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(260, 100);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(166)))));
            this.lblLogo.Location = new System.Drawing.Point(30, 25);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(173, 50);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Trang🌸";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(260, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(920, 80);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblWelcome.ForeColor = System.Drawing.Color.Gray;
            this.lblWelcome.Location = new System.Drawing.Point(750, 30);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(136, 23);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Xin chào, Admin!";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(304, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Dashboard Tổng Quan";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBody.Controls.Add(this.pnlBottom);
            this.pnlBody.Controls.Add(this.pnlCards);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(260, 80);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(30);
            this.pnlBody.Size = new System.Drawing.Size(920, 620);
            this.pnlBody.TabIndex = 2;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.pnlActivity);
            this.pnlBottom.Controls.Add(this.pnlChart);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(30, 190);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.pnlBottom.Size = new System.Drawing.Size(860, 400);
            this.pnlBottom.TabIndex = 1;
            // 
            // pnlActivity
            // 
            this.pnlActivity.BackColor = System.Drawing.Color.White;
            this.pnlActivity.Controls.Add(this.lblActivityList);
            this.pnlActivity.Controls.Add(this.lblActivityTitle);
            this.pnlActivity.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlActivity.Location = new System.Drawing.Point(440, 20);
            this.pnlActivity.Name = "pnlActivity";
            this.pnlActivity.Size = new System.Drawing.Size(420, 380);
            this.pnlActivity.TabIndex = 1;
            // 
            // lblActivityList
            // 
            this.lblActivityList.AutoSize = true;
            this.lblActivityList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblActivityList.ForeColor = System.Drawing.Color.DimGray;
            this.lblActivityList.Location = new System.Drawing.Point(20, 70);
            this.lblActivityList.Name = "lblActivityList";
            this.lblActivityList.Size = new System.Drawing.Size(348, 161);
            this.lblActivityList.TabIndex = 0;
            this.lblActivityList.Text = "• Nguyễn Văn A vừa cập nhật hồ sơ\n\n• Đã phê duyệt nghỉ phép cho Trần Thị B\n\n• Có " +
    "3 ứng viên mới nộp hồ sơ vào vị trí Dev\n\n• Hệ thống đã sao lưu dữ liệu lúc 12:00" +
    "";
            // 
            // lblActivityTitle
            // 
            this.lblActivityTitle.AutoSize = true;
            this.lblActivityTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblActivityTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblActivityTitle.Location = new System.Drawing.Point(20, 20);
            this.lblActivityTitle.Name = "lblActivityTitle";
            this.lblActivityTitle.Size = new System.Drawing.Size(195, 28);
            this.lblActivityTitle.TabIndex = 1;
            this.lblActivityTitle.Text = "Hoạt động gần đây";
            // 
            // pnlChart
            // 
            this.pnlChart.BackColor = System.Drawing.Color.White;
            this.pnlChart.Controls.Add(this.lblSales);
            this.pnlChart.Controls.Add(this.pgbSales);
            this.pnlChart.Controls.Add(this.lblHR);
            this.pnlChart.Controls.Add(this.pgbHR);
            this.pnlChart.Controls.Add(this.lblIT);
            this.pnlChart.Controls.Add(this.pgbIT);
            this.pnlChart.Controls.Add(this.lblChartTitle);
            this.pnlChart.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlChart.Location = new System.Drawing.Point(0, 20);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(420, 380);
            this.pnlChart.TabIndex = 0;
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(20, 210);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(172, 20);
            this.lblSales.TabIndex = 0;
            this.lblSales.Text = "Phòng Kinh doanh (35%)";
            // 
            // pgbSales
            // 
            this.pgbSales.Location = new System.Drawing.Point(20, 235);
            this.pgbSales.Name = "pgbSales";
            this.pgbSales.Size = new System.Drawing.Size(350, 20);
            this.pgbSales.TabIndex = 1;
            this.pgbSales.Value = 35;
            // 
            // lblHR
            // 
            this.lblHR.AutoSize = true;
            this.lblHR.Location = new System.Drawing.Point(20, 140);
            this.lblHR.Name = "lblHR";
            this.lblHR.Size = new System.Drawing.Size(171, 20);
            this.lblHR.TabIndex = 2;
            this.lblHR.Text = "Phòng Hành chính (25%)";
            // 
            // pgbHR
            // 
            this.pgbHR.Location = new System.Drawing.Point(20, 165);
            this.pgbHR.Name = "pgbHR";
            this.pgbHR.Size = new System.Drawing.Size(350, 20);
            this.pgbHR.TabIndex = 3;
            this.pgbHR.Value = 25;
            // 
            // lblIT
            // 
            this.lblIT.AutoSize = true;
            this.lblIT.Location = new System.Drawing.Point(20, 70);
            this.lblIT.Name = "lblIT";
            this.lblIT.Size = new System.Drawing.Size(109, 20);
            this.lblIT.TabIndex = 4;
            this.lblIT.Text = "Phòng IT (40%)";
            // 
            // pgbIT
            // 
            this.pgbIT.Location = new System.Drawing.Point(20, 95);
            this.pgbIT.Name = "pgbIT";
            this.pgbIT.Size = new System.Drawing.Size(350, 20);
            this.pgbIT.TabIndex = 5;
            this.pgbIT.Value = 40;
            // 
            // lblChartTitle
            // 
            this.lblChartTitle.AutoSize = true;
            this.lblChartTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblChartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblChartTitle.Location = new System.Drawing.Point(20, 20);
            this.lblChartTitle.Name = "lblChartTitle";
            this.lblChartTitle.Size = new System.Drawing.Size(330, 28);
            this.lblChartTitle.TabIndex = 6;
            this.lblChartTitle.Text = "Phân bổ Nhân sự theo Phòng ban";
            // 
            // pnlCards
            // 
            this.pnlCards.Controls.Add(this.card4);
            this.pnlCards.Controls.Add(this.card3);
            this.pnlCards.Controls.Add(this.card2);
            this.pnlCards.Controls.Add(this.card1);
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Location = new System.Drawing.Point(30, 30);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Size = new System.Drawing.Size(860, 160);
            this.pnlCards.TabIndex = 0;
            // 
            // card4
            // 
            this.card4.BackColor = System.Drawing.Color.White;
            this.card4.Controls.Add(this.lblNumContract);
            this.card4.Controls.Add(this.lblTitleContract);
            this.card4.Location = new System.Drawing.Point(660, 10);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(200, 140);
            this.card4.TabIndex = 3;
            // 
            // lblNumContract
            // 
            this.lblNumContract.AutoSize = true;
            this.lblNumContract.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblNumContract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.lblNumContract.Location = new System.Drawing.Point(20, 50);
            this.lblNumContract.Name = "lblNumContract";
            this.lblNumContract.Size = new System.Drawing.Size(54, 62);
            this.lblNumContract.TabIndex = 0;
            this.lblNumContract.Text = "4";
            // 
            // lblTitleContract
            // 
            this.lblTitleContract.AutoSize = true;
            this.lblTitleContract.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitleContract.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleContract.Location = new System.Drawing.Point(20, 20);
            this.lblTitleContract.Name = "lblTitleContract";
            this.lblTitleContract.Size = new System.Drawing.Size(110, 23);
            this.lblTitleContract.TabIndex = 1;
            this.lblTitleContract.Text = "SẮP HẾT HĐ";
            // 
            // card3
            // 
            this.card3.BackColor = System.Drawing.Color.White;
            this.card3.Controls.Add(this.lblNumAbsent);
            this.card3.Controls.Add(this.lblTitleAbsent);
            this.card3.Location = new System.Drawing.Point(440, 10);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(200, 140);
            this.card3.TabIndex = 2;
            // 
            // lblNumAbsent
            // 
            this.lblNumAbsent.AutoSize = true;
            this.lblNumAbsent.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblNumAbsent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblNumAbsent.Location = new System.Drawing.Point(20, 50);
            this.lblNumAbsent.Name = "lblNumAbsent";
            this.lblNumAbsent.Size = new System.Drawing.Size(54, 62);
            this.lblNumAbsent.TabIndex = 0;
            this.lblNumAbsent.Text = "2";
            // 
            // lblTitleAbsent
            // 
            this.lblTitleAbsent.AutoSize = true;
            this.lblTitleAbsent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitleAbsent.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleAbsent.Location = new System.Drawing.Point(20, 20);
            this.lblTitleAbsent.Name = "lblTitleAbsent";
            this.lblTitleAbsent.Size = new System.Drawing.Size(144, 23);
            this.lblTitleAbsent.TabIndex = 1;
            this.lblTitleAbsent.Text = "VẮNG HÔM NAY";
            // 
            // card2
            // 
            this.card2.BackColor = System.Drawing.Color.White;
            this.card2.Controls.Add(this.lblNumNew);
            this.card2.Controls.Add(this.lblTitleNew);
            this.card2.Location = new System.Drawing.Point(220, 10);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(200, 140);
            this.card2.TabIndex = 1;
            // 
            // lblNumNew
            // 
            this.lblNumNew.AutoSize = true;
            this.lblNumNew.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblNumNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblNumNew.Location = new System.Drawing.Point(20, 50);
            this.lblNumNew.Name = "lblNumNew";
            this.lblNumNew.Size = new System.Drawing.Size(54, 62);
            this.lblNumNew.TabIndex = 0;
            this.lblNumNew.Text = "5";
            // 
            // lblTitleNew
            // 
            this.lblTitleNew.AutoSize = true;
            this.lblTitleNew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitleNew.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleNew.Location = new System.Drawing.Point(20, 20);
            this.lblTitleNew.Name = "lblTitleNew";
            this.lblTitleNew.Size = new System.Drawing.Size(143, 23);
            this.lblTitleNew.TabIndex = 1;
            this.lblTitleNew.Text = "NHÂN VIÊN MỚI";
            // 
            // card1
            // 
            this.card1.BackColor = System.Drawing.Color.White;
            this.card1.Controls.Add(this.lblNumTotal);
            this.card1.Controls.Add(this.lblTitleTotal);
            this.card1.Location = new System.Drawing.Point(0, 10);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(200, 140);
            this.card1.TabIndex = 0;
            // 
            // lblNumTotal
            // 
            this.lblNumTotal.AutoSize = true;
            this.lblNumTotal.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblNumTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(166)))));
            this.lblNumTotal.Location = new System.Drawing.Point(20, 50);
            this.lblNumTotal.Name = "lblNumTotal";
            this.lblNumTotal.Size = new System.Drawing.Size(108, 62);
            this.lblNumTotal.TabIndex = 0;
            this.lblNumTotal.Text = "128";
            // 
            // lblTitleTotal
            // 
            this.lblTitleTotal.AutoSize = true;
            this.lblTitleTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitleTotal.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleTotal.Location = new System.Drawing.Point(20, 20);
            this.lblTitleTotal.Name = "lblTitleTotal";
            this.lblTitleTotal.Size = new System.Drawing.Size(142, 23);
            this.lblTitleTotal.TabIndex = 1;
            this.lblTitleTotal.Text = "TỔNG NHÂN SỰ";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 700);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Nhân sự Pro";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlActivity.ResumeLayout(false);
            this.pnlActivity.PerformLayout();
            this.pnlChart.ResumeLayout(false);
            this.pnlChart.PerformLayout();
            this.pnlCards.ResumeLayout(false);
            this.card4.ResumeLayout(false);
            this.card4.PerformLayout();
            this.card3.ResumeLayout(false);
            this.card3.PerformLayout();
            this.card2.ResumeLayout(false);
            this.card2.PerformLayout();
            this.card1.ResumeLayout(false);
            this.card1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        // Biến Control
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnChamCong;
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