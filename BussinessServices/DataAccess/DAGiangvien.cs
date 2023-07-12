using DataTransfer;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DAGiangvien : Configuration
    {
        public List<DTGiangvien> GetAllGiangVien()
        {
            List<DTGiangvien> lisRes = new List<DTGiangvien>();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("spGetAllGiangVien", sqlCon))
                {
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

        public List<DTKhoa> GetKhoa()
        {
            List<DTKhoa> lisRes = new List<DTKhoa>();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand("select * from Khoa", sqlCon))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
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

        public List<string[]> GetTinh()
        {
            List<string[]> lisRes = new List<string[]>();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand("select * from Tinh", sqlCon))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lisRes.Add(new string[]
                            {
                                reader.GetString(0),
                                reader.GetString(1)
                            });
                        }
                    }
                }
            }
            return lisRes;
        }

        public List<string[]> GetHuyen(string maTinh)
        {
            List<string[]> list = new List<string[]>();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand("select * from Huyen where maTinh = @maTinh", sqlCon))
                {
                    cmd.Parameters.AddWithValue("@maTinh", maTinh);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new string[]
                            {
                                reader.GetString(0),
                                reader.GetString(1),
                                reader.GetString(2)
                            });
                        }
                    }
                }
            }
            return list;
        }

        public List<string[]> GetXa(string maHuyen)
        {
            List<string[]> list = new List<string[]>();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand("select * from Xa where maHuyen = @maHuyen", sqlCon))
                {
                    cmd.Parameters.AddWithValue("@maHuyen", maHuyen);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new string[]
                            {
                                reader.GetString(0),
                                reader.GetString(1),
                                reader.GetString(2)
                            });
                        }
                    }
                }
            }
            return list;
        }

        public bool CheckExist(string mgv)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("select * from GiangVien where maGiangVien = @ma",
                    sqlCon))
                {
                    command.Parameters.AddWithValue("@ma", mgv);
                    return command.ExecuteScalar() != null;
                }
            }
        }

        public bool ThemGiangVien(DTGiangvien giangVien)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand(
                    "insert into GiangVien values (@ma, @ten, @ho, @gioi, @ngay, @dia, @dien, @mai, @hov, @mak) " +
                    "insert into Taikhoan(tenDangNhap) values (@ma)",
                    sqlCon))
                {
                    command.Parameters.AddWithValue("@ma", giangVien.MaGiangVien);
                    command.Parameters.AddWithValue("@ten", giangVien.TenGiangVien);
                    command.Parameters.AddWithValue("@ho", giangVien.HoDem);
                    command.Parameters.AddWithValue("@gioi", giangVien.GioiTinh);
                    command.Parameters.AddWithValue("@ngay", giangVien.NgaySinh);
                    command.Parameters.AddWithValue("@dia", giangVien.DiaChi);
                    command.Parameters.AddWithValue("@dien", giangVien.DienThoai);
                    command.Parameters.AddWithValue("@mai", giangVien.Email);
                    command.Parameters.AddWithValue("@hov", giangVien.HocVi);
                    command.Parameters.AddWithValue("@mak", giangVien.MaKhoa);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool EditGiangVien(DTGiangvien giangVien)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand(
                    "update GiangVien set tenGiangVien = @ten, hoDem = @ho, gioiTinh = @gioi, ngaySinh = @ngay, " +
                    "diaChi = @dia, dienThoai = @dien, email = @mai, hocVi = @hov, maKhoa = @mak " +
                    "where maGiangVien = @ma",
                    sqlCon))
                {
                    command.Parameters.AddWithValue("@ma", giangVien.MaGiangVien);
                    command.Parameters.AddWithValue("@ten", giangVien.TenGiangVien);
                    command.Parameters.AddWithValue("@ho", giangVien.HoDem);
                    command.Parameters.AddWithValue("@gioi", giangVien.GioiTinh);
                    command.Parameters.AddWithValue("@ngay", giangVien.NgaySinh);
                    command.Parameters.AddWithValue("@dia", giangVien.DiaChi);
                    command.Parameters.AddWithValue("@dien", giangVien.DienThoai);
                    command.Parameters.AddWithValue("@mai", giangVien.Email);
                    command.Parameters.AddWithValue("@hov", giangVien.HocVi);
                    command.Parameters.AddWithValue("@mak", giangVien.MaKhoa);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteGiangVien(string ma)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand(
                    "delete from GiangVien where maGiangVien = @ma; " +
                    "delete from Taikhoan where tenDangNhap = @ma",
                    sqlCon))
                {
                    command.Parameters.AddWithValue("@ma", ma);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
