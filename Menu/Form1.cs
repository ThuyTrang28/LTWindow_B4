using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateMenuButtons();

            // [MỚI] Căn giữa ngay khi mở lên
            AlignContentCenter();

            // [MỚI] Khi kéo dãn Form, tự động căn giữa lại
            this.SizeChanged += (s, ev) => AlignContentCenter();
        }

        // [MỚI] HÀM TÍNH TOÁN ĐỂ CĂN GIỮA NÚT
        private void AlignContentCenter()
        {
            // Kích thước nút (160) + Margin trái (10) + Margin phải (10) = 180
            int itemWidth = 180;
            int panelWidth = pnlMenu.ClientSize.Width;

            // Tính xem 1 hàng chứa được tối đa bao nhiêu nút
            int columns = panelWidth / itemWidth;
            if (columns < 1) columns = 1;

            // Tính tổng chiều rộng thực tế của các nút
            int totalContentWidth = columns * itemWidth;

            // Tính khoảng trống thừa ra chia đôi để làm lề trái
            int leftPadding = (panelWidth - totalContentWidth) / 2;

            // Áp dụng Padding mới (Giữ nguyên Padding Top là 20)
            pnlMenu.Padding = new Padding(leftPadding, 20, 0, 0);
        }

        private void CreateMenuButtons()
        {
            pnlMenu.Controls.Clear();

            // 1. TẠO CÁC NÚT TỪ 00 ĐẾN 26
            for (int i = 0; i <= 27; i++)
            {
                // Bỏ qua các bài: 4, 1, 3 theo yêu cầu của bạn
                if (i == 4 ) continue;

                Button btn = new Button();
                string articleId = i.ToString("D2");

                btn.Text = $"Article {articleId}";
                btn.Name = $"btnArticle{articleId}";
                btn.Tag = articleId;

                StyleButton(btn);

#pragma warning disable CS8622 
                btn.Click += Article_Click;
#pragma warning restore CS8622 
                pnlMenu.Controls.Add(btn);
            }

            // --- TẠO NÚT QUẢN LÝ ---
            Button btnQL = new Button();
            btnQL.Text = "Quản Lý";
            btnQL.Name = "btnArticle_QuanLy";
            btnQL.Tag = "Article_QuanLy";

            StyleButton(btnQL);

            // Màu cam nổi bật cho nút Quản Lý
            btnQL.BackColor = Color.White;
            btnQL.ForeColor = Color.FromArgb(44, 62, 80);

#pragma warning disable CS8622 
            btnQL.Click += Article_Click;
#pragma warning restore CS8622 
            pnlMenu.Controls.Add(btnQL);
        }

        private void StyleButton(Button btn)
        {
            btn.Size = new Size(160, 60);
            // Margin 10px mỗi bên -> Tổng chiều rộng chiếm dụng là 160 + 20 = 180
            btn.Margin = new Padding(10);

            btn.BackColor = Color.White;
            btn.ForeColor = Color.FromArgb(44, 62, 80);
            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
        }

        private void Article_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton && clickedButton.Tag != null)
            {
#pragma warning disable CS8600 
                string tag = clickedButton.Tag.ToString();
#pragma warning restore CS8600 
                string projectName;

#pragma warning disable CS8602 
                if (tag.StartsWith("Article"))
                {
                    projectName = tag;
                }
                else
                {
                    projectName = $"Article{tag}";
                }
#pragma warning restore CS8602 

                try
                {
                    string currentDir = Application.StartupPath;
#pragma warning disable CS8600 
                    DirectoryInfo solutionDir = GetSolutionDir(currentDir);
#pragma warning restore CS8600 

                    if (solutionDir == null)
                    {
                        MessageBox.Show("Không tìm thấy thư mục gốc của Solution!");
                        return;
                    }

                    string exePath = "";
                    string projectBinPath = Path.Combine(solutionDir.FullName, projectName, "bin");

                    if (Directory.Exists(projectBinPath))
                    {
                        string[] files = Directory.GetFiles(projectBinPath, $"{projectName}.exe", SearchOption.AllDirectories);
                        if (files.Length > 0) exePath = files[0];
                    }

                    if (!string.IsNullOrEmpty(exePath) && File.Exists(exePath))
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = exePath,
                            UseShellExecute = true
                        });
                    }
                    else
                    {
                        MessageBox.Show($"Không tìm thấy file: {projectName}.exe\n\nHãy Rebuild Solution!", "Lỗi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                }
            }
        }

        private DirectoryInfo? GetSolutionDir(string currentPath)
        {
            DirectoryInfo dir = new DirectoryInfo(currentPath);
            for (int i = 0; i < 5; i++)
            {
                if (dir.Parent == null) return null;
                string testPath = Path.Combine(dir.Parent.FullName, "Article00");
                if (Directory.Exists(testPath)) return dir.Parent;
                dir = dir.Parent;
            }
            return null;
        }
    }
}