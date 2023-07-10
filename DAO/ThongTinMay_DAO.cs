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
    public class ThongTinMay_DAO:DataProvider
    {
        public DataTable dsMay_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from May where TrangThai='Đóng'",connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable dsMayMo_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select ttm.TenMay,TrangThai,ThoiGianMo,ThoiGianDong,ThoiGianSuDung,MaNhanVien" +
                                                    " from May, ThongTinMay ttm " +
                                                    " where  May.TenMay = ttm.TenMay  ", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool moMay_DAO(May_DTO thongTinMay_DTO, string manv,string time)
        {
            try
            {
                Open();
                string sql = "insert into ThongTinMay values (N'"+thongTinMay_DTO.TenMay.Trim()+"','"+manv.Trim()+"','"+time.ToString()+"',null,null)";
                if (ExecuteNonQuery(sql, null) > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool tatMay_DAO(May_DTO thongTinMay_DTO, string time)
        {
            try
            {
                Open();
                string sql = "update ThongTinMay set ThoiGianDong='" + time.ToString() + "' where TenMay= '" + thongTinMay_DTO.TenMay.Trim() + "'";
                if (ExecuteNonQuery(sql, null) > 0)
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
