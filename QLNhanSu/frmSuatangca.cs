using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DTO;
namespace QLNhanSu
{
    public partial class frmSuatangca : DevExpress.XtraEditors.XtraForm
    {
        public delegate void Reload();
        public Reload reload;
        private string manv;
        private string tenca;
        private Tangca tc = new Tangca();
        public frmSuatangca()
        {
            InitializeComponent();
        }
        public frmSuatangca(string manv)
        {
            InitializeComponent();
            this.manv = manv;
            txtManv.Text = manv;
            txtManv.Enabled = false;
            date_ngaycong.Enabled = true;

        }

        public frmSuatangca(Tangca tc,string tenca)
        {
            InitializeComponent();
            this.manv = tc.Manv;
            txtManv.Text = manv;
            txtManv.Enabled = false;
            date_ngaycong.Enabled = true;
            date_ngaycong.DateTime = DateTime.Parse(tc.Ngay + "/" + tc.Thang + "/" + tc.Nam);
            this.tenca = tenca;
            txtSogio.Text = tc.Sogio;
            this.tc = tc;
        }
        private void frmSuatangca_Load(object sender, EventArgs e)
        {
            cmbLoaica.Items.Add("Tăng ca ngày chủ nhật");
            cmbLoaica.Items.Add("Tăng ca đêm");
            cmbLoaica.Items.Add("Tăng ca ngày lễ");
            cmbLoaica.Items.Add("Tăng ca ngày thường");
            cmbLoaica.SelectedItem = tenca;
        }
        private void txtSogio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void date_ngaycong_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtSogio_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSogio.Text != "")
            {
                if (int.Parse(txtSogio.Text.ToString()) < 1 || int.Parse(txtSogio.Text.ToString()) > 12)
                {
                    txtSogio.ForeColor = Color.Red;
                    txtSogio.ToolTip = "Số giờ không hợp lệ";
                }
                else
                {
                    txtSogio.ForeColor = Color.DodgerBlue;
                    txtSogio.ToolTip = "Nhập số giờ";
                }
            }
        }

        #region update
        public bool kt_Luu()
        {
            bool kt = true;
            if (date_ngaycong.Text == "" || txtSogio.Text == "")
            {
                kt = false;
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

                // kiem tra thay doi ngay cua thang
            else if(date_ngaycong.DateTime.Day.ToString() != tc.Ngay || date_ngaycong.DateTime.Month.ToString() !=tc.Thang || 
                date_ngaycong.DateTime.Year.ToString() !=tc.Nam )
            {
                if (!BUS_Tangca.kt_tangca_trung(txtManv.Text, date_ngaycong.DateTime))
                {
                    kt = false;
                    MessageBox.Show("Nhân viên " + txtManv.Text + " đã tăng ca ngày " + date_ngaycong.Text + " rồi",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (BUS_Bangcong.kiemtra_ngaycong_trung(txtManv.Text, date_ngaycong.DateTime))
            {
                kt = false;
                MessageBox.Show("Ngày " + date_ngaycong.Text + " nhân viên có mã " + txtManv.Text + " không đi làm, nên không được tăng ca", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (int.Parse(txtSogio.Text.ToString()) < 0 || int.Parse(txtSogio.Text.ToString()) > 12)
            {
                kt = false;
                MessageBox.Show("Số giờ quá giới hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return kt;
        }
        private void update()
        {
            if (kt_Luu())
            {
                DTO.Tangca tc_new = new DTO.Tangca();
                tc_new.Manv = txtManv.Text;
                if (cmbLoaica.Text == "Tăng ca ngày chủ nhật")
                    tc_new.Maloaica = "tccn";
                if (cmbLoaica.Text == "Tăng ca đêm")
                    tc_new.Maloaica = "tcd";
                if (cmbLoaica.Text == "Tăng ca ngày lễ")
                    tc_new.Maloaica = "tcl";
                if (cmbLoaica.Text == "Tăng cả ngày thường")
                    tc_new.Maloaica = "tct";
                tc_new.Ngay = date_ngaycong.DateTime.Day.ToString();
                tc_new.Thang = date_ngaycong.DateTime.Month.ToString();
                tc_new.Nam = date_ngaycong.DateTime.Year.ToString();
                tc_new.Sogio = txtSogio.Text;
                if (BUS_Tangca.update(tc,tc_new) == "true")
                {
                    //MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reload();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại từ lỗi hệ thống, hãy liên hệ với bộ phận kỹ thuật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void luu()
        {
            update();
        }
        private void btCapnhat_Click(object sender, EventArgs e)
        {
            luu();
        }

        #endregion

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void date_ngaycong_KeyDown(object sender, KeyEventArgs e)
        {
            //if (BUS_Bangcong.kiemtra_ngaycong_trung(txtManv.Text, date_ngaycong.DateTime) || !BUS_Tangca.kt_tangca_trung(txtManv.Text, date_ngaycong.DateTime))
            //{
            //    date_ngaycong.ForeColor = Color.Red;
            //}
            //else
            //    date_ngaycong.ForeColor = Color.DodgerBlue;
        }

        
    }
}