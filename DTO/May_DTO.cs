using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public  class May_DTO
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
        public May_DTO(string TenMay, string TrangThai)
        {
            this.tenMay = TenMay;
            this.trangThai = TrangThai;
            
        }
    }
}
