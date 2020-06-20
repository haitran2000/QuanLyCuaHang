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
    public class LoaiHang_DAO
    {
        public List<LoaiHang_DTO> LayDanhSach()
        {
            List<LoaiHang_DTO> dsLH = new List<LoaiHang_DTO>();
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader dr = null;
            try
            {
                // 2. mở kết nối
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM [dbo].[LOAIHANG] WHERE TRANGTHAI = 1";
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LoaiHang_DTO lH = new LoaiHang_DTO();
                    // đọc từng dòng dữ liệu
                    if (!dr.IsDBNull(0))
                        lH.MaLH = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        lH.TenLH = (string)dr[1];
                        dsLH.Add(lH);
                }

            }
            finally
            {
                dr.Close();
                // 5. đóng kết nối
                conn.Close();
            }
            return dsLH;
        }
    }
}
