using DataTransfer;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DALopHP : Configuration
    {
        public List<DTLophocphan> GetAllLHP()
        {
            List<DTLophocphan> lisRes = new List<DTLophocphan>();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand("spGetAllLopHP", sqlCon))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lisRes.Add(new DTLophocphan
                            {
                                MaLopHocPhan = dr.GetString(0),
                                MaMon = dr.GetString(1),
                                TenMon = dr.GetString(2),
                                MaGiangVien = dr.GetString(3),
                                TenGiangVien = dr.GetString(4) + " " + dr.GetString(5),
                                HocKy = dr.GetByte(6),
                                NamHoc = dr.GetString(7),
                                MaKhoa = dr.GetString(8),
                                TenKhoa = dr.GetString(9)
                            });
                        }
                    }
                }
            }
            return lisRes;
        }

        public List<DTKhoa> GetAllKhoa()
        {
            List<DTKhoa> lisRes = new List<DTKhoa>();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("select * from Khoa", sqlCon))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lisRes.Add(new DTKhoa
                            {
                                MaKhoa = reader.GetString(0),
                                TenKhoa = reader.GetString(1),
                                SoDienThoai = reader.GetString(2)
                            });
                        }
                    }
                }
            }
            return lisRes;
        }

        public List<DTGiangvien> GetGiangVienByKHoa(string mak)
        {
            List<DTGiangvien> lisRes = new List<DTGiangvien>();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("spGetGiangVienByKHoa @mak", sqlCon))
                {
                    command.Parameters.AddWithValue("@mak", mak);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lisRes.Add(new DTGiangvien
                            {
                                MaGiangVien = reader.GetString(0),
                                TenGiangVien = reader.GetString(1) + " " + reader.GetString(2),
                                GioiTinh = reader.GetBoolean(3),
                                NgaySinh = reader.GetDateTime(4),
                                DiaChi = reader.GetString(5),
                                DienThoai = reader.GetString(6),
                                Email = reader.GetString(7),
                                HocVi = reader.GetString(8),
                                MaKhoa = reader.GetString(9),
                                TenKhoa = reader.GetString(10)
                            });
                        }
                    }
                }
            }
            return lisRes;
        }

        public List<DTMonhoc> GetMonHocByKhoa(string mak)
        {
            List<DTMonhoc> lisRes = new List<DTMonhoc>();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("select maMon, tenMon, soTinChi, MonHoc.maKhoa, " +
                    "Khoa.tenKhoa from MonHoc join Khoa on MonHoc.maKhoa = Khoa.maKhoa " +
                    "where MonHoc.maKhoa = @mak", sqlCon))
                {
                    command.Parameters.AddWithValue("@mak", mak);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lisRes.Add(new DTMonhoc
                            {
                                MaMon = reader.GetString(0),
                                TenMon = reader.GetString(1),
                                SoTinChi = reader.GetByte(2),
                                MaKhoa = reader.GetString(3),
                                TenKhoa = reader.GetString(4)
                            });
                        }
                    }
                }
            }
            return lisRes;
        }

        public bool CheckAdd(DTLophocphan lop)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("select * from LopHocPhan where maKhoa = @mak and " +
                    "maMon = @mam and namHoc = @nam and hocKy = @hok", sqlCon))
                {
                    command.Parameters.AddWithValue("@mam", lop.MaMon);
                    command.Parameters.AddWithValue("@hok", lop.HocKy);
                    command.Parameters.AddWithValue("@nam", lop.NamHoc);
                    command.Parameters.AddWithValue("@mak", lop.MaKhoa);
                    return command.ExecuteScalar() != null;
                }
            }
        }

        public bool CheckExist(DTLophocphan lop)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("select * from LopHocPhan where maLopHP = @mal", sqlCon))
                {
                    command.Parameters.AddWithValue("@mal", lop.MaLopHocPhan);
                    return command.ExecuteScalar() != null;
                }
            }
        }

        public bool AddLopHP(DTLophocphan lop)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("insert into LopHocPhan " +
                    "values (@mal, @mam, @mag, @hok, @nam, @mak)", sqlCon))
                {
                    command.Parameters.AddWithValue("@mal", lop.MaLopHocPhan);
                    command.Parameters.AddWithValue("@mam", lop.MaMon);
                    command.Parameters.AddWithValue("@mag", lop.MaGiangVien);
                    command.Parameters.AddWithValue("@hok", lop.HocKy);
                    command.Parameters.AddWithValue("@nam", lop.NamHoc);
                    command.Parameters.AddWithValue("@mak", lop.MaKhoa);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool EditLopHP(DTLophocphan lop)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("update LopHocPhan set maGiangVien = @mag, " +
                    "hocKy = @hok, namHoc = @nam where maLopHP = @mal and maMon = @mam and maKhoa = @mak", sqlCon))
                {
                    command.Parameters.AddWithValue("@mal", lop.MaLopHocPhan);
                    command.Parameters.AddWithValue("@mam", lop.MaMon);
                    command.Parameters.AddWithValue("@mag", lop.MaGiangVien);
                    command.Parameters.AddWithValue("@hok", lop.HocKy);
                    command.Parameters.AddWithValue("@nam", lop.NamHoc);
                    command.Parameters.AddWithValue("@mak", lop.MaKhoa);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteLopHP(DTLophocphan lop)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("delete from LopHocPhan where maLopHP = @mal " +
                    "and maMon = @mam and maKhoa = @mak", sqlCon))
                {
                    command.Parameters.AddWithValue("@mal", lop.MaLopHocPhan);
                    command.Parameters.AddWithValue("@mam", lop.MaMon);
                    command.Parameters.AddWithValue("@mak", lop.MaKhoa);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
