namespace QLNhanSu.Report
{
    partial class frmNhanvienditre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanvienditre));
            this.Xem = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.btDong = new DevExpress.XtraEditors.SimpleButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGio = new System.Windows.Forms.ComboBox();
            this.cmbPhut = new System.Windows.Forms.ComboBox();
            this.cbm_thang = new System.Windows.Forms.ComboBox();
            this.cbm_nam = new System.Windows.Forms.ComboBox();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.rpt_NV = new QLNhanSu.rpt_NV();
            this.Report_NhanVienTableAdapter = new QLNhanSu.rpt_NVTableAdapters.Report_NhanVienTableAdapter();
            this.Report_NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptBaocaotheongaylamviecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpt_NV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report_NhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptBaocaotheongaylamviecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Xem
            // 
            this.Xem.Image = ((System.Drawing.Image)(resources.GetObject("Xem.Image")));
            this.Xem.Location = new System.Drawing.Point(812, 71);
            this.Xem.Name = "Xem";
            this.Xem.Size = new System.Drawing.Size(96, 22);
            this.Xem.StyleController = this.layoutControl2;
            this.Xem.TabIndex = 3;
            this.Xem.Text = "Xem";
            this.Xem.Click += new System.EventHandler(this.Xem_Click_1);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.btDong);
            this.layoutControl2.Controls.Add(this.crystalReportViewer1);
            this.layoutControl2.Controls.Add(this.label1);
            this.layoutControl2.Controls.Add(this.cmbGio);
            this.layoutControl2.Controls.Add(this.cmbPhut);
            this.layoutControl2.Controls.Add(this.Xem);
            this.layoutControl2.Controls.Add(this.cbm_thang);
            this.layoutControl2.Controls.Add(this.cbm_nam);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(1017, 583);
            this.layoutControl2.TabIndex = 3;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // btDong
            // 
            this.btDong.Image = ((System.Drawing.Image)(resources.GetObject("btDong.Image")));
            this.btDong.Location = new System.Drawing.Point(912, 71);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(93, 22);
            this.btDong.StyleController = this.layoutControl2;
            this.btDong.TabIndex = 17;
            this.btDong.Text = "Đóng";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            //this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 97);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(993, 474);
            this.crystalReportViewer1.TabIndex = 0;
           // this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(993, 55);
            this.label1.TabIndex = 14;
            this.label1.Text = "BÁO CÁO NHÂN VIÊN ĐI TRỄ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbGio
            // 
            this.cmbGio.FormattingEnabled = true;
            this.cmbGio.Location = new System.Drawing.Point(59, 71);
            this.cmbGio.Name = "cmbGio";
            this.cmbGio.Size = new System.Drawing.Size(149, 21);
            this.cmbGio.TabIndex = 15;
            // 
            // cmbPhut
            // 
            this.cmbPhut.FormattingEnabled = true;
            this.cmbPhut.Location = new System.Drawing.Point(259, 71);
            this.cmbPhut.Name = "cmbPhut";
            this.cmbPhut.Size = new System.Drawing.Size(149, 21);
            this.cmbPhut.TabIndex = 16;
            // 
            // cbm_thang
            // 
            this.cbm_thang.FormattingEnabled = true;
            this.cbm_thang.Location = new System.Drawing.Point(459, 71);
            this.cbm_thang.Name = "cbm_thang";
            this.cbm_thang.Size = new System.Drawing.Size(149, 21);
            this.cbm_thang.TabIndex = 1;
            // 
            // cbm_nam
            // 
            this.cbm_nam.FormattingEnabled = true;
            this.cbm_nam.Location = new System.Drawing.Point(659, 71);
            this.cbm_nam.Name = "cbm_nam";
            this.cbm_nam.Size = new System.Drawing.Size(149, 21);
            this.cbm_nam.TabIndex = 2;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8,
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1017, 583);
            this.layoutControlGroup2.Text = "layoutControlGroup2";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.crystalReportViewer1;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 85);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(997, 478);
            this.layoutControlItem8.Text = "layoutControlItem8";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextToControlDistance = 0;
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.label1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(997, 59);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cmbGio;
            this.layoutControlItem6.CustomizationFormText = "Giờ vào";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 59);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(200, 26);
            this.layoutControlItem6.Text = "Giờ vào";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.cmbPhut;
            this.layoutControlItem7.CustomizationFormText = "Phút vào";
            this.layoutControlItem7.Location = new System.Drawing.Point(200, 59);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(200, 26);
            this.layoutControlItem7.Text = "Phút vào";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbm_thang;
            this.layoutControlItem4.CustomizationFormText = "Tháng";
            this.layoutControlItem4.Location = new System.Drawing.Point(400, 59);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(200, 26);
            this.layoutControlItem4.Text = "Tháng";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cbm_nam;
            this.layoutControlItem5.CustomizationFormText = "Năm";
            this.layoutControlItem5.Location = new System.Drawing.Point(600, 59);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(200, 26);
            this.layoutControlItem5.Text = "Năm";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.Xem;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(800, 59);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(100, 26);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btDong;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(900, 59);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(97, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // rpt_NV
            // 
            this.rpt_NV.DataSetName = "rpt_NV";
            this.rpt_NV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Report_NhanVienTableAdapter
            // 
            this.Report_NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // Report_NhanVienBindingSource
            // 
            this.Report_NhanVienBindingSource.DataMember = "Report_NhanVien";
            this.Report_NhanVienBindingSource.DataSource = this.rpt_NV;
            // 
            // NhanVienBindingSource
            // 
            this.NhanVienBindingSource.DataMember = "NhanVien";
            // 
            // frmNhanvienditre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 583);
            this.Controls.Add(this.layoutControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNhanvienditre";
            this.Text = "Báo cáo nhân viên đi trể";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhanvienditre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpt_NV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report_NhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptBaocaotheongaylamviecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Xem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbm_nam;
        private System.Windows.Forms.ComboBox cbm_thang;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private rpt_NV rpt_NV;
        private rpt_NVTableAdapters.Report_NhanVienTableAdapter Report_NhanVienTableAdapter;
        private System.Windows.Forms.BindingSource Report_NhanVienBindingSource;
        private System.Windows.Forms.BindingSource rptBaocaotheongaylamviecBindingSource;
        private System.Windows.Forms.BindingSource NhanVienBindingSource;
        private System.Windows.Forms.ComboBox cmbPhut;
        private System.Windows.Forms.ComboBox cmbGio;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btDong;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}