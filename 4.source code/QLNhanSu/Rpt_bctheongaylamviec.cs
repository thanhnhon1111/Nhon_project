using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CrystalDecisions.Shared;
using System.Data.SqlClient;

namespace QLNhanSu
{
    public partial class Rpt_bctheongaylamviec : DevExpress.XtraEditors.XtraForm
    {
        public Rpt_bctheongaylamviec()
        {
            InitializeComponent();
        }
        private void addThangNam()
        {

            cbm_thang.Items.Add("----Chọn tháng----");
            for (int i = 1; i <= 12; i++)
            {
                cbm_thang.Items.Add(i);
            }
            cbm_thang.SelectedItem = "----Chọn tháng----";
            for (int i = 1980; i <= DateTime.Now.Year; i++)
            {
                cbm_nam.Items.Add(i);
            }
            cbm_nam.SelectedItem = DateTime.Now.Year;
        }

        public string THANG { get; set; }
        public string NAM { get; set; }

        private void Rpt_bctheongaylamviec_Load(object sender, EventArgs e)
        {       
            addThangNam();
        }

        private void loadCrystalRpt()
        {
            try
            {
                THANG = cbm_thang.Text;
                NAM = cbm_nam.Text;
                CrystalReport1 Rp = new CrystalReport1();
                /*ds_ngayvaolam ds = new ds_ngayvaolam();
                Report_NhanVien_ngaylamviecTableAdapter ngay = new Report_NhanVien_ngaylamviecTableAdapter();
                ngay.Fill(ds.Report_NhanVien_ngaylamviec);*/

                DataTable ds = BUS.BUS_Nhanvien.baocaonvvaolamtheongay();
                Rp.SetDataSource(ds);
                Rp.SetParameterValue("nam", Int32.Parse(NAM));
                if (cbm_thang.Text == "----Chọn tháng----")
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
                MessageBox.Show("Kết nối với máy chủ thất bại","Chú ý",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void Xem_Click(object sender, EventArgs e)
        {
            loadCrystalRpt();
        }

        private void bt_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}