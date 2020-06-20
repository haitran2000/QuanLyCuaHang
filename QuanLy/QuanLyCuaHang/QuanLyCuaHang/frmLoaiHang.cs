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
    public partial class frmLoaiHang : DevExpress.XtraEditors.XtraForm
    {
        List<LoaiHang_DTO> dsLH = null;
        public frmLoaiHang()
        {
            InitializeComponent();
        }

        private void LoaiHang_Load(object sender, EventArgs e)
        {
            LoaiHang_BUS lH_BUS = new LoaiHang_BUS();
            dsLH = lH_BUS.LayDanhSach();
            dataGridViewLoaiHang.DataSource = dsLH;
            dataGridViewLoaiHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLoaiHang.Columns["MALH"].HeaderText = "Mã Loại Hàng";
            dataGridViewLoaiHang.Columns["TENLH"].HeaderText = "Tên Loại Hàng";
            dataGridViewLoaiHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}