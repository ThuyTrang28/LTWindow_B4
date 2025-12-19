namespace Article11
{
    public partial class Form1 : Form
    {
        // Khai báo các biến thành viên (dựa trên Slide83)
        decimal memory = 0;          // Bộ nhớ (cho MC, MR, MS, M+, M-)
        decimal workingMemory = 0;   // Giá trị toán hạng đầu tiên
        string opr = "";             // Toán tử đang chờ (*, /, +, -)

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Có thể thêm cài đặt mặc định hoặc cấu hình ban đầu ở đây nếu cần
            // Ví dụ: Đặt font cho txtDisplay
            txtDisplay.Font = new Font("Segoe UI", 16, FontStyle.Bold);
        }

        // Phương thức xử lý sự kiện cho TẤT CẢ các nút bấm (dựa trên Slide84 đến Slide90)
        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            // 1. Xử lý các nút số và dấu chấm (Slide84)
            if ((Char.IsDigit(bt.Text, 0) && bt.Text.Length == 1) || bt.Text == ".")
            {
                txtDisplay.Text += bt.Text;
            }

            // 2. Xử lý các nút toán tử cơ bản (*, /, +, -) (Slide84, Slide86)
            else if (bt.Text == "*" || bt.Text == "/" || bt.Text == "+" || bt.Text == "-")
            {
                // Lưu toán tử hiện tại
                opr = bt.Text;
                // Lưu giá trị đang hiển thị vào workingMemory
                workingMemory = decimal.Parse(txtDisplay.Text);
                // Xóa màn hình để chuẩn bị nhập toán hạng thứ hai
                txtDisplay.Clear();
            }

            // 3. Xử lý nút bằng (=) (Slide84, Slide87)
            else if (bt.Text == "=")
            {
                if (opr != "") // Chỉ tính toán nếu có toán tử đang chờ
                {
                    decimal secondValue = decimal.Parse(txtDisplay.Text);
                    switch (opr)
                    {
                        case "+":
                            txtDisplay.Text = (workingMemory + secondValue).ToString();
                            break;
                        case "-":
                            txtDisplay.Text = (workingMemory - secondValue).ToString();
                            break;
                        case "*":
                            txtDisplay.Text = (workingMemory * secondValue).ToString();
                            break;
                        case "/":
                            // Xử lý chia cho 0 nếu cần, nhưng theo slide gốc thì không có
                            txtDisplay.Text = (workingMemory / secondValue).ToString();
                            break;
                    }
                    // Reset trạng thái sau khi tính toán để chuẩn bị cho phép tính mới
                    workingMemory = decimal.Parse(txtDisplay.Text);
                    opr = "";
                }
            }

            // 4. Xử lý nút đổi dấu (±) (Slide84, Slide88)
            else if (bt.Text == "±")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = -currVal;
                txtDisplay.Text = currVal.ToString();
            }

            // 5. Xử lý nút căn bậc hai (√) (Slide84, Slide88)
            else if (bt.Text == "√")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                // Phải ép kiểu sang double cho Math.Sqrt, sau đó ép về decimal
                currVal = (decimal)Math.Sqrt((double)currVal);
                txtDisplay.Text = currVal.ToString();
            }

            // 6. Xử lý nút phần trăm (%) (Slide84, Slide88)
            else if (bt.Text == "%")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = currVal / 100;
                txtDisplay.Text = currVal.ToString();
            }

            // 7. Xử lý nút nghịch đảo (1/x) (Slide84, Slide88)
            else if (bt.Text == "1/x")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = 1 / currVal;
                txtDisplay.Text = currVal.ToString();
            }

            // 8. Xử lý nút Backspace (←) (Slide85, Slide89)
            else if (bt.Text == "←")
            {
                if (txtDisplay.TextLength > 0)
                {
                    // Xóa ký tự cuối cùng
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.TextLength - 1);
                }
                if (txtDisplay.TextLength == 0) // Nếu xóa hết thì đặt lại là "0"
                {
                    txtDisplay.Text = "0";
                }
            }

            // 9. Xử lý nút Memory Clear (MC) (Slide85, Slide89)
            else if (bt.Text == "MC")
            {
                memory = 0;
            }

            // 10. Xử lý nút Memory Recall (MR) (Slide85, Slide89)
            else if (bt.Text == "MR")
            {
                txtDisplay.Text = memory.ToString();
            }

            // 11. Xử lý nút Memory Store (MS) (Slide85, Slide89)
            else if (bt.Text == "MS")
            {
                memory = decimal.Parse(txtDisplay.Text);
                txtDisplay.Clear(); // Xóa màn hình sau khi lưu
            }

            // 12. Xử lý nút Memory Plus (M+) (Slide85, Slide90)
            else if (bt.Text == "M+")
            {
                memory = memory + decimal.Parse(txtDisplay.Text);
            }

            // 13. Xử lý nút Memory Minus (M-) (Slide85, Slide90)
            else if (bt.Text == "M-")
            {
                memory = memory - decimal.Parse(txtDisplay.Text);
            }

            // 14. Xử lý nút Clear (C) - Xóa tất cả (Slide85, Slide90)
            else if (bt.Text == "C")
            {
                workingMemory = 0;
                opr = "";
                txtDisplay.Clear(); // Xóa màn hình
            }

            // 15. Xử lý nút Clear Entry (CE) - Xóa mục nhập hiện tại (Slide85, Slide90)
            else if (bt.Text == "CE")
            {
                txtDisplay.Clear(); // Chỉ xóa màn hình
            }
        }
    }
}