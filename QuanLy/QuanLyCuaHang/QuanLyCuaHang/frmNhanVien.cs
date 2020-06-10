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
    public partial class frmNhanVien : Form
    {
        List<NhanVien_DTO> dsNhanVien = null;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {           
            NhanVien_BUS nV_BUS = new NhanVien_BUS();
            dsNhanVien = nV_BUS.LayDanhSach();
            dataGridViewNhanVien.DataSource = dsNhanVien;
            dataGridViewNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewNhanVien.Columns["MANV"].HeaderText = "Mã Nhân Viên";
            dataGridViewNhanVien.Columns["TENNV"].HeaderText = "Tên Nhân Viên";
            dataGridViewNhanVien.Columns["GiOITINH"].HeaderText = "Giới Tính";
            dataGridViewNhanVien.Columns["NGAYSINH"].HeaderText = "Ngày Sinh";
            dataGridViewNhanVien.Columns["SDT"].HeaderText = "Số Điện Thoại";
            dataGridViewNhanVien.Columns["DIACHI"].HeaderText = "Địa Chỉ";
            dataGridViewNhanVien.Columns["QUEQUAN"].HeaderText = "Quê QUán";
        }
        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewNhanVien.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có thật sự muốn xóa Nhân Viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Lấy ra sản phẩm được chọn
                    DataGridViewRow selectedItem = dataGridViewNhanVien.SelectedRows[0];
                        // xóa trên CSDL
                        NhanVien_BUS objNV_BUS = new NhanVien_BUS();
                        objNV_BUS.XoaNV(textMaNV.Text);
                        dataGridViewNhanVien.DataSource = objNV_BUS.LayDanhSach();
                        
                }
            }
        }
        private void dataGridViewNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow item = dataGridViewNhanVien.SelectedRows[0];
                textMaNV.Text = item.Cells["MANV"].Value.ToString();
                textTenNV.Text = item.Cells["TENNV"].Value.ToString();
                textGT.Text = item.Cells["GIOITINH"].Value.ToString();
                dateNgaySinh.EditValue = DateTime.ParseExact(item.Cells["NgaySinh"].Value.ToString(), "d/M/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                textDiaChi.Text = item.Cells["DIACHI"].Value.ToString();
                textQueQuan.Text = item.Cells["QUEQUAN"].Value.ToString();
                textSDT.Text = item.Cells["SDT"].Value.ToString();
            }
        }

        private void simpleButtonSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedItem = dataGridViewNhanVien.SelectedRows[0];
                NhanVien_BUS objNV_BUS = new NhanVien_BUS();
                //objNV_BUS.SuaNV(textMaNV.Text, textTenNV.Text, textGT.Text,Convert.ToDateTime(dateNgaySinh.EditValue.ToString()), textSDT.Text, textDiaChi.Text, textQueQuan.Text);
                //dataGridViewNhanVien.DataSource = objNV_BUS.LayDanhSach();
            }
        }

        private void simpleButtonReset_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateNgaySinh.EditValue.ToString());
        }
    }
}
