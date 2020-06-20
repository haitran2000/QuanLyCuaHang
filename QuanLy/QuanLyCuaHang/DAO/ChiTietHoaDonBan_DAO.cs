using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class ChiTietHoaDonBan_DAO
    {
        public List<ChiTietHoaDonBan_DTO> LayDanhSach()
        {
            List<ChiTietHoaDonBan_DTO> dsCTHDB = new List<ChiTietHoaDonBan_DTO>();
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader dr = null;
            try
            {
                // 2. mở kết nối
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM [dbo].[CHITIETHOADONBAN] WHERE TRANGTHAI = 1";
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ChiTietHoaDonBan_DTO cTHDB = new ChiTietHoaDonBan_DTO();
                    // đọc từng dòng dữ liệu
                    if (!dr.IsDBNull(0))
                        cTHDB.MaHDB = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        cTHDB.MaHH = (string)dr[1];
                    if (!dr.IsDBNull(2))
                        cTHDB.SoLuong = (int)dr[2];
                    if (!dr.IsDBNull(3))
                        cTHDB.KhuyenMai = (int)dr[3];
                    if (!dr.IsDBNull(4))
                        cTHDB.GiamGia = (double)dr[4];
                    if (!dr.IsDBNull(5))
                        cTHDB.ThanhTien = (double)dr[5];

                    dsCTHDB.Add(cTHDB);
                }

            }
            finally
            {
                dr.Close();
                // 5. đóng kết nối
                conn.Close();
            }
            return dsCTHDB;
        }
    }
}
