using System.ComponentModel;
using System;

namespace Article_QuanLy
{
    public static class DataGlobal
    {
        // 1. Danh sách Nhân viên
        public static BindingList<NhanVien> DanhSachNV = new BindingList<NhanVien>();

        // 2. Danh sách Chấm công
        public static BindingList<ChamCong> DanhSachChamCong = new BindingList<ChamCong>();

        // 3. Danh sách Lương
        public static BindingList<Luong> DanhSachLuong = new BindingList<Luong>();

        // 4. Danh sách Ứng viên
        public static BindingList<UngVien> DanhSachUngVien = new BindingList<UngVien>();

        // --- MỚI THÊM: Biến Cấu hình hệ thống (Dùng cho MainForm5) ---
        public static string TenCongTy = "Công Ty TNHH Công Nghệ ABC";
        public static string DiaChi = "123 Đường Nguyễn Văn Linh, Quận 7, TP.HCM";
        public static string DienThoai = "028 3777 9999";
        public static string Email = "contact@abc-tech.com";

        // Hàm tạo dữ liệu giả
        public static void FakeData()
        {
            // Dữ liệu mẫu Nhân viên
            if (DanhSachNV.Count == 0)
            {
                DanhSachNV.Add(new NhanVien("NV01", "Nguyễn Văn A", "Nam", DateTime.Now, "Giám đốc", "0901", ""));
                DanhSachNV.Add(new NhanVien("NV02", "Trần Thị B", "Nữ", DateTime.Now, "Kế toán", "0902", ""));
            }

            // Dữ liệu mẫu Ứng viên
            if (DanhSachUngVien.Count == 0)
            {
                DanhSachUngVien.Add(new UngVien("UV01", "Lê Văn C", "Backend Developer", "1 năm", DateTime.Now, "Chờ phỏng vấn"));
                DanhSachUngVien.Add(new UngVien("UV02", "Phạm Thị D", "Tester", "Mới ra trường", DateTime.Now, "Đạt"));
            }
        }
    }
}