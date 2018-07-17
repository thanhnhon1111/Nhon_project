namespace QLNhanSu.Report
{
    partial class frm_Nhanvienngiviectrongthang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Nhanvienngiviectrongthang));
            this.cmb_nam = new System.Windows.Forms.ComboBox();
            this.cmb_thang = new System.Windows.Forms.ComboBox();
            this.bt_xem = new DevExpress.XtraEditors.DropDownButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.label1 = new System.Windows.Forms.Label();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_nam
            // 
            this.cmb_nam.FormattingEnabled = true;
            this.cmb_nam.Location = new System.Drawing.Point(192, 63);
            this.cmb_nam.Name = "cmb_nam";
            this.cmb_nam.Size = new System.Drawing.Size(112, 21);
            this.cmb_nam.TabIndex = 2;
            // 
            // cmb_thang
            // 
            this.cmb_thang.FormattingEnabled = true;
            this.cmb_thang.Location = new System.Drawing.Point(46, 63);
            this.cmb_thang.Name = "cmb_thang";
            this.cmb_thang.Size = new System.Drawing.Size(108, 21);
            this.cmb_thang.TabIndex = 1;
            // 
            // bt_xem
            // 
            this.bt_xem.Image = ((System.Drawing.Image)(resources.GetObject("bt_xem.Image")));
            this.bt_xem.Location = new System.Drawing.Point(308, 63);
            this.bt_xem.Name = "bt_xem";
            this.bt_xem.Size = new System.Drawing.Size(117, 22);
            this.bt_xem.StyleController = this.layoutControl1;
            this.bt_xem.TabIndex = 3;
            this.bt_xem.Text = "Xem Chi Tiết";
            this.bt_xem.Click += new System.EventHandler(this.bt_xem_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cmb_nam);
            this.layoutControl1.Controls.Add(this.bt_xem);
            this.layoutControl1.Controls.Add(this.label1);
            this.layoutControl1.Controls.Add(this.cmb_thang);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(763, 97);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(739, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "BÁO CÁO NHÂN VIÊN NGHỈ VIỆC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(763, 97);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.label1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(743, 51);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cmb_thang;
            this.layoutControlItem2.CustomizationFormText = "Tháng";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 51);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(146, 26);
            this.layoutControlItem2.Text = "Tháng";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(30, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cmb_nam;
            this.layoutControlItem3.CustomizationFormText = "Năm";
            this.layoutControlItem3.Location = new System.Drawing.Point(146, 51);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(150, 26);
            this.layoutControlItem3.Text = "Năm";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(30, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.bt_xem;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(296, 51);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(121, 26);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(417, 51);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(326, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.crystalReportViewer1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 101);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(767, 360);
            this.panelControl2.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            //this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(763, 356);
            this.crystalReportViewer1.TabIndex = 0;
           // this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(767, 101);
            this.panelControl1.TabIndex = 0;
            // 
            // frm_Nhanvienngiviectrongthang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 461);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Nhanvienngiviectrongthang";
            this.Text = "Báo cáo nhân viên nghĩ việc trong ngày";
            this.Load += new System.EventHandler(this.frm_Nhanvienngiviectrongthang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.DropDownButton bt_xem;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox cmb_nam;
        private System.Windows.Forms.ComboBox cmb_thang;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}