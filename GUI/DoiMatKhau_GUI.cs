using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAO;
namespace GUI
{
    public partial class DoiMatKhau_GUI : Form 
    {
        DataProvider pro = new DataProvider();
        public DoiMatKhau_GUI()
        {
            InitializeComponent();
        }

        private void DoiMatKhau_GUI_Load(object sender, EventArgs e)
        {
            lblTaiKhoan.Text = DangNhap_GUI.taikhoan;
        }

        private void lblkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text!=""&&txtMatKhauMoi.Text!="")
            {
                pro.Open();
                string kt=("select MatKhau from TaiKhoan where TenTaiKhoan='" + lblTaiKhoan.Text + "'");
                if (pro.ExecuteScalar(kt) != null)
                {
                    if (txtMatKhauCu.Text.Trim() == pro.ExecuteScalar(kt).ToString().Trim())
                    {
                        string update = ("update TaiKhoan set MatKhau='" + txtMatKhauMoi.Text + "' where TenTaiKhoan='" + lblTaiKhoan.Text + "'");
                        if (pro.ExecuteQuery(update) != null)
                            MessageBox.Show("Đổi mật khẩu thành công");
                        else
                            MessageBox.Show("Đổi mật khẩu thất bại");
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng");
                        return;
                    }    
                }
               
            }
            else
            {
                MessageBox.Show("Vui lòng không để trống thông tin mật khẩu");
            }   

        }

        private void txtMatKhauCu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar)||txtMatKhauCu.TextLength>20)
                e.Handled = true;
        }

        private void txtMatKhauMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar)||txtMatKhauMoi.TextLength>20)
                e.Handled = true;
        }
    }
}
