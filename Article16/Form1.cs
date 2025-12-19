using System.Windows.Forms;
using System;
using System.Drawing;

namespace Article16
{
    // Form1 phải kế thừa System.Windows.Forms.Form
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Gọi phương thức khởi tạo Controls
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Logic khi Form được load
            this.label1.Text = "Form đã Load xong.";
        }

        // Phương thức xử lý sự kiện DateChanged cho MonthCalendar (Đã gắn trong Designer)
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;
            // textBox1 được định nghĩa trong Designer, nên có thể truy cập trực tiếp
            this.textBox1.Text = selectedDate.ToLongDateString();
            this.Text = "Ngày được chọn: " + selectedDate.ToShortDateString();
        }

        // Phương thức xử lý sự kiện Click cho Button (Cần được thêm vào, ví dụ)
        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Nút đã được nhấn!";
            MessageBox.Show("Nút Click Me đã được nhấn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}