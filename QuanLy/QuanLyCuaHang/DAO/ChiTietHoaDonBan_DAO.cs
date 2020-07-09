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
                cmd.CommandText = "SELECT cthdb.MAHH,TENHH,cthdb.SOLUONG,hh.DONGIABAN ,cthdb.THANHTIEN FROM [dbo].[CHITIETHOADONBAN] cthdb,[dbo].[HANGHOA] hh WHERE cthdb.MAHH=hh.MAHH AND cthdb.TRANGTHAI = 1";
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ChiTietHoaDonBan_DTO cTHDB = new ChiTietHoaDonBan_DTO();
                    if (!dr.IsDBNull(0))
                        cTHDB.MaHH = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        cTHDB.TenHH = (string)dr[1];
                    if (!dr.IsDBNull(2))
                        cTHDB.SoLuong = (int)dr[2];
                    if (!dr.IsDBNull(3))
                        cTHDB.DonGia = (double)dr[3];
                    if (!dr.IsDBNull(4))
                        cTHDB.ThanhTien = (double)dr[4];
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
        public List<ChiTietHoaDonBan_DTO> LayDanhSachTheoMa(string maHDB)
        {
            List<ChiTietHoaDonBan_DTO> dsCTHDB = new List<ChiTietHoaDonBan_DTO>();
            List<HangHoa_DTO> dsHH = new List<HangHoa_DTO>();
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader dr = null;
            try
            {
                // 2. mở kết nối
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT cthdb.MAHH,TENHH,cthdb.SOLUONG,hh.DONGIABAN ,cthdb.THANHTIEN FROM [dbo].[CHITIETHOADONBAN] cthdb,[dbo].[HANGHOA] hh WHERE cthdb.MAHH=hh.MAHH AND cthdb.TRANGTHAI = 1 AND MAHDB='" + maHDB + "'";
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ChiTietHoaDonBan_DTO cTHDB = new ChiTietHoaDonBan_DTO();
                    if (!dr.IsDBNull(0))
                        cTHDB.MaHH = (string)dr[0];
                    if (!dr.IsDBNull(1))
                        cTHDB.TenHH = (string)dr[1];
                    if (!dr.IsDBNull(2))
                        cTHDB.SoLuong = (int)dr[2];
                    if (!dr.IsDBNull(3))
                        cTHDB.DonGia = (double)dr[3];
                    if (!dr.IsDBNull(4))
                        cTHDB.ThanhTien = (double)dr[4];
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
        public void XoaCTHDB(string maHDB)
        {
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                //"DELETE FROM FC WHERE FCName = 'Chelsea'"

                cmd.CommandText = string.Format("DELETE FROM CHITIETHOADONBAN WHERE MAHDB = '{0}'", maHDB);
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
        public string TongTienHoaDon(string maHDB)
        {
            string tongTien = "0";
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                //"DELETE FROM FC WHERE FCName = 'Chelsea'"

                cmd.CommandText = string.Format("exec sp_TongTienHoaDon '{0}'", maHDB);
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.Read())
                {
                        tongTien = reader.GetDouble(0).ToString();
                }
                return tongTien;
                
            }
            
            finally
            {
                // 5. đóng kết nối
                conn.Close();
            }
        }
        public void ThemCTHDB(ChiTietHoaDonBan_DTO cTHDB_DTO)
        {
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                //"DELETE FROM FC WHERE FCName = 'Chelsea'"

                cmd.CommandText = string.Format("EXEC sp_ThemCTHoaDon '{0}','{1}','{2}','{3}','{4}','{5}'", cTHDB_DTO.MaHDB,cTHDB_DTO.MaHH,cTHDB_DTO.SoLuong,cTHDB_DTO.KhuyenMai,cTHDB_DTO.GiamGia,cTHDB_DTO.ThanhTien);
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

        public void CapNhatCTHDB(int soLuong,long thanhTien,string maHDB,string maHH)
        {
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                //"DELETE FROM FC WHERE FCName = 'Chelsea'"

                cmd.CommandText = string.Format("EXEC sp_CapNhatCTHoaDon '{0}','{1}','{2}','{3}'", soLuong,thanhTien,maHDB, maHH);
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
        public bool checkCTHDB(string maHDB, string maHH)
        {
            // 1. Tạo đối tượng kết nối
            SqlConnection conn = DataProvider.TaoKetNoi();
            try
            {
                // 3. tạo đối tượng command
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = string.Format("SELECT MAHDB,MAHH FROM CHITIETHOADONBAN WHERE TRANGTHAI=1 AND MAHDB='{0}' AND MAHH='{1}'", maHDB,maHH);
                cmd.Connection = conn;
                // 4. thực thi cmd và xử lý kết quả
                SqlDataReader reader = cmd.ExecuteReader();
                int value = 0;
                if (reader.Read())
                {
                    if ((maHDB == reader.GetString(0).Trim()) && (maHH == reader.GetString(1).Trim()))
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
