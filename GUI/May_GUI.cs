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
using DTO;
using BUS;
namespace GUI
{
    public partial class May_GUI : Form
    {
        May_BUS may_BUS = new May_BUS();

        public May_GUI()
        {
            InitializeComponent();
        }

        private void May_GUI_Load(object sender, EventArgs e)
        {
            dgvMay.DataSource = may_BUS.dsMay__BUS();
        }

        private void dgvMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow r = this.dgvMay.Rows[e.RowIndex];
                txtTenMay.Text = r.Cells[0].Value.ToString() ;
                txtTrangThai.Text = r.Cells[1].Value.ToString();
                txtTrangThai.Enabled = false;
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult them = MessageBox.Show("Bạn có muốn thêm máy", "Thông báo", MessageBoxButtons.YesNo);
            if(them==DialogResult.Yes)
            {
                if(txtTenMay.Text!="")
                {
                    May_DTO may = new May_DTO(txtTenMay.Text, txtTrangThai.Text);
                    if (may_BUS.insert_May_BUS(may))
                    {
                        MessageBox.Show("Thêm máy thành công");
                        May_GUI_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Thêm máy thất bại, vui lòng kiểm tra lại thông tin ");
                    }
                }
                else
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin ");

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult them = MessageBox.Show("Bạn có muốn xóa máy", "Thông báo", MessageBoxButtons.YesNo);
            if (them == DialogResult.Yes)
            {
                if (txtTenMay.Text != "")
                {
                    May_DTO may = new May_DTO(txtTenMay.Text, txtTrangThai.Text);
                    if (may_BUS.delete_May_BUS(may))
                    {
                        MessageBox.Show("Xóa máy thành công");
                        May_GUI_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa vì máy vẫn còn trong sử dụng ");
                    }
                }
                else
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin ");

            }
        }

        private void lblkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenMay.Text = txtTrangThai.Text = "";
            txtTenMay.Enabled = true;
        }

        private void txtTenMay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTenMay.TextLength > 20)
                e.Handled = true;
        }
    }
}
