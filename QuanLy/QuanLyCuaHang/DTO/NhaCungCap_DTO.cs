using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap_DTO
    {
        private string maNCC;

        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
        private string tenNCC;

        public string TenNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
        }
        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string sDT;

        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }
        public NhaCungCap_DTO()
        {
        }
        public NhaCungCap_DTO(string _maNCC, string _tenNCC, string _diaChi, string _sDT)
        {
            this.maNCC = _maNCC;
            this.tenNCC = _tenNCC;
            this.diaChi = _diaChi;
            this.sDT = _sDT;
        }

    }
}
