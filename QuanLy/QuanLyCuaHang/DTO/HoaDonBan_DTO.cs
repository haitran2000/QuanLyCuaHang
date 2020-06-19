using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonBan_DTO
    {
        private string maHDB;
        private string maNV;

        public string MaHDB
        {
            get { return maHDB; }
            set { maHDB = value; }
        }
        

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private DateTime ngayBan;

        public DateTime NgayBan
        {
            get { return ngayBan; }
            set { ngayBan = value; }
        }
        private string maKH;

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        private double tongTien;

        public double TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
        public HoaDonBan_DTO()
        { 
        }
        public HoaDonBan_DTO(string _maHDB,string _maNV,DateTime _ngayBan,string _maKH,double _tongTien)
        {
            this.maHDB=_maHDB;
            this.maNV=_maNV;
            this.ngayBan=_ngayBan;
            this.maKH=_maKH;
            this.tongTien=_tongTien;
        }

    }
}
