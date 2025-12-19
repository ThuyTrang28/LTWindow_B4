using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing; // Cần thiết cho các cấu hình cơ bản của Form

namespace Article15
{
    // ----------------------------------------------------------------------
    // 1. CLASS STUDENT (Định nghĩa cấu trúc dữ liệu Sinh viên)
    // ----------------------------------------------------------------------
    public class Student
    {
        public string FullName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string Faculty { get; set; } = string.Empty;

        // Ghi đè phương thức ToString() để ListBox hiển thị chi tiết (theo định dạng ảnh)
        public override string ToString()
        {
            // Các ký tự \r\n (xuống dòng) giúp hiển thị từng thông tin trên một dòng trong ListBox
            return $" -Giới tính: {Gender}\r\n -Ngày Sinh: {DateOfBirth.ToString("dd/MM/yyyy")}\r\n -Khoa: {Faculty}";
        }
    }

    // ----------------------------------------------------------------------
    // 2. FORM1 (Chứa logic xử lý)
    // ----------------------------------------------------------------------
    public partial class Form1 : Form
    {
        // Khai báo danh sách để lưu trữ đối tượng Student
        private List<Student> studentList = new List<Student>();

        public Form1()
        {
            InitializeComponent();

            // Liên kết sự kiện Click cho các nút (nếu chưa làm trong Designer)
            btnThem.Click += new EventHandler(btnThem_Click);
            btnThoat.Click += new EventHandler(btnThoat_Click);
        }

        // ----------------------------------------------------------------------
        // 3. SỰ KIỆN FORM_LOAD (Tải dữ liệu ban đầu)
        // ----------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo dữ liệu cho ComboBox Khoa
            cboKhoa.Items.Add("Công nghệ thông tin");
            cboKhoa.Items.Add("Quản trị kinh doanh");
            cboKhoa.Items.Add("Kế toán");
            cboKhoa.Items.Add("Ngoại ngữ");

            // Chọn mặc định mục đầu tiên
            if (cboKhoa.Items.Count > 0)
            {
                cboKhoa.SelectedIndex = 0;
            }

            // Thêm dữ liệu mẫu ban đầu (từ ảnh Slide112.JPG)
            studentList.Add(new Student
            {
                FullName = "Nguyễn Văn Rớt",
                DateOfBirth = new DateTime(1995, 10, 20),
                Gender = "Nam",
                Faculty = "Công nghệ thông tin"
            });
            studentList.Add(new Student
            {
                FullName = "Trần Thị Học Lai",
                DateOfBirth = new DateTime(1994, 7, 10),
                Gender = "Nữ",
                Faculty = "Công nghệ thông tin"
            });

            // Cập nhật ListBox sau khi thêm dữ liệu mẫu
            UpdateListBox();
        }

        // ----------------------------------------------------------------------
        // 4. PHƯƠNG THỨC CẬP NHẬT LISTBOX
        // ----------------------------------------------------------------------
        private void UpdateListBox()
        {
            lstSinhVien.Items.Clear();

            for (int i = 0; i < studentList.Count; i++)
            {
                Student s = studentList[i];
                // Thêm tiêu đề (VD: 1.Nguyễn Văn Rớt)
                lstSinhVien.Items.Add($"{i + 1}.{s.FullName}");
                // Thêm thông tin chi tiết (sử dụng Student.ToString() đã ghi đè)
                // Lưu ý: ListBox sẽ hiển thị chuỗi ToString() trên một dòng duy nhất, 
                // nhưng nhờ ký tự \r\n, nó sẽ tạo ra hiệu ứng xuống dòng trong ô hiển thị.
                lstSinhVien.Items.Add(s.ToString());
            }
        }

        // ----------------------------------------------------------------------
        // 5. SỰ KIỆN NÚT THÊM (btnThem_Click)
        // ----------------------------------------------------------------------
        private void btnThem_Click(object? sender, EventArgs e)
        {
            // A. Kiểm tra và lấy dữ liệu
            string fullName = txtHoTen.Text.Trim();
            DateTime dob = dtpNgaySinh.Value;

            if (string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Vui lòng nhập Họ và tên.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            string faculty = cboKhoa.SelectedItem?.ToString() ?? string.Empty;
            if (string.IsNullOrEmpty(faculty))
            {
                MessageBox.Show("Vui lòng chọn Khoa.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gender = rdbNam.Checked ? "Nam" : (rdbNu.Checked ? "Nữ" : "Chưa chọn");
            if (gender == "Chưa chọn")
            {
                MessageBox.Show("Vui lòng chọn Giới tính.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // B. Tạo đối tượng và thêm vào danh sách
            Student newStudent = new Student
            {
                FullName = fullName,
                DateOfBirth = dob,
                Gender = gender,
                Faculty = faculty
            };

            studentList.Add(newStudent);

            // C. Cập nhật giao diện
            UpdateListBox();

            // D. Xóa dữ liệu trên controls để nhập mới
            txtHoTen.Clear();
            rdbNu.Checked = false;
            rdbNam.Checked = false;
            dtpNgaySinh.Value = DateTime.Now; // Reset ngày sinh về ngày hiện tại hoặc mặc định
            txtHoTen.Focus();
        }

        // ----------------------------------------------------------------------
        // 6. SỰ KIỆN NÚT THOÁT (btnThoat_Click)
        // ----------------------------------------------------------------------
        private void btnThoat_Click(object? sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng Form
            }
        }
    }
}