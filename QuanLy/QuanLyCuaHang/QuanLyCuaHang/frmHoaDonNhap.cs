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
    public partial class frmHoaDonNhap : DevExpress.XtraEditors.XtraForm
    {
        List<HoaDonNhap_DTO> dsHoaDonNhap = null;
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }

        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            HoaDonNhap_BUS hDN_BUS = new HoaDonNhap_BUS();
            dsHoaDonNhap = hDN_BUS.LayDanhSach();
            dataGridViewHoaDonNhap.DataSource = dsHoaDonNhap;
            dataGridViewHoaDonNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHoaDonNhap.Columns["MAHDN"].HeaderText = "Mã Hoá Nhập";
            dataGridViewHoaDonNhap.Columns["MANV"].HeaderText = "Mã Nhân Viên Lập Hoá Đơn";
            dataGridViewHoaDonNhap.Columns["NGAYMUA"].HeaderText = "Ngày Lập Hoá Đơn";
            dataGridViewHoaDonNhap.Columns["MANCC"].HeaderText = "Mã Khách Hàng";
            dataGridViewHoaDonNhap.Columns["TONGTIEN"].HeaderText = "Tổng Tiền";
            dataGridViewHoaDonNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnXemChiTietHDN_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDonNhap frmCTHDN = new frmChiTietHoaDonNhap();
            frmCTHDN.Show();
        }
    }
}