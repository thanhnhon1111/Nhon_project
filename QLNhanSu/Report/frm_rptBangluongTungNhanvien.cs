using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLNhanSu.Report
{
    public partial class frm_rptBangluongTungNhanvien : DevExpress.XtraEditors.XtraForm
    {
        private string manv,thang,nam;
        public frm_rptBangluongTungNhanvien()
        {
            InitializeComponent();
        }
        public frm_rptBangluongTungNhanvien(string manv,string thang,string nam)
        {
            InitializeComponent();
            this.manv = manv;
            this.thang = thang;
            this.nam = nam;
        }
        public string THANG { get; set; }
        public string NAM { get; set; }
        private void loadCrystalRpt()
        {
            try
            {
                    THANG = thang;
                    NAM = nam;
                    rpt_Luongtungnv Rp = new rpt_Luongtungnv();
                    DataTable ds = BUS.BUS_Report.bangluongtungNV(thang, nam);
                    Rp.SetDataSource(ds);
                    Rp.SetParameterValue("nam", Int32.Parse(NAM));
                    if (thang == "----Chọn tháng----")
                    {
                        THANG = "0";
                        Rp.SetParameterValue("thang_nam", "NĂM " + NAM + " ");
                        Rp.SetParameterValue("dau", "");

                    }
                    else
                    {
                        Rp.SetParameterValue("thang_nam", "THÁNG " + THANG + " - " + NAM + "  ");
                        Rp.SetParameterValue("dau", " - ");
                    }
                    Rp.SetParameterValue("thang", Int32.Parse(THANG));
                    crystalReport_luongTungNV.ReportSource = Rp;
            }
            catch
            {
                MessageBox.Show("Kết nối với máy chủ thất bại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frm_rprBangluongTungNhanvien_Load(object sender, EventArgs e)
        {
            loadCrystalRpt();
        }
    }
}