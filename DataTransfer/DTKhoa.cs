namespace DataTransfer
{
    public class DTKhoa
    {
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string SoDienThoai { get; set; }

        public override string ToString()
        {
            return MaKhoa + " | " + TenKhoa;
        }
    }
}
