namespace QuanLyCuaHang
{
    partial class frmDangNhap
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
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnDangNhap.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.Appearance.Options.UseForeColor = true;
            this.btnDangNhap.BackgroundImage = global::QuanLyCuaHang.Properties.Resources.user_edit_icon;
            this.btnDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDangNhap.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDangNhap.Location = new System.Drawing.Point(407, 202);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(246, 53);
            this.btnDangNhap.TabIndex = 8;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(343, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chưa Có tài Khoản ?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.linkLabel1.ForeColor = System.Drawing.Color.Cyan;
            this.linkLabel1.Location = new System.Drawing.Point(613, 154);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(98, 19);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đăng Ký Mới";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(306, 92);
            this.txtMK.Multiline = true;
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(446, 27);
            this.txtMK.TabIndex = 3;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(306, 34);
            this.txtTK.Multiline = true;
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(446, 27);
            this.txtTK.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl2.Location = new System.Drawing.Point(136, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 22);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mật Khẩu :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl1.Location = new System.Drawing.Point(132, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tài Khoản :";
            // 
            // frmDangNhap
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(961, 326);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtTK);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTK;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
    }
}