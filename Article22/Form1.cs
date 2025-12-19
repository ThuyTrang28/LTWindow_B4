using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Article22
{
    public partial class Form1 : Form
    {
        // Khai báo các biến thành viên
        private ArrayList lstEmp;
        private BindingSource bs;

        public Form1()
        {
            InitializeComponent();
            lstEmp = new ArrayList();
            bs = new BindingSource();
        }

        public List<Employee> GetData()
        {
            List<Employee> lst = new List<Employee>
            {
                new Employee { Id = "53418", Name = "Trần Tiên", Age = 20, Gender = true },
                new Employee { Id = "53416", Name = "Nguyễn Cường", Age = 25, Gender = false },
                new Employee { Id = "53417", Name = "Nguyễn Hảo", Age = 23, Gender = true }
            };
            return lst;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Khởi tạo và gán dữ liệu ban đầu
            lstEmp = new ArrayList(GetData());

            // 2. Gán dữ liệu cho BindingSource
            bs.DataSource = lstEmp;

            // 3. Gán BindingSource cho DataGridView
            dgvEmployee.DataSource = bs;
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (bs == null || lstEmp == null) return;

                // 1. Tạo đối tượng Employee mới
                Employee em = new Employee();
                em.Id = tBId.Text;
                em.Name = tBName.Text;

                // Kiểm tra nhập liệu cho Age
                if (int.TryParse(tBAge.Text, out int age))
                {
                    em.Age = age;
                }
                else
                {
                    MessageBox.Show("Tuổi không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                em.Gender = ckGender.Checked;

                // --- SỬA LỖI TẠI ĐÂY ---
                // SAI: lstEmp.Add(em); (Không thêm thủ công vào list gốc khi đang dùng BindingSource để Add)

                // 2. Thêm vào BindingSource
                // BindingSource sẽ tự động thêm vào lstEmp và cập nhật giao diện
                bs.Add(em);

                // Xóa dữ liệu cũ trên các control
                tBId.Clear();
                tBName.Clear();
                tBAge.Clear();
                ckGender.Checked = false;
                tBId.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào đang được chọn không
            if (bs.Current != null)
            {
                // --- SỬA LỖI TẠI ĐÂY ---
                // Chỉ cần xóa khỏi BindingSource, nó sẽ tự xóa trong List gốc
                bs.RemoveCurrent();

                // Đoạn code cũ của bạn:
                // int idx = dgvEmployee.CurrentCell.RowIndex;
                // bs.RemoveAt(idx);
                // lstEmp.RemoveAt(idx); // <-- Dòng này thừa và gây lỗi logic (xóa 2 lần)
            }
        }

        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;

            if (idx >= 0 && idx < dgvEmployee.Rows.Count)
            {
                // Lấy đối tượng từ BindingSource thay vì lấy từ Cell để chính xác hơn
                if (bs.Count > idx && bs[idx] is Employee em)
                {
                    tBId.Text = em.Id;
                    tBName.Text = em.Name;
                    tBAge.Text = em.Age.ToString();
                    ckGender.Checked = em.Gender;
                }
                // Fallback: Nếu không lấy được object, lấy từ cell như cũ
                else
                {
                    tBId.Text = dgvEmployee.Rows[idx].Cells[0].Value?.ToString();
                    tBName.Text = dgvEmployee.Rows[idx].Cells[1].Value?.ToString();
                    tBAge.Text = dgvEmployee.Rows[idx].Cells[2].Value?.ToString();

                    object? genderValue = dgvEmployee.Rows[idx].Cells[3].Value;
                    if (genderValue is bool boolValue)
                        ckGender.Checked = boolValue;
                    else
                        ckGender.Checked = false;
                }
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}