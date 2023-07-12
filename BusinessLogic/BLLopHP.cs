using DataAccess;
using DataTransfer;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class BLLopHP
    {
        public BLLopHP()
        {
            daLHP = new DALopHP();
            daMon = new DAMonhoc();
        }

        readonly DALopHP daLHP;
        readonly DAMonhoc daMon;

        public List<DTLophocphan> GetAllLHP() { return daLHP.GetAllLHP(); }

        public List<DTKhoa> GetAllKhoa() { return daLHP.GetAllKhoa(); }

        public List<DTGiangvien> GetGiangVienByKHoa(string mak) { return daLHP.GetGiangVienByKHoa(mak); }

        public List<DTMonhoc> GetMonHoc() { return daMon.GetAllMonHoc(); }

        void CheckValid(DTLophocphan lop)
        {
            string[] nam = lop.NamHoc.Split('-');
            if (lop.MaKhoa.Contains("--")) { throw new Exception("Vui lòng chọn khoa phù hợp!"); }
            else if (lop.MaGiangVien.Contains("--")) { throw new Exception("Vui lòng chọn giảng viên phù hợp!"); }
            else if (lop.MaMon.Contains("--")) { throw new Exception("Vui lòng chọn môn học phù hợp!"); }
            else if (int.Parse(nam[1].Trim()) > int.Parse(nam[0].Trim()) + 1)
            {
                throw new Exception("Kỳ học quá dài!");
            }
        }

        public bool AddLopHP(DTLophocphan lop)
        {
            CheckValid(lop);
            if (daLHP.CheckAdd(lop)) { throw new Exception("Lớp học phần đã tồn tại!"); }
            return daLHP.AddLopHP(lop);
        }

        public bool EditLopHP(DTLophocphan lop)
        {
            CheckValid(lop);
            if (!daLHP.CheckExist(lop)) { throw new Exception("Không tìm thấy mã lớp!"); }
            return daLHP.EditLopHP(lop);
        }

        public bool DeleteLopHP(DTLophocphan lop)
        {
            if (!daLHP.CheckExist(lop)) { throw new Exception("Không tìm thấy mã lớp!"); }
            return daLHP.DeleteLopHP(lop);
        }
    }
}
