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
    public class Nuoc_DAO:DataProvider
    {
        public DataTable showdsNuoc_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("Select*from Nuoc", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Insert_Nuoc_DAO(Nuoc_DTO Nuoc_DTO)
        {
            try
            {
                Open();
                string kt = "Select * from Nuoc where MaNuoc='" + Nuoc_DTO.MaNuoc + "' or TenNuoc =N'" + Nuoc_DTO.TenNuoc + "'";
                if (ExecuteScalar(kt) != null)
                {
                    MessageBox.Show("Nước đã tồn tại");
                    return false;
                }
                string SQL = "Insert into Nuoc values ('" + Nuoc_DTO.MaNuoc + "',N'" + Nuoc_DTO.TenNuoc + "',N'Nước','" + Nuoc_DTO.GiaNuoc + "')";
                if (ExecuteNonQuery(SQL, null) > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool Delete_Nuoc_DAO(Nuoc_DTO Nuoc_DTO)
        {
            try
            {
                Open();
                string SQL = "delete from Nuoc where MaNuoc='" + Nuoc_DTO.MaNuoc + "'";
                if (ExecuteNonQuery(SQL) > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool Update_Nuoc_DAO(Nuoc_DTO Nuoc_DTO)
        {
            try
            {
                Open();
                string kt = "Select * from Nuoc where MaNuoc='" + Nuoc_DTO.MaNuoc + "'";
                if (ExecuteScalar(kt) != null)
                {
                    string SQL = "Update Nuoc set TenNuoc=N'" + Nuoc_DTO.TenNuoc + "',GiaNuoc='" + Nuoc_DTO.GiaNuoc + "' where MaNuoc= '" + Nuoc_DTO.MaNuoc + "'";
                    if (ExecuteNonQuery(SQL, null) > 0)
                        return true;
                }
                else
                {
                    MessageBox.Show("Nước không tồn tại");
                    return false;
                }

            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public DataTable Search_Nuoc_DAO(Object tim)
        {
            Open();
            string timkiem = "Select*from Nuoc where MaNuoc LIKE '%" + tim + "%' or TenNuoc LIKE N'%" + tim + "%' or GiaNuoc LIKE '%" + tim + "%'";
            SqlDataAdapter da = new SqlDataAdapter(timkiem, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

