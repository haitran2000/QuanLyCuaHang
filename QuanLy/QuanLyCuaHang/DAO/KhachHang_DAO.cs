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
    public class KhachHang_DAO
    {
        public List<KhachHang_DTO> LayDanhSach()
        {
            List<KhachHang_DTO> dsKH = new List<KhachHang_DTO>();
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader dr = null;
            try
            {
                // 2. mở kết nối
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM [dbo].[KHACHHANG] WHERE TRANGTHAI = 1";
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    KhachHang_DTO kH = new KhachHang_DTO();
                    // đọc từng dòng dữ liệu
                    if (!dr.IsDBNull(0))
                        kH.MaKH = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        kH.TenKH = (string)dr[1];
                    if (!dr.IsDBNull(2))
                        kH.DiaChi = (string)dr[2];
                    if (!dr.IsDBNull(3))
                        kH.SoDT = (string)dr[3];
                    if (!dr.IsDBNull(4))
                        dsKH.Add(kH);
                }

            }
            finally
            {
                dr.Close();
                // 5. đóng kết nối
                conn.Close();
            }
            return dsKH;
        }
    }
}
