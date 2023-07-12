using DataAccess;
using DataTransfer;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class BLDiem
    {
        public BLDiem()
        {
            daDie = new DABangdiem();
        }

        readonly DABangdiem daDie;

        public List<DTDiem> GetAllDiem() { return daDie.GetAllDiem(); }

        public List<DTDiem> GetAllDiemByGV(string mgv) { return daDie.GetAllDiemByGV(mgv); }

        public List<DTLophocphan> GetLopHP() { return daDie.GetLopHP(); }

        public List<DTSinhvien> GetSinhViens(string magv) { return daDie.GetSinhVien(magv); }

        public bool AddDiem(DTDiem diem)
        {
            if (daDie.CheckExist(diem)) { throw new Exception("Sinh viên này đã có điểm!"); }
            else { return daDie.AddDiem(diem); }
        }

        public bool EditDiem(DTDiem diem)
        {
            if (!daDie.CheckExist(diem)) { throw new Exception("Sinh viên này chưa có điểm!"); }
            return daDie.EditDiem(diem);
        }

        public bool DeleteDiem(DTDiem diem)
        {
            if (!daDie.CheckExist(diem)) { throw new Exception("Sinh viên này chưa có điểm!"); }
            return daDie.DeleteDiem(diem);
        }
    }
}
