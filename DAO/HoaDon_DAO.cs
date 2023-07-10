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
    public class HoaDon_DAO:DataProvider
    {
      

        public DataTable showHoaDonMoi_DAO(string TenMay, string ngayLap)
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from HoaDon where TenMay='" + TenMay + "' and NgayLap='" + ngayLap + "'",connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataSet showdsHoaDon_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from HoaDon ", connection);
            DataSet dt = new DataSet();
            da.Fill(dt,"HoaDon");
            return dt;
        }

        public bool insert_HoaDon_DAO(HoaDon_DTO hoaDon_DTO)
        {
            Open();
            try
            {
                string sql = "insert into HoaDon values ('" + hoaDon_DTO.maNhanVien + "','" + hoaDon_DTO.tenMay + "','" + hoaDon_DTO.ngayLap + "'," + hoaDon_DTO.tongGia + ")";
                if (ExecuteNonQuery(sql) > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        

    }
}
