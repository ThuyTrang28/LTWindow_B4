namespace Article06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Hàm xử lý sự kiện click của nút bt_OK
        private void bt_OK_Click(object sender, EventArgs e)
        {
            // 1. Khởi tạo một đối tượng mới từ chính class Form1
            Form1 newForm = new Form1();

            // 2. Thiết lập thuộc tính cho Form mới (như đề bài yêu cầu thay đổi Text và Size)
            newForm.Text = "Article for Button (New Form)";
            newForm.Size = new Size(500, 500);

            // (Tuỳ chọn) Đặt vị trí để nó không đè lên form cũ
            newForm.StartPosition = FormStartPosition.CenterScreen;

            // 3. Hiển thị Form mới
            // newForm.ShowDialog(); // Dùng cái này nếu muốn bắt buộc đóng form mới rồi mới thao tác được form cũ
            newForm.Show();       // Dùng cái này nếu muốn mở nhiều form cùng lúc
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add any initialization code here if needed
        }
    }
}
