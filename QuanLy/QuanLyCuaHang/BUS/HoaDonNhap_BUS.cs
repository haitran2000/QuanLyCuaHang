using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class HoaDonNhap_BUS
    {
        public List<HoaDonNhap_DTO> LayDanhSach()
        {
            HoaDonNhap_DAO objHDN_DAO = new HoaDonNhap_DAO();
            return objHDN_DAO.LayDanhSach();
        }
    }
}
