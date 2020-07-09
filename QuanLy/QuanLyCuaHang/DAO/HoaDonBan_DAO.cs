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
        public void ThemHDB(HoaDonBan_DTO hDB_DTO)
        {
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = string.Format("INSERT [dbo].[HOADONBAN](MAHDB ,MANV,NGAYBAN,MAKH,TONGTIEN) VALUES('{0}','{1}','{2}','{3}','{4}') ", hDB_DTO.MaHDB,hDB_DTO.MaNV,hDB_DTO.NgayBan.ToString(),hDB_DTO.MaKH,hDB_DTO.TongTien);
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
        public bool CheckMaHDB(string maHDB)
        {
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = string.Format("SELECT MAHDB FROM [dbo].[HOADONBAN] WHERE MAHDB ='{0}'", maHDB);
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                SqlDataReader reader = cmd.ExecuteReader();
                int value = 0;
                if (reader.Read())
                {
                    if ((maHDB == reader.GetString(0).Trim()))
                    {
                        value = 1;
                    }
                }
                if (value == 1)
                    return true;
                else
                    return false;

            }

            finally
            {
                // 5. đóng kết nối
                conn.Close();
            }
        }
    }
}
