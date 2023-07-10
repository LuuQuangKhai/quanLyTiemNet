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
    public class DangNhap_BUS
    {
        DangNhap_DAO dangNhap = new DangNhap_DAO();
        public int dangNhap_BUS(DangNhap_DTO dangNhapDTO)
        {
            return dangNhap.Login_DAO(dangNhapDTO);
        }
    }
}
