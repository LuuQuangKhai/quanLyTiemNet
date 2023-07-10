using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAO
{
   public class DoAn_DAO:DataProvider
    {
   

        public DataTable showdsDoAn_DAO( )
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from DoAn", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Insert_DoAn_DAO(DoAn_DTO doAn_DTO)
        {
            try
            {
                Open();
                string kt = "Select * from DoAn where MaDoAn='" + doAn_DTO.MaDoAn + "' or TenDoAn =N'"+doAn_DTO.TenDoAn+"'";
                if(ExecuteScalar(kt)!=null)
                {
                    MessageBox.Show("Đồ ăn đã tồn tại");
                    return false;
                }    
                string SQL = "Insert into DoAn values ('"+doAn_DTO.MaDoAn+"',N'"+doAn_DTO.TenDoAn+"',N'Đồ ăn','"+doAn_DTO.GiaDoAn+"')";
                if (ExecuteNonQuery(SQL,null) > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        
        public bool Delete_DoAn_DAO(DoAn_DTO doAn_DTO)
        {
            try
            {
                Open();
                string SQL = "delete from DoAn where MaDoAn='"+doAn_DTO.MaDoAn+"'";
                if (ExecuteNonQuery(SQL) > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool Update_DoAn_DAO(DoAn_DTO doAn_DTO)
        {
            try
            {
                Open();
                string kt = "Select * from DoAn where MaDoAn='" + doAn_DTO.MaDoAn + "'";
                if (ExecuteScalar(kt) != null)
                {
                    string SQL = "Update DoAn set TenDoAn=N'" + doAn_DTO.TenDoAn + "',GiaDoAn='" + doAn_DTO.GiaDoAn + "' where MaDoAn= '" + doAn_DTO.MaDoAn + "'";
                    if (ExecuteNonQuery(SQL, null) > 0)
                        return true;
                }
                else
                {
                    MessageBox.Show("Đồ ăn không tồn tại");
                    return false;
                }    
               
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public DataTable Search_DoAn_DAO(Object tim)
        {
            Open();
            string timkiem = "Select*from DoAn where MaDoAn LIKE '%" + tim + "%' or TenDoAn LIKE N'%" + tim + "%' or GiaDoAn LIKE '%" + tim + "%' ";
            SqlDataAdapter da = new SqlDataAdapter(timkiem, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
