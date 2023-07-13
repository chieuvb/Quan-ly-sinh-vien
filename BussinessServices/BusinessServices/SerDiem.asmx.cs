using DataAccess;
using DataTransfer;
using System.Collections.Generic;
using System.Web.Services;

namespace BussinessServices.BusinessServices
{
    /// <summary>
    /// Summary description for SerDiem
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SerDiem : WebService
    {
        readonly DABangdiem daDie = new DABangdiem();

        [WebMethod]
        public List<DTDiem> GetAllDiem()
        {
            return daDie.GetAllDiem();
        }

        [WebMethod]
        public List<DTDiem> GetAllDiemByLHP(string mal)
        {
            return daDie.GetAllDiemByLHP(mal);
        }

        [WebMethod]
        public List<DTDiem> GetAllDiemByGV(string mag)
        {
            return daDie.GetAllDiemByGV(mag);
        }

        [WebMethod]
        public List<DTLophocphan> GetLopHP()
        {
            return daDie.GetLopHP();
        }

        [WebMethod]
        public List<DTSinhvien> GetSinhViens(string magv)
        {
            return daDie.GetSinhVien(magv);
        }

        /*
        0: loi
        1: ok
        2: da ton tai
        3: khong tim thay
        */

        [WebMethod]
        public int AddDiem(DTDiem diem)
        {
            if (daDie.CheckExist(diem))
            {
                return 2;
            }
            else
            {
                if (daDie.AddDiem(diem))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        [WebMethod]
        public bool EditDiem(DTDiem diem)
        {
            if (!daDie.CheckExist(diem))
            {
                return false;
            }
            else
            {
                return daDie.EditDiem(diem);
            }
        }

        [WebMethod]
        public bool DeleteDiem(DTDiem diem)
        {
            if (!daDie.CheckExist(diem))
            {
                return false;
            }
            else
            {
                return daDie.DeleteDiem(diem);
            }
        }
    }
}
