using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
namespace QLNhanSu.Report
{
    public partial class frm_rptBangcong : DevExpress.XtraEditors.XtraForm
    {
        public frm_rptBangcong()
        {
            InitializeComponent();
        }

        private void frm_rptBangcong_Load(object sender, EventArgs e)
        {
            addThangNam();
        }

        private void addThangNam()
        {

            cmbThang.Items.Add("----Chọn tháng----");
            for (int i = 1; i <= 12; i++)
            {
                cmbThang.Items.Add(i);
            }
            cmbThang.SelectedItem = "----Chọn tháng----";
            for (int i = 1980; i <= DateTime.Now.Year; i++)
            {
                cmbNam.Items.Add(i);
            }
            cmbNam.SelectedItem = DateTime.Now.Year;
        }

        public string THANG { get; set; }
        public string NAM { get; set; }

        private void Rpt_bctheongaylamviec_Load(object sender, EventArgs e)
        {
            addThangNam();
        }
        public bool kt_songuyen(string val)
        {
            try
            {
                int s = int.Parse(val);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool kiemtra()
        {
            bool kt = true;
            if (cmbNam.Text == "" || cmbThang.Text == "")
            {
                kt = false;
                MessageBox.Show("Hãy nhập tháng và năm","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (!kt_songuyen(cmbThang.Text) || !kt_songuyen(cmbThang.Text))
            {
                kt = false;
                MessageBox.Show("Dữ liệu nhập vào phải là kiểu số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return kt;
        }
        private void loadCrystalRpt()
        {
            try
            {
                if (kiemtra())
                {
                    THANG = cmbThang.Text;
                    NAM = cmbNam.Text;
                    Report.rptBangcong Rp = new rptBangcong();

                    DataTable ds = BUS_Bangcong.selectAllBC(cmbThang.Text, cmbNam.Text);
                    Rp.SetDataSource(ds);
                    Rp.SetParameterValue("nam", Int32.Parse(NAM));
                    Rp.SetParameterValue("@nam", Int32.Parse(NAM));
                    if (cmbThang.Text == "----Chọn tháng----")
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
                    Rp.SetParameterValue("@thang", Int32.Parse(THANG));
                    crystalReportViewer1.ReportSource = Rp;
                }
            }
            catch
            {
                MessageBox.Show("Kết nối với máy chủ thất bại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            loadCrystalRpt();
        }
    }
}