using System;
using System.Text;
using System.Data;
using System.Data.SqlClient; 

namespace DTO
{
    public class HangHoa_DTO
    {
        private string maHH;


        private string tenHH;
        private string maLoaiHH;
        private string maNCC;
        private int soLuong;
        private long donGiaNhap;
        private long donGiaBan;
        public string TenHH
        {
            get { return tenHH; }
            set { tenHH = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public long DonGiaNhap
        {
            get { return donGiaNhap; }
            set { donGiaNhap = value; }
        }
        public long DonGiaBan
        {
            get { return donGiaBan; }
            set { donGiaBan = value; }
        }
        
        public string MaHH
        {
            get { return maHH; }
            set { maHH = value; }
        }
        public string MaLoaiHH
        {
            get { return maLoaiHH; }
            set { maLoaiHH = value; }
        }
        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
        public HangHoa_DTO()
        {
        }
        public HangHoa_DTO(string _maHH,string _tenHH,int _soLuong,long _donGiaNhap,long _donGiaBan,string _maLoaiHH,string _maNCC)
        {
            this.maHH = _maHH;
            this.tenHH = _tenHH;
            this.soLuong = _soLuong;
            this.donGiaNhap = _donGiaNhap;
            this.donGiaBan = _donGiaNhap = _donGiaBan;
            this.maLoaiHH = _maLoaiHH;
            this.maNCC = _maNCC;
        }
        
    }
}
