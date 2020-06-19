namespace QuanLyCuaHang
{
    partial class frmHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangHoa));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridViewHangHoa = new System.Windows.Forms.DataGridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnCapNhatXong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemXong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.numericSoLuong = new System.Windows.Forms.NumericUpDown();
            this.textTenHH = new DevExpress.XtraEditors.TextEdit();
            this.textMaHH = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.comboBoxMaLoaiHang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.comboBoxMaNCC = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textBoxGiaBan = new System.Windows.Forms.TextBox();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textBoxGiaNhap = new System.Windows.Forms.TextBox();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTenHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaHH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxMaLoaiHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxMaNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dataGridViewHangHoa);
            this.groupControl1.Location = new System.Drawing.Point(12, 171);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1308, 398);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh Sách Hàng Hoá";
            // 
            // dataGridViewHangHoa
            // 
            this.dataGridViewHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHangHoa.Location = new System.Drawing.Point(16, 23);
            this.dataGridViewHangHoa.Name = "dataGridViewHangHoa";
            this.dataGridViewHangHoa.Size = new System.Drawing.Size(1277, 370);
            this.dataGridViewHangHoa.TabIndex = 0;
            this.dataGridViewHangHoa.SelectionChanged += new System.EventHandler(this.dataGridViewHangHoa_SelectionChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnCapNhatXong);
            this.groupControl2.Controls.Add(this.btnThemXong);
            this.groupControl2.Controls.Add(this.btnThem);
            this.groupControl2.Controls.Add(this.btnHuy);
            this.groupControl2.Controls.Add(this.btnSua);
            this.groupControl2.Controls.Add(this.btnXoa);
            this.groupControl2.Controls.Add(this.imageSlider1);
            this.groupControl2.Controls.Add(this.layoutControl1);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1308, 153);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Chi Tiết Hàng Hoá";
            // 
            // btnCapNhatXong
            // 
            this.btnCapNhatXong.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnCapNhatXong.Appearance.Options.UseFont = true;
            this.btnCapNhatXong.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatXong.Image")));
            this.btnCapNhatXong.Location = new System.Drawing.Point(1177, 62);
            this.btnCapNhatXong.Name = "btnCapNhatXong";
            this.btnCapNhatXong.Size = new System.Drawing.Size(126, 34);
            this.btnCapNhatXong.TabIndex = 44;
            this.btnCapNhatXong.Text = "Cập Nhật Xong";
            // 
            // btnThemXong
            // 
            this.btnThemXong.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnThemXong.Appearance.Options.UseFont = true;
            this.btnThemXong.Image = ((System.Drawing.Image)(resources.GetObject("btnThemXong.Image")));
            this.btnThemXong.Location = new System.Drawing.Point(1182, 21);
            this.btnThemXong.Name = "btnThemXong";
            this.btnThemXong.Size = new System.Drawing.Size(121, 34);
            this.btnThemXong.TabIndex = 43;
            this.btnThemXong.Text = "Thêm Xong";
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(1076, 22);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 34);
            this.btnThem.TabIndex = 42;
            this.btnThem.Text = "Thêm";
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(1177, 107);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(126, 36);
            this.btnHuy.TabIndex = 41;
            this.btnHuy.Text = "Huỷ";
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(1076, 61);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 36);
            this.btnSua.TabIndex = 40;
            this.btnSua.Text = "Cập Nhật";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(1076, 107);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 36);
            this.btnXoa.TabIndex = 39;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // imageSlider1
            // 
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch;
            this.imageSlider1.Location = new System.Drawing.Point(16, 34);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(141, 109);
            this.imageSlider1.TabIndex = 1;
            this.imageSlider1.Text = "imageSlider1";
            this.imageSlider1.UseDisabledStatePainter = true;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textBoxGiaNhap);
            this.layoutControl1.Controls.Add(this.textBoxGiaBan);
            this.layoutControl1.Controls.Add(this.comboBoxMaLoaiHang);
            this.layoutControl1.Controls.Add(this.comboBoxMaNCC);
            this.layoutControl1.Controls.Add(this.numericSoLuong);
            this.layoutControl1.Controls.Add(this.textTenHH);
            this.layoutControl1.Controls.Add(this.textMaHH);
            this.layoutControl1.Location = new System.Drawing.Point(163, 23);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(392, 210, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(907, 120);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // numericSoLuong
            // 
            this.numericSoLuong.Location = new System.Drawing.Point(553, 12);
            this.numericSoLuong.Name = "numericSoLuong";
            this.numericSoLuong.Size = new System.Drawing.Size(342, 21);
            this.numericSoLuong.TabIndex = 6;
            // 
            // textTenHH
            // 
            this.textTenHH.Location = new System.Drawing.Point(110, 36);
            this.textTenHH.Name = "textTenHH";
            this.textTenHH.Size = new System.Drawing.Size(785, 20);
            this.textTenHH.StyleController = this.layoutControl1;
            this.textTenHH.TabIndex = 5;
            // 
            // textMaHH
            // 
            this.textMaHH.Location = new System.Drawing.Point(110, 12);
            this.textMaHH.Name = "textMaHH";
            this.textMaHH.Size = new System.Drawing.Size(341, 20);
            this.textMaHH.StyleController = this.layoutControl1;
            this.textMaHH.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem7,
            this.layoutControlItem6,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(907, 120);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textMaHH;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(443, 24);
            this.layoutControlItem1.Text = "Mã Hàng Hoá";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textTenHH;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(887, 24);
            this.layoutControlItem2.Text = "Tên Hành Hoá";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.numericSoLuong;
            this.layoutControlItem3.Location = new System.Drawing.Point(443, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(444, 24);
            this.layoutControlItem3.Text = "Số Lượng Hàng Hoá";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.comboBoxMaLoaiHang;
            this.layoutControlItem6.Location = new System.Drawing.Point(443, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(444, 24);
            this.layoutControlItem6.Text = "Mã Loại Hàng";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(95, 13);
            // 
            // comboBoxMaLoaiHang
            // 
            this.comboBoxMaLoaiHang.Location = new System.Drawing.Point(553, 60);
            this.comboBoxMaLoaiHang.Name = "comboBoxMaLoaiHang";
            this.comboBoxMaLoaiHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxMaLoaiHang.Size = new System.Drawing.Size(342, 20);
            this.comboBoxMaLoaiHang.StyleController = this.layoutControl1;
            this.comboBoxMaLoaiHang.TabIndex = 11;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.comboBoxMaNCC;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(443, 24);
            this.layoutControlItem7.Text = "Mã Nhà Cung Cấp";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(95, 13);
            // 
            // comboBoxMaNCC
            // 
            this.comboBoxMaNCC.Location = new System.Drawing.Point(110, 60);
            this.comboBoxMaNCC.Name = "comboBoxMaNCC";
            this.comboBoxMaNCC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxMaNCC.Size = new System.Drawing.Size(341, 20);
            this.comboBoxMaNCC.StyleController = this.layoutControl1;
            this.comboBoxMaNCC.TabIndex = 10;
            // 
            // textBoxGiaBan
            // 
            this.textBoxGiaBan.Location = new System.Drawing.Point(110, 84);
            this.textBoxGiaBan.Name = "textBoxGiaBan";
            this.textBoxGiaBan.Size = new System.Drawing.Size(341, 20);
            this.textBoxGiaBan.TabIndex = 12;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textBoxGiaBan;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(443, 28);
            this.layoutControlItem4.Text = "Giá Bán";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(95, 13);
            // 
            // textBoxGiaNhap
            // 
            this.textBoxGiaNhap.Location = new System.Drawing.Point(553, 84);
            this.textBoxGiaNhap.Name = "textBoxGiaNhap";
            this.textBoxGiaNhap.Size = new System.Drawing.Size(342, 20);
            this.textBoxGiaNhap.TabIndex = 13;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.textBoxGiaNhap;
            this.layoutControlItem5.Location = new System.Drawing.Point(443, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(444, 28);
            this.layoutControlItem5.Text = "Giá Nhập";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(95, 13);
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 581);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmHangHoa";
            this.Text = "frmHangHoa";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTenHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaHH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxMaLoaiHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxMaNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dataGridViewHangHoa;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.NumericUpDown numericSoLuong;
        private DevExpress.XtraEditors.TextEdit textTenHH;
        private DevExpress.XtraEditors.TextEdit textMaHH;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatXong;
        private DevExpress.XtraEditors.SimpleButton btnThemXong;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.TextBox textBoxGiaNhap;
        private System.Windows.Forms.TextBox textBoxGiaBan;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxMaLoaiHang;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxMaNCC;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}