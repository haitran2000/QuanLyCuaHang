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
    public class HoaDonBan_DAO
    {
        public List<HoaDonBan_DTO> LayDanhSach()
        {
            List<HoaDonBan_DTO> dsHDB = new List<HoaDonBan_DTO>();
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader dr = null;
            try
            {
                // 2. mở kết nối
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM [dbo].[HOADONBAN] WHERE TRANGTHAI = 1";
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    HoaDonBan_DTO hDB = new HoaDonBan_DTO();
                    // đọc từng dòng dữ liệu
                    if (!dr.IsDBNull(0))
                        hDB.MaHDB = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        hDB.MaNV = (string)dr[1];
                    if (!dr.IsDBNull(2))
                        hDB.NgayBan = (DateTime)dr[2];
                    if (!dr.IsDBNull(3))
                        hDB.MaKH = (string)dr[3];
                    if (!dr.IsDBNull(4))
                        hDB.TongTien = (double)dr[4];
                    
                        dsHDB.Add(hDB);
                }

            }
            finally
            {
                dr.Close();
                // 5. đóng kết nối
                conn.Close();
            }
            return dsHDB;
        }
    }
}
