namespace Report
{
    partial class BaoCaonhanvientheongaylamviec
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bCnhanvientheongaylamviec = new Report.BCnhanvientheongaylamviec();
            this.bCnhanvientheongaylamviecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bCnhanvientheongaylamviec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCnhanvientheongaylamviecBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Baocaonhanvientheongayvaolam";
            reportDataSource1.Value = this.bCnhanvientheongaylamviecBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Report.Baocaonhanvientheongayvaolam.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(676, 280);
            this.reportViewer1.TabIndex = 0;
            // 
            // bCnhanvientheongaylamviec
            // 
            this.bCnhanvientheongaylamviec.DataSetName = "BCnhanvientheongaylamviec";
            this.bCnhanvientheongaylamviec.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bCnhanvientheongaylamviecBindingSource
            // 
            this.bCnhanvientheongaylamviecBindingSource.DataSource = this.bCnhanvientheongaylamviec;
            this.bCnhanvientheongaylamviecBindingSource.Position = 0;
            // 
            // BaoCaonhanvientheongaylamviec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 280);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BaoCaonhanvientheongaylamviec";
            this.Text = "BaoCaonhanvientheongaylamviec";
            this.Load += new System.EventHandler(this.BaoCaonhanvientheongaylamviec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bCnhanvientheongaylamviec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCnhanvientheongaylamviecBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bCnhanvientheongaylamviecBindingSource;
        private BCnhanvientheongaylamviec bCnhanvientheongaylamviec;
    }
}