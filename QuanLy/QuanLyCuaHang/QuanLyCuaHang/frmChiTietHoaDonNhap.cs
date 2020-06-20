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
    public partial class frmChiTietHoaDonNhap : DevExpress.XtraEditors.XtraForm
    {
        List<ChiTietHoaDonNhap_DTO> dsCTHDN = null;
        public frmChiTietHoaDonNhap()
        {
            InitializeComponent();
        }

        private void frmChiTietHoaDonNhap_Load(object sender, EventArgs e)
        {
            ChiTietHoaDonNhap_BUS cTHDN_BUS = new ChiTietHoaDonNhap_BUS();
            dsCTHDN = cTHDN_BUS.LayDanhSach();
            dataGridViewCTHDN.DataSource = dsCTHDN;
            dataGridViewCTHDN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCTHDN.Columns["MAHDN"].HeaderText = "Mã Hoá Đơn Bán";
            dataGridViewCTHDN.Columns["MAHH"].HeaderText = "Mã Hàng Hoá";
            dataGridViewCTHDN.Columns["SOLUONG"].HeaderText = "Số Lượng";
            dataGridViewCTHDN.Columns["GIAMGIA"].HeaderText = "Giảm Giá";
            dataGridViewCTHDN.Columns["THANHTIEN"].HeaderText = "Thành Tiền";
            dataGridViewCTHDN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}