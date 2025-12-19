using System;
using System.Drawing;
using System.Windows.Forms;

namespace Article25
{
    public partial class Form1 : Form
    {
        // --- 1. KHAI BÁO BIẾN ---
        PictureBox pb = new PictureBox();

        // SỬA LỖI TẠI ĐÂY: Thêm "System.Windows.Forms." vào trước Timer
        System.Windows.Forms.Timer tmGame = new System.Windows.Forms.Timer();

        int xBall = 0;
        int yBall = 0;
        int xDelta = 5;
        int yDelta = 5;

        public Form1()
        {
            InitializeComponent();
        }

        // --- 2. SỰ KIỆN LOAD ---
        private void Form1_Load(object sender, EventArgs e)
        {
            // Thiết lập Timer
            tmGame.Interval = 10;
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            tmGame.Tick += tmGame_Tick;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            tmGame.Start();

            // Thiết lập PictureBox
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(100, 100);
            pb.Location = new Point(xBall, yBall);

            // Đường dẫn ảnh (Bạn nhớ sửa lại nếu cần)
            pb.ImageLocation = @"E:\ball.png";

            this.Controls.Add(pb);
        }

        // --- 3. SỰ KIỆN TIMER TICK ---
        void tmGame_Tick(object sender, EventArgs e)
        {
            // Di chuyển
            xBall += xDelta;
            yBall += yDelta;

            // Xử lý va chạm biên Ngang
            if (xBall > this.ClientSize.Width - pb.Width || xBall <= 0)
            {
                xDelta = -xDelta;
            }

            // Xử lý va chạm biên Dọc
            if (yBall > this.ClientSize.Height - pb.Height || yBall <= 0)
            {
                yDelta = -yDelta;
            }

            // Cập nhật vị trí
            pb.Location = new Point(xBall, yBall);
        }
    }
}