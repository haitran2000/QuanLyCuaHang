using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonNhap_DTO
    {
        private string maHDN;

        public string MaHDN
        {
            get { return maHDN; }
            set { maHDN = value; }
        }
        private string maHH;

        public string MaHH
        {
            get { return maHH; }
            set { maHH = value; }
        }
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        private double giamGia;

        public double GiamGia
        {
            get { return giamGia; }
            set { giamGia = value; }
        }
        private double thanhTien;

        public double ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }
        public ChiTietHoaDonNhap_DTO()
        {
        }
        public ChiTietHoaDonNhap_DTO(string _maHDN, string _maHH,int _soLuong,double _giamGia,double _thanhTien)
        {
            this.maHDN = _maHDN;
            this.maHH = _maHH;
            this.soLuong = _soLuong;
            this.giamGia = _giamGia;
            this.thanhTien = _thanhTien;

        }
    }
}
