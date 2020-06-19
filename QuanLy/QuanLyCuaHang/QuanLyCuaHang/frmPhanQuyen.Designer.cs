namespace QuanLyCuaHang
{
    partial class frmPhanQuyen
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
            this.dataGridViewPhanQuyen = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.comboBoxMaQuyen = new System.Windows.Forms.ComboBox();
            this.textTK = new DevExpress.XtraEditors.TextEdit();
            this.textGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPhanQuyen
            // 
            this.dataGridViewPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhanQuyen.Location = new System.Drawing.Point(15, 33);
            this.dataGridViewPhanQuyen.Name = "dataGridViewPhanQuyen";
            this.dataGridViewPhanQuyen.Size = new System.Drawing.Size(1277, 389);
            this.dataGridViewPhanQuyen.TabIndex = 1;
            this.dataGridViewPhanQuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhanQuyen_CellClick);
            this.dataGridViewPhanQuyen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhanQuyen_CellContentClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dataGridViewPhanQuyen);
            this.groupControl1.Location = new System.Drawing.Point(12, 142);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1308, 427);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Quyền Tài Khoản";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.comboBoxMaQuyen);
            this.layoutControl1.Controls.Add(this.textTK);
            this.layoutControl1.Controls.Add(this.textGhiChu);
            this.layoutControl1.Location = new System.Drawing.Point(12, 10);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(651, 126);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // comboBoxMaQuyen
            // 
            this.comboBoxMaQuyen.FormattingEnabled = true;
            this.comboBoxMaQuyen.Location = new System.Drawing.Point(83, 36);
            this.comboBoxMaQuyen.Name = "comboBoxMaQuyen";
            this.comboBoxMaQuyen.Size = new System.Drawing.Size(556, 21);
            this.comboBoxMaQuyen.TabIndex = 7;
            // 
            // textTK
            // 
            this.textTK.Location = new System.Drawing.Point(83, 12);
            this.textTK.Name = "textTK";
            this.textTK.Size = new System.Drawing.Size(556, 20);
            this.textTK.StyleController = this.layoutControl1;
            this.textTK.TabIndex = 4;
            // 
            // textGhiChu
            // 
            this.textGhiChu.EditValue = "";
            this.textGhiChu.Location = new System.Drawing.Point(83, 61);
            this.textGhiChu.Name = "textGhiChu";
            this.textGhiChu.Size = new System.Drawing.Size(556, 20);
            this.textGhiChu.StyleController = this.layoutControl1;
            this.textGhiChu.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(651, 126);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textTK;
            this.layoutControlItem1.CustomizationFormText = "Tên Tài Khoản";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(631, 24);
            this.layoutControlItem1.Text = "Tên Tài Khoản";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.comboBoxMaQuyen;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(631, 25);
            this.layoutControlItem2.Text = "Mã Quyền";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textGhiChu;
            this.layoutControlItem3.CustomizationFormText = "Ghi Chú";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 49);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(631, 57);
            this.layoutControlItem3.Text = "Ghi Chú";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(68, 13);
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 581);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmPhanQuyen";
            this.Text = "frmPhanQuyen";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPhanQuyen;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit textTK;
        private DevExpress.XtraEditors.TextEdit textGhiChu;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.ComboBox comboBoxMaQuyen;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}