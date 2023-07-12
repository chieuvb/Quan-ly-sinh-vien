using DataTransfer;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DAMonhoc : Configuration
    {
        public List<DTMonhoc> GetAllMonHoc()
        {
            List<DTMonhoc> lisRes = new List<DTMonhoc>();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("select maMon, tenMon, soTinChi, MonHoc.maKhoa, " +
                    "Khoa.tenKhoa from MonHoc join Khoa on MonHoc.maKhoa = Khoa.maKhoa", sqlCon))
                {
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

        public bool CheckExist(string ma)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("select maMon from MonHoc where maMon = @ma", sqlCon))
                {
                    command.Parameters.AddWithValue("@ma", ma);
                    return command.ExecuteScalar() != null;
                }
            }
        }

        public bool AddMonHoc(DTMonhoc mon)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("insert into MonHoc values (@ma, @ten, @tin, @mak)", sqlCon))
                {
                    command.Parameters.AddWithValue("@ma", mon.MaMon);
                    command.Parameters.AddWithValue("@ten", mon.TenMon);
                    command.Parameters.AddWithValue("@tin", mon.SoTinChi);
                    command.Parameters.AddWithValue("@mak", mon.MaKhoa);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateMonHoc(DTMonhoc mon)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("update MonHoc set tenMon = @ten, " +
                    "soTinChi = @tin, maKhoa = @mak where maMon = @ma", sqlCon))
                {
                    command.Parameters.AddWithValue("@ma", mon.MaMon);
                    command.Parameters.AddWithValue("@ten", mon.TenMon);
                    command.Parameters.AddWithValue("@tin", mon.SoTinChi);
                    command.Parameters.AddWithValue("@mak", mon.MaKhoa);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteMonHoc(string ma)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("delete from MonHoc where maMon = @ma", sqlCon))
                {
                    command.Parameters.AddWithValue("@ma", ma);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
