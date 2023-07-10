using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoAn_DTO
    {
        private string maDoAn;

        public string MaDoAn
        {
            get { return maDoAn; }
            set { maDoAn = value; }
        }

        private string tenDoAn;

        public string TenDoAn
        {
            get { return tenDoAn; }
            set { tenDoAn = value; }
        }

        private string tenDanhMuc;

        public string TenDanhMuc
        {
            get { return tenDanhMuc; }
            set { tenDanhMuc = value; }
        }

        private float giaDoAn;

        public float GiaDoAn
        {
            get { return giaDoAn; }
            set { giaDoAn = value; }
        }

      
        public DoAn_DTO(string MaDoAn, string TenDoAn, string TenDanhMuc, float GiaDoAn)
        {
            this.maDoAn = MaDoAn;
            this.tenDoAn = TenDoAn;
            this.tenDanhMuc = TenDanhMuc;
            this.giaDoAn = GiaDoAn;
        }
    }
}
