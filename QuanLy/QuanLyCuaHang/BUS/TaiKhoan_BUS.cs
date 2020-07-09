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
        TaiKhoan_DAO objTK_DAO = new TaiKhoan_DAO();
        public List<TaiKhoan_DTO> LayDanhSach()
        {
            return objTK_DAO.LayDanhSach();
        }
        public void ThemTK(string TK,string MK)
        {
            objTK_DAO.ThemTK(TK,MK);
        }
        public void DoiMK(string MKM,string TK,string MKC)
        {
            objTK_DAO.DoiMK(MKM,TK,MKC);
        }
        public bool DangNhap(string taiKhoan, string matKhau)
        {
            if (objTK_DAO.DangNhap(taiKhoan,matKhau))
            {
                return true;
            }
            else
                return false;
        }
    }
}

