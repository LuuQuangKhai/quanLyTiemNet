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
    public partial class GiaoDienAdmin : Form
    {
        public GiaoDienAdmin()
        {
            InitializeComponent();
        }

        private void btnQuanLiNhanVien_Click(object sender, EventArgs e)
        {
            pCuaSoChinh.Controls.Clear();
            NhanVien_GUI nhanvien = new NhanVien_GUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true };
            this.pCuaSoChinh.Controls.Add(nhanvien);
            nhanvien.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap_GUI dangNhap = new DangNhap_GUI();
            dangNhap.Show();
            this.Close();
        }

        private void btnQuanLiTaiKhoan_Click(object sender, EventArgs e)
        {
            pCuaSoChinh.Controls.Clear();
            TaiKhoan_GUI taiKhoan = new TaiKhoan_GUI()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true };
            this.pCuaSoChinh.Controls.Add(taiKhoan);
            taiKhoan.Show();
        }

        private void btnQuanLiDanhMuc_Click(object sender, EventArgs e)
        {
            pCuaSoChinh.Controls.Clear();
            DanhMuc_GUI danhMuc = new DanhMuc_GUI()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true };
            this.pCuaSoChinh.Controls.Add(danhMuc);
            danhMuc.Show();
        }

        private void btnQuanLiHoaDon_Click(object sender, EventArgs e)
        {
            pCuaSoChinh.Controls.Clear();
            PhieuThongKe_GUI tk = new PhieuThongKe_GUI()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true };
            this.pCuaSoChinh.Controls.Add(tk);
            tk.Show();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            pCuaSoChinh.Controls.Clear();
            ThongTinMay_GUI thongTinMay = new ThongTinMay_GUI()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true };
            this.pCuaSoChinh.Controls.Add(thongTinMay);
            thongTinMay.Show();


        }
  
        private void button2_Click(object sender, EventArgs e)
        {
            pCuaSoChinh.Controls.Clear();
            May_GUI may = new May_GUI()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true };
            this.pCuaSoChinh.Controls.Add(may);
            may.Show();
        }
    }
}
