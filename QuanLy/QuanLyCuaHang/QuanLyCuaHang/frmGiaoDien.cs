using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class frmGiaoDien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmGiaoDien()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void GiaoDien_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Springtime";
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDangNhap dangNhap = new frmDangNhap();
            dangNhap.MdiParent = this;
            dangNhap.Show();
        }

        private void barButtonItemNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhanVien nhanVien = new frmNhanVien();
            nhanVien.MdiParent = this;
            nhanVien.Show();
            nhanVien.WindowState = FormWindowState.Maximized;
            tabControl1.Hide();
            tabControl1.Show();
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMatKhau frmDMK = new frmDoiMatKhau();
            frmDMK.MdiParent = this;
            frmDMK.Show();
        }

        private void barButtonItemDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDangKy frmDK = new frmDangKy();
            frmDK.MdiParent = this;
            frmDK.Show();
        }

        private void barButtonItemPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhanQuyen frmPQ = new frmPhanQuyen();
            frmPQ.MdiParent = this;
            frmPQ.Show();
        }

        private void barButtonItemDSHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHangHoa frmHH = new frmHangHoa();
            frmHH.MdiParent = this;
            frmHH.Show();
        }

        private void barButtonItemHoaDonBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHoaDonBan frmHDB = new frmHoaDonBan();
            frmHDB.MdiParent = this;
            frmHDB.Show();
        }

        private void barButtonItemHoaDonNhaphang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHoaDonNhap frmHDN = new frmHoaDonNhap();
            frmHDN.MdiParent = this;
            frmHDN.Show();
        }

        private void barButtonItemNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhaCungCap frmNCC = new frmNhaCungCap();
            frmNCC.MdiParent = this;
            frmNCC.Show();
        }

        private void barButtonItemLoaiHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLoaiHang frmLH = new frmLoaiHang();
            frmLH.MdiParent = this;
            frmLH.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void taoHoaDonBan_Click(object sender, EventArgs e)
        {
            frmPhieuMuaHang frm = new frmPhieuMuaHang();
            frm.Show();
        }
        
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;

            Font drawFont = new Font("Arial", 9);

            g.FillRectangle(new SolidBrush(Color.Silver), e.Bounds);

            e.Graphics.DrawString("AS", drawFont, new SolidBrush(Color.FromArgb(0xFF, 0x00, 0x33)), e.Bounds.Right+8,e.Bounds.Top + 4);

            e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, e.Font, Brushes.White, e.Bounds.Left + 1, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }
    }
}
