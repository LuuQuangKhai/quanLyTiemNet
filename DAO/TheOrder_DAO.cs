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
    public class TheOrder_DAO:DataProvider
    {
        public DataTable showdsTheOrder_DAO(string tenmay)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select OrderThe.TenThe, SoLuongTheOrder from The, OrderThe" +
                                                    " where The.TenThe=OrderThe.TenThe" +
                                                    " and TenMay='" + tenmay + "'", connection);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        public bool insert_TheOrder_DAO(TheOrder_DTO TheOrder_DTO)
        {
            try
            {
                Open();
                string TheOrder = "insert into OrderThe values ('" + TheOrder_DTO.tenMay.Trim() + "','" + TheOrder_DTO.tenThe.Trim() + "'," + TheOrder_DTO.soLuong + ",0,'" + TheOrder_DTO.maNhanVien.Trim() + "')";
                if (ExecuteNonQuery(TheOrder, null) > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public bool update_TheOrder_DAO(TheOrder_DTO TheOrder_DTO)
        {
            try
            {
                Open();
                string TheOrder = "update OrderThe  set SoLuongTheOrder=" + TheOrder_DTO.soLuong + " where TenThe ='" + TheOrder_DTO.tenThe.Trim() + "' and TenMay='" + TheOrder_DTO.tenMay.Trim() + "' and MaNhanVien='" + TheOrder_DTO.maNhanVien.Trim() + "'";
                if (ExecuteNonQuery(TheOrder, null) > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public bool delete_TheOrder_DAO(TheOrder_DTO TheOrder_DTO)
        {
            try
            {
                Open();
                string TheOrder = "delete from OrderThe  where TenThe ='" + TheOrder_DTO.tenThe.Trim() + "' and TenMay='" + TheOrder_DTO.tenMay.Trim() + "' and MaNhanVien='" + TheOrder_DTO.maNhanVien.Trim() + "'";
                if (ExecuteNonQuery(TheOrder, null) > 0)
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
