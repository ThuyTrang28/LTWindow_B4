using System;
using System.Drawing;
using System.Windows.Forms;

namespace Article26
{
    public partial class Form1 : Form
    {
        // --- KHAI BÁO BIẾN ---
        PictureBox pbEgg = new PictureBox();
        System.Windows.Forms.Timer tmEgg = new System.Windows.Forms.Timer();

        int xEgg = 300;
        int yEgg = 0;
        int xDelta = 3;
        int yDelta = 5; // Tăng tốc độ một chút cho dễ nhìn

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cài đặt Timer
            tmEgg.Interval = 10;
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            tmEgg.Tick += tmEgg_Tick;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            tmEgg.Start();

            // Cài đặt PictureBox
            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(100, 100);
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.BackColor = Color.Transparent;

            this.Controls.Add(pbEgg);

            try
            {
                pbEgg.Image = Image.FromFile(@"E:\\egg_gold.png");
            }
            catch
            {
                MessageBox.Show("Không tìm thấy file ảnh egg_gold.png!");
            }
        }

        // [SỬA LỖI LOGIC TẠI ĐÂY]
        void tmEgg_Tick(object sender, EventArgs e)
        {
            // 1. Tăng tọa độ Y để trứng rơi xuống
            yEgg += yDelta;

            // 2. Kiểm tra nếu trứng chạm đáy form
            // (ClientSize.Height là chiều cao vùng làm việc của Form)
            if (yEgg >= this.ClientSize.Height - pbEgg.Height)
            {
                // A. Gán cứng vị trí nằm ngay sát đáy (để tránh bị trôi lố ra ngoài)
                yEgg = this.ClientSize.Height - pbEgg.Height;

                // B. Dừng Timer lại ngay lập tức -> Để trứng nằm im
                tmEgg.Stop();

                // C. Đổi hình ảnh sang trứng vỡ
                try
                {
                    pbEgg.Image = Image.FromFile(@"E:\\egg_gold_broken.png");
                }
                catch { }
            }

            // 3. Cập nhật vị trí mới cho PictureBox
            pbEgg.Location = new Point(xEgg, yEgg);
        }
    }
}