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
    }
}
