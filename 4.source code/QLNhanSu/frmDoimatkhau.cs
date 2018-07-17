using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLNhanSu
{
    public partial class frmDoimatkhau : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        #region contrustor
        public frmDoimatkhau()
        {
            InitializeComponent();
        }
        public frmDoimatkhau(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }
        #endregion
        #region load
        private void frmDoimatkhau_Load(object sender, EventArgs e)
        {

        }
        #endregion
        #region kiem tra truoc khi thuc thi
        private bool kiemtra()
        {
            if (txt_passCu.Text == "" || txt_passMoi.Text == "" || txt_xacNhan.Text == "")
            {
                lb_loi.Text = "Hãy nhập đầy đủ thông tin.";
                return false;
            }
            else if (txt_passCu.Text != dt.Rows[0]["matkhau"].ToString())
            {
                lb_loi.Text = "Mật khẩu hiện tại không chính xác.";
                return false;
            }
            else if (txt_passMoi.Text != txt_xacNhan.Text)
            {
                lb_loi.Text = "Mật khẩu xác nhận không khớp.";
                return false;
            }
            lb_loi.Text = "";
            return true;
        }
        #endregion
        #region cap nhat
        private void capnhat()
        {
            if (kiemtra())
            {
                BUS.BUS_hethong.updateTaikhoan("", dt.Rows[0]["ten"].ToString(), dt.Rows[0]["ten"].ToString(), txt_passMoi.Text, dt.Rows[0]["quyen"].ToString());
                this.Close();
            }
        }
        private void bt_capNhat_Click(object sender, EventArgs e)
        {
            capnhat();
        }
        #endregion
        #region cac su kien
        private void bt_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_passCu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                capnhat();
            }
        }

        private void txt_passMoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                capnhat();
            }
        }

        private void txt_xacNhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                capnhat();
            }
        }
        #endregion
    }
}