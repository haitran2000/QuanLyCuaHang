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
   public class HoaDonNhap_DAO
    {
        public List<HoaDonNhap_DTO> LayDanhSach()
        {
            List<HoaDonNhap_DTO> dsHDN = new List<HoaDonNhap_DTO>();
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader dr = null;
            try
            {
                // 2. mở kết nối
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM [dbo].[HOADONNHAP] WHERE TRANGTHAI = 1";
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    HoaDonNhap_DTO hDN = new HoaDonNhap_DTO();
                    // đọc từng dòng dữ liệu
                    if (!dr.IsDBNull(0))
                        hDN.MaHDN = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        hDN.MaNV = (string)dr[1];
                    if (!dr.IsDBNull(2))
                        hDN.NgayMua = (DateTime)dr[2];
                    if (!dr.IsDBNull(3))
                        hDN.MaNCC = (string)dr[3];
                    if (!dr.IsDBNull(4))
                        hDN.TongTien = (double)dr[4];

                    dsHDN.Add(hDN);
                }

            }
            finally
            {
                dr.Close();
                // 5. đóng kết nối
                conn.Close();
            }
            return dsHDN;
        }
    }
}
