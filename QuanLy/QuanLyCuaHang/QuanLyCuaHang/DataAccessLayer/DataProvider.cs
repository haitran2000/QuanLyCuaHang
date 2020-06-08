using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data; 
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang
{
    class DataProvider
    {
        public static string chuoiKetNoi = @"Data Source=TRANDUCHAI\HAITRAN;Initial Catalog=QuanLyCuaHang1;Integrated Security=True";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private DataTable dtTable; 
        public static SqlConnection TaoKetNoi()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(chuoiKetNoi);
                con.Open();
            }
            catch (Exception) //Nếu không thể mở kết nối đồng thời bị lỗi thì trả về NULL
            {
                return null;
            }
            return con;
        }
    }
}
