using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Windows.Forms;

namespace DAO
{
    public class The_DAO:DataProvider
    {
        public DataTable showdsThe_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("Select*from The", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Insert_The_DAO(The_DTO the_DTO)
        {
            try
            {
                Open();
                string kt = "Select * from The where TenThe =N'" + the_DTO.TenThe + "'";
                if (ExecuteScalar(kt) != null)
                {
                    MessageBox.Show("Thẻ đã tồn tại");
                    return false;
                }
                string SQL = "Insert into The values (N'" + the_DTO.TenThe + "',N'Nước','" + the_DTO.GiaThe + "')";
                if (ExecuteNonQuery(SQL, null) > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool Delete_The_DAO(The_DTO the_DTO)
        {
            try
            {
                Open();
                string SQL = "delete from The where TenThe='" + the_DTO.TenThe+ "'";
                if (ExecuteNonQuery(SQL) > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool Update_The_DAO(The_DTO the_DTO)
        {
            try
            {
                Open();
                string kt = "Select * from The where TenThe='" + the_DTO.TenThe + "'";
                if (ExecuteScalar(kt) != null)
                {
                    string SQL = "Update The set GiaThe='" + the_DTO.GiaThe + "' where TenThe=N'" + the_DTO.TenThe + "'";
                    if (ExecuteNonQuery(SQL, null) > 0)
                        return true;
                }
                else
                {
                    MessageBox.Show("Thẻ không tồn tại");
                    return false;
                }

            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public DataTable Search_The_DAO(Object tim)
        {
            Open();
            string timkiem = "Select * from The where  TenThe LIKE N'%" + tim + "%' or GiaThe LIKE '%" + tim + "%'";
            SqlDataAdapter da = new SqlDataAdapter(timkiem, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
