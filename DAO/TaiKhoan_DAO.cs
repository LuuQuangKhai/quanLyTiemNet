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
    public class TaiKhoan_DAO:DataProvider
    {
        public DataTable showQuyen()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from QuyenTaiKhoan", connection);
            DataTable dsQuyen = new DataTable();
            da.Fill(dsQuyen);
            return dsQuyen;
        }
        public DataTable showTaiKhoan()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("Select MaTaiKhoan, TenTaiKhoan,MatKhau,q.MaQuyen,TenQuyen from TaiKhoan tk, QuyenTaiKhoan q where tk.MaQuyen=q.MaQuyen", connection);
            DataTable dstaiKhoan = new DataTable();
            da.Fill(dstaiKhoan);
            return dstaiKhoan;
        }

        public bool Insert_TaiKhoan_DAO(TaiKhoan_DTO taiKhoan)
        {
            try
            {
                Open();
                string SQL = "Insert into TaiKhoan values ('" + taiKhoan.maTaiKhoan + "','" + taiKhoan.tenTaiKhoan+ "','"+taiKhoan.matKhau+"','"+taiKhoan.maQuyen+"')";
                if (ExecuteNonQuery(SQL,null) > 0)
                    return true;
            }
            catch (Exception)
            {
                Close();
            }
            return false;
        }


        public bool Delete_TaiKhoan_DAO(TaiKhoan_DTO taiKhoan)
        {
            try
            {
                Open();
                String SQLKt = "Select MaTaiKhoan from NhanVien where MaTaiKhoan='" + taiKhoan.maTaiKhoan + "'";
                if (ExecuteScalar(SQLKt) != null)
                {
                    MessageBox.Show("Tồn tại người dùng sử dụng nên không thể xóa", "Thông báo");
                    return false;
                }
                else
                {
                    String SQL = "Delete from TaiKhoan where MaTaiKhoan='" + taiKhoan.maTaiKhoan + "'";
                    if (ExecuteNonQuery(SQL,null) > 0)
                    {
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                Close();
                Dispose();
            }
            return false;
        }
     
        public bool Update_TaiKhoan_DAO(TaiKhoan_DTO taiKhoan)
        {

            try
            {
                Open();
                String SQL = "Update TaiKhoan set TenTaiKhoan='" + taiKhoan.tenTaiKhoan + "'," +
                                                 "MatKhau='"+taiKhoan.matKhau+"'," +
                                                 "MaQuyen='"+taiKhoan.maQuyen+"'"+
                                                 " Where MaTaiKhoan='" + taiKhoan.maTaiKhoan + "'";
                if (ExecuteNonQuery(SQL,null) > 0)
                {
                    return true;
                }

            }
            catch (Exception)
            {
                Close();
                Dispose();
            }
            return false;
        }
        public DataTable Search_TaiKhoan_DAO( string tim)
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TaiKhoan where  TenTaiKhoan LIKE '%" + tim + "%' ", connection);
            DataTable dstaiKhoan = new DataTable();
            da.Fill(dstaiKhoan);
            return dstaiKhoan;

        }

        public bool ResetPassWord_TaiKhoanDA0(TaiKhoan_DTO taiKhoan)
        {
            try
            {
                Open();
                String SQL = "Update TaiKhoan set MatKhau='1' where MaTaiKhoan='" + taiKhoan.maTaiKhoan + "'";
                if (ExecuteNonQuery(SQL,null) > 0)
                {
                    return true;
                }

            }
            catch (Exception)
            {
                Close();
                Dispose();
            }
            return false;
        }

     
    }
}
