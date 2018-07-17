using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
namespace QLNhanSu
{
    public partial class frmBangluong : DevExpress.XtraEditors.XtraForm
    {
        public frmBangluong()
        {
            InitializeComponent();
        }
        #region load
        private void frmBangluong_Load(object sender, EventArgs e)
        {
            loadFrom();
        }
        public void loadFrom()
        {
            for (int i = 1; i <= 12; i++)
            {
                cmbThang.Items.Add(i.ToString());
            }
            cmbThang.SelectedItem = DateTime.Now.Month.ToString();
            for (int i = 1990; i <= DateTime.Now.Year; i++)
            {
                cmbNam.Items.Add(i.ToString());
            }
            cmbNam.SelectedItem = DateTime.Now.Year.ToString();
        }
       #endregion

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void xem()
        {
            gridBangluong.DataSource = BUS_Bangluong.selectBangluong(cmbThang.Text, cmbNam.Text);
            lbManv.DataBindings.Clear();
            lbManv.DataBindings.Add("Text", gridBangluong.DataSource, "Mã nhân viên");
        }
        private void btXem_Click(object sender, EventArgs e)
        {
            xem();
        }

        private void btChitiet_Click(object sender, EventArgs e)
        {
            if (gridBangluong.MainView.RowCount > 0)
            {
                Report.frm_rptBangluongTungNhanvien frm = new Report.frm_rptBangluongTungNhanvien(lbManv.Text, cmbThang.Text, cmbNam.Text);
                frm.Show();
            }
        }
    }
}