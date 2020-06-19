using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class PhanQuyen_BUS
    {
        public List<PhanQuyen_DTO> LayDanhSach()
        {
            PhanQuyen_DAO objPQ_DAO = new PhanQuyen_DAO();
            return objPQ_DAO.LayDanhSach();
        }
    }
}
