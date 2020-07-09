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
    public partial class frmPhieuMuaHang : DevExpress.XtraEditors.XtraForm
    {
        HangHoa_BUS hh_BUS = new HangHoa_BUS();
        HoaDonBan_BUS hdb_BUS = new HoaDonBan_BUS();
        KhachHang_BUS kH_BUS = new KhachHang_BUS();
        ChiTietHoaDonBan_BUS cTHDB_BUS = new ChiTietHoaDonBan_BUS();
        NhanVien_BUS nhanVien = new NhanVien_BUS();
        List<ChiTietHoaDonBan_DTO> lsCTHDB = null;
        HoaDonBan_DTO hdB = new HoaDonBan_DTO();
        public frmPhieuMuaHang()
        {
            InitializeComponent();
        }
        
        private void frmPhieuMuaHang_Load(object sender, EventArgs e)
        {
            loadDuLieu();
            trangThaiBanDau();
            luuHD.Enabled =huyHD.Enabled= false;
        }
        public void loadDuLieu()
        {
            cbBMaHang.DataSource = hh_BUS.LayDanhSach();
            cbBMaHang.ValueMember = "MaHH";
            cbBMaHoaDon.DataSource = hdb_BUS.LayDanhSach();
            cbBMaHoaDon.ValueMember = "MaHDB";
            cbBMaKH.DataSource = kH_BUS.LayDanhSach();
            cbBMaKH.ValueMember = "MaKH";
            cbBMaNV.DataSource = nhanVien.LayDanhSach();
            cbBMaNV.ValueMember = "MaNV";
        }
        void trangThaiBanDau()
        {
            txtDiaChi.Text = txtDienThoai.Text = txtMaHD.Text = txtTenHang.Text = txtTenNV.Text = txtTenKH.Text = "";
            txtTongTien.Text = txtThanhTien.Text = txtGiamGia.Text = txtGia.Text = "0";
            cbBMaHoaDon.SelectedIndex = cbBMaKH.SelectedIndex = cbBMaHang.SelectedIndex = cbBMaNV.SelectedIndex = -1;
            dateNgayBan.Value = DateTime.Now;
            lvCTHDB.Items.Clear();
        }
        void hiemThiThongTinHangHoa(HangHoa_DTO hangHoa)
        {
            txtTenHang.Text = hangHoa.TenHH;
            txtGia.Text = hangHoa.DonGiaBan.ToString();
            numberSoLuong.Value = 0;
            txtThanhTien.Text = "0";
        }
        void hiemThiThongTinHoaDon(HoaDonBan_DTO hoaDonBan)
        {
            txtMaHD.Text = hoaDonBan.MaHDB;
            dateNgayBan.Value = hoaDonBan.NgayBan;
            cbBMaNV.Text = hoaDonBan.MaNV;
            cbBMaKH.Text = hoaDonBan.MaKH;
        }
        void hiemThiThongTinKhachHang(KhachHang_DTO khachHang)
        {
            txtTenKH.Text = khachHang.TenKH;
            txtDiaChi.Text = khachHang.DiaChi;
            txtDienThoai.Text = khachHang.SoDT;
        }
        void tenNhanVien(NhanVien_DTO nhanVien)
        {
            txtTenNV.Text = nhanVien.TenNV;
        }
        private void themHH_Click(object sender, EventArgs e)
        {
            if (lvCTHDB.Items.Count == 0)
            {
                ListViewItem lvi = new ListViewItem(cbBMaHang.Text);
                lvi.SubItems.Add(txtTenHang.Text);
                lvi.SubItems.Add(numberSoLuong.Value.ToString());
                lvi.SubItems.Add(txtGia.Text);
                lvi.SubItems.Add(txtThanhTien.Text);
                lvCTHDB.Items.Add(lvi);
            }
            if (lvCTHDB.Items.Count > 0)
            {
                int values = 0;
                for (int i = 0; i < lvCTHDB.Items.Count; i++)
                {
                    if (lvCTHDB.Items[i].Text.Equals(cbBMaHang.Text))
                    {
                        int soLuong = int.Parse(lvCTHDB.Items[i].SubItems[2].Text);
                        long thanhTien = long.Parse(lvCTHDB.Items[i].SubItems[4].Text);
                        lvCTHDB.Items[i].SubItems[2].Text = (soLuong + numberSoLuong.Value).ToString();
                        lvCTHDB.Items[i].SubItems[4].Text = (thanhTien + long.Parse(txtThanhTien.Text)).ToString();
                        values = 1;
                        break;
                    }
                }
                if (values == 0)
                {
                    ListViewItem lvi = new ListViewItem(cbBMaHang.Text);
                    lvi.SubItems.Add(txtTenHang.Text);
                    lvi.SubItems.Add(numberSoLuong.Value.ToString());
                    lvi.SubItems.Add(txtGia.Text);
                    lvi.SubItems.Add(txtThanhTien.Text);
                    lvCTHDB.Items.Add(lvi);
                }
            }
        }

        private void cbBMaHang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbBMaHang.SelectedItem != null)
            {
                HangHoa_DTO hangHoa_DTO = (HangHoa_DTO)cbBMaHang.SelectedItem;
                hiemThiThongTinHangHoa(hangHoa_DTO);
            }
        }

        private void numberSoLuong_ValueChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = (numberSoLuong.Value*long.Parse(txtGia.Text)).ToString();
        }

        private void timKiemMaHD_Click(object sender, EventArgs e)
        {

            if (cbBMaHoaDon.SelectedItem != null)
            {
                if(hdb_BUS.CheckMaHDB(cbBMaHoaDon.Text))
                {
                    lvCTHDB.Items.Clear();
                    HoaDonBan_DTO hoaDonBan = (HoaDonBan_DTO)cbBMaHoaDon.SelectedItem;
                    hiemThiThongTinHoaDon(hoaDonBan);
                    KhachHang_DTO khachHang = (KhachHang_DTO)cbBMaKH.SelectedItem;
                    hiemThiThongTinKhachHang(khachHang);
                    NhanVien_DTO nhanVien = (NhanVien_DTO)cbBMaNV.SelectedItem;
                    tenNhanVien(nhanVien);
                    lsCTHDB = cTHDB_BUS.LayDanhSachTheoMa(cbBMaHoaDon.Text);
                    foreach (ChiTietHoaDonBan_DTO ctHDB in lsCTHDB)
                    {
                        ListViewItem lvi = new ListViewItem(ctHDB.MaHH);
                        lvi.SubItems.Add(ctHDB.TenHH);
                        lvi.SubItems.Add(ctHDB.SoLuong.ToString());
                        lvi.SubItems.Add(ctHDB.DonGia.ToString());
                        lvi.SubItems.Add(ctHDB.ThanhTien.ToString());
                        lvCTHDB.Items.Add(lvi);
                    }
                    txtTongTien.Text = cTHDB_BUS.TongTienHoaDon(txtMaHD.Text);
                }
                else
                {
                    MessageBox.Show("Không Tìm Thấy !");
                }
                
            }
        }

        private void cbBMaNV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            NhanVien_DTO nhanVien = (NhanVien_DTO)cbBMaNV.SelectedItem;
            tenNhanVien(nhanVien);
        }

        private void cbBMaKH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            KhachHang_DTO khachHang = (KhachHang_DTO)cbBMaKH.SelectedItem;
            hiemThiThongTinKhachHang(khachHang);
        }
        private void themHD_Click(object sender, EventArgs e)
        {
            trangThaiBanDau();
            txtMaHD.Text = "HD";
            luuHD.Enabled = huyHD.Enabled = true;
            themHD.Enabled = false;
        }

        private void huyHD_Click(object sender, EventArgs e)
        {
            themHD.Enabled = true;
            huyHD.Enabled = luuHD.Enabled = false;
            trangThaiBanDau();
        }
        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void luuHD_Click(object sender, EventArgs e)
        {
            if (!hdb_BUS.CheckMaHDB(txtMaHD.Text))
            {
              hdB.MaHDB = txtMaHD.Text;
              hdB.MaKH = cbBMaKH.Text;
              hdB.MaNV = cbBMaNV.Text;
              hdB.NgayBan = dateNgayBan.Value;
              hdB.TongTien = double.Parse(txtTongTien.Text);
              hdb_BUS.ThemHDB(hdB);
             for (int i = 0; i < lvCTHDB.Items.Count; i++)
             {
                 int soLuong = int.Parse(lvCTHDB.Items[i].SubItems[2].Text);
                 long thanhTien = long.Parse(lvCTHDB.Items[i].SubItems[4].Text);
                 string maHH = lvCTHDB.Items[i].Text;
                 ChiTietHoaDonBan_DTO cTHDB_DTO = new ChiTietHoaDonBan_DTO();
                 cTHDB_DTO.MaHDB=txtMaHD.Text;
                 cTHDB_DTO.MaHH=maHH;
                 cTHDB_DTO.SoLuong=soLuong;
                 cTHDB_DTO.ThanhTien=thanhTien;
                 cTHDB_DTO.KhuyenMai = 0;
                 cTHDB_DTO.GiamGia = 0;
                 cTHDB_BUS.ThemCTHDB(cTHDB_DTO);
             }
            }
            if (hdb_BUS.CheckMaHDB(txtMaHD.Text))
            {
                cTHDB_BUS.XoaCTHDB(txtMaHD.Text);
                for (int i = 0; i < lvCTHDB.Items.Count; i++)
                {
                    int soLuong = int.Parse(lvCTHDB.Items[i].SubItems[2].Text);
                    long thanhTien = long.Parse(lvCTHDB.Items[i].SubItems[4].Text);
                    string maHH = lvCTHDB.Items[i].Text;
                    ChiTietHoaDonBan_DTO cTHDB_DTO = new ChiTietHoaDonBan_DTO();
                    cTHDB_DTO.MaHDB = txtMaHD.Text;
                    cTHDB_DTO.MaHH = maHH;
                    cTHDB_DTO.SoLuong = soLuong;
                    cTHDB_DTO.ThanhTien = thanhTien;
                    cTHDB_DTO.KhuyenMai = 0;
                    cTHDB_DTO.GiamGia = 0;
                    cTHDB_BUS.ThemCTHDB(cTHDB_DTO);
                }
            }
            //for (int i = 0; i < lvCTHDB.Items.Count; i++)
            //{
            //    if (cTHDB_BUS.checkCTHDB(txtMaHD.Text, lvCTHDB.Items[i].Text))
            //    {
            //        int soLuong = int.Parse(lvCTHDB.Items[i].SubItems[2].Text);
            //        long thanhTien = long.Parse(lvCTHDB.Items[i].SubItems[4].Text);
            //        string maHH = lvCTHDB.Items[i].Text;
            //        cTHDB_BUS.CapNhatCTHDB(soLuong, thanhTien, txtMaHD.Text, maHH);
            //    }
            //}
            trangThaiBanDau();
            loadDuLieu();
            luuHD.Enabled = huyHD.Enabled = false;
        }
        private void lvCTHDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCTHDB.SelectedItems.Count > 0)
            {
                ListViewItem item = lvCTHDB.SelectedItems[0];
                ChiTietHoaDonBan_DTO ctHDB = new ChiTietHoaDonBan_DTO(item.SubItems[1].Text, item.Text, int.Parse(item.SubItems[2].Text), 0, double.Parse(item.SubItems[3].Text), long.Parse(item.SubItems[4].Text));
                txtTenHang.Text = ctHDB.MaHDB;
                cbBMaHang.SelectedValue = ctHDB.MaHH;
                numberSoLuong.Value = ctHDB.SoLuong;
                txtGia.Text = ctHDB.GiamGia.ToString();
                txtThanhTien.Text = ctHDB.ThanhTien.ToString();
            }
        }

        private void lvCTHDB_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem lvItem in lvCTHDB.SelectedItems)
            {
                lvCTHDB.Items.Remove(lvItem);
            }
        }
        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (hdb_BUS.CheckMaHDB(txtMaHD.Text))
            {
                MessageBox.Show("Mã Tồn Tại !!!", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Mã Không Tồn Tại  !!!", "Thông Báo");
            }
        }
        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhatHoaDon_Click(object sender, EventArgs e)
        {
            if (lvCTHDB.SelectedItems.Count > 0)
            {
                lvCTHDB.SelectedItems[0].SubItems[0].Text = cbBMaHang.Text;
                lvCTHDB.SelectedItems[0].SubItems[1].Text = txtTenHang.Text;
                lvCTHDB.SelectedItems[0].SubItems[2].Text = numberSoLuong.Value.ToString();
                lvCTHDB.SelectedItems[0].SubItems[3].Text = txtGia.Text;
                lvCTHDB.SelectedItems[0].SubItems[4].Text = txtThanhTien.Text;
            }
        }
    }
}