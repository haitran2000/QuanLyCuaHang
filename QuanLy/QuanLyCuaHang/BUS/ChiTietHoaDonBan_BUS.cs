using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class ChiTietHoaDonBan_BUS
    {
        ChiTietHoaDonBan_DAO objCTHDB_DAO = new ChiTietHoaDonBan_DAO();
        public List<ChiTietHoaDonBan_DTO> LayDanhSach()
        {
            return objCTHDB_DAO.LayDanhSach();
        }
        public List<ChiTietHoaDonBan_DTO> LayDanhSachTheoMa(string maHDB)
        {
            return objCTHDB_DAO.LayDanhSachTheoMa(maHDB);
        }
        public string TongTienHoaDon(string maHDB)
        {
            return objCTHDB_DAO.TongTienHoaDon(maHDB);
        }
        public void XoaCTHDB(string maHDB)
        {
            objCTHDB_DAO.XoaCTHDB(maHDB);
        }
        public void ThemCTHDB(ChiTietHoaDonBan_DTO cTHDB_DTO)
        {
            objCTHDB_DAO.ThemCTHDB(cTHDB_DTO);
        }
        public void CapNhatCTHDB(int soLuong, long thanhTien, string maHDB, string maHH)
        {
            objCTHDB_DAO.CapNhatCTHDB(soLuong, thanhTien, maHDB, maHH);
        }
        public bool checkCTHDB(string maHDB, string maHH)
        {
            return objCTHDB_DAO.checkCTHDB(maHDB, maHH);
        }
    }
}
