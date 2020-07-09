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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKy dangKy = new frmDangKy();
            dangKy.ShowDialog();
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoan_BUS tK_BUS = new TaiKhoan_BUS();
            if(tK_BUS.DangNhap(txtTK.Text,txtMK.Text))
            {
                MessageBox.Show("Đăng nhập thành công vào hẹ thống","Thông Báo");
                frmGiaoDien frm = new frmGiaoDien();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại","Thông Báo");
                
            }
        }
    }
}