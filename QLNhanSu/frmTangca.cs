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
    public partial class frmThemtangca : DevExpress.XtraEditors.XtraForm
    {
        public delegate void Reload();
        public Reload reload;
        private string manv;
        public frmThemtangca()
        {
            InitializeComponent();
        }
        public frmThemtangca(string manv)
        {
            InitializeComponent();
            this.manv = manv;
            txtManv.Text = manv;
            txtManv.Enabled = false;
            date_ngaycong.Enabled = true;

        }
        private void frmThemtangca_Load(object sender, EventArgs e)
        {
            cmbLoaica.Items.Add("Tăng ca ngày chủ nhật");
            cmbLoaica.Items.Add("Tăng ca đêm");
            cmbLoaica.Items.Add("Tăng ca ngày lễ");
            cmbLoaica.Items.Add("Tăng cả ngày thường");
            cmbLoaica.SelectedItem = "Tăng cả ngày thường";
        }
        public bool kt_Them()
        {
            bool kt = true;
            if (txtManv.Text == "" || date_ngaycong.Text == "" || txtSogio.Text == "")
            {
                kt = false;
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (BUS_Nhanvien.KiemTraMaNV(txtManv.Text) == "true")
            {
                kt = false;
                MessageBox.Show("Mã nhân viên không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            else if (!BUS_Tangca.kt_tangca_trung(txtManv.Text, date_ngaycong.DateTime))
            {
                kt = false;
                MessageBox.Show("Nhân viên " + txtManv.Text + " đã tăng ca ngày " + date_ngaycong.Text + " rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return kt;
        }

        private void txtSogio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtManv_KeyUp(object sender, KeyEventArgs e)
        {
            if (BUS_Nhanvien.KiemTraMaNV(txtManv.Text) == "true")
            {
                txtManv.ForeColor = Color.Red;
                txtManv.ToolTip = "Mã nhân viên không tồn tại";
                date_ngaycong.Enabled = false;
            }
            else
            {
                txtManv.ForeColor = Color.DodgerBlue;
                txtManv.ToolTip = "Nhập mã nhân viên";
                date_ngaycong.Enabled = true;
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
        private void insert()
        {
            if (kt_Them())
            {
                DTO.Tangca tc = new DTO.Tangca();
                tc.Manv = txtManv.Text;
                if (cmbLoaica.Text == "Tăng ca ngày chủ nhật")
                    tc.Maloaica = "tccn";
                if (cmbLoaica.Text == "Tăng ca đêm")
                    tc.Maloaica = "tcd";
                if (cmbLoaica.Text == "Tăng ca ngày lễ")
                    tc.Maloaica = "tcl";
                if (cmbLoaica.Text == "Tăng cả ngày thường")
                    tc.Maloaica = "tct";
                tc.Ngay = date_ngaycong.DateTime.Day.ToString();
                tc.Thang = date_ngaycong.DateTime.Month.ToString();
                tc.Nam = date_ngaycong.DateTime.Year.ToString();
                tc.Sogio = txtSogio.Text;
                if (BUS_Tangca.insert(tc) == "true")
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

        private void btLuu_Click(object sender, EventArgs e)
        {
            insert();
        }

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