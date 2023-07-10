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
    public partial class ThongTinMay_GUI : Form
    {
        ThongTinMay_BUS thongTinMayBUS = new ThongTinMay_BUS();
        public static string tenmay;
        public static string ngayDong;
        public static string tgsd;
        public ThongTinMay_GUI()
        {
            InitializeComponent();
            if (DangNhap_GUI.taikhoan == "Admin")
            {
                lblkThoat.Visible = true;
            }
            else
                lblkThoat.Visible = false;
        }
        public ThongTinMay_DTO thongTinMay_DTO()
        {
            if (lblThoiGianDong.Text == "")
                lblThoiGianDong.Text = null;
            if (lblThoiGianSuDung.Text == "")
                lblThoiGianSuDung.Text = null;
            return new ThongTinMay_DTO(lblMay.Text.Trim(), lblTrangThai.Text.Trim(), lblNhanVien.Text.Trim(), lblThoiGian.Text.Trim(), lblThoiGianDong.Text.Trim(), lblThoiGianSuDung.Text.Trim());
        }
        public May_DTO may_DTO()
        {
            return new May_DTO(lblMay.Text, lblTrangThai.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").ToString();
        }

       
        public void ThongTinMay_GUI_Load(object sender, EventArgs e)
        {
            lblNhanVien.Text = DangNhap_GUI.taikhoan;
            dgvDanhSachMay.DataSource = thongTinMayBUS.dsMay_BUS();
            dgvThongTinMay.DataSource = thongTinMayBUS.dsMayMo_BUS();
            lblMay.Text=lblTrangThai.Text = lblThoiGianMo.Text = lblThoiGianDong.Text = lblThoiGianSuDung.Text = "";
            btnDichVu.Enabled = false;
            btnMoMay.Enabled = false;
            btnDongMay.Enabled = false;

        }

        private void dgvThongTinMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow r = dgvThongTinMay.Rows[e.RowIndex];
                lblMay.Text = r.Cells[0].Value.ToString();
                
                lblTrangThai.Text = r.Cells[1].Value.ToString();
                lblThoiGianMo.Text = r.Cells[2].Value.ToString();
                lblThoiGianDong.Text = r.Cells[3].Value.ToString();
                lblThoiGianSuDung.Text = r.Cells[4].Value.ToString();
                btnMoMay.Enabled = false;
                btnDichVu.Enabled = true;
                btnDongMay.Enabled = true;
                btnTinhTien.Enabled = true;
                
            }


        }

        private void dgvDanhSachMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvDanhSachMay.Rows[e.RowIndex];
                lblMay.Text = r.Cells[0].Value.ToString();
                lblTrangThai.Text = r.Cells[1].Value.ToString();
                btnMoMay.Enabled = true;

                btnDichVu.Enabled = false;
                btnDongMay.Enabled = false;
                lblThoiGianMo.Text = lblThoiGianDong.Text = lblThoiGianSuDung.Text = "";
                btnTinhTien.Enabled = false;
            }
        }

        private void btnMoMay_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn mở máy này", "Xác nhận mở máy", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
               if(lblMay.Text=="")
                {
                    MessageBox.Show("Chọn máy để mở");
                }
                else
                {
                    if (thongTinMayBUS.moMay_BUS(may_DTO(), lblNhanVien.Text, lblThoiGian.Text))
                    {
                        MessageBox.Show("Mở máy thành công");
                        ThongTinMay_GUI_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Mở máy thất bại");
                    }
                }
            }
            else
                return;
        }

       

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            tenmay = lblMay.Text;
            DichVu_GUI dv = new DichVu_GUI();
            dv.Show();
        }

        private void lblMay_TextChanged(object sender, EventArgs e)
        {
            if (lblMay.Text == "")
            {
                btnMoMay.Enabled = false;
                btnDichVu.Enabled = false;
                btnDongMay.Enabled = false;
            }
          
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn tắt máy này và tính tiền", "Xác nhận tắt máy", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                if (lblMay.Text == "")
                {
                    MessageBox.Show("Chọn máy để tắt");
                }
                else
                {
                    if (thongTinMayBUS.tatMay_BUS(may_DTO(), lblThoiGian.Text))
                    {
                        MessageBox.Show("Tắt máy thành công");
                        dgvThongTinMay.DataSource = thongTinMayBUS.dsMayMo_BUS();
                    }

                    else
                    {
                        MessageBox.Show("Tắt máy thất bại");
                    }
                   
                }
                
            }

            else
                return;
            ThongTinMay_GUI_Load(sender, e);
        }

        private void btnTinhTien_Click_1(object sender, EventArgs e)
        {
            if(lblThoiGianDong.Text==""||lblThoiGianSuDung.Text=="")
            {
                if (lblTrangThai.Text == "Mở")
                {
                    MessageBox.Show("Vui lòng đóng máy trước khi tính tiền");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn máy muốn tính tiền ");
                return;
                }
            }    
            else
            {
                    ngayDong = Convert.ToDateTime(lblThoiGianDong.Text).ToString("yyyy-MM-dd HH:mm:ss").ToString();
                    tenmay = lblMay.Text;
                    tgsd = lblThoiGianSuDung.Text;
                    ThongTinThanhToan_GUI thongTinThanhToan_GUI = new ThongTinThanhToan_GUI();
                    thongTinThanhToan_GUI.Show();
                    ThongTinMay_GUI_Load(sender, e);
                   
            }    
           
        }

        private void lblkDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap_GUI dangNhap = new DangNhap_GUI();
            dangNhap.Show();
            this.Close();
        }

        private void lblkLamMoi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThongTinMay_GUI_Load(sender, e);
        }

        private void lblkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

       
    }
}
