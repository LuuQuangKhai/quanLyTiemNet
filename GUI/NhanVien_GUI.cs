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
    public partial class NhanVien_GUI : Form
    {
        NhanVien_BUS nhanVien_BUS = new NhanVien_BUS();
        public NhanVien_GUI()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public bool kt_NhanVien()
        {
            for(int i=0;i<=dgvNhanVien.RowCount-1;i++)
            {
                if (txtMaNhanVien.Text.Trim() == dgvNhanVien.Rows[i].Cells["MaNhanVien"].ToString().Trim())
                    return true;
            }
            return false;
        }

        public bool ktRong()
        {
            if (txtMaNhanVien.Text.Trim()==""||txtTenNhanVien.Text.Trim()==""||txtDienThoai.Text.Trim().Trim()==""||txtDiaChi.Text.Trim()==""||txtEmail.Text.Trim()=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ");
                return false;
            }
            return true;
        }
        public void ClearTextbox()
        {
            txtMaNhanVien.Clear();
            txtTenNhanVien.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
        }

        public NhanVien_DTO nhanVien_DTO()
        {
            return new NhanVien_DTO(txtMaNhanVien.Text, txtTenNhanVien.Text, txtDienThoai.Text, txtDiaChi.Text, txtEmail.Text);
        }
        private void NhanVien_GUI_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nhanVien_BUS.showNhanVien_BUS();
        }

     
  

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvNhanVien.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaNhanVien.Text = row.Cells[0].Value.ToString();
                txtTenNhanVien.Text = row.Cells[1].Value.ToString();
                txtDienThoai.Text=row.Cells[2].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                txtMaNhanVien.Enabled = false;
                

            }
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!kt_NhanVien())
            {
                DialogResult result = MessageBox.Show("Xác nhân thêm nhân viên ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (ktRong() == false)
                            return;
                        else
                        {
                            if (nhanVien_BUS.Insert_NhanVien_BUS(nhanVien_DTO()) == true)
                            {
                                MessageBox.Show("Thêm nhân viên thành công");
                                btnLamMoi_Click(sender, e);
                            }
                            else
                                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else return;
            }
            else
                MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng nhập lại ");
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhân xóa nhân viên ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (txtMaNhanVien.Text == "")
                    {
                        MessageBox.Show("Vui lòng không để trống mã nhân viên");
                        return;
                    }
                    else
                    {
                        if (nhanVien_BUS.Delete_NhanVien_BUS(nhanVien_DTO()))

                        {
                            MessageBox.Show("Xóa nhân viên thành công");
                            btnLamMoi_Click(sender, e);
                        }
                        else
                            MessageBox.Show("Xóa thất bại, vui lòng kiểm tra lại thông tin");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else return;
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nhanVien_BUS.showNhanVien_BUS();
            ClearTextbox();
            txtMaNhanVien.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult sua = MessageBox.Show("Xác nhận sửa thông tin nhân viên", "Thông báo", MessageBoxButtons.YesNo);
            if(sua==DialogResult.Yes)
            {
                if(ktRong())
                {
                    if (txtMaNhanVien.Text != "")
                    {
                        if (nhanVien_BUS.Update_NhanVien_BUS(nhanVien_DTO()))

                        {
                            MessageBox.Show("Cập nhập thông tin thành công");
                            btnLamMoi_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại, vui lòng kiểm tra lại thông tin");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại, vui lòng kiểm tra lại");
                        return;
                    }
                }                         
            }    
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text.Trim()!="")
            {
                dgvNhanVien.DataSource = nhanVien_BUS.Search_NhanVien_BUS(txtTimKiem.Text);
            }
            else
            {
                dgvNhanVien.DataSource = nhanVien_BUS.showNhanVien_BUS();   
            }
        }

        private void lblkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void txtTenNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || txtDienThoai.TextLength >= 11||char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
