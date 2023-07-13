using DataTransfer;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DABangdiem : Configuration
    {
        public List<DTDiem> GetAllDiem()
        {
            List<DTDiem> lisRes = new List<DTDiem>();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("spGetAllDiem", sqlCon))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lisRes.Add(new DTDiem
                            {
                                MaLopHocPhan = reader.GetString(0),
                                TenLopHocPhan = reader.GetString(1),
                                MaSinhVien = reader.GetString(2),
                                TenSinhVien = reader.GetString(3) + " " + reader.GetString(4),
                                DiemChuyenCan = reader.GetDouble(5),
                                DiemGiuaKy = reader.GetDouble(6),
                                DiemThi = reader.GetDouble(7),
                                DiemTrungBinh = reader.GetDouble(8)
                            });
                        }
                    }
                }
            }
            return lisRes;
        }

        public List<DTDiem> GetAllDiemByLHP(string mal)
        {
            List<DTDiem> lisRes = new List<DTDiem>();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("spGetDiemByLHP @mal", sqlCon))
                {
                    command.Parameters.AddWithValue("@mal", mal);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lisRes.Add(new DTDiem
                            {
                                MaLopHocPhan = reader.GetString(0),
                                TenLopHocPhan = reader.GetString(1),
                                MaSinhVien = reader.GetString(2),
                                TenSinhVien = reader.GetString(3) + " " + reader.GetString(4),
                                DiemChuyenCan = reader.GetDouble(5),
                                DiemGiuaKy = reader.GetDouble(6),
                                DiemThi = reader.GetDouble(7),
                                DiemTrungBinh = reader.GetDouble(8)
                            });
                        }
                    }
                }
            }
            return lisRes;
        }

        public List<DTLophocphan> GetLopHP()
        {
            List<DTLophocphan> lisRes = new List<DTLophocphan>();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("spGetAllLopHP", sqlCon))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lisRes.Add(new DTLophocphan
                            {
                                MaLopHocPhan = reader.GetString(0),
                                MaMon = reader.GetString(1),
                                TenMon = reader.GetString(2),
                                MaGiangVien = reader.GetString(3),
                                TenGiangVien = reader.GetString(4) + " " + reader.GetString(5),
                                HocKy = reader.GetByte(6),
                                NamHoc = reader.GetString(7),
                                MaKhoa = reader.GetString(8),
                                TenKhoa = reader.GetString(9)
                            });
                        }
                    }
                }
            }
            return lisRes;
        }

        public List<DTSinhvien> GetSinhVien(string magv)
        {
            List<DTSinhvien> lisRes = new List<DTSinhvien>();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("spGetSinhVienForGV @magv", sqlCon))
                {
                    command.Parameters.AddWithValue("@magv", magv);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lisRes.Add(new DTSinhvien
                            {
                                MaSinhVien = reader.GetString(0),
                                TenSinhVien = reader.GetString(1) + " " + reader.GetString(2),
                            });
                        }
                    }
                }
            }
            return lisRes;
        }

        public bool CheckExist(DTDiem diem)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand(
                    "select * from BangDiem where maLopHP = @malop and maSinhVien = @masv"
                    , sqlCon))
                {
                    command.Parameters.AddWithValue("@malop", diem.MaLopHocPhan);
                    command.Parameters.AddWithValue("@masv", diem.MaSinhVien);
                    return command.ExecuteScalar() != null;
                }
            }
        }

        public bool AddDiem(DTDiem diem)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand(
                    "insert into BangDiem values(@malop, @masv, @diemcc, @diemgk, @diemkt, @diemtb)"
                    , sqlCon))
                {
                    command.Parameters.AddWithValue("@malop", diem.MaLopHocPhan);
                    command.Parameters.AddWithValue("@masv", diem.MaSinhVien);
                    command.Parameters.AddWithValue("@diemcc", diem.DiemChuyenCan);
                    command.Parameters.AddWithValue("@diemgk", diem.DiemGiuaKy);
                    command.Parameters.AddWithValue("@diemkt", diem.DiemThi);
                    command.Parameters.AddWithValue("@diemtb", diem.DiemTrungBinh);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool EditDiem(DTDiem diem)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand(
                    "update BangDiem " +
                    "set diemChuyenCan = @diemcc, diemGiuaKy = @diemgk, diemThi = @diemkt, diemTrungBinh = @diemtb " +
                    "where maLopHP = @malop and maSinhVien = @masv"
                    , sqlCon))
                {
                    command.Parameters.AddWithValue("@malop", diem.MaLopHocPhan);
                    command.Parameters.AddWithValue("@masv", diem.MaSinhVien);
                    command.Parameters.AddWithValue("@diemcc", diem.DiemChuyenCan);
                    command.Parameters.AddWithValue("@diemgk", diem.DiemGiuaKy);
                    command.Parameters.AddWithValue("@diemkt", diem.DiemThi);
                    command.Parameters.AddWithValue("@diemtb", diem.DiemTrungBinh);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteDiem(DTDiem diem)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand(
                    "delete from BangDiem where maLopHP = @malo and maSinhVien = @masv"
                    , sqlCon))
                {
                    command.Parameters.AddWithValue("@malo", diem.MaLopHocPhan);
                    command.Parameters.AddWithValue("@masv", diem.MaSinhVien);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
