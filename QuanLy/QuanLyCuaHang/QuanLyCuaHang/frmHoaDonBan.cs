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
    public partial class frmHoaDonBan : DevExpress.XtraEditors.XtraForm
    {
        List<HoaDonBan_DTO> dsHoaDonBan = null;
        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            HoaDonBan_BUS hDB_BUS = new HoaDonBan_BUS();
            dsHoaDonBan = hDB_BUS.LayDanhSach();
            dataGridViewHoaDonBan.DataSource = dsHoaDonBan;
            dataGridViewHoaDonBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHoaDonBan.Columns["MAHDB"].HeaderText = "Mã Hoá Đơn";
            dataGridViewHoaDonBan.Columns["MANV"].HeaderText = "Mã Nhân Viên Lập Hoá Đơn";
            dataGridViewHoaDonBan.Columns["NGAYBAN"].HeaderText = "Ngày Lập Hoá Đơn";
            dataGridViewHoaDonBan.Columns["MAKH"].HeaderText = "Mã Khách Hàng";
            dataGridViewHoaDonBan.Columns["TONGTIEN"].HeaderText = "Tổng Tiền";
            dataGridViewHoaDonBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

        }
    }
}