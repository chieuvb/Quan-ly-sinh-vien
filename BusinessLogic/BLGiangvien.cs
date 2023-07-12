using DataAccess;
using DataTransfer;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public class BLGiangvien
    {
        public BLGiangvien()
        {
            daGia = new DAGiangvien();
        }

        readonly DAGiangvien daGia;

        public List<DTGiangvien> GetAllGiangVien() { return daGia.GetAllGiangVien(); }

        public List<DTKhoa> GetKhoa() { return daGia.GetKhoa(); }

        public List<string[]> GetTinh() { return daGia.GetTinh(); }

        public List<string[]> GetHuyen(string maT) { return daGia.GetHuyen(maT); }

        public List<string[]> GetXa(string maH) { return daGia.GetXa(maH); }

        void CheckData(DTGiangvien gv)
        {
            if (gv.TenGiangVien.Contains("--")) { throw new Exception("Tên không hợp lệ!"); }
            else if (string.IsNullOrWhiteSpace(gv.HoDem)) { throw new Exception("Vui lòng nhập họ tên đầy đủ!"); }
            else if (gv.NgaySinh == new DateTime(2009, 12, 31)) { throw new Exception("Ngày sinh không hợp lệ!"); }
            else if (gv.DiaChi.Contains("--")) { throw new Exception("Địa chỉ không hợp lệ!"); }
            else if (!Regex.IsMatch(gv.DienThoai, @"^(0[2-9]|01[2689]|09|08[1-9])[0-9]{8}$"))
            {
                throw new Exception("Số điện thoại không hợp lệ!");
            }
            else if (!Regex.IsMatch(gv.Email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                throw new Exception("Email không hợp lệ!");
            }
            else if (gv.HocVi.Contains("--")) { throw new Exception("Học vị chưa được chọn!"); }
            else if (gv.MaKhoa.Contains("--")) { throw new Exception("Vui lòng chọn khoa!"); }
        }

        public bool ThemGiangVien(DTGiangvien giangVien)
        {
            if (daGia.CheckExist(giangVien.MaGiangVien)) { throw new Exception("Mã giảng viên này đã được sử dụng!"); }
            CheckData(giangVien);
            return daGia.ThemGiangVien(giangVien);
        }

        public bool EditGiangVien(DTGiangvien giangVien)
        {
            if (!daGia.CheckExist(giangVien.MaGiangVien)) { throw new Exception("Giảng viên không tồn tại!"); }
            CheckData(giangVien);
            return daGia.EditGiangVien(giangVien);
        }

        public bool DeleteGiangVien(string ma)
        {
            if (!daGia.CheckExist(ma)) { throw new Exception("Giảng viên không tồn tại!"); }
            return daGia.DeleteGiangVien(ma);
        }
    }
}
