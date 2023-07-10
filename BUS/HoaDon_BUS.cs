using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAO;
namespace BUS
{
    public class HoaDon_BUS
    {
        HoaDon_DAO hoaDon_DAO = new HoaDon_DAO();

        public bool insert_HoaDonBUS(HoaDon_DTO hoaDon_DTO)
        {
            return hoaDon_DAO.insert_HoaDon_DAO(hoaDon_DTO);
        }
        public DataTable showHoaDonMoi_BUS(string tenmay, string ngaylap)
        {
            return hoaDon_DAO.showHoaDonMoi_DAO(tenmay, ngaylap);
        }
        public DataSet showdsHoaDon_BUS()
        {
            return hoaDon_DAO.showdsHoaDon_DAO();
        }
       
    }
}
