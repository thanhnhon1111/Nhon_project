using System;
using BUS;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress;

namespace QLNhanSu.Report_NhanVien
{
    public partial class rpt_nhanvien : Form
    {
        DataTable dt;
        private string s1,s2,s4;
        public rpt_nhanvien()
        {
            InitializeComponent();
        }

        public rpt_nhanvien(string s1, string s2,string s4)
        {
            this.s1 = s1; //ten bo phan
            this.s2 = s2; //ten chuc vu
            this.s4 = s4;
            InitializeComponent();
        }
        public string THANG { get; set; }
        public string NAM { get; set; }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            if (s4 == "1")  //nhan vien chua co HD, BH=tat ca
            {
                dt = BUS_Report.HetHD(s1, s2);
            }
            else if (s4 == "0") // co HD , BH = tat ca
            {
                dt = BUS_Report.conHD(s1, s2);
            }
            else if (s4 == "3")//con hd da dong bh
            {
                dt = BUS_Report.conHD_dadongBH(s1, s2);
            }
            else if (s4 == "4")//con hd chua dong bh
            {
                dt = BUS_Report.conHD_chuadongBH(s1, s2);
            }

            else if (s4 == "5")//het hd da dong bh
            {
                dt = BUS_Report.HetHD_dadongBH(s1, s2);
            }
            else if (s4 == "6")//het hd chua dong bh
            {
                dt = BUS_Report.HetHD_chuadongBH(s1, s2);
            }
            else if (s4 == "7")//da dong BH
            {
                dt = BUS_Report.coBH(s1, s2);
            }
            else if (s4 == "8")//chua dong BH
            {
                dt = BUS_Report.hetBH(s1, s2);
            }
            else
                dt = BUS_Report.tatca(s1, s2);
            loadCrystalRpt(dt);
        }

        private void loadCrystalRpt(DataTable dt)
        {
            try
            {
                Report.rpt_BCNV_hetHD Rp = new Report.rpt_BCNV_hetHD();
                Rp.SetDataSource(dt);
                crystalReportViewer1.ReportSource = Rp;
            }
            catch
            {
                MessageBox.Show("Kết nối với máy chủ thất bại", "Chú ý", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rpt_nhanvien_Load(object sender, EventArgs e)
        {
            if (s4 == "1")  //nhan vien chua co HD, BH=tat ca
            {
                dt = BUS_Report.HetHD(s1, s2);
            }
            else if (s4 == "0") // co HD , BH = tat ca
            {
                dt = BUS_Report.conHD(s1, s2);
            }
            else if (s4 == "3")//con hd da dong bh
            {
                dt = BUS_Report.conHD_dadongBH(s1, s2);
            }
            else if (s4 == "4")//con hd chua dong bh
            {
                dt = BUS_Report.conHD_chuadongBH(s1, s2);
            }

            else if (s4 == "5")//het hd da dong bh
            {
                dt = BUS_Report.HetHD_dadongBH(s1, s2);
            }
            else if (s4 == "6")//het hd chua dong bh
            {
                dt = BUS_Report.HetHD_chuadongBH(s1, s2);
            }
            else if (s4 == "7")//da dong BH
            {
                dt = BUS_Report.coBH(s1, s2);
            }
            else if (s4 == "8")//chua dong BH
            {
                dt = BUS_Report.hetBH(s1, s2);
            }
            else
                dt = BUS_Report.tatca(s1, s2);
            loadCrystalRpt(dt);
        }
    }
}