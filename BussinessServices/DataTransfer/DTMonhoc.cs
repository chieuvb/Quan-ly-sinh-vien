namespace DataTransfer
{
    public class DTMonhoc
    {
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public byte SoTinChi { get; set; }
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }

        public override string ToString()
        {
            return MaMon + " | " + TenMon;
        }
    }
}
