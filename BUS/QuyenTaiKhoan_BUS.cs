using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public class QuyenTaiKhoan_BUS
    {
        QuyenTaiKhoan_DAO quyenTaiKhoan_DAO = new QuyenTaiKhoan_DAO();
        public DataTable dsQuyenTaiKhoan()
        {

            return quyenTaiKhoan_DAO.showQuyenTaiKhoan();
        }
       

    }
}
