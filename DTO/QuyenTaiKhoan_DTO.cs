using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuyenTaiKhoan_DTO
    {
        private string MaQuyen;

        public string maQuyen
        {
            get { return MaQuyen; }
            set { MaQuyen = value; }
        }
        private string TenQuyen;

        public string tenQuyen
        {
            get { return TenQuyen; }
            set { TenQuyen = value; }
        }

        public QuyenTaiKhoan_DTO(string maQuyen,string tenQuyen)
        {
            this.MaQuyen = maQuyen;
            this.TenQuyen = tenQuyen;
        }

    }
}
