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
   public class NhanVien_DAO:DataProvider
    {

        public DataTable showNhanVien_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("Select*from  NhanVien where MaNhanVien!='Admin'", connection);
            DataTable dsQuyenTaiKhoan = new DataTable();
            da.Fill(dsQuyenTaiKhoan);
            return dsQuyenTaiKhoan;
        }

        public bool InsertNhanVien_DAO(NhanVien_DTO nhanVien_DTO)
        {
            try
            {
                Open();
                
                    string SQL = "Insert into NhanVien values ('" + nhanVien_DTO.MaNhanVien + "',N'" + nhanVien_DTO.TenNhanVien + "','" + nhanVien_DTO.SDT + "',N'" + nhanVien_DTO.DiaChi + "','" + nhanVien_DTO.Email + "')";
                if (ExecuteNonQuery(SQL, null) > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return false;
            
        }

        public bool DeleteNhanVien_DAO(NhanVien_DTO nhanVien_DTO)
        {
            Open();
            try
            {
              
                    string SQL = "delete from NhanVien where MaNhanVien='" + nhanVien_DTO.MaNhanVien.Trim() + "'";
                    if (ExecuteNonQuery(SQL, null)>0)
                    {     
                            return true;
                    }

                
            }
            catch (Exception)
            {   

                throw;
            }
            return false;
        }

        public bool Update_NhanVien_DAO(NhanVien_DTO nhanVien_DTO)
        {
            try
            {
                Open();
                string SQL= "Update NhanVien set TenNhanVien=N'"+nhanVien_DTO.TenNhanVien+"'," +
                    " SDT='" + nhanVien_DTO.SDT + "'," +
                    " Email='" + nhanVien_DTO.Email + "'," +
                    " DiaChi=N'"+nhanVien_DTO.DiaChi+"' "+
                    " where MaNhanVien='" + nhanVien_DTO.MaNhanVien + "'";
                if (ExecuteNonQuery(SQL, null)>0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

     
            public DataTable Search_NhanVien_DAO(string tim)
            {
                Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from NhanVien where MaNhanVien='" + tim + "' or TenNhanVien=N'" + tim + "' or SDT='" + tim + "' or DiaChi=N'"+tim+"' or Email='"+tim+"'", connection);
                DataTable dstaiKhoan = new DataTable();
                da.Fill(dstaiKhoan);
                return dstaiKhoan;   
            }
    }
}
