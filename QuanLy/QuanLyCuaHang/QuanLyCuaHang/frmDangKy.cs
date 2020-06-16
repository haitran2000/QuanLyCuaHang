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
    public partial class frmDangKy : DevExpress.XtraEditors.XtraForm
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tk, mk, nhapMK;
            tk = textBoxTaiKhoan.Text;
            mk = textBoxMatKhau.Text;
            nhapMK = textBoxNhapMatKhau.Text;
            if (tk != "")
            {
                if (mk != "")
                {
                    if (mk == nhapMK)
                    {
                        TaiKhoan_BUS objTK_BUS = new TaiKhoan_BUS();
                        objTK_BUS.ThemTK(tk, mk);
                        MessageBox.Show("Đăng Ký Thành Công Tự Động chuyển sang Đăng Nhập ", "Thống Báo");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nhập Lại Mật Khẩu Không Trùng Nhau !", "Lỗi");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa Nhập Mật Khẩu !", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Chưa Nhập Tài Khoản !", "Lỗi");
            }
        }
    }
}