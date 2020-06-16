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

namespace QuanLyCuaHang
{
    public partial class frmPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            TaiKhoan_BUS tk_BUS = new TaiKhoan_BUS();
            dataGridViewPhanQuyen.DataSource = tk_BUS.LayDanhSach();
            dataGridViewPhanQuyen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPhanQuyen.Columns["TAIKHOAN"].HeaderText = "Tài Khoản";
            dataGridViewPhanQuyen.Columns["MAQUYEN"].HeaderText = "Mã Quyền";
            dataGridViewPhanQuyen.Columns["GHICHU"].HeaderText = "Ghi Chú";
            dataGridViewPhanQuyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridViewPhanQuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}