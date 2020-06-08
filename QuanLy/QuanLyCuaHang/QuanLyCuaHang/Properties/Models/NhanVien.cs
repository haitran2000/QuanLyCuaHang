using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang
{
    class NhanVien
    {
        public string maNV {get;set;}
        public string tenNV { get; set; }
        public string gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public string soDT { get; set; }
        public string diaChi { get; set; }
        public string queQuan { get; set; }

        public NhanVien()
        {
        }

        public NhanVien(string _maNV, string _tenNV, string _gioiTinh, DateTime _ngaySinh, string _soDT, string _diaChi, string _queQuan)
        {
            maNV = _maNV;
            tenNV = _tenNV;
            gioiTinh = _gioiTinh;
            ngaySinh = _ngaySinh;
            soDT = _soDT;
            diaChi = _diaChi;
            queQuan = _queQuan;
        }
        public List<NhanVien> LayDanhSachNhanVien()
        {
            //Tạo một danh sách để chứa danh sách sinh viên
            List<NhanVien> listNV = new List<NhanVien>();

            #region Bước 1: Tạo kết nối với cơ sở dữ liệu

            //Tạo đối tượng kết nối
            SqlConnection con = DataProvider.TaoKetNoi();

            #endregion

            //Mở kết nối được
            if (con != null)
            {
                #region Bước 2: Tạo một đối tượng truy vấn dữ liệu Command

                //Tạo đối tượng truy vấn
                SqlCommand command = new SqlCommand();

                //Gán câu truy vấn vào đối tượng command thông qua thuộc tính CommandText
                command.CommandText = @"SELECT * FROM NhanVien WHERE TRANGTHAI = TRUE";

                //Gán đối tượng con vào trong command thông qua thuộc tính Connection
                command.Connection = con;

                //Hoặc sử dụng cách gán câu truy vấn, đối tượng con thông qua khởi tạo 
                //OleDbCommand command = new OleDbCommand(@"SELECT * FROM SINHVIEN", con);

                #endregion

                #region Bước 3: Truy vấn cơ sở dữ liệu và xử lý kết quả trả về

                //Tạo đối tượng truy vấn
                SqlDataReader dataReader = command.ExecuteReader();

                //Xử lý kết quả trả về
                //Mỗi lần dataReader gọi hàm Read() thì sẽ đọc một dòng dử liệu
                while (dataReader.Read())
                {
                    //Tạo một sinh viên để lưu trữ thông tin
                    NhanVien nV = new NhanVien();

                    //Nếu dữ liệu ở cột thứ 0 khác rỗng thì mới lấy ra được
                    if (dataReader.IsDBNull(0) != null)
                    {
                        //Lấy dữ liệu ở cột 0 ra
                        nV.maNV = dataReader[0].ToString();
                    }

                    //Nếu dữ liệu ở cột thứ 1 khác rỗng thì mới lấy ra được
                    if (dataReader.IsDBNull(1) != null)
                    {
                        //Có thể lấy dữ liệu ra bằng cách chọn chỉ số cột như lấy MSSV hoặc lấy theo tên cột
                        nV.tenNV = dataReader["TENNV"].ToString();
                    }

                    //Nếu dữ liệu ở cột thứ 2 khác rỗng thì mới lấy ra được
                    if (dataReader.IsDBNull(2) != null)
                    {
                        nV.gioiTinh = dataReader["GIOITINH"].ToString();
                    }

                    //Nếu dữ liệu ở cột thứ 3 khác rỗng thì mới lấy ra được
                    if (dataReader.IsDBNull(3) != null)
                    {
                        nV.ngaySinh = (DateTime)dataReader["NGAYSINH"];
                    }

                    //Nếu dữ liệu ở cột thứ 4 khác rỗng thì mới lấy ra được
                    if (dataReader.IsDBNull(4) != null)
                    {
                        nV.soDT = dataReader["SODT"].ToString();
                    }
                    if (dataReader.IsDBNull(5) != null)
                    {
                        nV.diaChi = dataReader["DIACHI"].ToString();
                    }
                    if (dataReader.IsDBNull(6) != null)
                    {
                        nV.soDT = dataReader["SODT"].ToString();
                    }                    
                    //Sau khi thêm dữ liệu cho sv xong thì thêm sinh viên đó vào danh sách listSV
                    listNV.Add(nV);
                }

                #endregion

                #region Bước 4: Đóng kết nối

                //Sau khi lấy dữ liệu xong thì đóng kết nối lại
                dataReader.Close();
                con.Close();

                #endregion
            }

            //Trả về danh sách sinh viên
            return listNV;
        }
    }
}
