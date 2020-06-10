using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NhanVien_BUS
    {
        public List<NhanVien_DTO> LayDanhSach()
        {
            NhanVien_DAO objNV_DAO = new NhanVien_DAO();
            return objNV_DAO.LayDanhSach();
        }
        public void XoaNV(string maNV)
        {
            // gọi xóa từ DAO
            NhanVien_DAO objNV_DAO = new NhanVien_DAO();
            objNV_DAO.XoaNV(maNV);
        }
        public void SuaNV(string maNV,string tenNV, string gioiTinh, DateTime ngaySinh, string sDT, string diaChi, string queQuan)
        {
            // gọi xóa từ DAO
            NhanVien_DAO objNV_DAO = new NhanVien_DAO();
            objNV_DAO.SuaNV(maNV,tenNV,gioiTinh,ngaySinh,sDT,diaChi,queQuan);
        }
    }
}
