using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TheOrder_DTO
    {
        

        private string TenMay;

        public string tenMay
        {
            get { return TenMay; }
            set { TenMay = value; }
        }
        private string TenThe;

        public string tenThe
        {
            get { return TenThe; }
            set { TenThe = value; }
        }

        private int SoLuong;

        public int soLuong
        {
            get { return SoLuong; }
            set { SoLuong = value; }
        }

      
        private string MaNhanVien;

        public string maNhanVien
        {
            get { return MaNhanVien; }
            set { MaNhanVien = value; }
        }


        public TheOrder_DTO(string tenThe, int soLuong, string tenMay,  string maNhanVien)
        {
            this.SoLuong = soLuong;
            this.TenThe = tenThe;
            this.TenMay = tenMay;
            this.MaNhanVien = maNhanVien;
        }
    }
}
