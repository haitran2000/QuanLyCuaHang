using System; 
using System.Text; 
using System.Data; 
using System.Data.SqlClient; 
namespace DTO
{
    public class NhanVien_DTO
    {
        //Khoi Tao Bien
        private string maNV;
        private string tenNV;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string sdt;
        private string diaChi;
        private string queQuan;
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        
        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        
        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        

        public string QueQuan
        {
            get { return queQuan; }
            set { queQuan = value; }
        }

        public NhanVien_DTO( string _maNV,string _tenNV,string _gioiTinh,DateTime _ngaySinh,string _sdt,string _diaChi,string _queQuan)
        {
            maNV = _maNV;
            tenNV = _tenNV;
            gioiTinh = _gioiTinh;
            ngaySinh = _ngaySinh;
            sdt = _sdt;
            diaChi = _diaChi;
            queQuan = _queQuan;
        }

        public NhanVien_DTO()
        {
        }
    }
}
