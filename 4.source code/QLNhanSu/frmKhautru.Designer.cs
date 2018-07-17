namespace QLNhanSu
{
    partial class frmKhautru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhautru));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtMakhautru = new DevExpress.XtraEditors.TextEdit();
            this.btDong = new DevExpress.XtraEditors.SimpleButton();
            this.btSua_kt = new DevExpress.XtraEditors.DropDownButton();
            this.gridKhautru = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.makt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenkt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btCapnhat = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTienkhautru = new DevExpress.XtraEditors.TextEdit();
            this.txtTenkhautru = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMakhautru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKhautru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienkhautru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenkhautru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtMakhautru);
            this.layoutControl1.Controls.Add(this.btDong);
            this.layoutControl1.Controls.Add(this.btSua_kt);
            this.layoutControl1.Controls.Add(this.gridKhautru);
            this.layoutControl1.Controls.Add(this.btCapnhat);
            this.layoutControl1.Controls.Add(this.label1);
            this.layoutControl1.Controls.Add(this.txtTienkhautru);
            this.layoutControl1.Controls.Add(this.txtTenkhautru);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(592, 385);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtMakhautru
            // 
            this.txtMakhautru.Enabled = false;
            this.txtMakhautru.Location = new System.Drawing.Point(105, 100);
            this.txtMakhautru.Name = "txtMakhautru";
            this.txtMakhautru.Size = new System.Drawing.Size(121, 20);
            this.txtMakhautru.StyleController = this.layoutControl1;
            this.txtMakhautru.TabIndex = 1;
            // 
            // btDong
            // 
            this.btDong.Image = ((System.Drawing.Image)(resources.GetObject("btDong.Image")));
            this.btDong.Location = new System.Drawing.Point(290, 339);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(278, 22);
            this.btDong.StyleController = this.layoutControl1;
            this.btDong.TabIndex = 6;
            this.btDong.Text = "Đóng";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btSua_kt
            // 
            this.btSua_kt.Image = ((System.Drawing.Image)(resources.GetObject("btSua_kt.Image")));
            this.btSua_kt.Location = new System.Drawing.Point(24, 339);
            this.btSua_kt.Name = "btSua_kt";
            this.btSua_kt.Size = new System.Drawing.Size(262, 22);
            this.btSua_kt.StyleController = this.layoutControl1;
            this.btSua_kt.TabIndex = 5;
            this.btSua_kt.Text = "Sửa";
            this.btSua_kt.Click += new System.EventHandler(this.btSua_kt_Click);
            // 
            // gridKhautru
            // 
            this.gridKhautru.Location = new System.Drawing.Point(24, 172);
            this.gridKhautru.MainView = this.gridView1;
            this.gridKhautru.Name = "gridKhautru";
            this.gridKhautru.Size = new System.Drawing.Size(544, 163);
            this.gridKhautru.TabIndex = 9;
            this.gridKhautru.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.makt,
            this.tenkt,
            this.tien});
            this.gridView1.GridControl = this.gridKhautru;
            this.gridView1.GroupPanelText = "Danh mục khấu trừ";
            this.gridView1.Name = "gridView1";
            this.gridView1.ViewCaption = "Danh mục khấu trừ";
            // 
            // makt
            // 
            this.makt.Caption = "Mã khấu trừ";
            this.makt.FieldName = "makt";
            this.makt.Name = "makt";
            this.makt.Visible = true;
            this.makt.VisibleIndex = 0;
            // 
            // tenkt
            // 
            this.tenkt.Caption = "Tên khấu trừ";
            this.tenkt.FieldName = "tenkt";
            this.tenkt.Name = "tenkt";
            this.tenkt.Visible = true;
            this.tenkt.VisibleIndex = 1;
            // 
            // tien
            // 
            this.tien.Caption = "Số tiền khấu trừ";
            this.tien.FieldName = "tien";
            this.tien.Name = "tien";
            this.tien.Visible = true;
            this.tien.VisibleIndex = 2;
            // 
            // btCapnhat
            // 
            this.btCapnhat.Image = ((System.Drawing.Image)(resources.GetObject("btCapnhat.Image")));
            this.btCapnhat.Location = new System.Drawing.Point(230, 146);
            this.btCapnhat.Name = "btCapnhat";
            this.btCapnhat.Size = new System.Drawing.Size(167, 22);
            this.btCapnhat.StyleController = this.layoutControl1;
            this.btCapnhat.TabIndex = 4;
            this.btCapnhat.Text = "Cập nhật";
            this.btCapnhat.Click += new System.EventHandler(this.btCapnhat_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "DANH MỤC KHẤU TRỪ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTienkhautru
            // 
            this.txtTienkhautru.Enabled = false;
            this.txtTienkhautru.Location = new System.Drawing.Point(105, 148);
            this.txtTienkhautru.Name = "txtTienkhautru";
            this.txtTienkhautru.Size = new System.Drawing.Size(121, 20);
            this.txtTienkhautru.StyleController = this.layoutControl1;
            this.txtTienkhautru.TabIndex = 3;
            this.txtTienkhautru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienkhautru_KeyPress);
            // 
            // txtTenkhautru
            // 
            this.txtTenkhautru.Enabled = false;
            this.txtTenkhautru.Location = new System.Drawing.Point(105, 124);
            this.txtTenkhautru.Name = "txtTenkhautru";
            this.txtTenkhautru.Size = new System.Drawing.Size(121, 20);
            this.txtTenkhautru.StyleController = this.layoutControl1;
            this.txtTenkhautru.TabIndex = 2;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(592, 385);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.label1;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(572, 58);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Danh mục khấu trừ";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem8,
            this.layoutControlItem2,
            this.layoutControlItem9,
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.emptySpaceItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 58);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(572, 307);
            this.layoutControlGroup2.Text = "Danh mục khấu trừ";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Black;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtTenkhautru;
            this.layoutControlItem3.CustomizationFormText = "Tên khấu trừ:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(206, 24);
            this.layoutControlItem3.Text = "Tên khấu trừ";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Black;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtTienkhautru;
            this.layoutControlItem4.CustomizationFormText = "Số tiền khấu trừ:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(206, 24);
            this.layoutControlItem4.Text = "Số tiền khấu trừ";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridKhautru;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(548, 167);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btSua_kt;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 239);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(266, 26);
            this.layoutControlItem8.Text = "layoutControlItem8";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextToControlDistance = 0;
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btDong;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(266, 239);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(282, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.ForeColor = System.Drawing.Color.Black;
            this.layoutControlItem9.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem9.Control = this.txtMakhautru;
            this.layoutControlItem9.CustomizationFormText = "Mã khấu trừ:";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(206, 24);
            this.layoutControlItem9.Text = "Mã khấu trừ";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(77, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(377, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(171, 72);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btCapnhat;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(206, 46);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(171, 26);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(206, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(171, 46);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmKhautru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 385);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmKhautru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khẩu trừ";
            this.Load += new System.EventHandler(this.frmKhautru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMakhautru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKhautru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienkhautru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenkhautru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtMakhautru;
        private DevExpress.XtraEditors.SimpleButton btDong;
        private DevExpress.XtraEditors.DropDownButton btSua_kt;
        private DevExpress.XtraGrid.GridControl gridKhautru;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtTienkhautru;
        private DevExpress.XtraEditors.TextEdit txtTenkhautru;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn makt;
        private DevExpress.XtraGrid.Columns.GridColumn tenkt;
        private DevExpress.XtraGrid.Columns.GridColumn tien;
        private DevExpress.XtraEditors.SimpleButton btCapnhat;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}