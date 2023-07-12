using DataTransfer;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DASinhvien : Configuration
    {
        public List<DTSinhvien> GetAllSinhVien()
        {
            List<DTSinhvien> lisRes = new List<DTSinhvien>();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("spGetAllSinhVien", sqlCon))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lisRes.Add(new DTSinhvien
                            {
                                MaSinhVien = reader.GetString(0),
                                TenSinhVien = reader.GetString(1) + " " + reader.GetString(2),
                                GioiTinh = reader.GetBoolean(3),
                                NgaySinh = reader.GetDateTime(4),
                                DiaChi = reader.GetString(5),
                                DienThoai = reader.GetString(6),
                                Email = reader.GetString(7),
                                MaLopHanhChinh = reader.GetString(8),
                                TenLopHanhChinh = reader.GetString(9)
                            });
                        }
                    }
                }
            }
            return lisRes;
        }

        public List<DTSinhvien> GetSinhVienLHC(string magv)
        {
            List<DTSinhvien> lisRes = new List<DTSinhvien>();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("spGetSinhVienLHC @magv", sqlCon))
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
                                GioiTinh = reader.GetBoolean(3),
                                NgaySinh = reader.GetDateTime(4),
                                DiaChi = reader.GetString(5),
                                DienThoai = reader.GetString(6),
                                Email = reader.GetString(7),
                                MaLopHanhChinh = reader.GetString(8),
                                TenLopHanhChinh = reader.GetString(9)
                            });
                        }
                    }
                }
            }
            return lisRes;
        }

        public List<DTLophanhchinh> GetAllLopHC()
        {
            List<DTLophanhchinh> lisRes = new List<DTLophanhchinh>();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("spGetAllLopHC", sqlCon))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lisRes.Add(new DTLophanhchinh
                            {
                                MaLopHanhChinh = reader.GetString(0),
                                TenLopHanhChinh = reader.GetString(1),
                                MaGiangVien = reader.GetString(2),
                                TenGiangVien = reader.GetString(3) + " " + reader.GetString(4),
                                MaKhoa = reader.GetString(5),
                                TenKhoa = reader.GetString(6),
                                NamNhapHoc = reader.GetInt32(7)
                            });
                        }
                    }
                }
            }
            return lisRes;
        }

        public List<string[]> GetTinhThanh()
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

        public bool CheckExist(string ma)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("select * from SinhVien where maSinhVien = @ma",
                    sqlCon))
                {
                    command.Parameters.AddWithValue("@ma", ma);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool ThemSinhVien(DTSinhvien sinhVien)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand(
                    "insert into SinhVien values (@ma, @ten, @ho, @gioi, @ngay, @dia, @dien, @mai, @lop)",
                    sqlCon))
                {
                    command.Parameters.AddWithValue("@ma", sinhVien.MaSinhVien);
                    command.Parameters.AddWithValue("@ten", sinhVien.TenSinhVien);
                    command.Parameters.AddWithValue("@ho", sinhVien.HoDem);
                    command.Parameters.AddWithValue("@gioi", sinhVien.GioiTinh);
                    command.Parameters.AddWithValue("@ngay", sinhVien.NgaySinh);
                    command.Parameters.AddWithValue("@dia", sinhVien.DiaChi);
                    command.Parameters.AddWithValue("@dien", sinhVien.DienThoai);
                    command.Parameters.AddWithValue("@mai", sinhVien.Email);
                    command.Parameters.AddWithValue("@lop", sinhVien.MaLopHanhChinh);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool EditSinhVien(DTSinhvien sinhVien)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand(
                    "update SinhVien " +
                    "set tenSinhVien = @ten, hoDem = @ho, gioiTinh = @gioi, ngaySinh = @ngay, " +
                    "diaChi = @dia, dienThoai = @dien, email = @mai, maLopHaCh = @lop where maSinhVien = @ma",
                    sqlCon))
                {
                    command.Parameters.AddWithValue("@ma", sinhVien.MaSinhVien);
                    command.Parameters.AddWithValue("@ten", sinhVien.TenSinhVien);
                    command.Parameters.AddWithValue("@ho", sinhVien.HoDem);
                    command.Parameters.AddWithValue("@gioi", sinhVien.GioiTinh);
                    command.Parameters.AddWithValue("@ngay", sinhVien.NgaySinh);
                    command.Parameters.AddWithValue("@dia", sinhVien.DiaChi);
                    command.Parameters.AddWithValue("@dien", sinhVien.DienThoai);
                    command.Parameters.AddWithValue("@mai", sinhVien.Email);
                    command.Parameters.AddWithValue("@lop", sinhVien.MaLopHanhChinh);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteSinhVien(string ma)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("delete from SinhVien where maSinhVien = @ma", sqlCon))
                {
                    command.Parameters.AddWithValue("@ma", ma);
                    return command.ExecuteNonQuery() > 0;
                }
            }

        }
    }
}
