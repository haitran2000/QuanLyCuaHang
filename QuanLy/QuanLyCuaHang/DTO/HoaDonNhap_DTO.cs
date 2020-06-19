using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonNhap_DTO
    {
        private string maHDN;

        public string MaHDN
        {
            get { return maHDN; }
            set { maHDN = value; }
        }
        private string maNV;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private DateTime ngayMua;

        public DateTime NgayMua
        {
            get { return ngayMua; }
            set { ngayMua = value; }
        }
        private string maNCC;

        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
        private double tongTien;

        public double TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
        public HoaDonNhap_DTO()
        {
        }
        public HoaDonNhap_DTO(string _maHDN, string _maNV, DateTime _ngayMua, string _maNCC, double _tongTien)
        {
            this.maHDN = _maHDN;
            this.maNV = _maNV;
            this.ngayMua = _ngayMua;
            this.maNCC = _maNCC;
            this.tongTien = _tongTien;
        }
    }
}
