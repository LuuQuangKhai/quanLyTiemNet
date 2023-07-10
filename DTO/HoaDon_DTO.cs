using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_DTO
    {
        private string MaNhanVien;

        public string maNhanVien
        {
            get { return MaNhanVien; }
            set { MaNhanVien = value; }
        }

        private string TenMay;

        public string tenMay
        {
            get { return TenMay; }
            set { TenMay = value; }
        }

        private string NgayLap;

        public string ngayLap
        {
            get { return NgayLap; }
            set { NgayLap = value; }
        }

        private int TongGia;

        public int tongGia
        {
            get { return TongGia; }
            set { TongGia = value; }
        }

        public HoaDon_DTO(string maNhanVien, string tenMay, string ngayLap,int tongGia)
        {
            this.MaNhanVien = maNhanVien;
            this.TenMay = tenMay;
            this.NgayLap = ngayLap;
            this.TongGia = tongGia;
        }
    }
}
