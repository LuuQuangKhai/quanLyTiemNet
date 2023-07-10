using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nuoc_DTO
    {
        private string maNuoc;

        public string MaNuoc
        {
            get { return maNuoc; }
            set { maNuoc = value; }
        }

        private string tenNuoc;

        public string TenNuoc
        {
            get { return tenNuoc; }
            set { tenNuoc = value; }
        }

        private string tenDanhMuc;

        public string TenDanhMuc
        {
            get { return tenDanhMuc; }
            set { tenDanhMuc = value; }
        }

        private float giaNuoc;

        public float GiaNuoc
        {
            get { return giaNuoc; }
            set { giaNuoc = value; }
        }


     
        public Nuoc_DTO(string MaNuoc, string TenNuoc, string TenDanhMuc, float GiaNuoc)
        {
            this.maNuoc = MaNuoc;
            this.tenNuoc = TenNuoc;
            this.tenDanhMuc = TenDanhMuc;
            this.giaNuoc = GiaNuoc;
        }
    }
}
