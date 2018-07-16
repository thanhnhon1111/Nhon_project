using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Report
{
    public partial class BaoCaonhanvientheongaylamviec : DevExpress.XtraEditors.XtraForm
    {
        public BaoCaonhanvientheongaylamviec()
        {
            InitializeComponent();
        }

        private void BaoCaonhanvientheongaylamviec_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.report_NhanVienTableAdapter.FillBy_nhanviendahethd(this.rpt_NV.Report_NhanVien, s1, s2, s3);
            this.nh
        }

    }
}