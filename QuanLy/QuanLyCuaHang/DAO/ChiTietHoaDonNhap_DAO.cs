using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class ChiTietHoaDonNhap_DAO
    {
        public List<ChiTietHoaDonNhap_DTO> LayDanhSach()
        {
            List<ChiTietHoaDonNhap_DTO> dsCTHDN = new List<ChiTietHoaDonNhap_DTO>();
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader dr = null;
            try
            {
                // 2. mở kết nối
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM [dbo].[CHITIETHOADONNHAP] WHERE TRANGTHAI = 1";
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ChiTietHoaDonNhap_DTO cTHDN = new ChiTietHoaDonNhap_DTO();
                    // đọc từng dòng dữ liệu
                    if (!dr.IsDBNull(0))
                        cTHDN.MaHDN = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        cTHDN.MaHH = (string)dr[1];
                    if (!dr.IsDBNull(2))
                        cTHDN.SoLuong = (int)dr[2];
                    if (!dr.IsDBNull(3))
                        cTHDN.GiamGia = (double)dr[3];
                    if (!dr.IsDBNull(4))
                        cTHDN.ThanhTien = (double)dr[4];
                    dsCTHDN.Add(cTHDN);
                }

            }
            finally
            {
                dr.Close();
                // 5. đóng kết nối
                conn.Close();
            }
            return dsCTHDN;
        }
    }
}
