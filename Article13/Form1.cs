using System;
using System.Collections;
using System.Windows.Forms;

namespace Article13
{
    // Giả sử lớp Faculty đã được định nghĩa trong file Faculty.cs
    /*
    public class Faculty
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
    */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Phương thức tạo và trả về ArrayList dữ liệu (theo Slide100.JPG)
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Faculty f = new Faculty();
            f.Id = "K01";
            f.Name = "Công nghệ thông tin";
            f.Quantity = 1200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K02";
            f.Name = "Quản trị kinh doanh";
            f.Quantity = 4200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K03"; // Đã sửa thành K03 để tránh trùng ID và demo chính xác
            f.Name = "Kế toán tài chính";
            f.Quantity = 5200;
            lst.Add(f);

            return lst;
        }

        // Sự kiện Form Load (theo Slide101.JPG)
        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            cb_Faculty.DataSource = lst;
            cb_Faculty.DisplayMember = "Name";

            // Bỏ chọn giá trị ban đầu để sự kiện SelectedValueChanged không kích hoạt ngay lập tức
            cb_Faculty.SelectedIndex = -1;
        }

        // Sự kiện SelectedValueChanged của ComboBox (theo Slide101.JPG)
        private void cb_Faculty_SelectedValueChanged(object sender, EventArgs e)
        {
            // Thiết lập ValueMember để lấy ra thuộc tính Id
            cb_Faculty.ValueMember = "Id";

            // Đảm bảo có mục được chọn trước khi chuyển đổi
            if (cb_Faculty.SelectedValue != null)
            {
                string id = cb_Faculty.SelectedValue.ToString();
                tbDisplay.Text = "Bạn đã chọn khoa có mã : " + id;
            }
        }

        // Sự kiện Click của nút OK (theo Slide101.JPG)
        private void btOK_Click(object sender, EventArgs e)
        {
            // Thiết lập ValueMember để lấy ra thuộc tính Name
            cb_Faculty.ValueMember = "Name";

            if (cb_Faculty.SelectedValue != null)
            {
                string name = cb_Faculty.SelectedValue.ToString();
                tbDisplay.Text = "Bạn đã chọn khoa có tên : " + name;
            }
        }

        // Sự kiện Click cho nút Clear
        private void btClear_Click(object sender, EventArgs e)
        {
            cb_Faculty.SelectedIndex = -1; // Bỏ chọn mục hiện tại
            tbDisplay.Clear(); // Xóa nội dung hiển thị
        }
    }
}