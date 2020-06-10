namespace QuanLyCuaHang
{
    partial class frmDangKy
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
            this.groupControlDangKy = new DevExpress.XtraEditors.GroupControl();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.textBoxTaiKhoan = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textBoxNhapMatKhau = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDangKy)).BeginInit();
            this.groupControlDangKy.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControlDangKy
            // 
            this.groupControlDangKy.Controls.Add(this.textBoxNhapMatKhau);
            this.groupControlDangKy.Controls.Add(this.labelControl3);
            this.groupControlDangKy.Controls.Add(this.textBoxMatKhau);
            this.groupControlDangKy.Controls.Add(this.textBoxTaiKhoan);
            this.groupControlDangKy.Controls.Add(this.labelControl2);
            this.groupControlDangKy.Controls.Add(this.labelControl1);
            this.groupControlDangKy.Location = new System.Drawing.Point(22, 12);
            this.groupControlDangKy.Name = "groupControlDangKy";
            this.groupControlDangKy.Size = new System.Drawing.Size(524, 225);
            this.groupControlDangKy.TabIndex = 1;
            this.groupControlDangKy.Text = "Đăng Ký";
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.Location = new System.Drawing.Point(193, 85);
            this.textBoxMatKhau.Multiline = true;
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(283, 27);
            this.textBoxMatKhau.TabIndex = 3;
            // 
            // textBoxTaiKhoan
            // 
            this.textBoxTaiKhoan.Location = new System.Drawing.Point(193, 45);
            this.textBoxTaiKhoan.Multiline = true;
            this.textBoxTaiKhoan.Name = "textBoxTaiKhoan";
            this.textBoxTaiKhoan.Size = new System.Drawing.Size(283, 27);
            this.textBoxTaiKhoan.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Location = new System.Drawing.Point(35, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(118, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nhập Mật Khẩu :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Location = new System.Drawing.Point(35, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Tài Khoản :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Location = new System.Drawing.Point(35, 131);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(132, 19);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Nhập Lại Mật Khẩu";
            // 
            // textBoxNhapMatKhau
            // 
            this.textBoxNhapMatKhau.Location = new System.Drawing.Point(193, 131);
            this.textBoxNhapMatKhau.Multiline = true;
            this.textBoxNhapMatKhau.Name = "textBoxNhapMatKhau";
            this.textBoxNhapMatKhau.Size = new System.Drawing.Size(283, 27);
            this.textBoxNhapMatKhau.TabIndex = 7;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(278, 245);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(138, 37);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Tạo Tài Khoản";
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 294);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControlDangKy);
            this.Name = "frmDangKy";
            this.Text = "frmDangKy";
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDangKy)).EndInit();
            this.groupControlDangKy.ResumeLayout(false);
            this.groupControlDangKy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlDangKy;
        private System.Windows.Forms.TextBox textBoxNhapMatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.TextBox textBoxTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}