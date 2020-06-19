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
            dataGridViewPhanQuyen.Columns["MATKHAU"].Visible = false;
            dataGridViewPhanQuyen.Columns["TRANGTHAI"].Visible = false;
            dataGridViewPhanQuyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PhanQuyen_BUS pQ_BUS = new PhanQuyen_BUS();
            comboBoxMaQuyen.DataSource = pQ_BUS.LayDanhSach();
            comboBoxMaQuyen.ValueMember = "MAQUYEN";
        }

        private void dataGridViewPhanQuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewPhanQuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPhanQuyen.SelectedRows.Count > 0)
            {
                DataGridViewRow item = dataGridViewPhanQuyen.SelectedRows[0];
                textTK.Text = item.Cells["TAIKHOAN"].Value.ToString();
                textGhiChu.Text = item.Cells["GHICHU"].Value.ToString();
            }
                
        }
    }
}