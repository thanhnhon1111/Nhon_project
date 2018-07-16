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
    public partial class frmNhanvienditre : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanvienditre()
        {
            InitializeComponent();
        }

        private void addThangNam()
        {
            //thang
            cbm_thang.Items.Add("----Chọn tháng----");
            for (int i = 1; i <= 12; i++)
            {
                cbm_thang.Items.Add(i);
            }
            cbm_thang.SelectedItem = "----Chọn tháng----";

            // nam
            cbm_nam.Items.Add("----Chọn năm----");
            for (int i = 1980; i <= DateTime.Now.Year; i++)
            {
                cbm_nam.Items.Add(i);
            }
            cbm_nam.SelectedItem = "----Chọn năm----";

            // gio 
            for (int i = 0; i <= 23; i++)
            {
                cmbGio.Items.Add(i);
            }

            //phut 
            for (int i = 0; i <= 59; i++)
            {
                cmbPhut.Items.Add(i);
            }
        }

        public string THANG { get; set; }
        public string NAM { get; set; }
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
            if (cmbGio.Text == "" || cmbPhut.Text == "" || cbm_thang.Text=="" || cbm_nam.Text=="")
            {
                kt = false;
                MessageBox.Show("Hãy nhập tháng và năm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!kt_songuyen(cmbGio.Text) || !kt_songuyen(cmbPhut.Text) || !kt_songuyen(cbm_thang.Text) || !kt_songuyen(cbm_nam.Text))
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
                    THANG = cbm_thang.Text;
                    NAM = cbm_nam.Text;
                    rpt_Nhanvienditre Rp = new rpt_Nhanvienditre();
                    DataTable ds = BUS.BUS_Bangcong.Nhanvienditre(cmbGio.Text, cmbPhut.Text, cbm_thang.Text, cbm_nam.Text);
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
            }
            catch
            {
                MessageBox.Show("Kết nối với máy chủ thất bại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmNhanvienditre_Load(object sender, EventArgs e)
        {
            addThangNam();
        }

        private void Xem_Click_1(object sender, EventArgs e)
        {
            loadCrystalRpt();
        }

        private void bt_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}