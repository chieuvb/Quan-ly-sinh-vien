using DataAccess;
using DataTransfer;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public class BLKhoa
    {
        public BLKhoa()
        {
            daKho = new DAKhoa();
        }

        readonly DAKhoa daKho;

        public List<DTKhoa> GetAllKhoa() { return daKho.GetAllKhoa(); }

        void Check(DTKhoa khoa)
        {
            if (khoa.MaKhoa.Contains("--")) { throw new Exception("Mã khoa không hợp lệ!"); }
            else if (khoa.TenKhoa.Contains("--")) { throw new Exception("Tên khoa không hợp lệ!"); }
            else if (!Regex.IsMatch(khoa.SoDienThoai, @"^(0[2-9]|01[2689]|09|08[1-9])[0-9]{8}$"))
            {
                throw new Exception("Số điện thoại không hợp lệ!");
            }
        }

        public bool AddKhoa(DTKhoa khoa)
        {
            Check(khoa);
            if (daKho.CheckExist(khoa.MaKhoa)) { throw new Exception("Mã khoa này đã được sử dụng!"); }
            return daKho.AddKhoa(khoa);
        }

        public bool EditKhoa(DTKhoa khoa)
        {
            Check(khoa);
            if (!daKho.CheckExist(khoa.MaKhoa)) { throw new Exception("Mã khoa không tồn tại!"); }
            return daKho.EditKhoa(khoa);
        }

        public bool DeleteKhoa(string ma)
        {
            if (!daKho.CheckExist(ma)) { throw new Exception("Mã khoa không tồn tại!"); }
            return daKho.DeleteKhoa(ma);
        }
    }
}
