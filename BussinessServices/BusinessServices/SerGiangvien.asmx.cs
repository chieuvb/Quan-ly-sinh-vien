using DataAccess;
using DataTransfer;
using System.Collections.Generic;
using System.Web.Services;

namespace BussinessServices.BusinessServices
{
    /// <summary>
    /// Summary description for SerGiangvien
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SerGiangvien : WebService
    {
        readonly DAGiangvien daGia = new DAGiangvien();

        [WebMethod]
        public List<DTGiangvien> GetAllGiangVien()
        {
            return daGia.GetAllGiangVien();
        }

        [WebMethod]
        public List<DTKhoa> GetKhoa()
        {
            return daGia.GetKhoa();
        }

        [WebMethod]
        public List<string[]> GetTinh()
        {
            return daGia.GetTinh();
        }

        [WebMethod]
        public List<string[]> GetHuyen(string maT)
        {
            return daGia.GetHuyen(maT);
        }

        [WebMethod]
        public List<string[]> GetXa(string maH)
        {
            return daGia.GetXa(maH);
        }

        [WebMethod]
        public bool ThemGiangVien(DTGiangvien giangVien)
        {
            if (daGia.CheckExist(giangVien.MaGiangVien))
            {
                return false;
            }
            else
            {
                return daGia.ThemGiangVien(giangVien);
            }
        }

        [WebMethod]
        public bool EditGiangVien(DTGiangvien giangVien)
        {
            if (!daGia.CheckExist(giangVien.MaGiangVien))
            {
                return false;
            }
            else
            {
                return daGia.EditGiangVien(giangVien);
            }
        }

        [WebMethod]
        public bool DeleteGiangVien(string ma)
        {
            if (!daGia.CheckExist(ma))
            {
                return false;
            }
            else
            {
                return daGia.DeleteGiangVien(ma);
            }
        }
    }
}
