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
    public class NhaCungCap_DAO
    {
        public List<NhaCungCap_DTO> LayDanhSach()
        {
            List<NhaCungCap_DTO> dsNCC = new List<NhaCungCap_DTO>();
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader dr = null;
            try
            {
                // 2. mở kết nối
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM [dbo].[NHACUNGCAP] WHERE TRANGTHAI = 1";
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    NhaCungCap_DTO nCC = new NhaCungCap_DTO();
                    // đọc từng dòng dữ liệu
                    if (!dr.IsDBNull(0))
                        nCC.MaNCC = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        nCC.TenNCC = (string)dr[1];
                    if (!dr.IsDBNull(2))
                        nCC.DiaChi = (string)dr[2];
                    if (!dr.IsDBNull(3))
                        nCC.SDT = (string)dr[3];
                    dsNCC.Add(nCC);
                }

            }
            finally
            {
                dr.Close();
                // 5. đóng kết nối
                conn.Close();
            }
            return dsNCC;
        }
    }
}
