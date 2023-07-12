using DataAccess;
using DataTransfer;
using System.Web.Services;

namespace BussinessServices.BusinessServices
{
    /// <summary>
    /// Summary description for SerTaikhoan
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SerTaikhoan : WebService
    {
        public SerTaikhoan() { daTai = new DATaikhoan(); }
        readonly DATaikhoan daTai;

        [WebMethod]
        public DTTaikhoan Login(DTTaikhoan taiKhoan)
        {
            DTTaikhoan taikhoan = daTai.Login(taiKhoan);
            if (string.IsNullOrEmpty(taikhoan.Username)) { return null; }
            else { return taikhoan; }
        }

        [WebMethod]
        public bool ChangePass(DTTaikhoan taiKhoan, int oldp)
        {
            return daTai.ChangePassword(taiKhoan, oldp);
        }
    }
}
