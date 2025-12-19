namespace Article05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // Sử dụng StreamWriter để mở tệp log để ghi dữ liệu
            // @"D:\Key_Logger.txt": Đường dẫn tệp log
            // true: Tham số này đảm bảo dữ liệu mới được ghi thêm (append) vào cuối tệp
            System.IO.StreamWriter sw = new System.IO.StreamWriter(@"E:\Key_Logger.txt", true);

            // Ghi mã phím (KeyCode) của phím vừa được nhả ra
            sw.Write(e.KeyCode);

            // Đóng StreamWriter để đảm bảo dữ liệu được ghi vào tệp
            sw.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
