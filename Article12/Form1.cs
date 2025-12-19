// File: Form1.cs (Hoàn thiện với btClear_Click)

using System;
using System.Windows.Forms;

namespace Article12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thiết lập mục được chọn ban đầu: "Quản trị kinh doanh" (Index 2)
            cb_Faculty.SelectedIndex = 2;
        }

        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hiển thị chỉ mục đã chọn
            int index = cb_Faculty.SelectedIndex;
            tbDisplay.Text = "Bạn đã chọn khoa thứ: " + index.ToString();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            // Hiển thị nội dung đã chọn
            if (cb_Faculty.SelectedItem != null)
            {
                string item = cb_Faculty.SelectedItem.ToString();
                tbDisplay.Text = "Bạn là sinh viên khoa : " + item;
            }
            else
            {
                tbDisplay.Text = "Vui lòng chọn một khoa.";
            }
        }

        // Phương thức xử lý sự kiện khi nút "Clear" được click
        private void btClear_Click(object sender, EventArgs e)
        {
            // Xóa nội dung trong TextBox hiển thị
            tbDisplay.Text = string.Empty;

            // Tùy chọn: Đặt ComboBox về trạng thái chưa chọn (-1) hoặc chọn lại mục đầu tiên (0)
            // Ví dụ: Bỏ chọn hoàn toàn
            // cb_Faculty.SelectedIndex = -1; 
        }
    }
}