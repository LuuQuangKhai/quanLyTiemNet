using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class May_DAO : DataProvider
    {
        public DataTable showdsMay()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from May", connection);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        public bool insertMay_DAO(May_DTO may)
        {
            Open();
            try
            {
                string sql = "insert into May values ('" + may.TenMay + "',null)";
                if (ExecuteNonQuery(sql) > 0)
                    return true;
            }
            catch (Exception)
            {

                return false;
            }
            return false;

        }
        public bool delete_May_DAO(May_DTO may)
        {
            Open();
            try
            {
                string sql = "delete from May where TenMay='" + may.TenMay.Trim() + "'";
                if (ExecuteNonQuery(sql) > 0)
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
            return false;

        }
    }
}
