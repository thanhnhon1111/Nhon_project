using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLNhanSu.Report.ds_sapkiHDTableAdapters;

namespace QLNhanSu.Report
{
    public partial class frm_sapkiHD : DevExpress.XtraEditors.XtraForm
    {
        public frm_sapkiHD()
        {
            InitializeComponent();
        }

        private void frm_sapkiHD_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            Report.Rpt_sapkiHD Rp = new Rpt_sapkiHD();
            Report.ds_sapkiHD ds = new ds_sapkiHD();
            Report_Nhanvien_saphetHDTableAdapter sapki = new Report_Nhanvien_saphetHDTableAdapter();
            sapki.Fill(ds.Report_Nhanvien_saphetHD);
            Rp.SetDataSource(ds);
            crystalReportViewer1.ReportSource = Rp;
        }
    }
}