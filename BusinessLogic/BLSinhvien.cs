using DataAccess;
using DataTransfer;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public class BLSinhvien
    {
        public BLSinhvien()
        {
            daSin = new DASinhvien();
        }

        readonly DASinhvien daSin;

        public List<DTSinhvien> GetAllSinhVien() { return daSin.GetAllSinhVien(); }

        public List<DTSinhvien> GetSinhVienLHC(string magv) { return daSin.GetSinhVienLHC(magv); }

        public List<DTLophanhchinh> GetAllLopHC() { return daSin.GetAllLopHC(); }

        public List<string[]> GetTinhThanh() { return daSin.GetTinhThanh(); }

        public List<string[]> GetHuyen(string maTinh) { return daSin.GetHuyen(maTinh); }

        public List<string[]> GetXa(string maHuyen) { return daSin.GetXa(maHuyen); }

        void CheckData(DTSinhvien sinh)
        {
            if (sinh.TenSinhVien.Contains("--"))
            {
                throw new Exception("Vui lòng nhập tên sinh viên!");
            }
            else if (string.IsNullOrEmpty(sinh.HoDem))
            {
                throw new Exception("Tên không hợp lệ!");
            }
            else if (sinh.NgaySinh == new DateTime(2009, 12, 31))
            {
                throw new Exception("Vui lòng chọn ngày sinh phù hợp!");
            }
            else if (sinh.DiaChi.Contains("--"))
            {
                throw new Exception("Địa chỉ không hợp lệ!");
            }
            else if (!Regex.IsMatch(sinh.DienThoai, @"^(0[2-9]|01[2689]|09|08[1-9])[0-9]{8}$"))
            {
                throw new Exception("Số điện thoại không hợp lệ!");
            }
            else if (!Regex.IsMatch(sinh.Email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                throw new Exception("Email không hợp lệ!");
            }
            else if (sinh.MaLopHanhChinh.Contains("-- Lớp hành chính --"))
            {
                throw new Exception("Bạn chưa chọn lớp!");
            }
        }

        public bool ThemSinhVien(DTSinhvien sinhVien)
        {
            if (daSin.CheckExist(sinhVien.MaSinhVien))
            {
                throw new Exception("Mã sinh viên này đã được sử dụng!");
            }
            CheckData(sinhVien);
            return daSin.ThemSinhVien(sinhVien);
        }

        public bool EditSinhVien(DTSinhvien sinhVien)
        {
            if (daSin.CheckExist(sinhVien.MaSinhVien))
            {
                throw new Exception("Sinh viên chưa tồn tại trong hệ thống!");
            }
            CheckData(sinhVien);
            return daSin.EditSinhVien(sinhVien);
        }

        public bool DeleteSinhVien(string ma)
        {
            if (daSin.CheckExist(ma))
            {
                throw new Exception("Sinh viên chưa tồn tại trong hệ thống!");
            }
            return daSin.DeleteSinhVien(ma);
        }
    }
}
