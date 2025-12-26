using System;
using System.Drawing;
using System.Windows.Forms;

namespace Article27
{
    public partial class Form1 : Form
    {
        // Khai báo biến toàn cục
        PictureBox pbBasket = new PictureBox();
        int xBasket = 350; // Chỉnh lại cho cân giữa lúc bắt đầu (Form 800, Rổ 100 -> giữa là 350)
        int yBasket = 300; // Đưa rổ lên cao hơn (300) để không chạm vào nút Up ở vị trí 400
        int xDelta = 30;
        int yDelta = 30;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cấu hình rổ hứng trứng
            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(100, 100);
            pbBasket.Location = new Point(xBasket, yBasket);
            pbBasket.BackColor = Color.FromArgb(240, 240, 240);

            this.Controls.Add(pbBasket);

            try
            {
                pbBasket.Image = Image.FromFile("E:\\basket.png");
            }
            catch
            {
                pbBasket.BackColor = Color.Red;
            }

            // QUAN TRỌNG: Để bắt được phím khi đang có nút bấm trên màn hình
            this.KeyPreview = true;
        }

        // --- XỬ LÝ SỰ KIỆN PHÍM BẤM (KEYBOARD) ---
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 37: // Mũi tên Trái
                    MoveLeft();
                    break;
                case 39: // Mũi tên Phải
                    MoveRight();
                    break;
                case 38: // Mũi tên Lên
                    MoveUp();
                    break;
                case 40: // Mũi tên Xuống
                    MoveDown();
                    break;
            }
        }

        // --- XỬ LÝ SỰ KIỆN CLICK NÚT (BUTTONS) ---

        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveUp();
            this.Focus(); // Trả focus về Form
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveDown();
            this.Focus();
        }

        private void btnLeftArrow_Click(object sender, EventArgs e)
        {
            MoveLeft();
            this.Focus();
        }

        private void btnRightArrow_Click(object sender, EventArgs e)
        {
            MoveRight();
            this.Focus();
        }

        // --- CÁC HÀM DI CHUYỂN CHUNG ---

        private void MoveLeft()
        {
            if (xBasket > 0)
            {
                xBasket -= xDelta;
                UpdateBasketPosition();
            }
        }

        private void MoveRight()
        {
            // Kiểm tra biên phải (Form Width - Rổ Width - viền)
            if (xBasket < this.ClientSize.Width - pbBasket.Width - 10)
            {
                xBasket += xDelta;
                UpdateBasketPosition();
            }
        }

        private void MoveUp()
        {
            if (yBasket > 0)
            {
                yBasket -= yDelta;
                UpdateBasketPosition();
            }
        }

        private void MoveDown()
        {
            // Nút "Up" nằm ở vị trí Y khoảng 400. 
            // Rổ cao 100. Vậy yBasket không được quá 300 (400 - 100) nếu muốn tránh nút.
            // Tuy nhiên, để thoải mái hơn ta cho giới hạn là 380 (chạm nhẹ nút Up)
            if (yBasket < 380)
            {
                yBasket += yDelta;
                UpdateBasketPosition();
            }
        }

        // Hàm cập nhật vị trí mới cho PictureBox
        private void UpdateBasketPosition()
        {
            pbBasket.Location = new Point(xBasket, yBasket);
        }
    }
}