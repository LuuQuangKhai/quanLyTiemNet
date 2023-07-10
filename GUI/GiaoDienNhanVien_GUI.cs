using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GiaoDienNhanVien_GUI : Form
    {
        public GiaoDienNhanVien_GUI()
        {
            InitializeComponent();
        }

        private void GiaoDienNhanVien_GUI_Load(object sender, EventArgs e)
        {
            lblNhanVien.Text = "Chào mừng nhân viên " + DangNhap_GUI.taikhoan;
            pCuaSoChinh.Controls.Clear();
            ThongTinMay_GUI thongTinMay = new ThongTinMay_GUI()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true };
            this.pCuaSoChinh.Controls.Add(thongTinMay);
            thongTinMay.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap_GUI dangNhap = new DangNhap_GUI();
            dangNhap.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoiMatKhau_GUI doiMatKhau_GUI = new DoiMatKhau_GUI();
            doiMatKhau_GUI.Show();
        }
    }
}
