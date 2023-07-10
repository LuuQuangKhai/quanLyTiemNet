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
   public class NuocOrder_DAO:DataProvider
    {
        public DataTable showdsNuocOrder_DAO(string tenmay)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select TenNuoc, SoLuongNuocOrder from Nuoc, OrderNuoc" +
                                                    " where Nuoc.MaNuoc=OrderNuoc.MaNuoc" +
                                                    " and TenMay='" + tenmay + "'", connection);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        public bool insert_NuocOrder_DAO(NuocOrder_DTO NuocOrder_DTO)
        {
            try
            {
                Open();
                string NuocOrder = "insert into OrderNuoc values ('" + NuocOrder_DTO.tenMay.Trim() + "','" + NuocOrder_DTO.maNuoc.Trim() + "'," + NuocOrder_DTO.soLuong + ",0,'" + NuocOrder_DTO.maNhanVien.Trim() + "')";
                if (ExecuteNonQuery(NuocOrder, null) > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public bool update_NuocOrder_DAO(NuocOrder_DTO NuocOrder_DTO)
        {
            try
            {
                Open();
                string NuocOrder = "update OrderNuoc  set SoLuongNuocOrder=" + NuocOrder_DTO.soLuong + " where MaNuoc ='" + NuocOrder_DTO.maNuoc.Trim() + "' and TenMay='" + NuocOrder_DTO.tenMay.Trim() + "' and MaNhanVien='" + NuocOrder_DTO.maNhanVien.Trim() + "'";
                if (ExecuteNonQuery(NuocOrder, null) > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public bool delete_NuocOrder_DAO(NuocOrder_DTO NuocOrder_DTO)
        {
            try
            {
                Open();
                string NuocOrder = "delete from OrderNuoc  where MaNuoc ='" + NuocOrder_DTO.maNuoc.Trim() + "' and TenMay='" + NuocOrder_DTO.tenMay.Trim() + "' and MaNhanVien='" + NuocOrder_DTO.maNhanVien.Trim() + "'";
                if (ExecuteNonQuery(NuocOrder, null) > 0)
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
