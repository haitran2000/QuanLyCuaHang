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
        HoaDonBan_DAO objHDB_DAO = new HoaDonBan_DAO();
        public List<HoaDonBan_DTO> LayDanhSach()
        {
           
            return objHDB_DAO.LayDanhSach();
        }
        public void ThemHDB(HoaDonBan_DTO hDB_DTO)
        {
            objHDB_DAO.ThemHDB(hDB_DTO);
        }
        public bool CheckMaHDB(string maHDB)
        {
            return objHDB_DAO.CheckMaHDB(maHDB);
        }
    }
}
