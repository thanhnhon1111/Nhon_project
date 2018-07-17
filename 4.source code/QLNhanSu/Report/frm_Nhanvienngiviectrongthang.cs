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
    public partial class frm_Nhanvienngiviectrongthang : DevExpress.XtraEditors.XtraForm
    {
        public string THANG { get; set; }
        public string NAM { get; set; }
        public frm_Nhanvienngiviectrongthang()
        {
            InitializeComponent();
        }

        private void addThangNam()
        {

            cmb_thang.Items.Add("----Chọn tháng----");
            for (int i = 1; i <= 12; i++)
            {
                cmb_thang.Items.Add(i);
            }
            cmb_thang.SelectedItem = "----Chọn tháng----";
            for (int i = 1980; i <= DateTime.Now.Year; i++)
            {
                cmb_nam.Items.Add(i);
            }
            cmb_nam.SelectedItem = DateTime.Now.Year;
        }

        private void loadFull()
        {
            
            try
            {
                THANG = cmb_thang.Text;
                NAM = cmb_nam.Text;
                Report.Rpt_Nhanviennghiviectrongthang Rp = new Rpt_Nhanviennghiviectrongthang();
               //sua lai proc  
                DataTable ds = BUS.BUS_Nhanvien.rpt_nvNghiviecThang();
                Rp.SetDataSource(ds);
                Rp.SetParameterValue("nam", NAM);
                if (cmb_thang.Text == "----Chọn tháng----")
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
                crystalReportViewer1.ReportSource = Rp;
            }
            catch
            {
                MessageBox.Show("Kết nối với máy chủ thất bại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frm_Nhanvienngiviectrongthang_Load(object sender, EventArgs e)
        {
            addThangNam();
        }

        private void bt_xem_Click(object sender, EventArgs e)
        {
            loadFull();
        }


    }
}