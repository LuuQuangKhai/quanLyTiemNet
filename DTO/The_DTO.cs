using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class The_DTO
    {
        private string tenThe;

        public string TenThe
        {
            get { return tenThe; }
            set { tenThe = value; }
        }

        private string tenDanhMuc;

        public string TenDanhMuc
        {
            get { return tenDanhMuc; }
            set { tenDanhMuc = value; }
        }

        private float giaThe;

        public float GiaThe
        {
            get { return giaThe; }
            set { giaThe = value; }
        }


       
        public The_DTO( string TenThe, string TenDanhMuc, float GiaThe)
        {
            this.tenThe = TenThe;
            this.tenDanhMuc = TenDanhMuc;
            this.giaThe = GiaThe;
        }
    }
}
