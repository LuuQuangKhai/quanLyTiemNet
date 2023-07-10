using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NuocOrder_DTO
    {
        private string MaNuoc;

        public string maNuoc
        {
            get { return MaNuoc; }
            set { MaNuoc = value; }
        }

        private int SoLuong;

        public int soLuong
        {
            get { return SoLuong; }
            set { SoLuong = value; }
        }

        private string TenMay;

        public string tenMay
        {
            get { return TenMay; }
            set { TenMay = value; }
        }
        private string MaNhanVien;

        public string maNhanVien
        {
            get { return MaNhanVien; }
            set { MaNhanVien = value; }
        }


        public NuocOrder_DTO(string maNuoc, int soLuong, string tenMay, string maNhanVien)
        {
            this.MaNuoc = maNuoc;
            this.SoLuong = soLuong;
            this.TenMay = tenMay;
            this.MaNhanVien = maNhanVien;
        }
    }
}
