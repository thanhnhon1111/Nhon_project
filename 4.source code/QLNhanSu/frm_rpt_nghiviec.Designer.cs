namespace QLNhanSu
{
    partial class frm_rpt_nghiviec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_rpt_nghiviec));
            this.NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptBaocaotheongaylamviecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.label1 = new System.Windows.Forms.Label();
            this.Xem = new DevExpress.XtraEditors.SimpleButton();
            this.cbm_nam = new System.Windows.Forms.ComboBox();
            this.bt_dong = new DevExpress.XtraEditors.DropDownButton();
            this.cbm_thang = new System.Windows.Forms.ComboBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.rpt_NV = new QLNhanSu.rpt_NV();
            this.Report_NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Report_NhanVienTableAdapter = new QLNhanSu.rpt_NVTableAdapters.Report_NhanVienTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rpt_nghiviec = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptBaocaotheongaylamviecBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpt_NV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report_NhanVienBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NhanVienBindingSource
            // 
            this.NhanVienBindingSource.DataMember = "NhanVien";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.layoutControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 84);
            this.panel1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.label1);
            this.layoutControl1.Controls.Add(this.Xem);
            this.layoutControl1.Controls.Add(this.cbm_nam);
            this.layoutControl1.Controls.Add(this.bt_dong);
            this.layoutControl1.Controls.Add(this.cbm_thang);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(795, 84);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "BÁO CÁO NHÂN VIÊN ĐÃ NGHĨ VIỆC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Xem
            // 
            this.Xem.Image = ((System.Drawing.Image)(resources.GetObject("Xem.Image")));
            this.Xem.Location = new System.Drawing.Point(504, 50);
            this.Xem.Name = "Xem";
            this.Xem.Size = new System.Drawing.Size(138, 22);
            this.Xem.StyleController = this.layoutControl1;
            this.Xem.TabIndex = 3;
            this.Xem.Text = "Xem";
            this.Xem.Click += new System.EventHandler(this.Xem_Click);
            // 
            // cbm_nam
            // 
            this.cbm_nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbm_nam.FormattingEnabled = true;
            this.cbm_nam.Location = new System.Drawing.Point(301, 50);
            this.cbm_nam.Name = "cbm_nam";
            this.cbm_nam.Size = new System.Drawing.Size(199, 21);
            this.cbm_nam.TabIndex = 2;
            // 
            // bt_dong
            // 
            this.bt_dong.Image = ((System.Drawing.Image)(resources.GetObject("bt_dong.Image")));
            this.bt_dong.Location = new System.Drawing.Point(646, 50);
            this.bt_dong.Name = "bt_dong";
            this.bt_dong.Size = new System.Drawing.Size(137, 22);
            this.bt_dong.StyleController = this.layoutControl1;
            this.bt_dong.TabIndex = 4;
            this.bt_dong.Text = "Đóng lại";
            this.bt_dong.Click += new System.EventHandler(this.bt_dong_Click);
            // 
            // cbm_thang
            // 
            this.cbm_thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbm_thang.FormattingEnabled = true;
            this.cbm_thang.Location = new System.Drawing.Point(72, 50);
            this.cbm_thang.Name = "cbm_thang";
            this.cbm_thang.Size = new System.Drawing.Size(165, 21);
            this.cbm_thang.TabIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(795, 84);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.BackColor = System.Drawing.Color.Transparent;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseBackColor = true;
            this.layoutControlItem4.Control = this.cbm_thang;
            this.layoutControlItem4.CustomizationFormText = "Chọn tháng:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 38);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(229, 26);
            this.layoutControlItem4.Text = "Chọn tháng";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.label1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(775, 38);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.BackColor = System.Drawing.Color.Transparent;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseBackColor = true;
            this.layoutControlItem5.Control = this.cbm_nam;
            this.layoutControlItem5.CustomizationFormText = "Chọn năm:";
            this.layoutControlItem5.Location = new System.Drawing.Point(229, 38);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(263, 26);
            this.layoutControlItem5.Text = "Chọn năm";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.Xem;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(492, 38);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(142, 26);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.bt_dong;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(634, 38);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(141, 26);
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
            // Report_NhanVienBindingSource
            // 
            this.Report_NhanVienBindingSource.DataMember = "Report_NhanVien";
            this.Report_NhanVienBindingSource.DataSource = this.rpt_NV;
            // 
            // Report_NhanVienTableAdapter
            // 
            this.Report_NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rpt_nghiviec);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 307);
            this.panel2.TabIndex = 1;
            // 
            // rpt_nghiviec
            // 
            this.rpt_nghiviec.ActiveViewIndex = -1;
            this.rpt_nghiviec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpt_nghiviec.Cursor = System.Windows.Forms.Cursors.Default;
            //this.rpt_nghiviec.DisplayStatusBar = false;
            this.rpt_nghiviec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt_nghiviec.Location = new System.Drawing.Point(0, 0);
            this.rpt_nghiviec.Name = "rpt_nghiviec";
            this.rpt_nghiviec.Size = new System.Drawing.Size(795, 307);
            this.rpt_nghiviec.TabIndex = 0;
            //this.rpt_nghiviec.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_rpt_nghiviec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 391);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_rpt_nghiviec";
            this.Text = "Báo cáo nhân viên nghĩ việc đã thôi việc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_rpt_nghiviec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptBaocaotheongaylamviecBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpt_NV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report_NhanVienBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource NhanVienBindingSource;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource Report_NhanVienBindingSource;
        private rpt_NV rpt_NV;
        private rpt_NVTableAdapters.Report_NhanVienTableAdapter Report_NhanVienTableAdapter;
        private System.Windows.Forms.BindingSource rptBaocaotheongaylamviecBindingSource;

        private System.Windows.Forms.Panel panel2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpt_nghiviec;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton Xem;
        private System.Windows.Forms.ComboBox cbm_nam;
        private DevExpress.XtraEditors.DropDownButton bt_dong;
        private System.Windows.Forms.ComboBox cbm_thang;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}