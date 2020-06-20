using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiHang_DTO
    {
        private string maLH;

        public string MaLH
        {
            get { return maLH; }
            set { maLH = value; }
        }
        private string tenLH;

        public string TenLH
        {
            get { return tenLH; }
            set { tenLH = value; }
        }
        public LoaiHang_DTO()
        {
        }
        public LoaiHang_DTO(string _maLH,string _tenLH)
        {
            this.maLH = _maLH;
            this.tenLH = _tenLH;
        }

    }
}
