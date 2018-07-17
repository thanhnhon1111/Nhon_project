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
    public partial class frmThemCmndChitiet : DevExpress.XtraEditors.XtraForm
    {
        private DateTime ngaysinh;
        private string cmnd, noicap;
        private DateTime ngaycap;
        public delegate void Getstring(string scmnd,string noicap,DateTime ngaycap);
        public Getstring Myget;

        public frmThemCmndChitiet()
        {
            InitializeComponent();
        }
        public frmThemCmndChitiet(DateTime ngaysinh,string cmnd, string noicap, DateTime ngaycap)
        {
            this.cmnd = cmnd;
            this.noicap = noicap;
            this.ngaycap = ngaycap;
            this.ngaysinh = ngaysinh;
            InitializeComponent();
        }
        private void frmThemCmndChitiet_Load(object sender, EventArgs e)
        {
            txtcmnd.Text = cmnd;
            dateNgaycap.DateTime = ngaycap;
            LoadComboboxTinh();
            cmbTinh.SelectedItem = noicap;
            if (txtcmnd.Text == "")
            {
                image_cmnd_no.Visible = true;
                image_cmnd_yes.Visible = false;
                txtcmnd.ToolTip = "Nơi cấp chứng minh nhân dân";
            }
            else
            {
                image_cmnd_no.Visible = false;
                image_cmnd_yes.Visible = true;
                txtcmnd.ToolTip = "Nơi cấp chứng minh nhân dân";
            }
        }
        private void LoadComboboxTinh()
        {
            List<Tinh> tinh = new List<Tinh>();
            tinh = BUS.BUS_Tinh.selectTinh();
            cmbTinh.Items.Add("--Chọn nơi cấp--");
            for (int i = 0; i < tinh.Count; i++)
            {
                cmbTinh.Items.Add(tinh[i].Tentinh);
                cmbTinh.ValueMember = tinh[i].Id;
                cmbTinh.DisplayMember = tinh[i].Id;
            }
            cmbTinh.SelectedItem = "--Chọn nơi cấp--";
        }
        public bool KT_Ngay(DateTime ngay1, DateTime ngay2)
        {
            int ngayht = ngay2.Day;
            int thanght = ngay2.Month;
            int namht = ngay2.Year;
            int ngay = ngay1.Day;
            int thang = ngay1.Month;
            int nam = ngay1.Year;
            bool hople = false;
            if (nam + 15 <= namht)
            {
                if (nam + 15 == namht)
                {
                    if (thang >= thanght)
                    {
                        if (thang == thanght)
                        {
                            if (ngay >= ngayht)
                            {
                                hople = true;
                            }
                            else hople = false;
                        }
                        else hople = true;
                    }
                    else hople = false;
                }
                else hople = true;
            }
            else hople = false;
            return hople;
        }
        private void txtcmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtcmnd_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtcmnd.Text == "")
            {
                image_cmnd_no.Visible = true;
                image_cmnd_yes.Visible = false;
                txtcmnd.ToolTip = "Nơi cấp chứng minh nhân dân";
            }
            else if (txtcmnd.Text.Length >= 11)
            {
                image_cmnd_no.Visible = true;
                image_cmnd_yes.Visible = false;
                txtcmnd.ToolTip = "Độ dài số chứng minh này không hợp lệ";
            }
            else if (!BUS.BUS_ChitietChungminhnhandan.KiemTraTrung(txtcmnd.Text))
            {
                image_cmnd_no.Visible = true;
                image_cmnd_yes.Visible = false;
                txtcmnd.ToolTip = "Số chứng minh nhân dân này đã tồn tại";
            }
            else
            {
                image_cmnd_no.Visible = false;
                image_cmnd_yes.Visible = true;
                txtcmnd.ToolTip = "Nơi cấp chứng minh nhân dân";
            }
        }

        private void cmbTinh_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbTinh.Text == "--Chọn nơi cấp--")
            {
                image_noicap_no.Visible = true;
                image_noicap_yes.Visible = false;
            }
            else
            {
                image_noicap_no.Visible = false;
                image_noicap_yes.Visible = true;
            }
        }

        private void dateNgaycap_EditValueChanged(object sender, EventArgs e)
        {
            if (dateNgaycap.Text == "")
            {
                image_ngaycap_no.Visible = true;
                image_ngaycap_yes.Visible = false;
                dateNgaycap.ToolTip = "Lỗi! Chọn ngày cấp cho nhân viên";
            }
            else
            {
                bool hople = KT_Ngay(ngaysinh, DateTime.Parse(dateNgaycap.Text));
                if (!hople)
                {
                    image_ngaycap_no.Visible = true;
                    image_ngaycap_yes.Visible = false;
                    dateNgaycap.ToolTip = "Lỗi! Nhân viên không đủ 15 tuổi để cấp chứng minh này";
                }
                else if (dateNgaycap.DateTime > DateTime.Now)
                {
                    image_ngaycap_no.Visible = true;
                    image_ngaycap_yes.Visible = false;
                    dateNgaycap.ToolTip = "Lỗi! Ngày cấp đã lớn hơn ngày hiện tại";
                }
                else
                {
                    image_ngaycap_no.Visible = false;
                    image_ngaycap_yes.Visible = true;
                    dateNgaycap.ToolTip = "Chọn ngày cấp chứng minh nhân dân cho nhân viên";
                }
            }
        }
        public bool kiemtraTontai=true;
        public bool KT_Hople()
        {
            bool hl = true;
            if (txtcmnd.Text == "")
            {
                hl = false;
                MessageBox.Show("Số chứng minh nhân dân không được để trống","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (txtcmnd.Text.Length >= 11)
            {
                hl = false;
                MessageBox.Show("Bạn nhập quá giới hạn cho phép", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbTinh.Text == "--Chọn nơi cấp--")
            {
                hl = false;
                MessageBox.Show("Hãy chọn nơi cấp chứng minh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateNgaycap.Text == "")
            {
                hl = false;
                MessageBox.Show("Hãy chọn ngày cấp chứng minh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!KT_Ngay(ngaysinh,DateTime.Parse(dateNgaycap.Text)))
            {
                hl = false;
                MessageBox.Show("Ngày cấp không hợp lệ với ngày sinh khi chưa đủ 15 tuổi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!BUS.BUS_ChitietChungminhnhandan.KiemTraTrung(txtcmnd.Text))
            {
                if (MessageBox.Show("Số chứng minh này đã tồn tại, bạn có muốn thay đổi không", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    kiemtraTontai = false;
                }
            }
            else if (dateNgaycap.DateTime > DateTime.Now)
            {
                hl = false;
                MessageBox.Show("Ngày cấp không được lớn hơn ngày hiện tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return hl;

        }
        private bool kt = false;
        private void btCapnhat_Click(object sender, EventArgs e)
        {
            if (KT_Hople())
            {
                kt = true;
                ChungminhChitiet cm = new ChungminhChitiet();
                cm.Socmnd = txtcmnd.Text;
                cm.Noicap = cmbTinh.Text;
                cm.Ngaycap = dateNgaycap.Text;
                if (kiemtraTontai)
                {
                    BUS.BUS_ChitietChungminhnhandan.insertCMND(cm);
                }
                else
                {
                    BUS.BUS_ChitietChungminhnhandan.updateCMND(cm);
                }
                Myget(txtcmnd.Text,cmbTinh.Text,dateNgaycap.DateTime);
                this.Close();
            }
        }

        private void frmThemCmndChitiet_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!kt)
                Myget(cmnd,noicap,dateNgaycap.DateTime);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }   

    }
}