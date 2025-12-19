using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Article20
{
    public partial class Form1 : Form
    {
        // Khai báo biến thành viên
        // Sử dụng ArrayList như trong slide, mặc dù List<T> hoặc DataTable thường được ưu tiên hơn.
        ArrayList? lstEm;

        public Form1()
        {
            InitializeComponent();
        }

        // 1. Sự kiện Load Form
        private void Form1_Load(object sender, EventArgs e)
        {
            lstEm = new ArrayList();

            // Tải dữ liệu mẫu vào DataGridView để mô phỏng (tùy chọn)
            dgvEmployee.Rows.Add("53418", "Trần Tiến", "20", true);
            dgvEmployee.Rows.Add("53416", "Nguyễn Cường", "25", false);
            dgvEmployee.Rows.Add("53417", "Nguyễn Hảo", "23", true);
        }

        // 2. Sự kiện Click nút "Thêm" (btAddNew_Click)
        private void btAddNew_Click(object sender, EventArgs e)
        {
            // Thêm một hàng mới vào DataGridView với dữ liệu từ các controls nhập liệu
            // Thứ tự: Mã, Tên, Tuổi, Giới tính (Nam)
            dgvEmployee.Rows.Add(tbID.Text, tbName.Text, tbAge.Text, ckGender.Checked);

            // Xóa nội dung nhập sau khi thêm (tùy chọn)
            tbID.Clear();
            tbName.Clear();
            tbAge.Clear();
            ckGender.Checked = false;
        }

        // 3. Sự kiện Click nút "Xóa" (btDelete_Click)
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentCell != null)
            {
                // Lấy chỉ mục (index) của hàng hiện tại
                int idx = dgvEmployee.CurrentCell.RowIndex;

                // Xóa hàng tại chỉ mục đó
                dgvEmployee.Rows.RemoveAt(idx);
            }
        }

        // 4. Sự kiện Click nút "Thoát" (btExit_Click)
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // 5. Sự kiện khi chọn hàng (dgvEmployee_RowEnter)
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Tránh lỗi khi hàng bị xóa hoặc hàng mới chưa có dữ liệu
            if (e.RowIndex < 0 || e.RowIndex >= dgvEmployee.Rows.Count - 1)
            {
                // Nếu là hàng trống cuối cùng (để thêm mới) hoặc chỉ mục không hợp lệ, thoát
                return;
            }

            int idx = e.RowIndex;

            // Cột 0: Mã nhân viên
            if (dgvEmployee.Rows[idx].Cells[0].Value != null)
                tbID.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();

            // Cột 1: Tên nhân viên
            if (dgvEmployee.Rows[idx].Cells[1].Value != null)
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();

            // Cột 2: Tuổi
            if (dgvEmployee.Rows[idx].Cells[2].Value != null)
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();

            // Cột 3: Giới tính (Giá trị bool)
            object genderValue = dgvEmployee.Rows[idx].Cells[3].Value;
            if (genderValue != null)
            {
                if (genderValue is bool genderBool)
                {
                    ckGender.Checked = genderBool;
                }
                else if (bool.TryParse(genderValue.ToString(), out bool result))
                {
                    ckGender.Checked = result;
                }
                else
                {
                    ckGender.Checked = false;
                }
            }
            else
            {
                ckGender.Checked = false;
            }
        }
    }
}