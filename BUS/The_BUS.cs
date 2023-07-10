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
    public class The_BUS
    {
        The_DAO the_DAO = new The_DAO();
        public DataTable showdsThe_BUS()
        {

            return the_DAO.showdsThe_DAO();
        }
        public bool Insert_The_BUS(The_DTO the_DTO)
        {
            return the_DAO.Insert_The_DAO(the_DTO);
        }

        public bool Delete_The_BUS(The_DTO the_DTO)
        {
            return the_DAO.Delete_The_DAO(the_DTO);
        }
        public bool Update_The_BUS(The_DTO the_DTO)
        {
            return the_DAO.Update_The_DAO(the_DTO);
        }
        public DataTable Search_The_BUS(string tim)
        {

            return the_DAO.Search_The_DAO(tim);
        }
    }
}
