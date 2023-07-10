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
    public partial class DanhMuc_GUI : Form
    {
        DoAn_BUS doAn_BUS = new DoAn_BUS();
        Nuoc_BUS nuoc_BUS = new Nuoc_BUS();
        The_BUS the_BUS = new The_BUS();

        public DanhMuc_GUI()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public DoAn_DTO doAn_DTO()
        {
            return new DoAn_DTO(txtMaDoAn.Text.Trim(), txtTenDoAn.Text.Trim(), "Đồ ăn", float.Parse(txtGiaDoAn.Text.Trim()));
        }
        public Nuoc_DTO Nuoc_DTO()
        {
            return new Nuoc_DTO(txtMaNuoc.Text.Trim(), txtTenNuoc.Text.Trim(), "Nước", float.Parse(txtGiaNuoc.Text.Trim()));
        }
        public The_DTO the_DTO()
        {
            return new The_DTO( txtTenThe.Text.Trim(), "Thẻ", float.Parse(txtGiaThe.Text.Trim()));
        }

        public bool kt_DoAn()
        {
            for(int i=0;i<=dgvDoAn.Rows.Count-1;i++)
            {
                if ( dgvDoAn.Rows[i].Cells["MaDoAn"].Value.ToString().Trim()== txtMaDoAn.Text.Trim())
                {
                    return true;
                }
            }
            return false;
        }
        public bool kt_Nuoc()
        {
            for (int i = 0; i < dgvNuoc.Rows.Count - 1; i++)
            {
                if (txtMaNuoc.Text.Trim() == dgvNuoc.Rows[i].Cells["MaNuoc"].Value.ToString().Trim())
                {
                    return true;
                }
            }
            return false;
        }

        public bool kt_The()
        {
            for (int i = 0; i < dgvThe.Rows.Count - 1; i++)
            {
                if (txtTenThe.Text.Trim() == dgvThe.Rows[i].Cells["TenThe"].Value.ToString().Trim())
                {
                    return true;
                }
            }
            return false;
        }


        public void ClearDoAn()
        {

            txtMaDoAn.Clear();
            txtTenDoAn.Clear();
            txtGiaDoAn.Clear();
            txtTimDoAn.Clear();
        }
        public void ClearNuoc()
        {

            txtMaNuoc.Clear();
            txtTenNuoc.Clear();
            txtGiaNuoc.Clear();
            txtTimNuoc.Clear();
        }
        public void ClearThe()
        {
            txtTenThe.Clear();
            txtGiaThe.Clear();
            txtTimKiemThe.Clear();
        }

        private void DanhMuc_GUI_Load(object sender, EventArgs e)
        {
            dgvDoAn.DataSource = doAn_BUS.showdsDoAn_BUS();
            dgvNuoc.DataSource = nuoc_BUS.showdsNuoc_BUS();
            dgvThe.DataSource = the_BUS.showdsThe_BUS();
        }

        private void dgvDoAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDoAn.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaDoAn.Text = row.Cells[0].Value.ToString();
                txtTenDoAn.Text = row.Cells[1].Value.ToString();
                txtGiaDoAn.Text = row.Cells[3].Value.ToString();
                txtMaDoAn.Enabled = false;

            }
           
        }
        private void dgvNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvNuoc.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaNuoc.Text = row.Cells[0].Value.ToString();
                txtTenNuoc.Text = row.Cells[1].Value.ToString();
                txtGiaNuoc.Text = row.Cells[3].Value.ToString();
                txtMaNuoc.Enabled = false;

            }
        }

        private void dgvThe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvThe.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtTenThe.Text = row.Cells[0].Value.ToString();
                txtGiaThe.Text = row.Cells[2].Value.ToString();
                txtTenThe.Enabled = false;

            }
        }


        private void btnThemDoAn_Click(object sender, EventArgs e)
        {
           if(!kt_DoAn())
            {
                DialogResult Nuocm = MessageBox.Show("Xác nhận thêm đồ ăn ? ", "Thông báo", MessageBoxButtons.YesNo);
                if (Nuocm == DialogResult.Yes)
                {
                    try
                    {
                        if (txtMaDoAn.Text != "" && txtTenDoAn.Text != "" && txtGiaDoAn.Text != "")
                        {
                            if (doAn_BUS.Insert_DoAn_BUS(doAn_DTO()))
                            {
                                MessageBox.Show("Thêm đồ ăn thành công");
                                btnLamMoiDoAn_Click(sender, e);
                            }
                            else
                                MessageBox.Show("Thêm đồ ăn thất bại");
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                            btnLamMoiDoAn_Click(sender, e);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }   
           else
            {
                MessageBox.Show("Mã đồ ăn đã tồn tại, vui lòng nhập lại mã khác ", "Thông báo");

               
            }    
        }
        private void btnThemNuoc_Click(object sender, EventArgs e)
        {
         if (!kt_Nuoc())
            {
                DialogResult Nuocm = MessageBox.Show("Xác nhận thêm nước ? ", "Thông báo", MessageBoxButtons.YesNo);
                if (Nuocm == DialogResult.Yes)
                {
                    try
                    {
                        if (txtMaNuoc.Text != "" && txtTenNuoc.Text != "" && txtGiaNuoc.Text != "")
                        {
                            if (nuoc_BUS.Insert_Nuoc_BUS(Nuoc_DTO()))
                            {
                                MessageBox.Show("Thêm nước thành công");
                                btnLamMoiNuoc_Click(sender, e);
                            }
                            else
                                MessageBox.Show("Thêm nước thất bại");
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                            btnLamMoiNuoc_Click(sender, e);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            else
            {
               
                MessageBox.Show("Mã nước đã tồn tại, vui lòng nhập lại mã khác ", "Thông báo");

            }
        }
        private void btnThemThe_Click(object sender, EventArgs e)
        {
            if(!kt_The())
            {
                DialogResult Them = MessageBox.Show("Xác nhận thêm thẻ ? ", "Thông báo", MessageBoxButtons.YesNo);
                if (Them == DialogResult.Yes)
                {
                    try
                    {
                        if (txtTenThe.Text != "" && txtGiaThe.Text != "")
                        {
                            if (the_BUS.Insert_The_BUS(the_DTO()))
                            {
                                MessageBox.Show("Thêm thẻ thành công");
                                btnLamMoiThe_Click(sender, e);
                            }
                            else
                                MessageBox.Show("Thêm thẻ thất bại");
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                            btnLamMoiThe_Click(sender, e);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            else
            {
               
                MessageBox.Show("Thẻ đã tồn tại, vui lòng nhập lại ", "Thông báo");
            }
        }


        private void btnXoaDoAn_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show("Xác nhận xóa đồ ăn ", "Thông báo", MessageBoxButtons.YesNo);
            if (xoa == DialogResult.Yes)
            {
                if (txtMaDoAn.Text != "")
                {
                    if (doAn_BUS.Delete_DoAn_BUS(doAn_DTO()))
                    {
                        MessageBox.Show("Xóa thành công");
                        btnLamMoiDoAn_Click(sender, e);
                    }
                    else
                        MessageBox.Show("Xóa thất bại, kiểm tra lại mã đồ ăn");

                }
                else
                    MessageBox.Show("Không để trống mã đồ ăn");
            }
        }
        private void btnXoaNuoc_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show("Xác nhận xóa nước ", "Thông báo", MessageBoxButtons.YesNo);
            if (xoa == DialogResult.Yes)
            {
                if (txtMaNuoc.Text != "")
                {
                    if (nuoc_BUS.Delete_Nuoc_BUS(Nuoc_DTO()))
                    {
                        MessageBox.Show("Xóa thành công");
                        btnLamMoiNuoc_Click(sender, e);
                    }
                    else
                        MessageBox.Show("Xóa thất bại, kiểm tra lại mã nước");

                }
                else
                    MessageBox.Show("Không để trống mã nước");
            }
        }
        private void btnXoaThe_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show("Xác nhận xóa thẻ ", "Thông báo", MessageBoxButtons.YesNo);
            if (xoa == DialogResult.Yes)
            {
                if (txtTenThe.Text != "")
                {
                    if (the_BUS.Delete_The_BUS(the_DTO()))
                    {
                        MessageBox.Show("Xóa thành công");
                        btnLamMoiThe_Click(sender, e);
                    }
                    else
                        MessageBox.Show("Xóa thất bại, kiểm tra lại mã thẻ");

                }
                else
                    MessageBox.Show("Không để trống mã thẻ");
            }
        }

        private void btnSuaDoAn_Click(object sender, EventArgs e)
        {
            DialogResult sua = MessageBox.Show("Xác nhận sửa đồ ăn ", "Thông báo", MessageBoxButtons.YesNo);
            if (sua == DialogResult.Yes)
            {
                if (txtMaDoAn.Text != "")
                {
                    if (doAn_BUS.Update_DoAn_BUS(doAn_DTO()))
                    {
                        MessageBox.Show("Chỉnh sửa thành công");
                        btnLamMoiDoAn_Click(sender, e);
                    }
                    else
                        MessageBox.Show("Chỉnh sửa thất bại, kiểm tra lại mã đồ ăn");

                }
                else
                    MessageBox.Show("Không để trống mã đồ ăn");
            }
        }
        private void btnSuaNuoc_Click(object sender, EventArgs e)
        {
            DialogResult sua = MessageBox.Show("Xác nhận sửa nước ", "Thông báo", MessageBoxButtons.YesNo);
            if (sua == DialogResult.Yes)
            {
                if (txtMaNuoc.Text != "")
                {
                    if (nuoc_BUS.Update_Nuoc_BUS(Nuoc_DTO()))
                    {
                        MessageBox.Show("Chỉnh sửa thành công");
                        btnLamMoiNuoc_Click(sender, e);
                    }
                    else
                        MessageBox.Show("Chỉnh sửa thất bại, kiểm tra lại mã nước");

                }
                else
                    MessageBox.Show("Không để trống mã nước");
            }
        }
        private void btnSuaThe_Click(object sender, EventArgs e)
        {
            DialogResult sua = MessageBox.Show("Xác nhận sửa thẻ ", "Thông báo", MessageBoxButtons.YesNo);
            if (sua == DialogResult.Yes)
            {
                if (txtTenThe.Text != "")
                {
                    if (the_BUS.Update_The_BUS(the_DTO()))
                    {
                        MessageBox.Show("Chỉnh sửa thành công");
                        btnLamMoiThe_Click(sender, e);
                    }
                    else
                        MessageBox.Show("Chỉnh sửa thất bại, kiểm tra lại tên thẻ");

                }
                else
                    MessageBox.Show("Không để trống tên thẻ");
            }
        }


        private void btnLamMoiDoAn_Click(object sender, EventArgs e)
        {
            ClearDoAn();
            dgvDoAn.DataSource = doAn_BUS.showdsDoAn_BUS();
            txtMaDoAn.Enabled = true;
        }
        private void btnLamMoiNuoc_Click(object sender, EventArgs e)
        {
            ClearNuoc();
            dgvNuoc.DataSource = nuoc_BUS.showdsNuoc_BUS();
            txtMaNuoc.Enabled = true;
        }
        private void btnLamMoiThe_Click(object sender, EventArgs e)
        {
            ClearThe();
            dgvThe.DataSource = the_BUS.showdsThe_BUS();
            txtTenThe.Enabled = true;
        }

        private void txtGiaDoAn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)||txtGiaDoAn.TextLength>10)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void txtGiaNuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)||txtGiaNuoc.TextLength<10)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void txtGiaThe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)||txtGiaThe.TextLength<10)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void txtTimDoAn_TextChanged(object sender, EventArgs e)
        {
            if(txtTimDoAn.Text.Trim()=="")
            {
                dgvDoAn.DataSource = doAn_BUS.showdsDoAn_BUS();
            }    
            else
            {
                dgvDoAn.DataSource = doAn_BUS.Search_DoAn_BUS(txtTimDoAn.Text.Trim());
            }    
        }

        private void txtTimNuoc_TextChanged(object sender, EventArgs e)
        {
            if (txtTimNuoc.Text.Trim() == "")
            {
                dgvNuoc.DataSource = nuoc_BUS.showdsNuoc_BUS();
            }
            else
            {
                dgvNuoc.DataSource = nuoc_BUS.Search_Nuoc_BUS(txtTimNuoc.Text.Trim());
            }
        }
        private void txtTimKiemThe_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiemThe.Text.Trim() == "")
            {
                dgvThe.DataSource = the_BUS.showdsThe_BUS();
            }
            else
            {
                dgvThe.DataSource = the_BUS.Search_The_BUS(txtTimKiemThe.Text.Trim());
            }
        }

        private void lblkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
