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
    public class DoAnOrder_BUS
    {
        DoAnOrder_DAO doAnOrder_DAO = new DoAnOrder_DAO();
        public DataTable showdsDoAnOrder_BUS(string tenmay)
        {
            return doAnOrder_DAO.showdsDoAnOrder_DAO(tenmay);
        }
        public bool insert_DoAnOrder_DTO(DoAnOrder_DTO doAnOrder_DTO)
        {
            return doAnOrder_DAO.insert_DoAnOrder_DAO(doAnOrder_DTO);
        }
        public bool update_DoAnOrder_DTO(DoAnOrder_DTO doAnOrder_DTO)
        {
            return doAnOrder_DAO.update_DoAnOrder_DAO(doAnOrder_DTO);
        }
        public bool delete_DoAnOrder_DTO(DoAnOrder_DTO doAnOrder_DTO)
        {
            return doAnOrder_DAO.delete_DoAnOrder_DAO(doAnOrder_DTO);
        }

    }
}
