using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class KhachHang_BUS
    {
        KhachHang_DAO objKH_DAO = new KhachHang_DAO();
        public List<KhachHang_DTO> LayDanhSach()
        {
            return objKH_DAO.LayDanhSach();
        }
    }
}
