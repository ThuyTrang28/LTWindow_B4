using System;
using System.Drawing; // Cần thiết cho đối tượng Image và Bitmap
using System.Windows.Forms; // Cần thiết cho Form, PictureBox, Button, OpenFileDialog
using System.IO; // Cần thiết cho FileStream để xử lý tệp ảnh

namespace Article19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Code thực thi khi Form được tải lần đầu
            // Ví dụ: Tải ảnh mặc định, thiết lập focus ban đầu
        }

        // --- Xử lý Event: Click của Button "Chọn ảnh..." (btnChonAnh_Click) ---
        // Phương thức này mở hộp thoại cho phép người dùng chọn tệp ảnh và tải nó vào PictureBox.
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Thiết lập bộ lọc cho các loại tệp ảnh hợp lệ
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All files (*.*)|*.*";
                openFileDialog.Title = "Chọn ảnh nhân viên";

                // Hiển thị hộp thoại và kiểm tra kết quả
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // SỬ DỤNG FileStream: Quan trọng để tránh khóa tệp gốc. 
                        // Điều này cho phép tệp ảnh có thể được thay đổi hoặc xóa sau khi tải.
                        using (var stream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            // 1. Thiết lập Property: Image
                            pictureBox1.Image = Image.FromStream(stream);
                        }

                        // 2. Thiết lập Property: ImageLocation (lưu đường dẫn tệp)
                        pictureBox1.ImageLocation = openFileDialog.FileName;

                        MessageBox.Show("Đã tải ảnh thành công!", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}", "Lỗi",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Đặt ảnh về null nếu tải lỗi
                        pictureBox1.Image = null;
                    }
                }
            }
        }

        // --- Xử lý Event: Click của PictureBox (pictureBox1_Click) ---
        // Phương thức này có thể được dùng để mở ảnh lớn hơn hoặc hiển thị thông tin chi tiết.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null && !string.IsNullOrEmpty(pictureBox1.ImageLocation))
            {
                // Hành động khi người dùng nhấp chuột vào ảnh 
                MessageBox.Show($"Đường dẫn ảnh: {pictureBox1.ImageLocation}",
                                "Chi tiết Ảnh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // --- Xử lý Event: Validating (pictureBox1_Validating) ---
        // Phương thức này kiểm tra tính hợp lệ của dữ liệu trước khi control mất focus.
        private void pictureBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Ví dụ: Bắt buộc người dùng phải chọn ảnh
            /*
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh nhân viên trước khi tiếp tục.", 
                                "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Ngăn không cho focus di chuyển ra khỏi PictureBox
            }
            */
        }
    }
}