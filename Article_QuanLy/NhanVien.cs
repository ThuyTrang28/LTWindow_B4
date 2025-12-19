using System;

namespace Article_QuanLy
{
    public class NhanVien
    {
        public string MaNV { get; set; } = "";
        public string TenNV { get; set; } = "";
        public string GioiTinh { get; set; } = "Nam"; // Mới
        public DateTime NgaySinh { get; set; } = DateTime.Now; // Mới
        public string ChucVu { get; set; } = "";
        public string DienThoai { get; set; } = "";
        public string HinhAnh { get; set; } = "";

        // Constructor đầy đủ
        public NhanVien(string ma, string ten, string gioitinh, DateTime ngaysinh, string chucvu, string sdt, string hinhanh)
        {
            MaNV = ma;
            TenNV = ten;
            GioiTinh = gioitinh;
            NgaySinh = ngaysinh;
            ChucVu = chucvu;
            DienThoai = sdt;
            HinhAnh = hinhanh;
        }

        public NhanVien() { }
    }
}