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
    public partial class DichVu_GUI : Form
    {
        DoAnOrder_BUS doAnOrder_BUS = new DoAnOrder_BUS();
        DoAn_BUS doAn_BUS = new DoAn_BUS();
        NuocOrder_BUS nuocOrder_BUS = new NuocOrder_BUS();
        Nuoc_BUS nuoc_BUS = new Nuoc_BUS();
        TheOrder_BUS TheOrder_BUS = new TheOrder_BUS();
        The_BUS The_BUS = new The_BUS();
        public int soLuongMon { get; set; }
        public int soLuongNuoc { get; set; }

        public int soLuongThe { get; set; }

        public DoAnOrder_DTO doAnOrder()
        {
            return new DoAnOrder_DTO(cbbDoAn.SelectedValue.ToString().Trim(), Convert.ToInt32(txtSoLuongDoAn.Text.Trim()), ThongTinMay_GUI.tenmay.Trim(), DangNhap_GUI.taikhoan.Trim());
        }
        public NuocOrder_DTO NuocOrder()
        {
            return new NuocOrder_DTO(cbbNuoc.SelectedValue.ToString().Trim(), Convert.ToInt32(txtSoLuongNuoc.Text.Trim()), ThongTinMay_GUI.tenmay.Trim(), DangNhap_GUI.taikhoan.Trim());
        }

        public TheOrder_DTO TheOrder()
        {
            return new TheOrder_DTO(cbbThe.SelectedValue.ToString().Trim(), Convert.ToInt32(txtSoLuongThe.Text.Trim()), ThongTinMay_GUI.tenmay.Trim(), DangNhap_GUI.taikhoan.Trim());
        }
        public DichVu_GUI()
        {
            InitializeComponent();
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtSoLuongDoAn.Text=="0")
                {
                    return;
                }
                else
                {
                    if (doAnOrder_BUS.insert_DoAnOrder_DTO(doAnOrder()))
                    {
                        {
                            DichVu_GUI_Load(sender, e);
                            txtSoLuongDoAn.Text = "0";
                        }
                    }

                    else
                        MessageBox.Show("Thêm thất bại");
                }
              
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void DichVu_GUI_Load(object sender, EventArgs e)
        {
            gbDanhDachOrder.Text = "Danh sách Order " + ThongTinMay_GUI.tenmay.ToString().Trim() + "";
            cbbDoAn.DataSource = doAn_BUS.showdsDoAn_BUS();
            cbbDoAn.ValueMember = "MaDoAn";
            cbbDoAn.DisplayMember = "TenDoAn";
            dgvDoAn.DataSource = doAnOrder_BUS.showdsDoAnOrder_BUS(ThongTinMay_GUI.tenmay);

            cbbNuoc.DataSource = nuoc_BUS.showdsNuoc_BUS();
            cbbNuoc.ValueMember = "MaNuoc";
            cbbNuoc.DisplayMember = "TenNuoc";
            dgvNuoc.DataSource = nuocOrder_BUS.showdsNuocOrder_BUS(ThongTinMay_GUI.tenmay);

            cbbThe.DataSource = The_BUS.showdsThe_BUS();
            cbbThe.ValueMember = "TenThe";
            cbbThe.DisplayMember = "TenThe";
            dgvThe.DataSource = TheOrder_BUS.showdsTheOrder_BUS(ThongTinMay_GUI.tenmay);
        }

        private void txtSoLuongDoAn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

     

        private void btnTangMon_Click(object sender, EventArgs e)
        {
            soLuongMon = Convert.ToInt32(txtSoLuongDoAn.Text) + 1;
            txtSoLuongDoAn.Text = soLuongMon.ToString();
        }

        private void btnGiamMon_Click(object sender, EventArgs e)
        {
            if(txtSoLuongDoAn.Text=="0")
            {
                return;
            }    
            else
            {
                soLuongMon = Convert.ToInt32(txtSoLuongDoAn.Text) - 1;
                txtSoLuongDoAn.Text = soLuongMon.ToString();
            }    
           
        }

        private void dgvDoAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow r = dgvDoAn.Rows[e.RowIndex];
                cbbDoAn.Text = r.Cells[0].Value.ToString();
                txtSoLuongDoAn.Text = r.Cells[1].Value.ToString();
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            try
            {
                if (doAnOrder_BUS.update_DoAnOrder_DTO(doAnOrder()))
                {
                    {
                        DichVu_GUI_Load(sender, e);
                    }
                }

                else
                    MessageBox.Show("Sửa thất bại");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnXoaMonAn_Click(object sender, EventArgs e)
        {
            try
            {
                if (doAnOrder_BUS.delete_DoAnOrder_DTO(doAnOrder()))
                {
                    {
                        DichVu_GUI_Load(sender, e);
                    }
                }

                else
                    MessageBox.Show("Xóa thất bại");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnTangNuoc_Click(object sender, EventArgs e)
        {
            soLuongNuoc = Convert.ToInt32(txtSoLuongNuoc.Text) + 1;
            txtSoLuongNuoc.Text = soLuongNuoc.ToString();
        }

        private void btnGiamNuoc_Click(object sender, EventArgs e)
        {

            if (txtSoLuongNuoc.Text == "0")
            {
                return;
            }
            else
            {
                soLuongMon = Convert.ToInt32(txtSoLuongNuoc.Text) - 1;
                txtSoLuongNuoc.Text = soLuongMon.ToString();
            };
        }

        private void btnThemNuoc_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtSoLuongNuoc.Text=="0")
                {
                    return;
                }
                else
                {
                    if (nuocOrder_BUS.insert_NuocOrder_DTO(NuocOrder()))
                    {
                        {
                            DichVu_GUI_Load(sender, e);
                            txtSoLuongNuoc.Text = "0";
                        }
                    }

                    else
                        MessageBox.Show("Thêm thất bại");
                }
        
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSuaNuoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (nuocOrder_BUS.update_NuocOrder_DTO(NuocOrder()))
                {
                    {
                        DichVu_GUI_Load(sender, e);
                    }
                }

                else
                    MessageBox.Show("Sửa thất bại");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (nuocOrder_BUS.delete_NuocOrder_DTO(NuocOrder()))
                {
                    {
                        DichVu_GUI_Load(sender, e);
                    }
                }

                else
                    MessageBox.Show("Xóa thất bại");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvNuoc.Rows[e.RowIndex];
                cbbNuoc.Text = r.Cells[0].Value.ToString();
                txtSoLuongNuoc.Text = r.Cells[1].Value.ToString();
            }
        }

        private void btnTangThe_Click(object sender, EventArgs e)
        {
            soLuongThe = Convert.ToInt32(txtSoLuongThe.Text) + 1;
            txtSoLuongThe.Text = soLuongThe.ToString();
        }

        private void btnGiamThe_Click(object sender, EventArgs e)
        {

            if (txtSoLuongThe.Text == "0")
            {
                return;
            }
            else
            {
                soLuongMon = Convert.ToInt32(txtSoLuongThe.Text) - 1;
                txtSoLuongThe.Text = soLuongMon.ToString();
            }
        }

        private void btnThemThe_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtSoLuongThe.Text=="0")
                {
                    return;
                }    
                else
                {
                    if (TheOrder_BUS.insert_TheOrder_DTO(TheOrder()))
                    {
                        {
                            DichVu_GUI_Load(sender, e);
                            txtSoLuongThe.Text = "0";
                        }
                    }

                    else
                        MessageBox.Show("Thêm thất bại");
                }
             
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSuaThe_Click(object sender, EventArgs e)
        {
            try
            {
                if (TheOrder_BUS.update_TheOrder_DTO(TheOrder()))
                {
                    {
                        DichVu_GUI_Load(sender, e);
                    }
                }

                else
                    MessageBox.Show("Sửa thất bại");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnXoaThe_Click(object sender, EventArgs e)
        {
            try
            {
                if (TheOrder_BUS.delete_TheOrder_DTO(TheOrder()))
                {
                    {
                        DichVu_GUI_Load(sender, e);
                    }
                }

                else
                    MessageBox.Show("Xóa thất bại");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvThe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvThe.Rows[e.RowIndex];
                cbbThe.Text = r.Cells[0].Value.ToString();
                txtSoLuongThe.Text = r.Cells[1].Value.ToString();
            }
        }

        private void lblkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
