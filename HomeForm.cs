using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; // Đảm bảo đã add reference System.Windows.Forms.DataVisualization

namespace Article01
{
    public partial class HomeForm : Form
    {
        // 1. Cấu hình chuỗi kết nối
        string connStr = @"Data Source=LAPTOP-6EIPC5N4\SQLNEW;Initial Catalog=sale;Integrated Security=True;TrustServerCertificate=True";

        // 2. Khai báo Control (để tạo bằng code)
        private Panel pnlTotalEmp, pnlTotalSalary, pnlTotalDept;
        private Label lblEmpCount, lblSalarySum, lblDeptCount;
        private Chart chartDept, chartGender;

        public HomeForm()
        {
            InitializeComponent();
            // Gọi hàm tạo giao diện dashboard
            SetupDashboardUI();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            // Load dữ liệu khi mở form
            LoadDashboardData();
        }

        // --- 3. HÀM TẠO GIAO DIỆN (Thay thế Designer) ---
        private void SetupDashboardUI()
        {
            this.BackColor = Color.WhiteSmoke;
            this.AutoScroll = true; // Cho phép cuộn nếu màn hình nhỏ

            // A. TẠO 3 THẺ SỐ LIỆU (CARDS)
            // Thẻ 1: Tổng Nhân Viên
            pnlTotalEmp = CreateCard("TỔNG NHÂN VIÊN", Color.FromArgb(52, 152, 219), 20, 20, out lblEmpCount);

            // Thẻ 2: Tổng Lương
            pnlTotalSalary = CreateCard("QUỸ LƯƠNG THÁNG", Color.FromArgb(46, 204, 113), 300, 20, out lblSalarySum);

            // Thẻ 3: Tổng Phòng Ban
            pnlTotalDept = CreateCard("PHÒNG BAN", Color.FromArgb(231, 76, 60), 580, 20, out lblDeptCount);

            this.Controls.Add(pnlTotalEmp);
            this.Controls.Add(pnlTotalSalary);
            this.Controls.Add(pnlTotalDept);

            // B. TẠO BIỂU ĐỒ (CHARTS)

            // Biểu đồ 1: Nhân sự theo phòng ban (Cột)
            chartDept = new Chart();
            chartDept.Location = new Point(20, 150);
            chartDept.Size = new Size(500, 350);
            ChartArea ca1 = new ChartArea("MainArea");
            chartDept.ChartAreas.Add(ca1);
            chartDept.Legends.Add(new Legend("Legend"));
            chartDept.Titles.Add("Nhân sự theo Phòng ban");
            Series s1 = new Series("NhanVien");
            s1.ChartType = SeriesChartType.Column;
            s1.IsValueShownAsLabel = true;
            chartDept.Series.Add(s1);
            this.Controls.Add(chartDept);

            // Biểu đồ 2: Tỉ lệ giới tính (Tròn)
            chartGender = new Chart();
            chartGender.Location = new Point(540, 150);
            chartGender.Size = new Size(350, 350);
            ChartArea ca2 = new ChartArea("MainArea");
            chartGender.ChartAreas.Add(ca2);
            chartGender.Legends.Add(new Legend("Legend"));
            chartGender.Titles.Add("Tỉ lệ Giới tính");
            Series s2 = new Series("GioiTinh");
            s2.ChartType = SeriesChartType.Pie; // Biểu đồ tròn
            s2.IsValueShownAsLabel = true;
            s2.LabelFormat = "#.##%"; // Hiển thị phần trăm
            chartGender.Series.Add(s2);
            this.Controls.Add(chartGender);
        }

        // Hàm hỗ trợ tạo thẻ Card đẹp
        private Panel CreateCard(string title, Color bg, int x, int y, out Label lblVal)
        {
            Panel p = new Panel();
            p.Location = new Point(x, y);
            p.Size = new Size(260, 100);
            p.BackColor = bg;

            Label lblTitle = new Label();
            lblTitle.Text = title;
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTitle.Location = new Point(10, 10);
            lblTitle.AutoSize = true;
            p.Controls.Add(lblTitle);

            lblVal = new Label();
            lblVal.Text = "Loading...";
            lblVal.ForeColor = Color.White;
            lblVal.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblVal.Location = new Point(10, 40);
            lblVal.AutoSize = true;
            p.Controls.Add(lblVal);

            return p;
        }

        // --- 4. LOAD DỮ LIỆU TỪ SQL ---
        private void LoadDashboardData()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // 1. Lấy Tổng nhân viên
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM NhanVien", conn);
                    lblEmpCount.Text = cmd.ExecuteScalar().ToString() + " người";

                    // 2. Lấy Tổng lương
                    cmd.CommandText = "SELECT SUM(LuongCoBan) FROM NhanVien";
                    object sum = cmd.ExecuteScalar();
                    lblSalarySum.Text = (sum != DBNull.Value) ? string.Format("{0:N0} đ", sum) : "0 đ";

                    // 3. Lấy Tổng phòng ban
                    cmd.CommandText = "SELECT COUNT(DISTINCT PhongBan) FROM NhanVien";
                    lblDeptCount.Text = cmd.ExecuteScalar().ToString() + " phòng";

                    // 4. Vẽ biểu đồ Phòng ban
                    SqlDataAdapter da = new SqlDataAdapter("SELECT PhongBan, COUNT(*) as SL FROM NhanVien GROUP BY PhongBan", conn);
                    DataTable dtDept = new DataTable();
                    da.Fill(dtDept);

                    chartDept.DataSource = dtDept;
                    chartDept.Series["NhanVien"].XValueMember = "PhongBan";
                    chartDept.Series["NhanVien"].YValueMembers = "SL";
                    chartDept.DataBind();

                    // 5. Vẽ biểu đồ Giới tính
                    da = new SqlDataAdapter("SELECT GioiTinh, COUNT(*) as SL FROM NhanVien GROUP BY GioiTinh", conn);
                    DataTable dtGender = new DataTable();
                    da.Fill(dtGender);

                    chartGender.DataSource = dtGender;
                    chartGender.Series["GioiTinh"].XValueMember = "GioiTinh";
                    chartGender.Series["GioiTinh"].YValueMembers = "SL";
                    chartGender.DataBind();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu Dashboard: " + ex.Message);
                }
            }
        }

        // --- 5. INITIALIZE COMPONENT (Phần này bắt buộc để Form chạy) ---
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);
        }
    }
}