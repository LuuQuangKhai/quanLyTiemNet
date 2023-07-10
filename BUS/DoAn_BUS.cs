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
   public class DoAn_BUS
    {
        DoAn_DAO doAn_DAO = new DoAn_DAO();
        public DataTable showdsDoAn_BUS()
        {

            return doAn_DAO.showdsDoAn_DAO();
        }
        public bool Insert_DoAn_BUS(DoAn_DTO doAn_DTO)
        {
            return doAn_DAO.Insert_DoAn_DAO(doAn_DTO);
        }

        public bool Delete_DoAn_BUS(DoAn_DTO doAn_DTO)
        {
            return doAn_DAO.Delete_DoAn_DAO(doAn_DTO);
        }
        public bool Update_DoAn_BUS(DoAn_DTO doAn_DTO)
        {
            return doAn_DAO.Update_DoAn_DAO(doAn_DTO);
        }
        public DataTable Search_DoAn_BUS(string tim)
        {

            return doAn_DAO.Search_DoAn_DAO(tim);
        }
    }
}
