using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        private string maKH;

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        private string tenKH;

        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string soDT;

        public string SoDT
        {
            get { return soDT; }
            set { soDT = value; }
        }
        public KhachHang_DTO()
        {
        }
        public KhachHang_DTO(string _maKH, string _tenKH, string _diaChi, string _soDT)
        {
            this.maKH = _maKH;
            this.tenKH = _tenKH;
            this.diaChi = _diaChi;
            this.soDT = _soDT;
        }
    }
}
