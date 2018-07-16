namespace QLNhanSu.Report
{
    partial class frm_rptBangluongTungNhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_rptBangluongTungNhanvien));
            this.crystalReport_luongTungNV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReport_luongTungNV
            // 
            this.crystalReport_luongTungNV.ActiveViewIndex = -1;
            this.crystalReport_luongTungNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReport_luongTungNV.Cursor = System.Windows.Forms.Cursors.Default;
           // this.crystalReport_luongTungNV.DisplayStatusBar = false;
            this.crystalReport_luongTungNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReport_luongTungNV.Location = new System.Drawing.Point(0, 0);
            this.crystalReport_luongTungNV.Name = "crystalReport_luongTungNV";
            this.crystalReport_luongTungNV.Size = new System.Drawing.Size(1004, 595);
            this.crystalReport_luongTungNV.TabIndex = 0;
           // this.crystalReport_luongTungNV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_rprBangluongTungNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 595);
            this.Controls.Add(this.crystalReport_luongTungNV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_rprBangluongTungNhanvien";
            this.Text = "In lương từng nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_rprBangluongTungNhanvien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReport_luongTungNV;
    }
}