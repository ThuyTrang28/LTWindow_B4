using System;
using System.Drawing; // Cần thiết để dùng Point và Size
using System.Windows.Forms;

namespace Article23
{
    public partial class Form1 : Form
    {
        // === KHAI BÁO BIẾN (Theo Slide 153) ===
        // Tạo đối tượng PictureBox và biến tọa độ x, y
        PictureBox pb = new PictureBox();
        int x = 0;
        int y = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Hàm này để trống như mẫu của bạn
        }

        // === NÚT FILE (Theo Slide 153) ===
        // Bạn nhớ đặt tên nút này trong Design là: btFile
        private void btFile_Click(object sender, EventArgs e)
        {
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(100, 100);
            pb.Location = new Point(x, y);

            // Lệnh quan trọng để hiển thị PictureBox lên Form
            this.Controls.Add(pb);

            // Đường dẫn ảnh (Bạn hãy sửa lại đường dẫn này nếu file ảnh nằm chỗ khác)
            pb.ImageLocation = @"E:\abc.jpg";
        }

        // === NÚT TRÁI (Theo Slide 154) ===
        // Bạn nhớ đặt tên nút này trong Design là: btLeft
        private void btLeft_Click(object sender, EventArgs e)
        {
            x -= 10; // Giảm tọa độ x để lùi về trái
            pb.Location = new Point(x, y);
        }

        // === NÚT PHẢI (Theo Slide 154) ===
        // Bạn nhớ đặt tên nút này trong Design là: btRight
        private void btRight_Click(object sender, EventArgs e)
        {
            x += 10; // Tăng tọa độ x để tiến về phải
            pb.Location = new Point(x, y);
        }
    }
}