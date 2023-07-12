using DataTransfer;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DATaikhoan : Configuration
    {
        public DTTaikhoan Login(DTTaikhoan taiKhoan)
        {
            DTTaikhoan resTK = new DTTaikhoan();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand(
                    "select tenDangNhap, quyenHan from TaiKhoan where tenDangNhap = @user and matKhau = @pass",
                    sqlCon))
                {
                    command.Parameters.AddWithValue("user", taiKhoan.Username);
                    command.Parameters.AddWithValue("pass", taiKhoan.Password);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            resTK.Username = reader.GetString(0);
                            resTK.Role = reader.GetByte(1);
                        }
                    }
                }
            }
            return resTK;
        }

        public bool ChangePassword(DTTaikhoan taiKhoan, int oldp)
        {
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand(
                    "update TaiKhoan set matKhau = @pass where tenDangNhap = @user and matKhau = @oldp",
                    sqlCon))
                {
                    command.Parameters.AddWithValue("@user", taiKhoan.Username);
                    command.Parameters.AddWithValue("@pass", taiKhoan.Password);
                    command.Parameters.AddWithValue("@oldp", oldp);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
