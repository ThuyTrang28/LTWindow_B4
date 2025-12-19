namespace Article08
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

            // 2. Thiết lập Form
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Caculator";

            // LƯU Ý: Bạn cần đảm bảo đã gán các Event Handlers này 
            // cho sự kiện Click của các Buttons trong Form1.Designer.cs
            // Ví dụ: this.btCong.Click += new System.EventHandler(this.btCong_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thường để trống hoặc dùng cho các thiết lập ban đầu khác
        }

        // 3. Phương thức Xử lý Sự kiện
        private void btCong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x + y;
            tbKetQua.Text = kq.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x * y;
            tbKetQua.Text = kq.ToString();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}