namespace QLNhanSu.Report_NhanVien
{
    partial class rpt_nhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_nhanvien));
            this.reportNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpt_NV = new QLNhanSu.rpt_NV();
            this.report_NhanVienTableAdapter = new QLNhanSu.rpt_NVTableAdapters.Report_NhanVienTableAdapter();
            this.rptNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Report_NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.reportNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpt_NV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report_NhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportNhanVienBindingSource
            // 
            this.reportNhanVienBindingSource.DataMember = "Report_NhanVien";
            this.reportNhanVienBindingSource.DataSource = this.rpt_NV;
            // 
            // rpt_NV
            // 
            this.rpt_NV.DataSetName = "rpt_NV";
            this.rpt_NV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // report_NhanVienTableAdapter
            // 
            this.report_NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // rptNVBindingSource
            // 
            this.rptNVBindingSource.DataSource = this.rpt_NV;
            this.rptNVBindingSource.Position = 0;
            // 
            // Report_NhanVienBindingSource
            // 
            this.Report_NhanVienBindingSource.DataMember = "Report_NhanVien";
            this.Report_NhanVienBindingSource.DataSource = this.rpt_NV;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(691, 394);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // rpt_nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 394);
            this.Controls.Add(this.crystalReportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rpt_nhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo nhân viên";
            this.Load += new System.EventHandler(this.rpt_nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpt_NV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report_NhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private rpt_NV rpt_NV;
        private System.Windows.Forms.BindingSource reportNhanVienBindingSource;
        private rpt_NVTableAdapters.Report_NhanVienTableAdapter report_NhanVienTableAdapter;
        private System.Windows.Forms.BindingSource rptNVBindingSource;
        private System.Windows.Forms.BindingSource Report_NhanVienBindingSource;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        //private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;

    }
}