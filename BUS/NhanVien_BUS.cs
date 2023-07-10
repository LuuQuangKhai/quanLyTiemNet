using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
   public class NhanVien_BUS
    {
        NhanVien_DAO nhanVien_DAO = new NhanVien_DAO();
        public DataTable showNhanVien_BUS()
        {
            return nhanVien_DAO.showNhanVien_DAO();
        }
        public bool Insert_NhanVien_BUS(NhanVien_DTO nhanVien_DTO)
        {
            return nhanVien_DAO.InsertNhanVien_DAO(nhanVien_DTO);
        }
        public bool Delete_NhanVien_BUS(NhanVien_DTO nhanVien_DTO)
        {
            return nhanVien_DAO.DeleteNhanVien_DAO(nhanVien_DTO);
        }

        public bool Update_NhanVien_BUS(NhanVien_DTO nhanVien_DTO)
        {
            return nhanVien_DAO.Update_NhanVien_DAO(nhanVien_DTO);
        }
        public DataTable Search_NhanVien_BUS(string tim)
        {
            return nhanVien_DAO.Search_NhanVien_DAO(tim);
        }

    }
}
