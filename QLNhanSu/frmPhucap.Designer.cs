namespace QLNhanSu
{
    partial class frmPhucap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhucap));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btDong = new DevExpress.XtraEditors.DropDownButton();
            this.grid_phucap = new DevExpress.XtraGrid.GridControl();
            this.menustrip_phucap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menustrip_pc_them = new System.Windows.Forms.ToolStripMenuItem();
            this.menustrip_pc_xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menustrip_pc_sua = new System.Windows.Forms.ToolStripMenuItem();
            this.menustrip_pc_restart = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Maphucap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenloai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btThemPc = new DevExpress.XtraEditors.DropDownButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btsuaPc = new DevExpress.XtraEditors.DropDownButton();
            this.txtTienpc = new DevExpress.XtraEditors.TextEdit();
            this.btXoaPc = new DevExpress.XtraEditors.DropDownButton();
            this.txtTenpc = new DevExpress.XtraEditors.TextEdit();
            this.txtMapc = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_phucap)).BeginInit();
            this.menustrip_phucap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienpc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenpc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMapc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btDong);
            this.layoutControl1.Controls.Add(this.grid_phucap);
            this.layoutControl1.Controls.Add(this.btThemPc);
            this.layoutControl1.Controls.Add(this.label1);
            this.layoutControl1.Controls.Add(this.btsuaPc);
            this.layoutControl1.Controls.Add(this.txtTienpc);
            this.layoutControl1.Controls.Add(this.btXoaPc);
            this.layoutControl1.Controls.Add(this.txtTenpc);
            this.layoutControl1.Controls.Add(this.txtMapc);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(410, 211, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(776, 493);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btDong
            // 
            this.btDong.Image = ((System.Drawing.Image)(resources.GetObject("btDong.Image")));
            this.btDong.Location = new System.Drawing.Point(575, 365);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(189, 22);
            this.btDong.StyleController = this.layoutControl1;
            this.btDong.TabIndex = 8;
            this.btDong.Text = "Đóng";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // grid_phucap
            // 
            this.grid_phucap.ContextMenuStrip = this.menustrip_phucap;
            this.grid_phucap.Location = new System.Drawing.Point(24, 170);
            this.grid_phucap.MainView = this.gridView1;
            this.grid_phucap.Name = "grid_phucap";
            this.grid_phucap.Size = new System.Drawing.Size(728, 179);
            this.grid_phucap.TabIndex = 4;
            this.grid_phucap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // menustrip_phucap
            // 
            this.menustrip_phucap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustrip_pc_them,
            this.menustrip_pc_xoa,
            this.menustrip_pc_sua,
            this.menustrip_pc_restart});
            this.menustrip_phucap.Name = "menustrip_phucap";
            this.menustrip_phucap.Size = new System.Drawing.Size(232, 92);
            // 
            // menustrip_pc_them
            // 
            this.menustrip_pc_them.Image = ((System.Drawing.Image)(resources.GetObject("menustrip_pc_them.Image")));
            this.menustrip_pc_them.Name = "menustrip_pc_them";
            this.menustrip_pc_them.Size = new System.Drawing.Size(231, 22);
            this.menustrip_pc_them.Text = "Thêm phụ cấp";
            this.menustrip_pc_them.Click += new System.EventHandler(this.menustrip_pc_them_Click);
            // 
            // menustrip_pc_xoa
            // 
            this.menustrip_pc_xoa.Image = ((System.Drawing.Image)(resources.GetObject("menustrip_pc_xoa.Image")));
            this.menustrip_pc_xoa.Name = "menustrip_pc_xoa";
            this.menustrip_pc_xoa.Size = new System.Drawing.Size(231, 22);
            this.menustrip_pc_xoa.Text = "Xoá phụ cấp";
            this.menustrip_pc_xoa.Click += new System.EventHandler(this.menustrip_pc_xoa_Click);
            // 
            // menustrip_pc_sua
            // 
            this.menustrip_pc_sua.Image = ((System.Drawing.Image)(resources.GetObject("menustrip_pc_sua.Image")));
            this.menustrip_pc_sua.Name = "menustrip_pc_sua";
            this.menustrip_pc_sua.Size = new System.Drawing.Size(231, 22);
            this.menustrip_pc_sua.Text = "Sửa phụ cấp";
            this.menustrip_pc_sua.Click += new System.EventHandler(this.menustrip_pc_sua_Click);
            // 
            // menustrip_pc_restart
            // 
            this.menustrip_pc_restart.Image = ((System.Drawing.Image)(resources.GetObject("menustrip_pc_restart.Image")));
            this.menustrip_pc_restart.Name = "menustrip_pc_restart";
            this.menustrip_pc_restart.Size = new System.Drawing.Size(231, 22);
            this.menustrip_pc_restart.Text = "Restart danh mục phụ cấp";
            this.menustrip_pc_restart.Click += new System.EventHandler(this.menustrip_pc_restart_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Maphucap,
            this.tenloai,
            this.tien});
            this.gridView1.GridControl = this.grid_phucap;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Bảng phụ cấp";
            // 
            // Maphucap
            // 
            this.Maphucap.Caption = "Mã phụ cấp";
            this.Maphucap.FieldName = "Maloaipc";
            this.Maphucap.Name = "Maphucap";
            this.Maphucap.Visible = true;
            this.Maphucap.VisibleIndex = 0;
            // 
            // tenloai
            // 
            this.tenloai.Caption = "Tên gọi phụ cấp";
            this.tenloai.FieldName = "Tenloai";
            this.tenloai.Name = "tenloai";
            this.tenloai.Visible = true;
            this.tenloai.VisibleIndex = 1;
            // 
            // tien
            // 
            this.tien.Caption = "Tiền phụ cấp";
            this.tien.FieldName = "Tien";
            this.tien.Name = "tien";
            this.tien.Visible = true;
            this.tien.VisibleIndex = 2;
            // 
            // btThemPc
            // 
            this.btThemPc.Image = ((System.Drawing.Image)(resources.GetObject("btThemPc.Image")));
            this.btThemPc.Location = new System.Drawing.Point(12, 365);
            this.btThemPc.Name = "btThemPc";
            this.btThemPc.Size = new System.Drawing.Size(181, 22);
            this.btThemPc.StyleController = this.layoutControl1;
            this.btThemPc.TabIndex = 5;
            this.btThemPc.Text = "Thêm";
            this.btThemPc.Click += new System.EventHandler(this.btThemPc_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 52);
            this.label1.TabIndex = 7;
            this.label1.Text = "DANH MỤC PHỤ CẤP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btsuaPc
            // 
            this.btsuaPc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btsuaPc.BackgroundImage")));
            this.btsuaPc.Image = ((System.Drawing.Image)(resources.GetObject("btsuaPc.Image")));
            this.btsuaPc.Location = new System.Drawing.Point(389, 365);
            this.btsuaPc.Name = "btsuaPc";
            this.btsuaPc.Size = new System.Drawing.Size(182, 22);
            this.btsuaPc.StyleController = this.layoutControl1;
            this.btsuaPc.TabIndex = 7;
            this.btsuaPc.Text = "Sửa";
            this.btsuaPc.Click += new System.EventHandler(this.btsuaPc_Click);
            // 
            // txtTienpc
            // 
            this.txtTienpc.Location = new System.Drawing.Point(90, 116);
            this.txtTienpc.Name = "txtTienpc";
            this.txtTienpc.Size = new System.Drawing.Size(260, 20);
            this.txtTienpc.StyleController = this.layoutControl1;
            this.txtTienpc.TabIndex = 3;
            // 
            // btXoaPc
            // 
            this.btXoaPc.Image = ((System.Drawing.Image)(resources.GetObject("btXoaPc.Image")));
            this.btXoaPc.Location = new System.Drawing.Point(197, 365);
            this.btXoaPc.Name = "btXoaPc";
            this.btXoaPc.Size = new System.Drawing.Size(188, 22);
            this.btXoaPc.StyleController = this.layoutControl1;
            this.btXoaPc.TabIndex = 6;
            this.btXoaPc.Text = "Xoá";
            this.btXoaPc.Click += new System.EventHandler(this.btXoaPc_Click);
            // 
            // txtTenpc
            // 
            this.txtTenpc.Location = new System.Drawing.Point(90, 92);
            this.txtTenpc.Name = "txtTenpc";
            this.txtTenpc.Size = new System.Drawing.Size(260, 20);
            this.txtTenpc.StyleController = this.layoutControl1;
            this.txtTenpc.TabIndex = 2;
            // 
            // txtMapc
            // 
            this.txtMapc.Location = new System.Drawing.Point(90, 68);
            this.txtMapc.Name = "txtMapc";
            this.txtMapc.Size = new System.Drawing.Size(260, 20);
            this.txtMapc.StyleController = this.layoutControl1;
            this.txtMapc.TabIndex = 1;
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
            this.layoutControlGroup2,
            this.emptySpaceItem4,
            this.layoutControlItem6,
            this.layoutControlItem8,
            this.layoutControlItem7,
            this.layoutControlItem9,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(776, 493);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtMapc;
            this.layoutControlItem1.CustomizationFormText = "Mã phụ cấp:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(342, 24);
            this.layoutControlItem1.Text = "Mã phụ cấp";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtTenpc;
            this.layoutControlItem2.CustomizationFormText = "Tên phụ cấp:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(342, 24);
            this.layoutControlItem2.Text = "Tên phụ cấp";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtTienpc;
            this.layoutControlItem3.CustomizationFormText = "Số tiền phụ cấp:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 104);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(342, 24);
            this.layoutControlItem3.Text = "Số tiền phụ cấp";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.label1;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(756, 56);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 128);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(756, 225);
            this.layoutControlGroup2.Text = "Danh mục phụ cấp";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.grid_phucap;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(732, 183);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 379);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(756, 94);
            this.emptySpaceItem4.Text = "emptySpaceItem4";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btXoaPc;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(185, 353);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(192, 26);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btThemPc;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 353);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(185, 26);
            this.layoutControlItem8.Text = "layoutControlItem8";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextToControlDistance = 0;
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btsuaPc;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem7.Location = new System.Drawing.Point(377, 353);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(186, 26);
            this.layoutControlItem7.Text = "layoutControlItem7";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextToControlDistance = 0;
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btDong;
            this.layoutControlItem9.CustomizationFormText = "layoutControlItem9";
            this.layoutControlItem9.Location = new System.Drawing.Point(563, 353);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(193, 26);
            this.layoutControlItem9.Text = "layoutControlItem9";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextToControlDistance = 0;
            this.layoutControlItem9.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(342, 56);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(414, 72);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmPhucap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 493);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPhucap";
            this.Text = "Danh mục phụ cấp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhucap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_phucap)).EndInit();
            this.menustrip_phucap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienpc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenpc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMapc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtTienpc;
        private DevExpress.XtraEditors.TextEdit txtTenpc;
        private DevExpress.XtraEditors.TextEdit txtMapc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.GridControl grid_phucap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Maphucap;
        private DevExpress.XtraGrid.Columns.GridColumn tenloai;
        private DevExpress.XtraGrid.Columns.GridColumn tien;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.DropDownButton btDong;
        private DevExpress.XtraEditors.DropDownButton btThemPc;
        private DevExpress.XtraEditors.DropDownButton btsuaPc;
        private DevExpress.XtraEditors.DropDownButton btXoaPc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.ContextMenuStrip menustrip_phucap;
        private System.Windows.Forms.ToolStripMenuItem menustrip_pc_them;
        private System.Windows.Forms.ToolStripMenuItem menustrip_pc_xoa;
        private System.Windows.Forms.ToolStripMenuItem menustrip_pc_sua;
        private System.Windows.Forms.ToolStripMenuItem menustrip_pc_restart;
    }
}