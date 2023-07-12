using DataAccess;
using DataTransfer;
using System;

namespace BusinessLogic
{
    public class BLTaiKhoan
    {
        public BLTaiKhoan()
        {
            daTai = new DATaikhoan();
        }

        readonly DATaikhoan daTai;

        public DTTaikhoan Login(DTTaikhoan taiKhoan)
        {
            if (taiKhoan.Username == "Tên đăng nhập" || string.IsNullOrEmpty(taiKhoan.Username) 
                || taiKhoan.Password.GetHashCode() == -231202094)
            {
                throw new Exception("Vui lòng nhập tài khoản, mật khẩu!");
            }
            else
            {
                DTTaikhoan taiKh = daTai.Login(taiKhoan);
                if (taiKh.Username == null)
                {
                    throw new Exception("Tài khoản hoặc mật khẩu không đúng!");
                }
                else if (taiKh.Role > 1) { throw new Exception("Bạn không được phép đăng nhập ứng dụng!"); }
                return taiKh;
            }
        }

        public bool ChangePass(DTTaikhoan taiKhoan, int oldp)
        {
            return daTai.ChangePassword(taiKhoan, oldp);
        }
    }
}
