using DataAccess;
using DataTransfer;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class BLMonhoc
    {
        public BLMonhoc()
        {
            daMon = new DAMonhoc();
        }

        readonly DAMonhoc daMon;

        public List<DTMonhoc> GetAllMonHoc() { return daMon.GetAllMonHoc(); }

        public List<DTKhoa> GetAllKhoa() { return daMon.GetAllKhoa(); }

        void CheckValid(DTMonhoc mon)
        {
            if (mon.MaMon.Contains("--")) { throw new Exception("Mã môn không hợp lệ!"); }
            else if (mon.TenMon.Contains("--")) { throw new Exception("Tên môn không hợp lệ!"); }
            else if(mon.SoTinChi <= 0) { throw new Exception("Số tín chỉ không hợp lệ!"); }
            else if (mon.MaKhoa.Contains("--")) { throw new Exception("Khoa không hợp lệ!"); }
        }

        public bool AddMonHoc(DTMonhoc mon)
        {
            CheckValid(mon);
            if (daMon.CheckExist(mon.MaMon)) { throw new Exception("Mã môn bị trùng!"); }
            return daMon.AddMonHoc(mon);
        }

        public bool UpdateMonHoc(DTMonhoc mon)
        {
            CheckValid(mon);
            if (!daMon.CheckExist(mon.MaMon)) { throw new Exception("Môn không tồn tại!"); }
            return daMon.UpdateMonHoc(mon);
        }

        public bool DeleteMonHoc(string ma)
        {
            if (!daMon.CheckExist(ma)) { throw new Exception("Môn không tồn tại!"); }
            return daMon.DeleteMonHoc(ma);
        }
    }
}
