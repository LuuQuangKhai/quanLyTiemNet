using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DangNhap_DTO
    {
        private string TenTaiKhoan;

        public string tenTaiKhoan
        {
            get { return TenTaiKhoan; }
            set { TenTaiKhoan = value; }
        }

        private string MatKhau;

        public string matKhau
        {
            get { return MatKhau; }
            set { MatKhau = value; }
        }

        public DangNhap_DTO (string tenTaiKhoan, string matKhau)
        {
            this.TenTaiKhoan = tenTaiKhoan;
            this.MatKhau = matKhau;
        }
    }
}
