using DataTransfer;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DALopHC : Configuration
    {
        public List<DTLophanhchinh> GetAllLHC()
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

        public List<DTGiangvien> GetGVCN()
        {
            List<DTGiangvien> lisRes = new List<DTGiangvien>();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("spGetGVCN", sqlCon))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lisRes.Add(new DTGiangvien
                            {
                                MaGiangVien = reader.GetString(0),
                                TenGiangVien = reader.GetString(2) + " " + reader.GetString(3),
                                HocVi = reader.GetString(1),
                                MaKhoa = reader.GetString(4),
                                TenKhoa = reader.GetString(5)
                            });
                        }
                    }
                }
            }
            return lisRes;
        }

        public bool CheckML(string mal)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("select * from LopHanhChinh " +
                    "where maLopHaCh = @mal", sqlCon))
                {
                    command.Parameters.AddWithValue("mal", mal);
                    return command.ExecuteScalar() != null;
                }
            }
        }

        public bool CheckMG(string maGiangVien)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("select * from LopHanhChinh " +
                    "where maGiangVien = @mag", sqlCon))
                {
                    command.Parameters.AddWithValue("mag", maGiangVien);
                    return command.ExecuteScalar() != null;
                }
            }
        }

        public bool AddLHC(DTLophanhchinh lop)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("insert into LopHanhChinh " +
                    "values (@mal, @ten, @mag, @mak, @nam)", sqlCon))
                {
                    command.Parameters.AddWithValue("@mal", lop.MaLopHanhChinh);
                    command.Parameters.AddWithValue("@ten", lop.TenLopHanhChinh);
                    command.Parameters.AddWithValue("@mag", lop.MaGiangVien);
                    command.Parameters.AddWithValue("@mak", lop.MaKhoa);
                    command.Parameters.AddWithValue("@nam", lop.NamNhapHoc);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool EditLHC(DTLophanhchinh lop)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("update LopHanhChinh set tenLop = @ten, " +
                    "maGiangVien = @mag, maKhoa = @mak, namNhapHoc = @nam where maLopHaCh = @mal", sqlCon))
                {
                    command.Parameters.AddWithValue("@mal", lop.MaLopHanhChinh);
                    command.Parameters.AddWithValue("@ten", lop.TenLopHanhChinh);
                    command.Parameters.AddWithValue("@mag", lop.MaGiangVien);
                    command.Parameters.AddWithValue("@mak", lop.MaKhoa);
                    command.Parameters.AddWithValue("@nam", lop.NamNhapHoc);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DelteLHC(string ma)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("delete from LopHanhChinh where maLopHaCh = @mal", sqlCon))
                {
                    command.Parameters.AddWithValue("@mal", ma);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
