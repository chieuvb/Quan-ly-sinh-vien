namespace DataTransfer
{
    public class DTLophanhchinh
    {
        public string MaLopHanhChinh { get; set; }
        public string TenLopHanhChinh { get; set; }
        public string MaGiangVien { get; set; }
        public string TenGiangVien { get; set; }
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public int NamNhapHoc { get; set; }

        public override string ToString()
        {
            return MaLopHanhChinh + " | " + TenLopHanhChinh + " | " + TenGiangVien;
        }
    }
}
