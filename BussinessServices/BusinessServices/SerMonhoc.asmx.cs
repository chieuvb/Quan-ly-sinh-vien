using DataAccess;
using DataTransfer;
using System.Collections.Generic;
using System.Web.Services;

namespace BussinessServices.BusinessServices
{
    /// <summary>
    /// Summary description for SerMonhoc
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SerMonhoc : WebService
    {
        readonly DAMonhoc daMon = new DAMonhoc();

        [WebMethod]
        public List<DTMonhoc> GetAllMonHoc()
        {
            return daMon.GetAllMonHoc();
        }

        [WebMethod]
        public List<DTKhoa> GetAllKhoa()
        {
            return daMon.GetAllKhoa();
        }

        [WebMethod]
        public bool AddMonHoc(DTMonhoc mon)
        {
            if (daMon.CheckExist(mon.MaMon))
            {
                return false;
            }
            else
            {
                return daMon.AddMonHoc(mon);
            }
        }

        [WebMethod]
        public bool UpdateMonHoc(DTMonhoc mon)
        {
            if (!daMon.CheckExist(mon.MaMon))
            {
                return false;
            }
            else
            {
                return daMon.UpdateMonHoc(mon);
            }
        }

        [WebMethod]
        public bool DeleteMonHoc(string ma)
        {
            if (!daMon.CheckExist(ma))
            {
                return false;
            }
            else
            {
                return daMon.DeleteMonHoc(ma);
            }
        }
    }
}
