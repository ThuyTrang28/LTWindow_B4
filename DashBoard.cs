using System;
using System.Drawing;
using System.Windows.Forms;

namespace Article01
{
    public partial class Dashboard : Form
    {
        private Button currentButton;
        private Form activeForm;

        // Khai báo nút Home mới (nếu bạn chưa kéo thả trong designer)
        private Button btnHome;

        public Dashboard()
        {
            InitializeComponent();
            // Thêm nút Home bằng code nếu chưa có trong Designer
            SetupHomeButton();
        }

        private void SetupHomeButton()
        {
            // Tạo nút Home ở trên cùng menu
            btnHome = new Button();
            btnHome.Text = "🏠 Trang Chủ";
            btnHome.Dock = DockStyle.Top;
            btnHome.Height = 60;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.ForeColor = Color.White;
            btnHome.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            btnHome.Click += new EventHandler(btnHome_Click);

            // Thêm vào sidebar ở vị trí đầu tiên (sau logo)
            pnlSidebar.Controls.Add(btnHome);
            pnlSidebar.Controls.SetChildIndex(btnHome, pnlSidebar.Controls.Count - 2); // Đặt dưới Logo
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // --- QUAN TRỌNG: Mở trang Dashboard thống kê ngay khi chạy ---
            btnHome_Click(btnHome, null);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Mở form thống kê
            OpenChildForm(new HomeForm(), sender);
            lblTitle.Text = "Tổng Quan Hệ Thống";
        }

        // --- CÁC HÀM CŨ GIỮ NGUYÊN ---

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            ActivateButton(btnSender);
            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.pnlContent.Controls.Add(childForm);
            this.pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.White;
                    currentButton.ForeColor = Color.FromArgb(231, 111, 139);
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in pnlSidebar.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(231, 111, 139);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
                }
            }
        }

        // --- CÁC SỰ KIỆN CLICK MENU CŨ ---
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeForm(), sender);
            lblTitle.Text = "Quản Lý Hồ Sơ Nhân Viên";
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SalaryForm(), sender);
            lblTitle.Text = "Bảng Lương & Thưởng";
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AttendanceForm(), sender);
            lblTitle.Text = "Quản Lý Chấm Công";
        }

        private void btnRecruit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RecruitForm(), sender);
            lblTitle.Text = "Quản Lý Tuyển Dụng";
        }

        private void btnReward_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RewardForm(), sender);
            lblTitle.Text = "Khen Thưởng - Kỷ Luật";
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ContractForm(), sender);
            lblTitle.Text = "Hợp Đồng Lao Động";
        }

        private void btnInsurance_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InsuranceForm(), sender);
            lblTitle.Text = "Quản Lý Bảo Hiểm";
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LeaveForm(), sender);
            lblTitle.Text = "Quản Lý Nghỉ Phép";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SettingsForm(), sender);
            lblTitle.Text = "Cấu Hình Hệ Thống";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất khỏi hệ thống?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}