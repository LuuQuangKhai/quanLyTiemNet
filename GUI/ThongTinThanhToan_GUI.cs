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
using DAO;
namespace GUI
{
    public partial class ThongTinThanhToan_GUI : Form
    {
        DataProvider pr = new DataProvider();
        HoaDon_BUS hoaDon = new HoaDon_BUS();
        public string giaDoAn, giaNuoc, giaThe;
        public ThongTinThanhToan_GUI()
        {
            InitializeComponent();
        }

        private void ThongTinThanhToan_GUI_Load(object sender, EventArgs e)
        {
            lblTenMay.Text = ThongTinMay_GUI.tenmay;
            lblThoiGianSuDung.Text = ThongTinMay_GUI.tgsd.ToString()+" phút";

            string gda = "select  sum(da.GiaDoAnOrder) from May m, OrderDoAn da,TinhTienThoiGian tttg" +
                " where m.TenMay = da.TenMay and m.TenMay=tttg.TenMay" +
                " and m.TenMay = '" + ThongTinMay_GUI.tenmay + "' and tttg.ThoiGianDong = '" + ThongTinMay_GUI.ngayDong + "' ";
            if(pr.ExecuteScalar(gda)!=null)
            {
                giaDoAn = pr.ExecuteScalar(gda).ToString();
            }
            string gn = "select  sum(n.GiaNuocOrder) from May m, OrderNuoc n,TinhTienThoiGian tttg" +
                   " where m.TenMay = n.TenMay and m.TenMay=tttg.TenMay" +
                   " and m.TenMay = '" + ThongTinMay_GUI.tenmay + "' and tttg.ThoiGianDong = '" + ThongTinMay_GUI.ngayDong + "' ";
            if (pr.ExecuteScalar(gn) != null)
            {
                giaNuoc = pr.ExecuteScalar(gn).ToString();
            
            }
            string gt = "select sum(t.GiaTheOrder) from May m, OrderThe t,TinhTienThoiGian tttg" +
                   " where m.TenMay = t.TenMay and m.TenMay=tttg.TenMay" +
                   " and m.TenMay = '" + ThongTinMay_GUI.tenmay + "' and tttg.ThoiGianDong = '" + ThongTinMay_GUI.ngayDong + "' ";
            if (pr.ExecuteScalar(gt) != null)
            {
                giaThe =pr.ExecuteScalar(gt).ToString();
               
            }

            string sql3 = "select tttg.TongTienThoiGian" +
               " from May m, TinhTienThoiGian tttg" +
               " where  m.TenMay = tttg.TenMay " +
               " and tttg.TenMay = '" + ThongTinMay_GUI.tenmay + "' and tttg.ThoiGianDong = '" + ThongTinMay_GUI.ngayDong + "'";
            if (pr.ExecuteScalar(sql3) != null)
                lblTongGiaThoiGian.Text = pr.ExecuteScalar(sql3).ToString();
            if (giaDoAn == "")
                giaDoAn = "0";
            if (giaNuoc == "")
                giaNuoc = "0";
            if (giaThe == "")
                giaThe = "0";
            lblTongGiaOrder.Text = (Int32.Parse(giaDoAn) + Int32.Parse(giaThe) + Int32.Parse(giaNuoc)).ToString();
            lblTongGia.Text = (Int32.Parse(giaDoAn) + Int32.Parse(giaThe)+Int32.Parse(giaNuoc)+Int32.Parse(lblTongGiaThoiGian.Text)).ToString();

        }

        private void btnXacNhanThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult xacnhan = MessageBox.Show("Xác nhận thanh toán", "Thông báo", MessageBoxButtons.YesNo);
            if(xacnhan==DialogResult.Yes)
            {
               
                HoaDon_DTO hoaDon_DTO = new HoaDon_DTO(DangNhap_GUI.taikhoan, lblTenMay.Text, ThongTinMay_GUI.ngayDong,Convert.ToInt32(lblTongGia.Text));
                if (hoaDon.insert_HoaDonBUS(hoaDon_DTO))
                {
                    MessageBox.Show("Thanh toán thành công");
                    HoaDon_GUI oaDon = new HoaDon_GUI();
                    oaDon.Show();
                    this.Close();
                }    
                else
                {
                    MessageBox.Show("Thanh toán thất bại");
                }
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "update May set TrangThai=N'Mở' where TenMay= '"+lblTenMay.Text+"'";
            pr.ExecuteNonQuery(sql);
            GiaoDienAdmin gdad = new GiaoDienAdmin();
            this.Close();
        }
    }
}
