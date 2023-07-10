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
    public class NuocOrder_BUS
    {
        NuocOrder_DAO NuocOrder_DAO = new NuocOrder_DAO();
        public DataTable showdsNuocOrder_BUS(string tenmay)
        {
            return NuocOrder_DAO.showdsNuocOrder_DAO(tenmay);
        }
        public bool insert_NuocOrder_DTO(NuocOrder_DTO NuocOrder_DTO)
        {
            return NuocOrder_DAO.insert_NuocOrder_DAO(NuocOrder_DTO);
        }
        public bool update_NuocOrder_DTO(NuocOrder_DTO NuocOrder_DTO)
        {
            return NuocOrder_DAO.update_NuocOrder_DAO(NuocOrder_DTO);
        }
        public bool delete_NuocOrder_DTO(NuocOrder_DTO NuocOrder_DTO)
        {
            return NuocOrder_DAO.delete_NuocOrder_DAO(NuocOrder_DTO);
        }
    }
}
