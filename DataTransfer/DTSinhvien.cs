using System;

namespace DataTransfer
{
    public class DTSinhvien
    {
        public string MaSinhVien { get; set; }
        public string TenSinhVien { get; set; }
        public string HoDem { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string MaLopHanhChinh { get; set; }
        public string TenLopHanhChinh { get; set; }

        public override string ToString()
        {
            return MaSinhVien + " | " + HoDem + " " + TenSinhVien + " | " + NgaySinh.ToString("dd-MM-yyyy") + " | " + TenLopHanhChinh;
        }
    }
}
