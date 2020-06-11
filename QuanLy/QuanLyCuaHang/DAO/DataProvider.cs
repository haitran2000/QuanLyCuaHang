using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data; 
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class DataProvider
    {
        public static string chuoiKetNoi = @"Data Source=TRANDUCHAI\HAITRAN;Initial Catalog=QuanLyCuaHang;Integrated Security=True";
        public static SqlConnection TaoKetNoi()
        {
                SqlConnection con = new SqlConnection(chuoiKetNoi);
                con.Open();
                return con;
        }
    }
}
