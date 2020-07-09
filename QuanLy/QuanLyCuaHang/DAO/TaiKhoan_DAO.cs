using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAO
{
    public class TaiKhoan_DAO
    {
        public List<TaiKhoan_DTO> LayDanhSach()
        {
            List<TaiKhoan_DTO> dsTK = new List<TaiKhoan_DTO>();
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader dr = null;
            try
            {
                // 2. mở kết nối
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select TAIKHOAN.TAIKHOAN,TAIKHOAN.MAQUYEN,PHANQUYEN.GHICHU from TAIKHOAN,PHANQUYEN where TAIKHOAN.TRANGTHAI=1 AND PHANQUYEN.MAQUYEN=TAIKHOAN.MAQUYEN;";
                cmd.Connection = conn;
                 // 4. thực thi cmd và xử lý kết quả
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TaiKhoan_DTO tK = new TaiKhoan_DTO();
                    // đọc từng dòng dữ liệu
                    if (!dr.IsDBNull(0))
                        tK.TaiKhoan = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        tK.MaQuyen = (int)dr[1];
                    if (!dr.IsDBNull(2))
                        tK.GhiChu = (string)dr[2];
                    dsTK.Add(tK);
                }

            }
            finally
            {
                dr.Close();
                // 5. đóng kết nối
                conn.Close();
            }
            return dsTK;
        }
        public void ThemTK(string taiKhoan, string matKhau)
        {
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = string.Format("INSERT [dbo].[TAIKHOAN](TAIKHOAN,MATKHAU) VALUES('{0}','{1}') ",taiKhoan,matKhau);
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                cmd.ExecuteNonQuery();
            }
            finally
            {
                // 5. đóng kết nối
                conn.Close();

            }
        }
        public void DoiMK(string matKhauMoi,string taiKhoan,string matKhauCu)
        {
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = string.Format("UPDATE [dbo].[TAIKHOAN] SET MATKHAU='{0}' WHERE TAIKHOAN='{1}' AND MATKHAU='{2}'",matKhauMoi,taiKhoan,matKhauCu);
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                cmd.ExecuteNonQuery();
            }
            finally
            {
                // 5. đóng kết nối
                conn.Close();
            }
        }
        public bool DangNhap(string taiKhoan, string matKhau)
        {
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = string.Format("SELECT TAIKHOAN, MATKHAU FROM TAIKHOAN WHERE TRANGTHAI=1 AND TAIKHOAN='{0}'",taiKhoan);
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                SqlDataReader reader= cmd.ExecuteReader();
                int value = 0;
                if (reader.Read())
                {
                    if ((taiKhoan == reader.GetString(0).Trim()) && (matKhau == reader.GetString(1).Trim()))
                    {
                        value = 1;
                    }
                }
                if (value == 1)
                    return true;
                else
                    return false;
            }
            finally
            {
                // 5. đóng kết nối
                conn.Close();
            }
        }
    }
}
