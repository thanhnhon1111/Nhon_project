namespace QLNhanSu
{
    partial class frmNhapExcelBangCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapExcelBangCong));
            this.textFileName = new DevExpress.XtraEditors.TextEdit();
            this.bt_Brows = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Thucthi = new DevExpress.XtraEditors.DropDownButton();
            this.bt_Thoat = new DevExpress.XtraEditors.DropDownButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grid_BangCong = new System.Windows.Forms.DataGridView();
            this.cmb_sheet = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textFileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_BangCong)).BeginInit();
            this.SuspendLayout();
            // 
            // textFileName
            // 
            this.textFileName.Location = new System.Drawing.Point(66, 73);
            this.textFileName.Name = "textFileName";
            this.textFileName.Size = new System.Drawing.Size(285, 20);
            this.textFileName.TabIndex = 0;
            // 
            // bt_Brows
            // 
            this.bt_Brows.Location = new System.Drawing.Point(357, 70);
            this.bt_Brows.Name = "bt_Brows";
            this.bt_Brows.Size = new System.Drawing.Size(75, 23);
            this.bt_Brows.TabIndex = 1;
            this.bt_Brows.Text = "Brows...";
            this.bt_Brows.Click += new System.EventHandler(this.bt_Brows_Click);
            // 
            // bt_Thucthi
            // 
            this.bt_Thucthi.Image = ((System.Drawing.Image)(resources.GetObject("bt_Thucthi.Image")));
            this.bt_Thucthi.Location = new System.Drawing.Point(116, 298);
            this.bt_Thucthi.Name = "bt_Thucthi";
            this.bt_Thucthi.Size = new System.Drawing.Size(135, 23);
            this.bt_Thucthi.TabIndex = 6;
            this.bt_Thucthi.Text = "Thực thi";
            this.bt_Thucthi.Click += new System.EventHandler(this.bt_Thucthi_Click);
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("bt_Thoat.Image")));
            this.bt_Thoat.Location = new System.Drawing.Point(257, 298);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(135, 23);
            this.bt_Thoat.TabIndex = 7;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grid_BangCong);
            this.groupControl1.Location = new System.Drawing.Point(25, 135);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(458, 157);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Bảng công";
            // 
            // grid_BangCong
            // 
            this.grid_BangCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_BangCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_BangCong.Location = new System.Drawing.Point(2, 20);
            this.grid_BangCong.Name = "grid_BangCong";
            this.grid_BangCong.Size = new System.Drawing.Size(454, 135);
            this.grid_BangCong.TabIndex = 0;
            // 
            // cmb_sheet
            // 
            this.cmb_sheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sheet.FormattingEnabled = true;
            this.cmb_sheet.Location = new System.Drawing.Point(66, 103);
            this.cmb_sheet.Name = "cmb_sheet";
            this.cmb_sheet.Size = new System.Drawing.Size(150, 21);
            this.cmb_sheet.TabIndex = 5;
            this.cmb_sheet.SelectedIndexChanged += new System.EventHandler(this.cmb_sheet_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl1.Location = new System.Drawing.Point(158, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(193, 26);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "NHẬP BẢNG CÔNG";
            // 
            // frmNhapExcelBangCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(509, 332);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmb_sheet);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_Thucthi);
            this.Controls.Add(this.bt_Brows);
            this.Controls.Add(this.textFileName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhapExcelBangCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập bảng công từ file excel";
            this.Load += new System.EventHandler(this.frmNhapExcelBangCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textFileName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_BangCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textFileName;
        private DevExpress.XtraEditors.SimpleButton bt_Brows;
        private DevExpress.XtraEditors.DropDownButton bt_Thucthi;
        private DevExpress.XtraEditors.DropDownButton bt_Thoat;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView grid_BangCong;
        private System.Windows.Forms.ComboBox cmb_sheet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}