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
    public class May_BUS 
    {
        May_DAO may = new May_DAO();
        public DataTable dsMay__BUS()
        {
            return may.showdsMay();
        }
        public bool insert_May_BUS(May_DTO mayDTO)
        {
            return may.insertMay_DAO(mayDTO);
        }
        public bool delete_May_BUS(May_DTO mayDTO)
        {
            return may.delete_May_DAO(mayDTO);
        }
    }
}
