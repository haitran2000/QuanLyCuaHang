namespace QuanLyCuaHang
{
    partial class frmNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.dataGridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.dateNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.textQueQuan = new DevExpress.XtraEditors.TextEdit();
            this.textSDT = new DevExpress.XtraEditors.TextEdit();
            this.textTenNV = new DevExpress.XtraEditors.TextEdit();
            this.textGT = new DevExpress.XtraEditors.TextEdit();
            this.textMaNV = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemMaNV = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemGioiTinhNV = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemTenNV = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemSDT = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemQueQuan = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemNgaySinh = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemDiaChi = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButtonThem = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonXoa = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSua = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonReset = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textQueQuan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textGT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemMaNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemGioiTinhNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTenNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemQueQuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemNgaySinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemDiaChi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNhanVien
            // 
            this.dataGridViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanVien.Location = new System.Drawing.Point(0, 144);
            this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            this.dataGridViewNhanVien.Size = new System.Drawing.Size(742, 285);
            this.dataGridViewNhanVien.TabIndex = 16;
            this.dataGridViewNhanVien.SelectionChanged += new System.EventHandler(this.dataGridViewNhanVien_SelectionChanged);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(741, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 409);
            this.barDockControlBottom.Size = new System.Drawing.Size(741, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 409);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(741, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 409);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Them";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.LargeGlyph = global::QuanLyCuaHang.Properties.Resources.user_edit_icon;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textDiaChi);
            this.layoutControl1.Controls.Add(this.dateNgaySinh);
            this.layoutControl1.Controls.Add(this.textQueQuan);
            this.layoutControl1.Controls.Add(this.textSDT);
            this.layoutControl1.Controls.Add(this.textTenNV);
            this.layoutControl1.Controls.Add(this.textGT);
            this.layoutControl1.Controls.Add(this.textMaNV);
            this.layoutControl1.Location = new System.Drawing.Point(0, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(745, 120);
            this.layoutControl1.TabIndex = 21;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textDiaChi
            // 
            this.textDiaChi.Location = new System.Drawing.Point(84, 84);
            this.textDiaChi.MenuManager = this.barManager1;
            this.textDiaChi.Name = "textDiaChi";
            this.textDiaChi.Size = new System.Drawing.Size(286, 20);
            this.textDiaChi.StyleController = this.layoutControl1;
            this.textDiaChi.TabIndex = 10;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.EditValue = null;
            this.dateNgaySinh.Location = new System.Drawing.Point(84, 60);
            this.dateNgaySinh.MenuManager = this.barManager1;
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Size = new System.Drawing.Size(286, 20);
            this.dateNgaySinh.StyleController = this.layoutControl1;
            this.dateNgaySinh.TabIndex = 9;
            // 
            // textQueQuan
            // 
            this.textQueQuan.Location = new System.Drawing.Point(446, 60);
            this.textQueQuan.MenuManager = this.barManager1;
            this.textQueQuan.Name = "textQueQuan";
            this.textQueQuan.Size = new System.Drawing.Size(287, 20);
            this.textQueQuan.StyleController = this.layoutControl1;
            this.textQueQuan.TabIndex = 8;
            // 
            // textSDT
            // 
            this.textSDT.Location = new System.Drawing.Point(446, 36);
            this.textSDT.MenuManager = this.barManager1;
            this.textSDT.Name = "textSDT";
            this.textSDT.Size = new System.Drawing.Size(287, 20);
            this.textSDT.StyleController = this.layoutControl1;
            this.textSDT.TabIndex = 7;
            // 
            // textTenNV
            // 
            this.textTenNV.Location = new System.Drawing.Point(84, 36);
            this.textTenNV.MenuManager = this.barManager1;
            this.textTenNV.Name = "textTenNV";
            this.textTenNV.Size = new System.Drawing.Size(286, 20);
            this.textTenNV.StyleController = this.layoutControl1;
            this.textTenNV.TabIndex = 6;
            // 
            // textGT
            // 
            this.textGT.Location = new System.Drawing.Point(446, 12);
            this.textGT.MenuManager = this.barManager1;
            this.textGT.Name = "textGT";
            this.textGT.Size = new System.Drawing.Size(287, 20);
            this.textGT.StyleController = this.layoutControl1;
            this.textGT.TabIndex = 5;
            // 
            // textMaNV
            // 
            this.textMaNV.Location = new System.Drawing.Point(84, 12);
            this.textMaNV.MenuManager = this.barManager1;
            this.textMaNV.Name = "textMaNV";
            this.textMaNV.Size = new System.Drawing.Size(286, 20);
            this.textMaNV.StyleController = this.layoutControl1;
            this.textMaNV.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemMaNV,
            this.layoutControlItemGioiTinhNV,
            this.layoutControlItemTenNV,
            this.layoutControlItemSDT,
            this.layoutControlItemQueQuan,
            this.layoutControlItemNgaySinh,
            this.layoutControlItemDiaChi});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(745, 120);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItemMaNV
            // 
            this.layoutControlItemMaNV.Control = this.textMaNV;
            this.layoutControlItemMaNV.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemMaNV.Name = "layoutControlItemMaNV";
            this.layoutControlItemMaNV.Size = new System.Drawing.Size(362, 24);
            this.layoutControlItemMaNV.Text = "Mã Nhân Viên";
            this.layoutControlItemMaNV.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItemGioiTinhNV
            // 
            this.layoutControlItemGioiTinhNV.Control = this.textGT;
            this.layoutControlItemGioiTinhNV.Location = new System.Drawing.Point(362, 0);
            this.layoutControlItemGioiTinhNV.Name = "layoutControlItemGioiTinhNV";
            this.layoutControlItemGioiTinhNV.Size = new System.Drawing.Size(363, 24);
            this.layoutControlItemGioiTinhNV.Text = "Giới Tính";
            this.layoutControlItemGioiTinhNV.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItemTenNV
            // 
            this.layoutControlItemTenNV.Control = this.textTenNV;
            this.layoutControlItemTenNV.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemTenNV.Name = "layoutControlItemTenNV";
            this.layoutControlItemTenNV.Size = new System.Drawing.Size(362, 24);
            this.layoutControlItemTenNV.Text = "Tên Nhân Viên";
            this.layoutControlItemTenNV.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItemSDT
            // 
            this.layoutControlItemSDT.Control = this.textSDT;
            this.layoutControlItemSDT.Location = new System.Drawing.Point(362, 24);
            this.layoutControlItemSDT.Name = "layoutControlItemSDT";
            this.layoutControlItemSDT.Size = new System.Drawing.Size(363, 24);
            this.layoutControlItemSDT.Text = "Số Điện Thoại";
            this.layoutControlItemSDT.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItemQueQuan
            // 
            this.layoutControlItemQueQuan.Control = this.textQueQuan;
            this.layoutControlItemQueQuan.Location = new System.Drawing.Point(362, 48);
            this.layoutControlItemQueQuan.Name = "layoutControlItemQueQuan";
            this.layoutControlItemQueQuan.Size = new System.Drawing.Size(363, 52);
            this.layoutControlItemQueQuan.Text = "Quê Quán";
            this.layoutControlItemQueQuan.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItemNgaySinh
            // 
            this.layoutControlItemNgaySinh.Control = this.dateNgaySinh;
            this.layoutControlItemNgaySinh.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItemNgaySinh.Name = "layoutControlItemNgaySinh";
            this.layoutControlItemNgaySinh.Size = new System.Drawing.Size(362, 24);
            this.layoutControlItemNgaySinh.Text = "Ngày Sinh";
            this.layoutControlItemNgaySinh.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItemDiaChi
            // 
            this.layoutControlItemDiaChi.Control = this.textDiaChi;
            this.layoutControlItemDiaChi.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItemDiaChi.Name = "layoutControlItemDiaChi";
            this.layoutControlItemDiaChi.Size = new System.Drawing.Size(362, 28);
            this.layoutControlItemDiaChi.Text = "Địa Chỉ";
            this.layoutControlItemDiaChi.TextSize = new System.Drawing.Size(69, 13);
            // 
            // simpleButtonThem
            // 
            this.simpleButtonThem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.simpleButtonThem.Appearance.Options.UseFont = true;
            this.simpleButtonThem.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonThem.Image")));
            this.simpleButtonThem.Location = new System.Drawing.Point(64, 112);
            this.simpleButtonThem.Name = "simpleButtonThem";
            this.simpleButtonThem.Size = new System.Drawing.Size(101, 26);
            this.simpleButtonThem.TabIndex = 30;
            this.simpleButtonThem.Text = "Thêm";
            // 
            // simpleButtonXoa
            // 
            this.simpleButtonXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.simpleButtonXoa.Appearance.Options.UseFont = true;
            this.simpleButtonXoa.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonXoa.Image")));
            this.simpleButtonXoa.Location = new System.Drawing.Point(215, 112);
            this.simpleButtonXoa.Name = "simpleButtonXoa";
            this.simpleButtonXoa.Size = new System.Drawing.Size(101, 26);
            this.simpleButtonXoa.TabIndex = 31;
            this.simpleButtonXoa.Text = "Xoá";
            this.simpleButtonXoa.Click += new System.EventHandler(this.simpleButtonXoa_Click);
            // 
            // simpleButtonSua
            // 
            this.simpleButtonSua.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.simpleButtonSua.Appearance.Options.UseFont = true;
            this.simpleButtonSua.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSua.Image")));
            this.simpleButtonSua.Location = new System.Drawing.Point(382, 112);
            this.simpleButtonSua.Name = "simpleButtonSua";
            this.simpleButtonSua.Size = new System.Drawing.Size(101, 26);
            this.simpleButtonSua.TabIndex = 32;
            this.simpleButtonSua.Text = "Sửa";
            this.simpleButtonSua.Click += new System.EventHandler(this.simpleButtonSua_Click);
            // 
            // simpleButtonReset
            // 
            this.simpleButtonReset.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.simpleButtonReset.Appearance.Options.UseFont = true;
            this.simpleButtonReset.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonReset.Image")));
            this.simpleButtonReset.Location = new System.Drawing.Point(562, 112);
            this.simpleButtonReset.Name = "simpleButtonReset";
            this.simpleButtonReset.Size = new System.Drawing.Size(101, 26);
            this.simpleButtonReset.TabIndex = 33;
            this.simpleButtonReset.Text = "Reset";
            this.simpleButtonReset.Click += new System.EventHandler(this.simpleButtonReset_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(741, 432);
            this.Controls.Add(this.simpleButtonReset);
            this.Controls.Add(this.simpleButtonSua);
            this.Controls.Add(this.simpleButtonXoa);
            this.Controls.Add(this.simpleButtonThem);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.dataGridViewNhanVien);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanViencs";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textQueQuan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textGT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemMaNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemGioiTinhNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTenNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemQueQuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemNgaySinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemDiaChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNhanVien;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit textSDT;
        private DevExpress.XtraEditors.TextEdit textTenNV;
        private DevExpress.XtraEditors.TextEdit textGT;
        private DevExpress.XtraEditors.TextEdit textMaNV;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemMaNV;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemGioiTinhNV;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemTenNV;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemSDT;
        private DevExpress.XtraEditors.TextEdit textDiaChi;
        private DevExpress.XtraEditors.DateEdit dateNgaySinh;
        private DevExpress.XtraEditors.TextEdit textQueQuan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemQueQuan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemNgaySinh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemDiaChi;
        private DevExpress.XtraEditors.SimpleButton simpleButtonReset;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSua;
        private DevExpress.XtraEditors.SimpleButton simpleButtonXoa;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThem;










    }
}