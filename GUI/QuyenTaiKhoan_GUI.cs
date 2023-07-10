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
    public partial class QuyenTaiKhoan_GUI : Form
    {
        QuyenTaiKhoan_BUS quyenTaiKhoan_BUS = new QuyenTaiKhoan_BUS();
        public QuyenTaiKhoan_GUI()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void QuyenTaiKhoan_GUI_Load(object sender, EventArgs e)
        {
            dgvQuyenTaiKhoan.DataSource = quyenTaiKhoan_BUS.dsQuyenTaiKhoan();
        }

        private void dgvQuyenTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                DataGridViewRow row = this.dgvQuyenTaiKhoan.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaQuyen.Text = row.Cells[0].Value.ToString();
                txtTenQuyen.Text = row.Cells[1].Value.ToString();
                txtMaQuyen.Enabled = false;
            }
        

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaQuyen.Enabled = txtTenQuyen.Enabled = true;
            txtMaQuyen.Text = txtTenQuyen.Text = "";
            QuyenTaiKhoan_GUI_Load(sender,e);
        }

       
    }


            }

