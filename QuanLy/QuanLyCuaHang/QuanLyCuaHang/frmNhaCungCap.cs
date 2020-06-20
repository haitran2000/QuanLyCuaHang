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
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        List<NhaCungCap_DTO> dsNCC = null;
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            NhaCungCap_BUS nCC_BUS = new NhaCungCap_BUS();
            dsNCC = nCC_BUS.LayDanhSach();
            dataGridViewNhaCungCap.DataSource = dsNCC;
            dataGridViewNhaCungCap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewNhaCungCap.Columns["MANCC"].HeaderText = "Mã Nhà Cung Cấp";
            dataGridViewNhaCungCap.Columns["TENNCC"].HeaderText = "Tên Nhà Cung Cấp";
            dataGridViewNhaCungCap.Columns["DIACHI"].HeaderText = "Địa Chỉ";
            dataGridViewNhaCungCap.Columns["SDT"].HeaderText = "Số Điện Thoại";
            dataGridViewNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}