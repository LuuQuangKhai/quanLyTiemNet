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
    public class TaiKhoan_BUS
    {
        TaiKhoan_DAO taiKhoan_DAO = new TaiKhoan_DAO();
        public DataTable dsQuyen()
        {
            return taiKhoan_DAO.showQuyen();
        }
        public DataTable dsTaiKhoan()
        {

            return taiKhoan_DAO.showTaiKhoan();
        }
        public bool Insert_taiKhoa_BUS(TaiKhoan_DTO taiKhoan_DTO)
        {
            return taiKhoan_DAO.Insert_TaiKhoan_DAO(taiKhoan_DTO);
        }
        public bool Delete_taiKhoan_BUS(TaiKhoan_DTO taiKhoan_DTO)
        {
            return taiKhoan_DAO.Delete_TaiKhoan_DAO(taiKhoan_DTO);
        }

        public bool Update_TaiKhoan_BUS(TaiKhoan_DTO taiKhoan_DTO)
        {
            return taiKhoan_DAO.Update_TaiKhoan_DAO(taiKhoan_DTO);
        }
        public DataTable Search_TaiKhoan_BUS(string tim)
        {
            return taiKhoan_DAO.Search_TaiKhoan_DAO( tim);
        }
        public bool ResetPassword_TaiKhoan_BUS(TaiKhoan_DTO taiKhoan_DTO)
        {
            return taiKhoan_DAO.ResetPassWord_TaiKhoanDA0(taiKhoan_DTO);
        }
    }
}
