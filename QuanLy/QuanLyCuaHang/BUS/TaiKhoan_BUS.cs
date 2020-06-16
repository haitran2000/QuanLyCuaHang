using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class TaiKhoan_BUS
    {
        public List<TaiKhoan_DTO> LayDanhSach()
        {
            TaiKhoan_DAO objTK_DAO = new TaiKhoan_DAO();
            return objTK_DAO.LayDanhSach();
        }
        public void ThemTK(string TK,string MK)
        {
            // gọi xóa từ DAO
            TaiKhoan_DAO objTK_DAO = new TaiKhoan_DAO();
            objTK_DAO.ThemTK(TK,MK);
        }
        public void DoiMK(string MKM,string TK,string MKC)
        {
            // gọi xóa từ DAO
            TaiKhoan_DAO objTK_DAO = new TaiKhoan_DAO();
            objTK_DAO.DoiMK(MKM,TK,MKC);
        }
    }
}

