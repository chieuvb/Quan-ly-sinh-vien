using DataTransfer;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DAKhoa : Configuration
    {
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
                using (SqlCommand command = new SqlCommand("select * from Khoa where maKhoa = @ma", sqlCon))
                {
                    command.Parameters.AddWithValue("@ma", ma);
                    return command.ExecuteScalar() != null;
                }
            }
        }

        public bool AddKhoa(DTKhoa khoa)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("insert into Khoa values (@ma, @ten, @so)", sqlCon))
                {
                    command.Parameters.AddWithValue("@ma", khoa.MaKhoa);
                    command.Parameters.AddWithValue("@ten", khoa.TenKhoa);
                    command.Parameters.AddWithValue("@so", khoa.SoDienThoai);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool EditKhoa(DTKhoa khoa)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("update Khoa set tenKhoa = @ten, dienThoai = @so " +
                    "where maKhoa = @ma", sqlCon))
                {
                    command.Parameters.AddWithValue("@ma", khoa.MaKhoa);
                    command.Parameters.AddWithValue("@ten", khoa.TenKhoa);
                    command.Parameters.AddWithValue("@so", khoa.SoDienThoai);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteKhoa(string ma)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("delete from Khoa where maKhoa = @ma", sqlCon))
                {
                    command.Parameters.AddWithValue("@ma", ma);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
