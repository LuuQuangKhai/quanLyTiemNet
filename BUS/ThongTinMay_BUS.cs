using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;
namespace BUS
{
    public class ThongTinMay_BUS
    {
        ThongTinMay_DAO thongTinMay = new ThongTinMay_DAO();
        public DataTable dsMay_BUS()
        {
            return thongTinMay.dsMay_DAO();
        }
        public DataTable dsMayMo_BUS()
        {
            return thongTinMay.dsMayMo_DAO();
        }
        public bool moMay_BUS(May_DTO thongTinMay_DTO,string manv,string time)
        {
            return thongTinMay.moMay_DAO(thongTinMay_DTO, manv,time);
        }
        public bool tatMay_BUS(May_DTO thongTinMay_DTO,  string time)
        {
            return thongTinMay.tatMay_DAO(thongTinMay_DTO,  time);
        }
    }
}
