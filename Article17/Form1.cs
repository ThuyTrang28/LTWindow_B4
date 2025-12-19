using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thêm dữ liệu mẫu vào ListBox khi Form Load (tương tự như Slide116)
            string[] songs = { "Giấc mơ Chapi", "Đôi Mắt Pleiku", "Em Muốn Sống Bên Anh Trọn Đời", "H’Zen Lên Rẫy", "Còn Thương Nhau Thì Về Buôn Mê Thuột", "Ly Cà Phê Ban Mê", "Đi tìm lời ru mặt trời" };
            lbSong.Items.AddRange(songs);
        }

       

        // Chuyển 1 item từ lbSong sang lbFavorite (Giống btSelect_Click và lbSong_MouseDoubleClick trong Slide118)
        private void btSelect_Click(object sender, EventArgs e)
        {
            if (lbSong.SelectedIndex != -1 && lbSong.SelectedItem is not null) // Đảm bảo có item được chọn
            {
                string song = lbSong.SelectedItem?.ToString() ?? string.Empty;
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(lbSong.SelectedIndex);
            }
        }

        // Chuyển tất cả item từ lbSong sang lbFavorite (Phiên bản dùng vòng lặp ngược từ Slide119 để tránh lỗi Index)
        private void btSelectAll_Click(object sender, EventArgs e)
        {
            // Duyệt ngược từ cuối danh sách. Điều này rất quan trọng khi xóa items trong khi lặp.
            for (int i = lbSong.Items.Count - 1; i >= 0; i--)
            {
                string song = lbSong.Items[i]?.ToString() ?? string.Empty;
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(i);
            }
        }

        // Xử lý Double Click trên lbSong (Sử dụng logic của Slide118/btSelect_Click)
        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Phiên bản dùng SelectedIndex (tương tự btSelect_Click):
            if (lbSong.SelectedIndex != -1 && lbSong.SelectedItem is not null)
            {
                string song = lbSong.SelectedItem?.ToString() ?? string.Empty;
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(lbSong.SelectedIndex);
            }

         
        }

        // ----------------------------------------------------------------------
        // PHƯƠNG THỨC GIẢ ĐỊNH CHO DESELECT (KHÔNG CÓ TRONG SLIDE)
        // ----------------------------------------------------------------------

        // Chuyển 1 item từ lbFavorite về lbSong
        private void btDeselect_Click(object sender, EventArgs e)
        {
            if (lbFavorite.SelectedIndex != -1 && lbFavorite.SelectedItem is not null)
            {
                string song = lbFavorite.SelectedItem?.ToString() ?? string.Empty;
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(lbFavorite.SelectedIndex);
            }
        }

        // Chuyển tất cả item từ lbFavorite về lbSong
        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = lbFavorite.Items.Count - 1; i >= 0; i--)
            {
                object? item = lbFavorite.Items[i];
                if (item is not null)
                {
                    string song = item?.ToString() ?? string.Empty;
                    lbSong.Items.Add(song);
                    lbFavorite.Items.RemoveAt(i);
                }
            }
        }

        // Xử lý Double Click trên lbFavorite (Chuyển ngược lại)
        private void lbFavorite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbFavorite.SelectedIndex != -1 && lbFavorite.SelectedItem is not null)
            {
                string song = lbFavorite.SelectedItem?.ToString() ?? string.Empty;
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(lbFavorite.SelectedIndex);
            }
        }
    }
}