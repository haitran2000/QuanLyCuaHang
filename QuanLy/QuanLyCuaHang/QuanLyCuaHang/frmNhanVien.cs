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
            dataGridViewNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }
        private void hiemThiKhoa()
        {
                textTenNV.ReadOnly = true;
                textMaNV.ReadOnly = true;
                textGT.ReadOnly = true;
                textDiaChi.ReadOnly = true;
                textQueQuan.ReadOnly = true;
                dateNgaySinh.ReadOnly = true;
                textSDT.ReadOnly = true;
                btnCapNhatXong.Enabled = false;
                btnThemXong.Enabled = false;
                btnHuy.Enabled = false;
        }
        private void hiemThiMo()
        {
            textTenNV.ReadOnly = false;
            textMaNV.ReadOnly = false;
            textGT.ReadOnly = false;
            textDiaChi.ReadOnly = false;
            textQueQuan.ReadOnly = false;
            dateNgaySinh.ReadOnly = false;
            textSDT.ReadOnly = false;
        }
        private void btnXoa_Click(object sender, EventArgs e)
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
                dateNgaySinh.EditValue = DateTime.ParseExact(item.Cells["NgaySinh"].Value.ToString(), "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                textDiaChi.Text = item.Cells["DIACHI"].Value.ToString();
                textQueQuan.Text = item.Cells["QUEQUAN"].Value.ToString();
                textSDT.Text = item.Cells["SDT"].Value.ToString();
            }
            hiemThiKhoa();
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            btnCapNhatXong.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            hiemThiMo();
            textMaNV.ReadOnly = true;
            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            textMaNV.Text = "";
            textTenNV.Text = "";
            textGT.Text = "";
            dateNgaySinh.EditValue = DateTime.Now;
            textSDT.Text = "";
            textQueQuan.Text = "";
            textDiaChi.Text = "";
            btnThemXong.Enabled = true;
            hiemThiMo();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
        }

        private void btnThemXong_Click(object sender, EventArgs e)
        {
            if (textMaNV.Text != "")
            {
                NhanVien_BUS objNV_BUS = new NhanVien_BUS();
                objNV_BUS.ThemNV(textMaNV.Text, textTenNV.Text, textGT.Text, (DateTime)DateTime.ParseExact(dateNgaySinh.EditValue.ToString(), "dd/MM/yyyy h:mm:ss tt",
                              null), textSDT.Text, textDiaChi.Text, textQueQuan.Text);
                dataGridViewNhanVien.DataSource = objNV_BUS.LayDanhSach();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                MessageBox.Show("Mã Nhân Viên Không Được Để Trống !!", "Thông Báo");
            }
            

        }
            
        private void btnCapNhatXong_Click_1(object sender, EventArgs e)
        {

            if (dataGridViewNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedItem = dataGridViewNhanVien.SelectedRows[0];
                NhanVien_BUS objNV_BUS = new NhanVien_BUS();
                objNV_BUS.SuaNV(textMaNV.Text, textTenNV.Text, textGT.Text, (DateTime)DateTime.ParseExact(dateNgaySinh.EditValue.ToString(), "dd/MM/yyyy h:mm:ss tt",
                                  null), textSDT.Text, textDiaChi.Text, textQueQuan.Text);
                dataGridViewNhanVien.DataSource = objNV_BUS.LayDanhSach();
            }
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            textMaNV.Text = "";
            textTenNV.Text = "";
            textGT.Text = "";
            dateNgaySinh.EditValue = DateTime.Now;
            textSDT.Text = "";
            textQueQuan.Text = "";
            textDiaChi.Text = "";
            hiemThiKhoa();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void dataGridViewNhanVien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }


    }
}
