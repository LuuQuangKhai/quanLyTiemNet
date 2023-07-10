using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string maNhanVien;

        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        private string tenNhanVien;

        public string TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }

        private string sDT;

        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }

        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        private string eMail;

        public string Email
        {
            get { return eMail; }
            set { eMail = value; }
        }

  
        public NhanVien_DTO(string MaNhanVien, string TenNhanVien, string SDT, string DiaChi, string Email)
        {
            this.maNhanVien = MaNhanVien;
            this.tenNhanVien = TenNhanVien;
            this.sDT = SDT;
            this.diaChi = DiaChi;
            this.eMail = Email;
        }
    }
}
