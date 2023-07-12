namespace DataTransfer
{
    public class DTLophocphan
    {
        public string MaLopHocPhan { get; set; }
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public string MaGiangVien { get; set; }
        public string TenGiangVien { get; set; }
        public byte HocKy { get; set; }
        public string NamHoc { get; set; }
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }

        public override string ToString()
        {
            return MaLopHocPhan + " | " + TenMon + " | " + TenGiangVien;
        }
    }
}
