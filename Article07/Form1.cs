namespace Article07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thêm logic khởi tạo nếu cần
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra:
            // 1. Ký tự nhấn có phải là Ký tự Điều khiển (Control key, ví dụ: Backspace) không?
            //    HOẶC
            // 2. Ký tự nhấn có phải là Chữ số (Digit) không?

            // Nếu ký tự KHÔNG PHẢI là Control VÀ KHÔNG PHẢI là Digit,
            // thì chúng ta chặn ký tự đó.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Đặt e.Handled = true để ngăn ký tự hiển thị trong TextBox
                e.Handled = true;
            }
        }
    }
}