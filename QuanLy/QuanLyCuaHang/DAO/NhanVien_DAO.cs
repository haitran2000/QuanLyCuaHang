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
    public class NhanVien_DAO
    {
        public List<NhanVien_DTO> LayDanhSach()
        {
            List<NhanVien_DTO> dsNV = new List<NhanVien_DTO>();
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader dr = null;
            try
            {
                // 2. mở kết nối
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM [dbo].[NHANVIEN] WHERE TRANGTHAI = 1";
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    NhanVien_DTO nV = new NhanVien_DTO();
                    // đọc từng dòng dữ liệu
                     if (!dr.IsDBNull(0))
                         nV.MaNV = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        nV.TenNV = (string)dr[1];
                    if (!dr.IsDBNull(2))
                        nV.GioiTinh = (string)dr[2];
                    if (!dr.IsDBNull(3))
                        nV.NgaySinh = (DateTime)dr[3];
                    if (!dr.IsDBNull(4))
                        nV.Sdt = (string)dr[4];
                    if (!dr.IsDBNull(5))
                        nV.DiaChi = (string)dr[5];
                    if (!dr.IsDBNull(6))
                        nV.QueQuan=(string)dr[6];
                    if (!dr.IsDBNull(7))
                        dsNV.Add(nV);
                }

            }
            finally
            {
                dr.Close();
                // 5. đóng kết nối
                conn.Close();
            }
            return dsNV;
        }
        public void XoaNV(string maNV)
        {
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                //"DELETE FROM FC WHERE FCName = 'Chelsea'"

                cmd.CommandText = string.Format("EXEC sp_XoaNhanVien '{0}'", maNV);
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
        public void SuaNV(string maNV,string tenNV,string gioiTinh, DateTime ngaySinh,string sDT, string diaChi, string queQuan)
        {
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                //"DELETE FROM FC WHERE FCName = 'Chelsea'"

                cmd.CommandText = string.Format("EXEC sp_CapNhatNhanVien N'{0}',N'{1}','{2}','{3}',N'{4}',N'{5}','{6}'", tenNV, gioiTinh, ngaySinh.ToString("MM/dd/yyyy h:mm:ss tt"), sDT, diaChi, queQuan, maNV);
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
        public void ThemNV(string maNV, string tenNV, string gioiTinh, DateTime ngaySinh, string sDT, string diaChi, string queQuan)
        {
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                //"DELETE FROM FC WHERE FCName = 'Chelsea'"

                cmd.CommandText = string.Format(" EXEC sp_ThemNhanVien '{0}',N'{1}',N'{2}','{3}','{4}',N'{5}',N'{6}'", maNV, tenNV, gioiTinh, ngaySinh.ToString("MM/dd/yyyy h:mm:ss tt"), sDT, diaChi, queQuan);
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
    }
}
