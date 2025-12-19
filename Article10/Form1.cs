namespace Article10
{
    public partial class Form1 : Form
    {
        // ********** KHAI BÁO BIẾN THÀNH VIÊN **********
        decimal workingMemory = 0;
        string opr = "";
        // **********************************************

        public Form1()
        {
            InitializeComponent();
            tbDisplay.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Không có logic cụ thể nào được hiển thị trong slide cho Form Load
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện thay đổi text của TextBox (nếu cần)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ********** LOGIC NÚT SỐ **********

        // Logic cho Nút 0 (Đã có)
        private void bt0_Click(object sender, EventArgs e)
        {
            // Tránh thêm số 0 thừa nếu màn hình chỉ là "0"
            if (tbDisplay.Text != "0")
            {
                tbDisplay.Text += bt0.Text;
            }
        }

        // Logic cho Nút 1 (Đã có)
        private void bt1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt1.Text;
        }

        // Logic cho Nút 2 (Đã có)
        private void bt2_Click(object sender, EventArgs e)
        {
            // Nối Text của nút bt2 vào Text hiện tại của TextBox hiển thị
            tbDisplay.Text += bt2.Text;
        }

        // Logic cho Nút 3 (MỚI)
        private void bt3_Click(object sender, EventArgs e)
        {
            // Nối Text của nút bt3 vào Text hiện tại của TextBox hiển thị
            tbDisplay.Text += "3"; // Giả định Text của bt3 là "3"
        }

        // ********** LOGIC DẤU THẬP PHÂN (btDot) **********

        private void btDot_Click(object sender, EventArgs e)
        {
            // Chỉ cho phép thêm dấu thập phân một lần duy nhất trong một số
            if (!tbDisplay.Text.Contains("."))
            {
                tbDisplay.Text += ".";
            }
        }

        // ********** LOGIC NÚT TOÁN TỬ (btPlus) **********

        private void btPlus_Click(object sender, EventArgs e)
        {
            opr = btPlus.Text;
            workingMemory = decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }

        private void btMul_Click(object sender, EventArgs e)
        {
            opr = btMul.Text;
            workingMemory = decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }

        // ********** LOGIC NÚT BẰNG (btEquals) **********

        private void btEquals_Click(object sender, EventArgs e)
        {
            decimal secondValue = decimal.Parse(tbDisplay.Text);
            decimal result = 0;

            if (opr == "+")
            {
                result = workingMemory + secondValue;
            }
            else if (opr == "*")
            {
                result = workingMemory * secondValue;
            }

            // Hiển thị kết quả
            tbDisplay.Text = result.ToString();

            workingMemory = result;
            opr = "";
        }
    }
}