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
    public class DangNhap_DAO:DataProvider
    {
        public int Login_DAO(DangNhap_DTO dangNhap)
        {
            try
            {
                Open();
                String SQL = "select TenTaiKhoan, MatKhau from TaiKhoan where TenTaiKhoan='" + dangNhap.tenTaiKhoan.Trim() + "' COLLATE Latin1_General_CS_AS and MatKhau='" + dangNhap.matKhau.Trim() + "' COLLATE Latin1_General_CS_AS";
                if (ExecuteScalar(SQL,null) !=null)
                {
                    String ktQ = "select MaQuyen from TaiKhoan where TenTaiKhoan='" + dangNhap.tenTaiKhoan.Trim() + "'";
                    if (ExecuteScalar(ktQ).ToString().Trim() == "Admin")
                    {
                        return 1;
                    }
                    else
                        return 2;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return 0;
        }
    }
}
