using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class TaiKhoan_DTO
    {
        private string MaTaiKhoan;

        public string maTaiKhoan
        {
            get { return MaTaiKhoan; }
            set { MaTaiKhoan = value; }
        }

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

        private string MaQuyen;

        public string maQuyen
        {
            get { return MaQuyen; }
            set { MaQuyen = value; }
        }

        public TaiKhoan_DTO (string maTaiKhoan,string tenTaiKhoan,string matKhau, string maQuyen )
        {
            this.MaTaiKhoan = maTaiKhoan;
            this.TenTaiKhoan = tenTaiKhoan;
            this.MatKhau = matKhau;
            this.MaQuyen = maQuyen;
        }



    }
}
