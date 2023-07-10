using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DoAnOrder_DTO
    {
        private string MaDoAn;

        public string maDoAn
        {
            get { return MaDoAn; }
            set { MaDoAn = value; }
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


        public DoAnOrder_DTO (string maDoAn, int soLuong, string tenMay, string maNhanVien)
        {
            this.MaDoAn = maDoAn;
            this.SoLuong = soLuong;
            this.TenMay = tenMay;
            this.MaNhanVien = maNhanVien;
        }
    }
}
