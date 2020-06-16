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
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (textBoxTaiKhoan.Text != "")
            {
                if (textMKCu.Text != "")
                {
                    if (textMKMoi.Text != "" && textMKMoiLai.Text != "")
                    {
                        if (textMKMoi.Text==textMKMoiLai.Text)
                        {
                            try
                            {
                                TaiKhoan_BUS objTK_BUS = new TaiKhoan_BUS();
                                objTK_BUS.DoiMK(textMKMoi.Text, textBoxTaiKhoan.Text, textMKCu.Text);
                                MessageBox.Show("Đổi Mật Khẩu Thành Công");
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Chính Xác !!!", "Thông Báo");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật Khẩu Không Trùng Nhau Hoặc Trống", "Thông Báo");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa Nhập Mật Khẩu", "Thông Báo");
                }
            }
            else
            {
                MessageBox.Show("Chưa Nhập Tài Khoản !", "Thông Báo");
            }
        }
    }
}