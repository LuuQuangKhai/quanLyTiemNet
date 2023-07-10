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
    public class TheOrder_BUS
    {
        TheOrder_DAO TheOrder_DAO = new TheOrder_DAO();
        public DataTable showdsTheOrder_BUS(string tenmay)
        {
            return TheOrder_DAO.showdsTheOrder_DAO(tenmay);
        }
        public bool insert_TheOrder_DTO(TheOrder_DTO TheOrder_DTO)
        {
            return TheOrder_DAO.insert_TheOrder_DAO(TheOrder_DTO);
        }
        public bool update_TheOrder_DTO(TheOrder_DTO TheOrder_DTO)
        {
            return TheOrder_DAO.update_TheOrder_DAO(TheOrder_DTO);
        }
        public bool delete_TheOrder_DTO(TheOrder_DTO TheOrder_DTO)
        {
            return TheOrder_DAO.delete_TheOrder_DAO(TheOrder_DTO);
        }
    }
}
