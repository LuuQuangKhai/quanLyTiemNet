using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinMay_DTO
    {
        private string tenMay;

        public string TenMay
        {
            get { return tenMay; }
            set { tenMay = value; }
        }
        private string trangThai;

        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }


        private string maNhanVien;

        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        private string thoiGianMo;

        public string ThoiGianMo
        {
            get { return thoiGianMo; }
            set { thoiGianMo = value; }
        }

        private string thoiGianDong;

        public string ThoiGianDong
        {
            get { return thoiGianDong; }
            set { thoiGianDong = value; }
        }


        private string thoiGianSuDung;

        public string ThoiGianSuDung
        {
            get { return thoiGianSuDung; }
            set { thoiGianSuDung = value; }
        }

        public ThongTinMay_DTO (string TenMay,string TrangThai, string MaNhanVien,string ThoiGianMo, string ThoiGianDong,string ThoiGianSuDung)
        {
            this.tenMay = TenMay;
            this.trangThai = TrangThai;
            this.maNhanVien = MaNhanVien;
            this.thoiGianMo = ThoiGianMo;
            this.thoiGianDong = ThoiGianDong;
            this.thoiGianSuDung = ThoiGianSuDung;
        }

    }
}
