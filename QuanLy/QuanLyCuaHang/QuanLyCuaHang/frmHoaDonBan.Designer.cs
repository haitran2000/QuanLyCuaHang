﻿namespace QuanLyCuaHang
{
    partial class frmHoaDonBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDonBan));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnXemChiTietHDB = new System.Windows.Forms.Button();
            this.dataGridViewHoaDonBan = new System.Windows.Forms.DataGridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnCapNhatXong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemXong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textTongTien = new System.Windows.Forms.TextBox();
            this.textMaKH = new DevExpress.XtraEditors.TextEdit();
            this.textHDB = new DevExpress.XtraEditors.TextEdit();
            this.dateNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.textMaNVLap = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemTenNV = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemNgaySinh = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemGioiTinhNV = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDonBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textHDB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaNVLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTenNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemNgaySinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemGioiTinhNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnXemChiTietHDB);
            this.groupControl1.Controls.Add(this.dataGridViewHoaDonBan);
            this.groupControl1.Location = new System.Drawing.Point(12, 180);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1310, 389);
            this.groupControl1.TabIndex = 35;
            this.groupControl1.Text = "Danh Sách Hoá Đơn Bán Hàng";
            // 
            // btnXemChiTietHDB
            // 
            this.btnXemChiTietHDB.BackColor = System.Drawing.Color.Lime;
            this.btnXemChiTietHDB.Location = new System.Drawing.Point(1224, 36);
            this.btnXemChiTietHDB.Name = "btnXemChiTietHDB";
            this.btnXemChiTietHDB.Size = new System.Drawing.Size(75, 344);
            this.btnXemChiTietHDB.TabIndex = 18;
            this.btnXemChiTietHDB.Text = "Xem Chi Tiết Hoá Đơn Đang Chọn";
            this.btnXemChiTietHDB.UseVisualStyleBackColor = false;
            this.btnXemChiTietHDB.Click += new System.EventHandler(this.btnXemChiTietHDB_Click);
            // 
            // dataGridViewHoaDonBan
            // 
            this.dataGridViewHoaDonBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoaDonBan.Location = new System.Drawing.Point(11, 36);
            this.dataGridViewHoaDonBan.Name = "dataGridViewHoaDonBan";
            this.dataGridViewHoaDonBan.ReadOnly = true;
            this.dataGridViewHoaDonBan.Size = new System.Drawing.Size(1199, 348);
            this.dataGridViewHoaDonBan.TabIndex = 16;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnCapNhatXong);
            this.groupControl2.Controls.Add(this.btnThemXong);
            this.groupControl2.Controls.Add(this.btnThem);
            this.groupControl2.Controls.Add(this.btnHuy);
            this.groupControl2.Controls.Add(this.layoutControl1);
            this.groupControl2.Controls.Add(this.imageSlider1);
            this.groupControl2.Controls.Add(this.btnSua);
            this.groupControl2.Controls.Add(this.btnXoa);
            this.groupControl2.Location = new System.Drawing.Point(14, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1308, 171);
            this.groupControl2.TabIndex = 36;
            this.groupControl2.Text = "Thông Tin Hoá Đơn Bán";
            // 
            // btnCapNhatXong
            // 
            this.btnCapNhatXong.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnCapNhatXong.Appearance.Options.UseFont = true;
            this.btnCapNhatXong.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatXong.Image")));
            this.btnCapNhatXong.Location = new System.Drawing.Point(1168, 81);
            this.btnCapNhatXong.Name = "btnCapNhatXong";
            this.btnCapNhatXong.Size = new System.Drawing.Size(135, 34);
            this.btnCapNhatXong.TabIndex = 38;
            this.btnCapNhatXong.Text = "Cập Nhật Xong";
            // 
            // btnThemXong
            // 
            this.btnThemXong.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnThemXong.Appearance.Options.UseFont = true;
            this.btnThemXong.Image = ((System.Drawing.Image)(resources.GetObject("btnThemXong.Image")));
            this.btnThemXong.Location = new System.Drawing.Point(1168, 27);
            this.btnThemXong.Name = "btnThemXong";
            this.btnThemXong.Size = new System.Drawing.Size(135, 34);
            this.btnThemXong.TabIndex = 37;
            this.btnThemXong.Text = "Thêm Xong";
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(1015, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(147, 34);
            this.btnThem.TabIndex = 36;
            this.btnThem.Text = "Thêm";
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(1168, 127);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(135, 36);
            this.btnHuy.TabIndex = 35;
            this.btnHuy.Text = "Huỷ";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textTongTien);
            this.layoutControl1.Controls.Add(this.textMaKH);
            this.layoutControl1.Controls.Add(this.textHDB);
            this.layoutControl1.Controls.Add(this.dateNgayLap);
            this.layoutControl1.Controls.Add(this.textMaNVLap);
            this.layoutControl1.Location = new System.Drawing.Point(187, 23);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(822, 140);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textTongTien
            // 
            this.textTongTien.Location = new System.Drawing.Point(100, 108);
            this.textTongTien.Name = "textTongTien";
            this.textTongTien.Size = new System.Drawing.Size(710, 20);
            this.textTongTien.TabIndex = 12;
            // 
            // textMaKH
            // 
            this.textMaKH.Location = new System.Drawing.Point(100, 84);
            this.textMaKH.Name = "textMaKH";
            this.textMaKH.Size = new System.Drawing.Size(710, 20);
            this.textMaKH.StyleController = this.layoutControl1;
            this.textMaKH.TabIndex = 5;
            // 
            // textHDB
            // 
            this.textHDB.Location = new System.Drawing.Point(100, 12);
            this.textHDB.Name = "textHDB";
            this.textHDB.Size = new System.Drawing.Size(710, 20);
            this.textHDB.StyleController = this.layoutControl1;
            this.textHDB.TabIndex = 6;
            // 
            // dateNgayLap
            // 
            this.dateNgayLap.EditValue = null;
            this.dateNgayLap.Location = new System.Drawing.Point(100, 60);
            this.dateNgayLap.Name = "dateNgayLap";
            this.dateNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayLap.Size = new System.Drawing.Size(710, 20);
            this.dateNgayLap.StyleController = this.layoutControl1;
            this.dateNgayLap.TabIndex = 9;
            // 
            // textMaNVLap
            // 
            this.textMaNVLap.Location = new System.Drawing.Point(100, 36);
            this.textMaNVLap.Name = "textMaNVLap";
            this.textMaNVLap.Size = new System.Drawing.Size(710, 20);
            this.textMaNVLap.StyleController = this.layoutControl1;
            this.textMaNVLap.TabIndex = 11;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemTenNV,
            this.layoutControlItemNgaySinh,
            this.layoutControlItem1,
            this.layoutControlItemGioiTinhNV,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(822, 140);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItemTenNV
            // 
            this.layoutControlItemTenNV.Control = this.textHDB;
            this.layoutControlItemTenNV.CustomizationFormText = "Tên Nhân Viên";
            this.layoutControlItemTenNV.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemTenNV.Name = "layoutControlItemTenNV";
            this.layoutControlItemTenNV.Size = new System.Drawing.Size(802, 24);
            this.layoutControlItemTenNV.Text = "Mã Hoá Đơn Bán";
            this.layoutControlItemTenNV.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutControlItemNgaySinh
            // 
            this.layoutControlItemNgaySinh.Control = this.dateNgayLap;
            this.layoutControlItemNgaySinh.CustomizationFormText = "Ngày Sinh";
            this.layoutControlItemNgaySinh.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItemNgaySinh.Name = "layoutControlItemNgaySinh";
            this.layoutControlItemNgaySinh.Size = new System.Drawing.Size(802, 24);
            this.layoutControlItemNgaySinh.Text = "Ngày Lập";
            this.layoutControlItemNgaySinh.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textMaNVLap;
            this.layoutControlItem1.CustomizationFormText = "Tên Nhân Viên";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(802, 24);
            this.layoutControlItem1.Text = "Mã Nhân Viên Lập";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutControlItemGioiTinhNV
            // 
            this.layoutControlItemGioiTinhNV.Control = this.textMaKH;
            this.layoutControlItemGioiTinhNV.CustomizationFormText = "Giới Tính";
            this.layoutControlItemGioiTinhNV.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItemGioiTinhNV.Name = "layoutControlItemGioiTinhNV";
            this.layoutControlItemGioiTinhNV.Size = new System.Drawing.Size(802, 24);
            this.layoutControlItemGioiTinhNV.Text = "Mã Khách Hàng";
            this.layoutControlItemGioiTinhNV.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textTongTien;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(802, 24);
            this.layoutControlItem2.Text = "Tổng Tiền";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(85, 13);
            // 
            // imageSlider1
            // 
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch;
            this.imageSlider1.Location = new System.Drawing.Point(11, 23);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(154, 140);
            this.imageSlider1.TabIndex = 1;
            this.imageSlider1.Text = "imageSlider1";
            this.imageSlider1.UseDisabledStatePainter = true;
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(1015, 79);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(147, 36);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "Cập Nhật";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(1015, 127);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(147, 36);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xoá";
            // 
            // frmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 581);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmHoaDonBan";
            this.Text = "HoaDonBan";
            this.Load += new System.EventHandler(this.frmHoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDonBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textHDB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaNVLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTenNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemNgaySinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemGioiTinhNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dataGridViewHoaDonBan;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatXong;
        private DevExpress.XtraEditors.SimpleButton btnThemXong;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.TextBox textTongTien;
        private DevExpress.XtraEditors.TextEdit textMaKH;
        private DevExpress.XtraEditors.TextEdit textHDB;
        private DevExpress.XtraEditors.DateEdit dateNgayLap;
        private DevExpress.XtraEditors.TextEdit textMaNVLap;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemTenNV;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemNgaySinh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemGioiTinhNV;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.Button btnXemChiTietHDB;
    }
}