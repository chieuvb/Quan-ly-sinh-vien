using DataAccess;
using DataTransfer;
using System.Collections.Generic;
using System.Web.Services;

namespace BussinessServices.BusinessServices
{
    /// <summary>
    /// Summary description for SerLopHC
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SerLopHC : WebService
    {
        readonly DALopHC daLHC = new DALopHC();

        [WebMethod]
        public List<DTLophanhchinh> GetAllLHC()
        {
            return daLHC.GetAllLHC();
        }

        [WebMethod]
        public List<DTGiangvien> GetGVCN()
        {
            return daLHC.GetGVCN();
        }

        [WebMethod]
        public bool AddLHC(DTLophanhchinh lop)
        {
            if (daLHC.CheckML(lop.MaLopHanhChinh))
            {
                return false;
            }
            else
            {
                return daLHC.AddLHC(lop);
            }
        }

        [WebMethod]
        public bool EditLHC(DTLophanhchinh lop)
        {
            if (!daLHC.CheckML(lop.MaLopHanhChinh))
            {
                return false;
            }
            else
            {
                return daLHC.EditLHC(lop);
            }
        }

        [WebMethod]
        public bool DelteLHC(string ma)
        {
            if (!daLHC.CheckML(ma))
            {
                return false;
            }
            else
            {
                return daLHC.DelteLHC(ma);
            }
        }
    }
}
