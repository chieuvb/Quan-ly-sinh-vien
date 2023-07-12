using DataAccess;
using DataTransfer;
using System.Collections.Generic;
using System.Web.Services;

namespace BussinessServices.BusinessServices
{
    /// <summary>
    /// Summary description for SerLopHP
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SerLopHP : WebService
    {
        readonly DALopHP daLHP = new DALopHP();
        readonly DAMonhoc daMon = new DAMonhoc();

        [WebMethod]
        public List<DTLophocphan> GetAllLHP()
        {
            return daLHP.GetAllLHP();
        }

        [WebMethod]
        public List<DTKhoa> GetAllKhoa()
        {
            return daLHP.GetAllKhoa();
        }

        [WebMethod]
        public List<DTGiangvien> GetGiangVienByKHoa(string mak)
        {
            return daLHP.GetGiangVienByKHoa(mak);
        }

        [WebMethod]
        public List<DTMonhoc> GetMonHoc()
        {
            return daMon.GetAllMonHoc();
        }

        [WebMethod]
        public bool AddLopHP(DTLophocphan lop)
        {
            if (daLHP.CheckAdd(lop))
            {
                return false;
            }
            else
            {
                return daLHP.AddLopHP(lop);
            }
        }

        [WebMethod]
        public bool EditLopHP(DTLophocphan lop)
        {
            if (!daLHP.CheckExist(lop))
            {
                return false;
            }
            else
            {
                return daLHP.EditLopHP(lop);
            }
        }

        [WebMethod]
        public bool DeleteLopHP(DTLophocphan lop)
        {
            if (!daLHP.CheckExist(lop))
            {
                return false;
            }
            else
            {
                return daLHP.DeleteLopHP(lop);
            }
        }
    }
}
