using System;

namespace Article_QuanLy
{
    public class ChamCong
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }

        // --- MỚI THÊM: Thuộc tính Giới tính ---
        public string GioiTinh { get; set; }

        public DateTime NgayCham { get; set; }
        public string TrangThai { get; set; } // Vd: Có mặt, Vắng, Trễ
        public string GhiChu { get; set; }

        // --- CẬP NHẬT: Constructor nhận thêm biến 'gioitinh' ---
        public ChamCong(string ma, string ten, string gioitinh, DateTime ngay, string tt, string ghichu)
        {
            MaNV = ma;
            TenNV = ten;
            GioiTinh = gioitinh; // Gán giá trị
            NgayCham = ngay;
            TrangThai = tt;
            GhiChu = ghichu;
        }

        // Constructor mặc định (đề phòng lỗi khi binding dữ liệu)
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public ChamCong() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    }
}