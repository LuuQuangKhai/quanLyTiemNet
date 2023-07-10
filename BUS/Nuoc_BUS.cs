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
    public class Nuoc_BUS
    {

        Nuoc_DAO nuoc_DAO = new Nuoc_DAO();
        public DataTable showdsNuoc_BUS()
        {

            return nuoc_DAO.showdsNuoc_DAO();
        }
        public bool Insert_Nuoc_BUS(Nuoc_DTO Nuoc_DTO)
        {
            return nuoc_DAO.Insert_Nuoc_DAO(Nuoc_DTO);
        }

        public bool Delete_Nuoc_BUS(Nuoc_DTO Nuoc_DTO)
        {
            return nuoc_DAO.Delete_Nuoc_DAO(Nuoc_DTO);
        }
        public bool Update_Nuoc_BUS(Nuoc_DTO Nuoc_DTO)
        {
            return nuoc_DAO.Update_Nuoc_DAO(Nuoc_DTO);
        }
        public DataTable Search_Nuoc_BUS(string tim)
        {

            return nuoc_DAO.Search_Nuoc_DAO(tim);
        }
    }
}
