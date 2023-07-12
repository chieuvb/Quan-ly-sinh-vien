using DataAccess;
using DataTransfer;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class BLLopHC
    {
        public BLLopHC()
        {
            daLHC = new DALopHC();
        }

        readonly DALopHC daLHC;

        public List<DTLophanhchinh> GetAllLHC() { return daLHC.GetAllLHC(); }

        public List<DTGiangvien> GetGVCN() { return daLHC.GetGVCN(); }

        void CheckValid(DTLophanhchinh lop)
        {
            if (lop.MaLopHanhChinh.Contains("--")) { throw new Exception("Mã lớp không hợp lệ!"); }
            else if (lop.TenLopHanhChinh.Contains("--")) { throw new Exception("Tên lớp không hợp lệ!"); }
            else if (lop.MaGiangVien.Contains("--")) { throw new Exception("Vui lòng chọn giảng viên!"); }
            else if (lop.MaKhoa == null) { throw new Exception("Mã khoa không hợp lệ!"); }
            else if (lop.NamNhapHoc >= DateTime.Now.Year) { throw new Exception("Năm nhập học không hợp lệ!"); }
        }

        public bool AddLHC(DTLophanhchinh lop)
        {
            CheckValid(lop);
            if (daLHC.CheckML(lop.MaLopHanhChinh)) { throw new Exception("Mã lớp đã được sử dụng!"); }
            else { return daLHC.AddLHC(lop); }
        }

        public bool EditLHC(DTLophanhchinh lop)
        {
            CheckValid(lop);
            if (!daLHC.CheckML(lop.MaLopHanhChinh)) { throw new Exception("Mã lớp không tồn tại!"); }
            else { return daLHC.EditLHC(lop); }
        }

        public bool DelteLHC(string ma)
        {
            if (!daLHC.CheckML(ma)) { throw new Exception("Mã lớp không tồn tại!"); }
            else { return daLHC.DelteLHC(ma); }
        }
    }
}
