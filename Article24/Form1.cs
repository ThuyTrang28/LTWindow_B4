using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article24
{
    public partial class Form1 : Form
    {
        // 1. Khai báo biến đếm giây (từ Slide 159)
        int second = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Code này chạy khi Form bắt đầu tải lên (bạn đang để trống)
        }

        // 2. Sự kiện khi nhấn nút Start
        private void btStart_Click(object sender, EventArgs e)
        {
            tmStopwatch.Interval = 1000; // Đặt chu kỳ là 1000ms (1 giây)
            tmStopwatch.Start();         // Bắt đầu chạy Timer
        }

        // 3. Sự kiện khi nhấn nút Stop
        private void btStop_Click(object sender, EventArgs e)
        {
            tmStopwatch.Stop();          // Dừng Timer
        }

        // 4. Sự kiện Tick của Timer (chạy mỗi giây)
        private void tmStopwatch_Tick(object sender, EventArgs e)
        {
            second++;                            // Tăng biến đếm lên 1
            lblDisplay.Text = second.ToString(); // Hiển thị ra Label
        }
    }
}