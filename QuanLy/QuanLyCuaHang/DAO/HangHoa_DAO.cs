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
    public class HangHoa_DAO
    {
        public List<HangHoa_DTO> LayDanhSach()
        {
            List<HangHoa_DTO> dsHH = new List<HangHoa_DTO>();
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader dr = null;
            try
            {
                // 2. mở kết nối
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM [dbo].[HANGHOA] WHERE TRANGTHAI = 1";
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    HangHoa_DTO hH = new HangHoa_DTO();
                    // đọc từng dòng dữ liệu
                     if (!dr.IsDBNull(0))
                         hH.MaHH = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        hH.TenHH = (string)dr[1];
                    if (!dr.IsDBNull(2))
                        hH.SoLuong = (int)dr[2];
                    if (!dr.IsDBNull(3))
                        hH.DonGiaNhap = double.Parse(dr[3].ToString());
                    if (!dr.IsDBNull(4))
                        hH.DonGiaBan = double.Parse(dr[4].ToString());
                    if (!dr.IsDBNull(5))
                        hH.MaLoaiHH = (string)dr[5];
                    if (!dr.IsDBNull(6))
                        hH.MaNCC=(string)dr[6];
                    if (!dr.IsDBNull(7))
                        dsHH.Add(hH);
                }

            }
            finally
            {
                dr.Close();
                // 5. đóng kết nối
                conn.Close();
            }
            return dsHH;
        }
        public void XoaHH(string maHH)
        {
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                //"DELETE FROM FC WHERE FCName = 'Chelsea'"

                cmd.CommandText = string.Format("UPDATE [dbo].[HANGHOA] SET TRANGTHAI = 0 WHERE MANV = '{0}'", maHH);
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
        public void SuaHH(string maHH,string tenHH,int soLuong, float donGiaNhap,float donGiaBan, string maLoaiHH, string maNCC)
        {
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                //"DELETE FROM FC WHERE FCName = 'Chelsea'"

                cmd.CommandText = string.Format("UPDATE [dbo].[HANGHOA] SET TENHH=N'{0}' ,SOLUONG=N'{1}', DONGIANHAP='{2}',DONGIABAN='{3}',MALOAI=N'{4}',MACC=N'{5}' WHERE MAHH =N'{6}'", tenHH, soLuong, donGiaNhap, donGiaBan, maHH, maNCC, maHH);
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
        public void ThemHH(string maHH, string tenHH, int soLuong, float donGiaNhap, float donGiaBan, string maLoaiHH, string maNCC)
        {
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                //"DELETE FROM FC WHERE FCName = 'Chelsea'"

                cmd.CommandText = string.Format("INSERT [dbo].[NHANVIEN](MANV,TENNV,GIOITINH,NGAYSINH,SDT,DIACHI,QUEQUAN) VALUES('{0}',N'{1}',N'{2}','{3}','{4}',N'{5}',N'{6}') ", maHH, tenHH, soLuong, donGiaNhap, donGiaBan, maLoaiHH, maNCC);
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
