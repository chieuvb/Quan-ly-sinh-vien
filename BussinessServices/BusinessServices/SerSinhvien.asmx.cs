using DataAccess;
using DataTransfer;
using System.Collections.Generic;
using System.Web.Services;

namespace BussinessServices.BusinessServices
{
    /// <summary>
    /// Summary description for SerSinhvien
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SerSinhvien : WebService
    {
        readonly DASinhvien daSin = new DASinhvien();

        [WebMethod]
        public List<DTSinhvien> GetAllSinhVien()
        {
            return daSin.GetAllSinhVien();
        }

        [WebMethod]
        public List<DTSinhvien> GetSinhVienLHC(string magv)
        {
            return daSin.GetSinhVienLHC(magv);
        }

        [WebMethod]
        public List<DTLophanhchinh> GetAllLopHC()
        {
            return daSin.GetAllLopHC();
        }

        [WebMethod]
        public List<DTSinhvien> SortSinhVien(string lop, string dia, string gio)
        {
            return daSin.SortSinhVien(lop, dia, gio);
        }

        [WebMethod]
        public List<DTSinhvien> SearchSinhVien(string sea)
        {
            return daSin.SearchSinhVien(sea);
        }

        [WebMethod]
        public List<string[]> GetTinhThanh()
        {
            return daSin.GetTinhThanh();
        }

        [WebMethod]
        public List<string[]> GetHuyen(string maTinh)
        {
            return daSin.GetHuyen(maTinh);
        }

        [WebMethod]
        public List<string[]> GetXa(string maHuyen)
        {
            return daSin.GetXa(maHuyen);
        }

        [WebMethod]
        public bool ThemSinhVien(DTSinhvien sinhVien)
        {
            if (daSin.CheckExist(sinhVien.MaSinhVien))
            {
                return false;
            }
            else
            {
                return daSin.ThemSinhVien(sinhVien);
            }
        }

        [WebMethod]
        public bool EditSinhVien(DTSinhvien sinhVien)
        {
            if (daSin.CheckExist(sinhVien.MaSinhVien))
            {
                return false;
            }
            else
            {
                return daSin.EditSinhVien(sinhVien);
            }
        }

        [WebMethod]
        public bool DeleteSinhVien(string ma)
        {
            if (daSin.CheckExist(ma))
            {
                return false;
            }
            else
            {
                return daSin.DeleteSinhVien(ma);
            }
        }
    }
}
