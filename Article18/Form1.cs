using System.Collections;
using System.Windows.Forms;

namespace Article18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Phương thức tạo và trả về danh sách các đối tượng Song
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Song s = new Song();
            s.Id = 53418;
            s.Name = "Giấc mơ cha pi";
            s.Author = "Trần Tiến";
            lst.Add(s);

            s = new Song();
            s.Id = 52616;
            s.Name = "Đôi mắt pleiku";
            s.Author = "Nguyễn Cường";
            lst.Add(s);

            s = new Song();
            s.Id = 51172;
            s.Name = "Em muốn sống bên anh trọn đời";
            s.Author = "Nguyễn Cường";
            lst.Add(s);

            return lst;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();

            // 1. Gán nguồn dữ liệu (Danh sách các đối tượng Song)
            lbSong.DataSource = lst;

            // 2. Chỉ định thuộc tính nào của đối tượng Song sẽ hiển thị
            lbSong.DisplayMember = "Name";
        }

        // THÊM: Phương thức xử lý sự kiện Click của nút ">"
        private void btSelect_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn không
            if (lbSong.SelectedItem == null)
            {
                return;
            }

            // Lấy đối tượng Song đã chọn từ ListBox (lbSong)
            // Cần ép kiểu (cast) từ object sang kiểu Song
            Song song = (Song)lbSong.SelectedItem;

            string id = song.Id.ToString();
            string name = song.Name;
            string author = song.Author;

            // Thêm thông tin chi tiết của bài hát đã chọn vào ListBox yêu thích (lbFavorite)
            lbFavorite.Items.Add(id + " - " + name + " - " + author);
        }

        // THÊM: Phương thức xử lý sự kiện Click của nút "<" (btRemove)
        private void btRemove_Click(object sender, EventArgs e)
        {
            if (lbFavorite.SelectedItem != null)
            {
                // Xóa mục đang được chọn khỏi ListBox lbFavorite
                lbFavorite.Items.Remove(lbFavorite.SelectedItem);
            }
        }
    }
}