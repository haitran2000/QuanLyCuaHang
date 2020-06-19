using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class HoaDonBan_BUS
    {
        public List<HoaDonBan_DTO> LayDanhSach()
        {
            HoaDonBan_DAO objHDB_DAO = new HoaDonBan_DAO();
            return objHDB_DAO.LayDanhSach();
        }
    }
}
