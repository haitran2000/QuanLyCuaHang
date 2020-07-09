using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonBan_DTO
    {
        private string maHDB;

        public string MaHDB
        {
            get { return maHDB; }
            set { maHDB = value; }
        }
        private string maHH;

        public string MaHH
        {
            get { return maHH; }
            set { maHH = value; }
        }
        private int soLuong;
        private double donGia;
        private string tenHH;

        public string TenHH
        {
            get { return tenHH; }
            set { tenHH = value; }
        }
        public double DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        private float khuyenMai;

        public float KhuyenMai
        {
            get { return khuyenMai; }
            set { khuyenMai = value; }
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
        public ChiTietHoaDonBan_DTO()
        {
        }
        public ChiTietHoaDonBan_DTO(string _maHDB, string _maHH,int _soLuong,float _khuyenMai,double _giamGia,double _thanhTien)
        {
            this.maHDB = _maHDB;
            this.maHH = _maHH;
            this.soLuong = _soLuong;
            this.khuyenMai = _khuyenMai;
            this.giamGia = _giamGia;
            this.thanhTien = _thanhTien;

        }

    }
}
