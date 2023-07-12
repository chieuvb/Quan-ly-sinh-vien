namespace DataTransfer
{
    public class DTDiem
    {
        public string MaLopHocPhan { get; set; }
        public string TenLopHocPhan { get; set; }
        public string MaSinhVien { get; set; }
        public string TenSinhVien { get; set; }
        public double DiemChuyenCan { get; set; }
        public double DiemGiuaKy { get; set; }
        public double DiemThi { get; set; }
        public double DiemTrungBinh { get; set; }

        public override string ToString()
        {
            return TenLopHocPhan + " | " + TenSinhVien + " | " + DiemChuyenCan + " | " + DiemGiuaKy + " | " + DiemThi + " | " + DiemTrungBinh;
        }
    }
}
