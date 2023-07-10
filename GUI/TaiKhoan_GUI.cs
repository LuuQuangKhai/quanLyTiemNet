using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using BUS;
using DTO;
namespace GUI
{
    public partial class TaiKhoan_GUI : Form
    {
        TaiKhoan_BUS taiKhoan_BUS = new TaiKhoan_BUS();
        public TaiKhoan_GUI()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
                txtMatKhau.Text = "1";
           
            TaiKhoan_DTO taiKhoan_DTO = new TaiKhoan_DTO(txtMaTaiKhoan.Text.Trim(), txtTenTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim(), cbbQuyen.SelectedValue.ToString().Trim());
            DialogResult them = MessageBox.Show("Bạn có chắc sẽ thêm tài khoản ?", "Thông báo", MessageBoxButtons.YesNo);
            if (them == DialogResult.Yes)
            {
                if (txtMaTaiKhoan.Text != "" && txtTenTaiKhoan.Text != "" )
                {
                    if (dgvTaiKhoan.Rows.Count == 1)
                    {
                        if (taiKhoan_BUS.Insert_taiKhoa_BUS(taiKhoan_DTO))
                        {
                            MessageBox.Show("Thêm tài khoản thành công");
                            TaiKhoan_GUI_Load(sender, e);
                            return;
                        }

                    }
                    else
                    {
                        for (int i = 0; i < dgvTaiKhoan.Rows.Count - 1; i++)
                        {
                            string kt = dgvTaiKhoan.Rows[i].Cells["MaTaiKhoan"].Value.ToString().Trim();
                            if (txtMaTaiKhoan.Text.Trim() == kt)
                            {
                                MessageBox.Show("Mã tài khoản đã tồn tại", "Thông báo");
                                return;
                            }
                            else
                            {
                                if (taiKhoan_BUS.Insert_taiKhoa_BUS(taiKhoan_DTO))
                                {
                                    MessageBox.Show("Thêm tài khoản thành công");
                                    TaiKhoan_GUI_Load(sender, e);
                                    return;
                                }
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Không được để trống thông tin");
                    txtMatKhau.Text = "";
                }
            }
            else
                return;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TaiKhoan_DTO taiKhoan_DTO = new TaiKhoan_DTO(txtMaTaiKhoan.Text.Trim(), txtTenTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim(), cbbQuyen.SelectedValue.ToString().Trim());
            if (txtMaTaiKhoan.Text != "")
            {
                DialogResult xoa = MessageBox.Show("Bạn có muốn xóa tài khoản này", "Thông báo", MessageBoxButtons.YesNo);
                if (xoa == DialogResult.Yes)
                {

                    if (taiKhoan_BUS.Delete_taiKhoan_BUS(taiKhoan_DTO))
                    {
                        MessageBox.Show("Xóa tài khoản thành công");
                        btnLamMoi_Click(sender, e);
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
                
            }
            else
                MessageBox.Show("Vui lòng không để trống mã tài khoản");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            DialogResult sua = MessageBox.Show("Bạn có chắc chắn muốn chỉnh sửa thông tin tài khoản ?", "Thông báo", MessageBoxButtons.YesNo);
            if (sua == DialogResult.Yes)
            {
                if (txtTenTaiKhoan.Text.Trim() != "")
                {
                      if(txtMatKhau.Text.Trim() != "")
                    {
                        TaiKhoan_DTO taiKhoan_DTO = new TaiKhoan_DTO(txtMaTaiKhoan.Text.Trim(), txtTenTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim(), cbbQuyen.SelectedValue.ToString().Trim());
                        if (taiKhoan_BUS.Update_TaiKhoan_BUS(taiKhoan_DTO))
                        {
                            MessageBox.Show("Chỉnh sửa tài khoản thành công");
                            btnLamMoi_Click(sender, e);
                            return;
                        }
                    }
                    else
                        MessageBox.Show("Chỉnh sửa thất bại, vui lòng kiểm tra lại thông tin cần sửa");

                }
                else 
                    MessageBox.Show("Chỉnh sửa thất bại, vui lòng kiểm tra lại thông tin cần sửa");
            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin tài khoản cần sửa ");
                return;
            }    
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            TaiKhoan_GUI_Load(sender,e);
        }

        private void TaiKhoan_GUI_Load(object sender, EventArgs e)
        {

            dgvTaiKhoan.DataSource = taiKhoan_BUS.dsTaiKhoan();
            cbbQuyen.DataSource = taiKhoan_BUS.dsQuyen();
            cbbQuyen.DisplayMember = "TenQuyen";
            cbbQuyen.ValueMember = "MaQuyen";
            txtMaTaiKhoan.Text = txtMatKhau.Text = txtTenTaiKhoan.Text = "";
            txtMaTaiKhoan.Enabled = true;

        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTaiKhoan.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaTaiKhoan.Text = row.Cells[0].Value.ToString();
                txtTenTaiKhoan.Text = row.Cells[1].Value.ToString();
                txtMatKhau.Text = row.Cells[2].Value.ToString();
                cbbQuyen.SelectedValue = row.Cells[3].Value.ToString();
                txtMaTaiKhoan.Enabled = false;
            }
            
        }

        private void dgvTaiKhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {

                dgvTaiKhoan.DataSource = taiKhoan_BUS.Search_TaiKhoan_BUS(txtTimKiem.Text.Trim());
            }
            else
                dgvTaiKhoan.DataSource = taiKhoan_BUS.dsTaiKhoan();
        }

        private void btnDatLaiMatKhau_Click(object sender, EventArgs e)
        {
            DialogResult sua = MessageBox.Show("Bạn có chắc chắn muốn đặt lại mật khẩu ?", "Thông báo", MessageBoxButtons.YesNo);
            if (sua == DialogResult.Yes)
            {
                if (txtTenTaiKhoan.Text.Trim() != "")
                {
                    TaiKhoan_DTO taiKhoan_DTO = new TaiKhoan_DTO(txtMaTaiKhoan.Text.Trim(), txtTenTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim(), cbbQuyen.SelectedValue.ToString().Trim());
                    if (taiKhoan_BUS.ResetPassword_TaiKhoan_BUS(taiKhoan_DTO))
                    {
                        MessageBox.Show("Đặt lại mật khẩu thành công \n Mật khẩu mặc định là 1");
                        btnLamMoi_Click(sender, e);
                        return;
                    }
                }
                else
                    MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }

        private void btnThongTinQuyen_Click(object sender, EventArgs e)
        {
            QuyenTaiKhoan_GUI quyen = new QuyenTaiKhoan_GUI();
            quyen.Show();
        }

        private void lblkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMatKhau.TextLength > 20||char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtTenTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTenTaiKhoan.TextLength > 20|char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

     
    }
}
