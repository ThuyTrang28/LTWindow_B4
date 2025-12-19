using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace Article21
{
    // Cần đảm bảo lớp Employee có thể truy cập được (ví dụ: đặt trong cùng namespace)
    public partial class Form1 : Form
    {
        // Khai báo danh sách nhân viên
        List<Employee> lst = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
        }

        // Phương thức tạo dữ liệu mẫu (Slide 141)
        public List<Employee> GetData()
        {
            List<Employee> lst = new List<Employee>();

            // Nhân viên 1: Trần Tiến
            Employee em = new Employee();
            em.Id = "53418";
            em.Name = "Trần Tiến";
            em.Age = 20;
            // Giới tính mặc định là true (Nam) theo hình ảnh hiển thị
            em.Gender = true;
            lst.Add(em);

            // Nhân viên 2: Nguyễn Cường
            em = new Employee();
            em.Id = "53416";
            em.Name = "Nguyễn Cường";
            em.Age = 25;
            em.Gender = false; // Giới tính mặc định là false (Nữ)
            lst.Add(em);

            // Nhân viên 3: Nguyễn Hảo
            em = new Employee();
            em.Id = "53417";
            em.Name = "Nguyễn Hảo";
            em.Age = 23;
            em.Gender = true;
            lst.Add(em);

            return lst;
        }

        // Sự kiện Form Load: Đổ dữ liệu từ List vào DataGridView (Slide 142)
        private void Form1_Load(object sender, EventArgs e)
        {
            lst = GetData();

            // Thêm các nhân viên vào DataGridView
            foreach (Employee em in lst)
            {
                // Thêm Id, Name, Age và Gender (giá trị boolean)
                dgvEmployee.Rows.Add(em.Id, em.Name, em.Age, em.Gender);
            }
        }

        // Sự kiện Click nút Thêm (btAddNew_Click) (Slide 143)
        private void btAddNew_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng Employee mới từ dữ liệu nhập
            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;

            // Xử lý chuyển đổi tuổi
            if (int.TryParse(tbAge.Text, out int ageValue)) { em.Age = ageValue; }
            {
                em.Age = ageValue;
            }
            // Giới tính được lấy từ CheckBox
            em.Gender = ckGender.Checked;

            // Thêm vào List
            lst.Add(em);

            // Thêm vào DataGridView
            dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked);

            // Xóa nội dung Textbox sau khi thêm (Tùy chọn)
            tbId.Clear();
            tbName.Clear();
            tbAge.Clear();
            ckGender.Checked = false;
        }

        // Sự kiện Click nút Xóa (btDelete_Click) (Slide 144)
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentCell != null)
            {
                int idx = dgvEmployee.CurrentCell.RowIndex;

                // Đảm bảo không xóa hàng trống cuối cùng
                if (idx >= 0 && idx < dgvEmployee.Rows.Count - 1)
                {
                    // Xóa khỏi List trước
                    lst.RemoveAt(idx);

                    // Xóa khỏi DataGridView
                    dgvEmployee.Rows.RemoveAt(idx);
                }
            }
        }

        // Sự kiện RowEnter: Hiển thị chi tiết khi chọn một hàng (Slide 144)
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;

            // Kiểm tra hàng hợp lệ (không phải hàng trống cuối cùng)
            if (idx >= 0 && idx < dgvEmployee.Rows.Count - 1)
            {
                // Lấy dữ liệu từ các ô (Cells) và đổ vào TextBoxes/CheckBox
                // Giả sử thứ tự cột: [0]=Id, [1]=Name, [2]=Age, [3]=Gender
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();

                // Gender là boolean
                bool genderValue;
                if (bool.TryParse(dgvEmployee.Rows[idx].Cells[3].Value.ToString(), out genderValue))
                {
                    ckGender.Checked = genderValue;
                }
                else
                {
                    ckGender.Checked = false;
                }
            }
        }
    }
}