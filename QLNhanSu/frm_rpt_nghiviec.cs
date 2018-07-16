using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLNhanSu.ds_nghiviecTableAdapters;

namespace QLNhanSu
{
    public partial class frm_rpt_nghiviec : Form
    {
        public frm_rpt_nghiviec()
        {
            InitializeComponent();
        }

        private void frm_rpt_nghiviec_Load(object sender, EventArgs e)
        {
            addThangNam();
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

        private void loadCrystalRpt()
        {

            THANG = cbm_thang.Text;
            NAM = cbm_nam.Text;
            rpt_nghiviec Rp = new rpt_nghiviec();
            ds_nghiviec ds = new ds_nghiviec();
            Report_NhanVien_nghiviecTableAdapter ngay = new Report_NhanVien_nghiviecTableAdapter();
            ngay.Fill(ds.Report_NhanVien_nghiviec);
            //DataSet ds = BUS.BUS_Nhanvien.baocaonghiviectheongay();
            Rp.SetDataSource(ds);
            Rp.SetParameterValue("nam", Int32.Parse(NAM));
            if (cbm_thang.Text == "----Chọn tháng----")
            {
                THANG = "0";
                Rp.SetParameterValue("ngay_thang", "NĂM " + NAM + " ");
            }
            else
            {
                Rp.SetParameterValue("ngay_thang", "THÁNG " + THANG + " - " + NAM + "  ");
            }
            Rp.SetParameterValue("thang", Int32.Parse(THANG));
            rpt_nghiviec.ReportSource = Rp;
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
