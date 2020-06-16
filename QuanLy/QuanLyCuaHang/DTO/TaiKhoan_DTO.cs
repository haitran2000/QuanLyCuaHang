using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan_DTO
    {
        public string taiKhoan;
        private string matKhau;
        public int maQuyen;
        private int trangThai;
        public string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }


        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }


        public int MaQuyen
        {
            get { return maQuyen; }
            set { maQuyen = value; }
        }


        public int TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        public string TaiKhoan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }
        public TaiKhoan_DTO()
        {
        }
        public TaiKhoan_DTO(string _taiKhoan, string _matKhau, int _maQuyen, int _trangThai, string _ghiChu)
        {
            this.taiKhoan = _taiKhoan;
            this.matKhau = _matKhau;
            this.maQuyen = _maQuyen;
            this.TrangThai = _trangThai;
            this.GhiChu = _ghiChu;
        }
    }
}
