using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class HangHoa_BUS
    {
        public List<HangHoa_DTO> LayDanhSach()
        {
            HangHoa_DAO objHH_DAO = new HangHoa_DAO();
            return objHH_DAO.LayDanhSach();
        }
        HangHoa_DAO objHH_DAO = new HangHoa_DAO();
        public void XoaNV(string maHH)
        {
            // gọi xóa từ DAO
            objHH_DAO.XoaHH(maHH);
        }
        public void SuaHH(string maHH, string tenHH, int soLuong, float donGiaNhap, float donGiaBan, string maLoaiHH, string maNCC)
        {
            // gọi xóa từ DAO
            objHH_DAO.SuaHH(maHH, tenHH, soLuong, donGiaNhap, donGiaBan, maLoaiHH, maNCC);
        }
        public void ThemHH(string maHH, string tenHH, int soLuong, float donGiaNhap, float donGiaBan, string maLoaiHH, string maNCC)
        {
            // gọi xóa từ DAO
            objHH_DAO.ThemHH(maHH, tenHH, soLuong, donGiaNhap, donGiaBan, maLoaiHH, maNCC);
        }
    }
}
