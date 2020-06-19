using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyCuaHang
{
    public partial class frmHangHoa : DevExpress.XtraEditors.XtraForm
    {
        List<HangHoa_DTO> dsHH = null;
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            HangHoa_BUS hH_BUS = new HangHoa_BUS();
            dsHH = hH_BUS.LayDanhSach();
            dataGridViewHangHoa.DataSource = dsHH;
            dataGridViewHangHoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHangHoa.Columns["MAHH"].HeaderText = "Mã Hàng Hoá";
            dataGridViewHangHoa.Columns["TENHH"].HeaderText = "Tên Hàng Hoá";
            dataGridViewHangHoa.Columns["SOLUONG"].HeaderText = "Số Lượng";
            dataGridViewHangHoa.Columns["DONGIANHAP"].HeaderText = "Đơn Giá Nhập";
            dataGridViewHangHoa.Columns["DONGIABAN"].HeaderText = "Đơn Giá Bán";
            dataGridViewHangHoa.Columns["MALOAIHH"].HeaderText = "Mã Loại Hàng";
            dataGridViewHangHoa.Columns["MANCC"].HeaderText ="Mã Nhà Cung Cấp";
            dataGridViewHangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void hiemThiKhoa()
        {
            textTenHH.ReadOnly = true;
            textMaHH.ReadOnly = true;
            numericSoLuong.ReadOnly = true;
            textBoxGiaBan.ReadOnly = true;
            textBoxGiaNhap.ReadOnly = true;
            comboBoxMaNCC.ReadOnly=true;
            comboBoxMaLoaiHang.ReadOnly = true;
            btnCapNhatXong.Enabled = false;
            btnThemXong.Enabled = false;
            btnHuy.Enabled = false;
        }
        private void hiemThiMo()
        {
            textTenHH.ReadOnly = false;
            textMaHH.ReadOnly = false;
            numericSoLuong.ReadOnly = false;
            textBoxGiaBan.ReadOnly = false;
            textBoxGiaNhap.ReadOnly = false;
            comboBoxMaNCC.ReadOnly = false;
            comboBoxMaLoaiHang.ReadOnly = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
        private void dataGridViewHangHoa_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewHangHoa.SelectedRows.Count > 0)
            {
                DataGridViewRow item = dataGridViewHangHoa.SelectedRows[0];
                textMaHH.Text = item.Cells["MAHH"].Value.ToString();
                textTenHH.Text = item.Cells["TENHH"].Value.ToString();
                numericSoLuong.Value = int.Parse(item.Cells["SOLUONG"].Value.ToString());
                textBoxGiaBan.Text =item.Cells["DONGIABAN"].Value.ToString();
                textBoxGiaNhap.Text = item.Cells["DONGIANHAP"].Value.ToString();
            }
            hiemThiKhoa();
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }
    }
}