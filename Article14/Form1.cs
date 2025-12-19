namespace Article14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Có thể thêm code khởi tạo ban đầu cho Form ở đây nếu cần
            // Ví dụ: Đảm bảo Checkbox Giảm giá không được check khi form load
            ckDiscount.Checked = false;
        }

        /// <summary>
        /// Xử lý sự kiện khi click vào nút "Tính tiền" (btRun)
        /// Mã này được trích từ Slide 106.
        /// </summary>
        private void btRun_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;
            // Khai báo và khởi tạo mức giảm giá
            // Giá trị disc = 5 trong Slide 106, nhưng giao diện hiển thị 7%. 
            // Tôi giữ theo logic trong Slide 106.
            int disc = 0;

            // 1. Kiểm tra RadioButton giới tính
            if (rbMale.Checked == true)
                msg += "Ông ";
            if (rbFemale.Checked == true)
                msg += "Bà ";

            // 2. Kiểm tra Checkbox giảm giá
            if (ckDiscount.Checked == true)
            {
                // Lấy mức giảm giá từ TextBox tbDiscount, hoặc gán cứng theo Slide 106.
                // Để code đơn giản và đúng với Slide 106, tôi gán cứng 5. 
                // Nếu muốn lấy từ tbDiscount, cần thêm TryParse.
                // Nếu lấy từ tbDiscount:
                if (int.TryParse(tbDiscount.Text, out int parsedDisc))
                {
                    disc = parsedDisc;
                }
                else
                {
                    disc = 5; // Fallback nếu không parse được
                }
            }

            // 3. Hiển thị kết quả
            // tbName.Text: là tên khách hàng (Nguyễn Văn A)
            // tbResult.Text: là TextBox hiển thị kết quả cuối cùng
            tbResult.Text = msg + tbName.Text + " được giảm " + disc.ToString() + "%" + "\r\n";
        }

        /// <summary>
        /// Xử lý sự kiện khi trạng thái của Checkbox Giảm giá (ckDiscount) thay đổi
        /// Mã này được trích từ Slide 106.
        /// </summary>
        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái "Checked" của Checkbox
            if (ckDiscount.Checked == true)
                // Nếu được check, bật TextBox nhập/hiển thị giảm giá (tbDiscount)
                tbDiscount.Enabled = true;
            else
                // Nếu không được check, tắt TextBox nhập/hiển thị giảm giá (tbDiscount)
                tbDiscount.Enabled = false;
        }

        // Lưu ý: Nút "Thoát" (btExit) chưa được gán sự kiện trong các slide.
        // Nếu muốn thêm chức năng Thoát:
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}