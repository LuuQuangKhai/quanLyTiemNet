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
using BUS;
using DTO;
namespace GUI
{
    public partial class DangNhap_GUI : Form
    {
        DangNhap_BUS dangNhap = new DangNhap_BUS();
        public static string taikhoan;
        public DangNhap_GUI()
        {
            InitializeComponent();
        }
        public DangNhap_DTO dangNhap_DTO()
        {
            return new DangNhap_DTO(txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim());
        }
        private void btnHienMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                btnKhongHienMatKhau.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void btnKhongHienMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')

            {
                btnHienMatKhau.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTaiKhoan.Text.Trim()!=""&& txtMatKhau.Text.Trim()!="")
                {
                    if (dangNhap.dangNhap_BUS(dangNhap_DTO()) == 1)
                    {
                        MessageBox.Show("Bạn đăng nhập dưới quyền Admin");
                        taikhoan = txtTaiKhoan.Text;
                        GiaoDienAdmin admin = new GiaoDienAdmin();
                        admin.Show();
                        this.Hide();
                    }
                    else if (dangNhap.dangNhap_BUS(dangNhap_DTO()) == 2)
                    {
                        MessageBox.Show("Bạn đăng nhập dưới quyền nhân viên");
                        taikhoan = txtTaiKhoan.Text;
                        GiaoDienNhanVien_GUI nhanVien_GUI = new GiaoDienNhanVien_GUI();
                        nhanVien_GUI.Show();
                        this.Hide();
                    }
                    
                    else
                        MessageBox.Show("Đăng nhập thất bại");
                }    
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập");

            }
            catch (Exception)
            {

                throw;
            }
        }

   
        private void DangNhap_GUI_Load(object sender, EventArgs e)
        {
            this.Padding = new System.Windows.Forms.Padding(5);
        }

        private void txtTaiKhoan_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txtMatKhau.BackColor = SystemColors.Control;
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            txtTaiKhoan.BackColor = SystemColors.Control;
        }

        private void llblQuenMatKhau_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ với quản lí để tiến hành đặt lại mật khẩu");
        }
    }
}
