using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DTO;
namespace QuanLyCuaHang
{
    public partial class frmChiTietHoaDonBan : DevExpress.XtraEditors.XtraForm
    {
        List<ChiTietHoaDonBan_DTO> dsCTHDB = null;
        public frmChiTietHoaDonBan()
        {
            InitializeComponent();
        }

        private void frmChiTietHoaDonBan_Load(object sender, EventArgs e)
        {
            ChiTietHoaDonBan_BUS cTHDB_BUS = new ChiTietHoaDonBan_BUS();
            dsCTHDB = cTHDB_BUS.LayDanhSach();
            dataGridViewCTHDB.DataSource = dsCTHDB;
            dataGridViewCTHDB.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCTHDB.Columns["MAHDB"].HeaderText = "Mã Hoá Đơn Bán";
            dataGridViewCTHDB.Columns["MAHH"].HeaderText = "Mã Hàng Hoá";
            dataGridViewCTHDB.Columns["SOLUONG"].HeaderText = "Số Lượng";
            dataGridViewCTHDB.Columns["KHUYENMAI"].HeaderText = "Khuyến Mại (%)";
            dataGridViewCTHDB.Columns["GIAMGIA"].HeaderText = "Giảm Giá";
            dataGridViewCTHDB.Columns["THANHTIEN"].HeaderText = "Thành Tiền";
            dataGridViewCTHDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}