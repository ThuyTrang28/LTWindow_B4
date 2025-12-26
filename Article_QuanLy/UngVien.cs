using System;

namespace Article_QuanLy
{
    public class UngVien
    {
        public string MaUV { get; set; }
        public string TenUV { get; set; }
        public string ViTriUngTuyen { get; set; }
        public string KinhNghiem { get; set; } // VD: 2 năm
        public DateTime NgayNopHoSo { get; set; }
        public string TrangThai { get; set; } // Chờ phỏng vấn, Đạt, Trượt

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public UngVien() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

        public UngVien(string ma, string ten, string vitri, string kn, DateTime ngay, string tt)
        {
            MaUV = ma;
            TenUV = ten;
            ViTriUngTuyen = vitri;
            KinhNghiem = kn;
            NgayNopHoSo = ngay;
            TrangThai = tt;
        }
    }
}