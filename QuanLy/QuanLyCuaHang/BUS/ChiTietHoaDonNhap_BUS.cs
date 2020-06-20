using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class ChiTietHoaDonNhap_BUS
    {
        ChiTietHoaDonNhap_DAO objCTHDN_DAO = new ChiTietHoaDonNhap_DAO();
        public List<ChiTietHoaDonNhap_DTO> LayDanhSach()
        {
            return objCTHDN_DAO.LayDanhSach();
        }
    }
}
