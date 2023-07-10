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
    public class QuyenTaiKhoan_DAO:DataProvider
    {
        //Load danh sách bảng Quyền tài khoản lên form 
        public DataTable showQuyenTaiKhoan()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("Select*from QuyenTaiKhoan",connection);
            DataTable dsQuyenTaiKhoan = new DataTable();
            da.Fill(dsQuyenTaiKhoan);
            return dsQuyenTaiKhoan;
        }


    }
}
