using System;

namespace DataTransfer
{
    public class DTGiangvien
    {
        public string MaGiangVien { get; set; }
        public string TenGiangVien { get; set; }
        public string HoDem { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string HocVi { get; set; }
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }

        public override string ToString()
        {
            string hv;
            switch (HocVi)
            {
                case "Thạc sĩ":
                    hv = "ThS. ";
                    break;
                case "Tiến sĩ":
                    hv = "TS. ";
                    break;
                default:
                    hv = null;
                    break;
            }
            return MaGiangVien + " | " + hv + HoDem + " " + TenGiangVien;
        }
    }
}
