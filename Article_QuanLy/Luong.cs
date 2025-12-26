using System;

namespace Article_QuanLy
{
    public class Luong
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public decimal LuongCoBan { get; set; }
        public decimal PhuCap { get; set; }
        public decimal Thuong { get; set; }
        public decimal KhauTru { get; set; } // Phạt/Kỷ luật

        // Tự động tính tổng khi get dữ liệu
        public decimal TongLuong
        {
            get { return LuongCoBan + PhuCap + Thuong - KhauTru; }
        }

        public Luong(string ma, string ten, decimal lcb, decimal pc, decimal thuong, decimal phat)
        {
            MaNV = ma;
            TenNV = ten;
            LuongCoBan = lcb;
            PhuCap = pc;
            Thuong = thuong;
            KhauTru = phat;
        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public Luong() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    }
}