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
    public partial class HoaDon_GUI : Form
    {
        HoaDon_BUS hoaDon_BUS = new HoaDon_BUS();
        public HoaDon_GUI()
        {
            InitializeComponent();
        }

        private void HoaDon_GUI_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = hoaDon_BUS.showHoaDonMoi_BUS(ThongTinMay_GUI.tenmay, ThongTinMay_GUI.ngayDong);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }
    }
}
