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
    public class DoAnOrder_DAO:DataProvider
    {
        public DataTable showdsDoAnOrder_DAO(string tenmay)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select TenDoAn, SoLuongDoAnOrder from DoAn, OrderDoAn" +
                                                    " where DoAn.MaDoAn=OrderDoAn.MaDoAn" +
                                                    " and TenMay='"+tenmay+"'", connection);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        public bool insert_DoAnOrder_DAO(DoAnOrder_DTO doAnOrder_DTO)
        {
            try
            {
                Open();
                string doAnOrder = "insert into OrderDoAn values ('"+doAnOrder_DTO.tenMay.Trim()+"','"+doAnOrder_DTO.maDoAn.Trim()+"',"+doAnOrder_DTO.soLuong+ ",0,'" + doAnOrder_DTO.maNhanVien.Trim() + "')";
                if (ExecuteNonQuery(doAnOrder, null) > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public bool update_DoAnOrder_DAO(DoAnOrder_DTO doAnOrder_DTO)
        {
            try
            {
                Open();
                string doAnOrder = "update OrderDoAn  set SoLuongDoAnOrder=" + doAnOrder_DTO.soLuong + " where MaDoAn ='" + doAnOrder_DTO.maDoAn.Trim() + "' and TenMay='" + doAnOrder_DTO.tenMay.Trim() + "' and MaNhanVien='" + doAnOrder_DTO.maNhanVien.Trim() + "'";
                if (ExecuteNonQuery(doAnOrder, null) > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public bool delete_DoAnOrder_DAO(DoAnOrder_DTO doAnOrder_DTO)
        {
            try
            {
                Open();
                string doAnOrder = "delete from OrderDoAn  where MaDoAn ='" + doAnOrder_DTO.maDoAn.Trim() + "' and TenMay='" + doAnOrder_DTO.tenMay.Trim() + "' and MaNhanVien='" + doAnOrder_DTO.maNhanVien.Trim() + "'";
                if (ExecuteNonQuery(doAnOrder, null) > 0)
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
