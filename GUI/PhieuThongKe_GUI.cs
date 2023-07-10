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
using DAO;
using CrystalDecisions.CrystalReports.Engine;

namespace GUI
{
    public partial class PhieuThongKe_GUI : Form
    {
        DataProvider prod = new DataProvider();
        public PhieuThongKe_GUI()
        {
            InitializeComponent();
        }

        private void dtNgayThongKe_ValueChanged(object sender, EventArgs e)
        {
            lblThongKeNgay.Text = "THỐNG KÊ DOANH THU \n NGÀY " + dtNgayThongKe.Text + "";
        }

        private void PhieuThongKe_GUI_Load(object sender, EventArgs e)
        {
        }

        private void btnThongKeNgay_Click(object sender, EventArgs e)
        {
            prod.Open();
            SqlDataAdapter da = new SqlDataAdapter("thongkeHDNgay",prod.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@ngay", SqlDbType.Int).Value = dtNgayThongKe.Value.Day;
            da.SelectCommand.Parameters.Add("@thang", SqlDbType.Int).Value = dtNgayThongKe.Value.Month;
            da.SelectCommand.Parameters.Add("@nam", SqlDbType.Int).Value = dtNgayThongKe.Value.Year;
            DataTable tkn = new DataTable();
            da.Fill(tkn);
       
            rptThongKe rptThKNgay = new rptThongKe();
            rptThKNgay.SetDataSource(tkn);

            TextObject title = (TextObject)rptThKNgay.ReportDefinition.Sections[1].ReportObjects["txtTitle"];
            title.Text = "PHIẾU THỐNG KÊ DOANH THU NGÀY " + dtNgayThongKe.Text + "";
            title.Color = Color.Red;
            

            this.rpThongKeNgay.ReportSource = rptThKNgay;

        }

        private void btnThongKeThang_Click(object sender, EventArgs e)
        {
            prod.Open();
            SqlDataAdapter da = new SqlDataAdapter("thongkeHDThang", prod.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@thang", SqlDbType.Int).Value = dtThangThongKe.Value.Month;
            da.SelectCommand.Parameters.Add("@nam", SqlDbType.Int).Value = dtThangThongKe.Value.Year;
            DataTable tkn = new DataTable();
            da.Fill(tkn);

            rptThongKe rptThKThang = new rptThongKe();
            rptThKThang.SetDataSource(tkn);

            TextObject title = (TextObject)rptThKThang.ReportDefinition.Sections[1].ReportObjects["txtTitle"];
            title.Text = "PHIẾU THỐNG KÊ DOANH THU THÁNG " + dtThangThongKe.Text + "";
            title.Color = Color.Red;
            this.rpThongKeThang.ReportSource = rptThKThang;

        }

        private void lblThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void dtNamThongKe_ValueChanged(object sender, EventArgs e)
        {
            if (dtNamThongKe.Value.Year > DateTime.Now.Year)
                MessageBox.Show("Năm thống kê không được lớn hơn năm hiện tại");
            else
                lblThongKeNam.Text = "THỐNG KÊ DOANH THU NĂM " + dtNamThongKe.Value.Year.ToString() + "";
        }

       

        private void dtThangThongKe_ValueChanged(object sender, EventArgs e)
        {
            lblThongKeThang.Text = "THỐNG KÊ THÁNG " + dtThangThongKe.Text + "";
        }

        private void btnThongKeNam_Click(object sender, EventArgs e)
        {
            prod.Open();
            SqlDataAdapter da = new SqlDataAdapter("thongkeHDNam", prod.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@nam", SqlDbType.Int).Value = dtNamThongKe.Value.Year;
            DataTable tkn = new DataTable();
            da.Fill(tkn);

            rptThongKe rptThKThang = new rptThongKe();
            rptThKThang.SetDataSource(tkn);

            TextObject title = (TextObject)rptThKThang.ReportDefinition.Sections[1].ReportObjects["txtTitle"];
            title.Text = "PHIẾU THỐNG KÊ DOANH THU NĂM " + dtNamThongKe.Text + "";
            title.Color = Color.Red;
            this.rpThongKeNam.ReportSource = rptThKThang;
        }
    }
}
