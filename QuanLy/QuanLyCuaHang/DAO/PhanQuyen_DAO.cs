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
    public class PhanQuyen_DAO
    {
        public List<PhanQuyen_DTO> LayDanhSach()
        {
            List<PhanQuyen_DTO> dsPQ = new List<PhanQuyen_DTO>();
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader dr = null;
            try
            {
                // 2. mở kết nối
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select MAQUYEN from PHANQUYEN";
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    PhanQuyen_DTO pQ = new PhanQuyen_DTO();
                    // đọc từng dòng dữ liệu
                    if (!dr.IsDBNull(0))
                        pQ.MaQuyen = (int)dr[0];
                    
                    dsPQ.Add(pQ);
                }

            }
            finally
            {
                dr.Close();
                // 5. đóng kết nối
                conn.Close();
            }
            return dsPQ;
        }
    }
}
