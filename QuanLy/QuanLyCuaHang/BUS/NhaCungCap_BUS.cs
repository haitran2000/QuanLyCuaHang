using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class NhaCungCap_BUS
    {
        NhaCungCap_DAO objNCC_DAO = new NhaCungCap_DAO();
        public List<NhaCungCap_DTO> LayDanhSach()
        {
            return objNCC_DAO.LayDanhSach();
        }

    }
}
