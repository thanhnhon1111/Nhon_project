namespace QLNhanSu
{
    partial class frmRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestore));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bt_dong = new DevExpress.XtraEditors.SimpleButton();
            this.bt_thucthi = new DevExpress.XtraEditors.SimpleButton();
            this.bt_browse = new DevExpress.XtraEditors.SimpleButton();
            this.txt_foldername = new DevExpress.XtraEditors.TextEdit();
            this.lb_loi = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_foldername.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl3.Location = new System.Drawing.Point(33, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 13);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Chọn đường dẫn:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Location = new System.Drawing.Point(172, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(203, 26);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "PHỤC HỒI DỮ LIỆU";
            // 
            // bt_dong
            // 
            this.bt_dong.Appearance.ForeColor = System.Drawing.Color.Red;
            this.bt_dong.Appearance.Options.UseForeColor = true;
            this.bt_dong.Image = ((System.Drawing.Image)(resources.GetObject("bt_dong.Image")));
            this.bt_dong.Location = new System.Drawing.Point(262, 92);
            this.bt_dong.Name = "bt_dong";
            this.bt_dong.Size = new System.Drawing.Size(111, 23);
            this.bt_dong.TabIndex = 10;
            this.bt_dong.Text = "Đóng";
            this.bt_dong.Click += new System.EventHandler(this.bt_dong_Click);
            // 
            // bt_thucthi
            // 
            this.bt_thucthi.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_thucthi.Appearance.Options.UseForeColor = true;
            this.bt_thucthi.Image = ((System.Drawing.Image)(resources.GetObject("bt_thucthi.Image")));
            this.bt_thucthi.Location = new System.Drawing.Point(122, 92);
            this.bt_thucthi.Name = "bt_thucthi";
            this.bt_thucthi.Size = new System.Drawing.Size(119, 23);
            this.bt_thucthi.TabIndex = 9;
            this.bt_thucthi.Text = "Thực thi";
            this.bt_thucthi.Click += new System.EventHandler(this.bt_thucthi_Click);
            // 
            // bt_browse
            // 
            this.bt_browse.Appearance.ForeColor = System.Drawing.Color.Green;
            this.bt_browse.Appearance.Options.UseForeColor = true;
            this.bt_browse.Image = ((System.Drawing.Image)(resources.GetObject("bt_browse.Image")));
            this.bt_browse.Location = new System.Drawing.Point(378, 62);
            this.bt_browse.Name = "bt_browse";
            this.bt_browse.Size = new System.Drawing.Size(123, 23);
            this.bt_browse.TabIndex = 8;
            this.bt_browse.Text = "Browse";
            this.bt_browse.Click += new System.EventHandler(this.bt_browse_Click);
            // 
            // txt_foldername
            // 
            this.txt_foldername.Enabled = false;
            this.txt_foldername.Location = new System.Drawing.Point(122, 65);
            this.txt_foldername.Name = "txt_foldername";
            this.txt_foldername.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_foldername.Properties.Appearance.Options.UseForeColor = true;
            this.txt_foldername.Size = new System.Drawing.Size(251, 20);
            this.txt_foldername.TabIndex = 11;
            // 
            // lb_loi
            // 
            this.lb_loi.Appearance.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loi.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lb_loi.Location = new System.Drawing.Point(33, 43);
            this.lb_loi.Name = "lb_loi";
            this.lb_loi.Size = new System.Drawing.Size(0, 13);
            this.lb_loi.TabIndex = 16;
            // 
            // frmRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 128);
            this.Controls.Add(this.lb_loi);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.bt_dong);
            this.Controls.Add(this.bt_thucthi);
            this.Controls.Add(this.bt_browse);
            this.Controls.Add(this.txt_foldername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phục hồi dữ liệu";
            ((System.ComponentModel.ISupportInitialize)(this.txt_foldername.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton bt_dong;
        private DevExpress.XtraEditors.SimpleButton bt_thucthi;
        private DevExpress.XtraEditors.SimpleButton bt_browse;
        private DevExpress.XtraEditors.TextEdit txt_foldername;
        private DevExpress.XtraEditors.LabelControl lb_loi;
    }
}