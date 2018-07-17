using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
namespace QLNhanSu
{
    public partial class frmBaocaoNV : DevExpress.XtraEditors.XtraForm
    {
        public frmBaocaoNV()
        {
            InitializeComponent();
        }


        private void frmBaocaoNV_Load(object sender, EventArgs e)
        {
            LoadThongtin();
        }
        private void LoadThongtin()
        {
            // load combobox bo phan
            cmbBophan.Items.Add("Tất cả");
            cmbBophan.SelectedItem = "Tất cả";
            List<DTO.Bophan> bophan = new List<Bophan>();
            bophan = BUS.BUS_Bophan.compoboxBophan();
            for (int i = 0; i < bophan.Count; i++)
            {
                cmbBophan.Items.Add(bophan[i].Tenbophan);
            }
            // load combobox chuc vu
            cmbChucvu.Items.Add("Tất cả");
            cmbChucvu.SelectedItem = "Tất cả";
            List<DTO.ChucVu> chucvu = new List<ChucVu>();
            chucvu = BUS.BUS_Chucvu.selectChucvu();
            for (int i = 0; i < chucvu.Count; i++)
            {
                cmbChucvu.Items.Add(chucvu[i].Tenchucvu);
            }
        }

        private void cmbBophan_SelectedValueChanged(object sender, EventArgs e)
        {

        }

#region report nhan vien
        
        private void bt_xem_Click(object sender, EventArgs e)
        {
            string s1 = cmbBophan.Text, s2 = cmbChucvu.Text, s4 = "";
            if (hopdong_radio.SelectedIndex == 0 && baohiem_radio.SelectedIndex==2)
                s4 = "0";   //co HD 
            if (hopdong_radio.SelectedIndex == 1 && baohiem_radio.SelectedIndex == 2)
                s4 = "1";   // chua có HD
            if (hopdong_radio.SelectedIndex == 2 && baohiem_radio.SelectedIndex == 2)
                s4 = "2";  //ko quan tam HD - BH

            if (cmbBophan.Text == "Tất cả")
                s1 = "%";
            if (cmbChucvu.Text == "Tất cả")
                s2 = "%";

            if (baohiem_radio.SelectedIndex == 0 && hopdong_radio.SelectedIndex == 0) //con hd da dong bh
                s4 = "3"; 
            if (baohiem_radio.SelectedIndex == 1 && hopdong_radio.SelectedIndex == 0) //con hd chua dong bh
                s4 = "4";

            if (baohiem_radio.SelectedIndex == 0 && hopdong_radio.SelectedIndex == 1) //het hd da dong bh
                s4 = "5";
            if (baohiem_radio.SelectedIndex == 1 && hopdong_radio.SelectedIndex == 1) //het hd chua dong bh
                s4 = "6";
            if (baohiem_radio.SelectedIndex == 0 && hopdong_radio.SelectedIndex == 2) //da dong BH
                s4 = "7";
            if (baohiem_radio.SelectedIndex == 1 && hopdong_radio.SelectedIndex == 2)//chua dong BH
                s4 = "8";

            Report_NhanVien.rpt_nhanvien frm = new Report_NhanVien.rpt_nhanvien(s1,s2,s4);
            frm.Show();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
#endregion

        private void hopdong_radio_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}