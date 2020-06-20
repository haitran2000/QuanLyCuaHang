using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
   public class LoaiHang_BUS
    {
        LoaiHang_DAO objLH_DAO = new LoaiHang_DAO();
        public List<LoaiHang_DTO> LayDanhSach()
        {
            return objLH_DAO.LayDanhSach();
        }
    }
}
