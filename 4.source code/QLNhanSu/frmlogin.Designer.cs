namespace QLNhanSu
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.bt_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.bt_Dangnhap = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.checkLuutaikhoanlogin = new DevExpress.XtraEditors.CheckEdit();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.lbCanhbao = new DevExpress.XtraEditors.LabelControl();
            this.image_canhbao = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkLuutaikhoanlogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_canhbao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_thoat
            // 
            this.bt_thoat.Image = ((System.Drawing.Image)(resources.GetObject("bt_thoat.Image")));
            this.bt_thoat.Location = new System.Drawing.Point(160, 192);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(90, 23);
            this.bt_thoat.TabIndex = 6;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(34, 85);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 15);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tài khoản:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(96, 82);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(125, 20);
            this.txtUser.TabIndex = 2;
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(34, 118);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 15);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Mật khẩu:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(96, 115);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.PasswordChar = '♥';
            this.txtPass.Properties.UseSystemPasswordChar = true;
            this.txtPass.Size = new System.Drawing.Size(125, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // bt_Dangnhap
            // 
            this.bt_Dangnhap.Image = ((System.Drawing.Image)(resources.GetObject("bt_Dangnhap.Image")));
            this.bt_Dangnhap.Location = new System.Drawing.Point(62, 192);
            this.bt_Dangnhap.Name = "bt_Dangnhap";
            this.bt_Dangnhap.Size = new System.Drawing.Size(90, 23);
            this.bt_Dangnhap.TabIndex = 5;
            this.bt_Dangnhap.Text = "Đăng nhập";
            this.bt_Dangnhap.Click += new System.EventHandler(this.bt_Dangnhap_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(265, 65);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(58, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Đăng nhập phần mềm";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(223, 113);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Size = new System.Drawing.Size(27, 24);
            this.pictureEdit2.TabIndex = 8;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(223, 81);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Size = new System.Drawing.Size(27, 24);
            this.pictureEdit3.TabIndex = 9;
            // 
            // checkLuutaikhoanlogin
            // 
            this.checkLuutaikhoanlogin.Location = new System.Drawing.Point(263, 170);
            this.checkLuutaikhoanlogin.Name = "checkLuutaikhoanlogin";
            this.checkLuutaikhoanlogin.Properties.Caption = "Lưu lại tài khoản";
            this.checkLuutaikhoanlogin.Size = new System.Drawing.Size(112, 19);
            this.checkLuutaikhoanlogin.TabIndex = 4;
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(349, 20);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit4.Size = new System.Drawing.Size(28, 23);
            this.pictureEdit4.TabIndex = 11;
            this.pictureEdit4.Click += new System.EventHandler(this.pictureEdit4_Click);
            // 
            // lbCanhbao
            // 
            this.lbCanhbao.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbCanhbao.Location = new System.Drawing.Point(61, 147);
            this.lbCanhbao.Name = "lbCanhbao";
            this.lbCanhbao.Size = new System.Drawing.Size(158, 13);
            this.lbCanhbao.TabIndex = 12;
            this.lbCanhbao.Text = "Thông tin đăng nhập không đúng";
            this.lbCanhbao.Visible = false;
            // 
            // image_canhbao
            // 
            this.image_canhbao.EditValue = ((object)(resources.GetObject("image_canhbao.EditValue")));
            this.image_canhbao.Location = new System.Drawing.Point(30, 141);
            this.image_canhbao.Name = "image_canhbao";
            this.image_canhbao.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.image_canhbao.Properties.Appearance.Options.UseBackColor = true;
            this.image_canhbao.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.image_canhbao.Size = new System.Drawing.Size(27, 24);
            this.image_canhbao.TabIndex = 13;
            this.image_canhbao.Visible = false;
            // 
            // frmlogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(403, 247);
            this.Controls.Add(this.image_canhbao);
            this.Controls.Add(this.lbCanhbao);
            this.Controls.Add(this.pictureEdit4);
            this.Controls.Add(this.checkLuutaikhoanlogin);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.bt_Dangnhap);
            this.Controls.Add(this.bt_thoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmlogin";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmlogin_MouseMove);
            this.Move += new System.EventHandler(this.frmlogin_Move);
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkLuutaikhoanlogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_canhbao.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bt_thoat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.SimpleButton bt_Dangnhap;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.CheckEdit checkLuutaikhoanlogin;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.LabelControl lbCanhbao;
        private DevExpress.XtraEditors.PictureEdit image_canhbao;
    }
}