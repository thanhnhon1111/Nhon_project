namespace QLNhanSu
{
    partial class frmBaocaoNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaocaoNV));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bt_xem = new DevExpress.XtraEditors.SimpleButton();
            this.bt_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBophan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbChucvu = new System.Windows.Forms.ComboBox();
            this.hopdong_radio = new DevExpress.XtraEditors.RadioGroup();
            this.label3 = new System.Windows.Forms.Label();
            this.baohiem_radio = new DevExpress.XtraEditors.RadioGroup();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.hopdong_radio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baohiem_radio.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelControl1.Location = new System.Drawing.Point(112, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(219, 26);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "BÁO CÁO NHÂN VIÊN";
            // 
            // bt_xem
            // 
            this.bt_xem.Image = ((System.Drawing.Image)(resources.GetObject("bt_xem.Image")));
            this.bt_xem.Location = new System.Drawing.Point(132, 208);
            this.bt_xem.Name = "bt_xem";
            this.bt_xem.Size = new System.Drawing.Size(89, 23);
            this.bt_xem.TabIndex = 5;
            this.bt_xem.Text = "Xem";
            this.bt_xem.Click += new System.EventHandler(this.bt_xem_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Image = ((System.Drawing.Image)(resources.GetObject("bt_thoat.Image")));
            this.bt_thoat.Location = new System.Drawing.Point(228, 208);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(89, 23);
            this.bt_thoat.TabIndex = 6;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bộ phận:";
            // 
            // cmbBophan
            // 
            this.cmbBophan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBophan.FormattingEnabled = true;
            this.cmbBophan.Location = new System.Drawing.Point(96, 20);
            this.cmbBophan.Name = "cmbBophan";
            this.cmbBophan.Size = new System.Drawing.Size(241, 21);
            this.cmbBophan.TabIndex = 0;
            this.cmbBophan.SelectedValueChanged += new System.EventHandler(this.cmbBophan_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chức vụ:";
            // 
            // cmbChucvu
            // 
            this.cmbChucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChucvu.FormattingEnabled = true;
            this.cmbChucvu.Location = new System.Drawing.Point(96, 51);
            this.cmbChucvu.Name = "cmbChucvu";
            this.cmbChucvu.Size = new System.Drawing.Size(241, 21);
            this.cmbChucvu.TabIndex = 1;
            // 
            // hopdong_radio
            // 
            this.hopdong_radio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hopdong_radio.Location = new System.Drawing.Point(96, 83);
            this.hopdong_radio.Name = "hopdong_radio";
            this.hopdong_radio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.hopdong_radio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Đã có"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Chưa có"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tất cả")});
            this.hopdong_radio.Properties.LookAndFeel.SkinName = "Liquid Sky";
            this.hopdong_radio.Size = new System.Drawing.Size(241, 27);
            this.hopdong_radio.TabIndex = 2;
            this.hopdong_radio.SelectedIndexChanged += new System.EventHandler(this.hopdong_radio_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hợp đồng:";
            // 
            // baohiem_radio
            // 
            this.baohiem_radio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.baohiem_radio.Location = new System.Drawing.Point(96, 116);
            this.baohiem_radio.Name = "baohiem_radio";
            this.baohiem_radio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.baohiem_radio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Đã đóng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Chưa đóng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tất cả")});
            this.baohiem_radio.Properties.LookAndFeel.SkinName = "Liquid Sky";
            this.baohiem_radio.Size = new System.Drawing.Size(241, 27);
            this.baohiem_radio.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bảo hiểm:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.baohiem_radio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.hopdong_radio);
            this.groupBox1.Controls.Add(this.cmbChucvu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbBophan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // frmBaocaoNV
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 244);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_xem);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBaocaoNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo nhân viên";
            this.Load += new System.EventHandler(this.frmBaocaoNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hopdong_radio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baohiem_radio.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton bt_xem;
        private DevExpress.XtraEditors.SimpleButton bt_thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBophan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbChucvu;
        private DevExpress.XtraEditors.RadioGroup hopdong_radio;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.RadioGroup baohiem_radio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}