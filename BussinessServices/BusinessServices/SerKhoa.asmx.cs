using DataAccess;
using DataTransfer;
using System.Collections.Generic;
using System.Web.Services;

namespace BussinessServices.BusinessServices
{
    /// <summary>
    /// Summary description for SerKhoa
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SerKhoa : WebService
    {
        readonly DAKhoa daKho = new DAKhoa();

        [WebMethod]
        public List<DTKhoa> GetAllKhoa()
        {
            return daKho.GetAllKhoa();
        }

        /*
        0: Lỗi
        1: OK
        2: Đã tồn tại
        3: Không tìm thấy mã khoa
        */

        [WebMethod]
        public int AddKhoa(DTKhoa khoa)
        {
            if (daKho.CheckExist(khoa.MaKhoa))
            {
                return 2;
            }
            else
            {
                if (daKho.AddKhoa(khoa))
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
        public int EditKhoa(DTKhoa khoa)
        {
            if (!daKho.CheckExist(khoa.MaKhoa))
            {
                return 3;
            }
            else
            {
                if (daKho.EditKhoa(khoa))
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
        public int DeleteKhoa(string ma)
        {
            if (!daKho.CheckExist(ma))
            {
                return 3;
            }
            else
            {
                if (daKho.DeleteKhoa(ma))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
