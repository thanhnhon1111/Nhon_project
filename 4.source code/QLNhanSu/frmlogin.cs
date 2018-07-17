using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using System.Net;
using BUS;
namespace QLNhanSu
{
    public partial class frmlogin : DevExpress.XtraEditors.XtraForm
    {

        public frmlogin()
        {
            InitializeComponent();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            if (!BUS_hethong.KT_ketnoi())
            {
                frmRestore frm = new frmRestore(1);
                frm.reload = new frmRestore.Reload(hien);
                frm.Show();
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                txtUser.Text = BUS_hethong.nhoTaikhoan();
                if (txtUser.Text == "")
                    checkLuutaikhoanlogin.Checked = false;
                else
                    checkLuutaikhoanlogin.Checked = true;
            }
        }

        private void hien()
        {
            this.WindowState = FormWindowState.Normal;
        }


        public void thoat1()
        {

            Show();
            txtUser.Text = "";
            txtPass.Text = "";
        }
        #region dang nhap
        public void Dangnhap()
        {
            DataTable dt = BUS_hethong.dangnhap(txtUser.Text, txtPass.Text);
            if (dt.Rows.Count > 0)
            {
                if (checkLuutaikhoanlogin.Checked == true)
                    BUS_hethong.setnhotaikhoan(txtUser.Text);
                else
                    BUS_hethong.setnhotaikhoan("");
                frmMainForm frm = new frmMainForm(dt);
                frm.thoat = new frmMainForm.Thoat(thoat1);
                frm.Show();
                Hide();
            }
            else
            {
                lbCanhbao.Visible = true;
                image_canhbao.Visible = true;
            }
        }

        private void bt_Dangnhap_Click(object sender, EventArgs e)
        {
            Dangnhap();
        }
        #endregion
        
        
        #region moveMouse_From
        private void frmlogin_Move(object sender, EventArgs e)
        {
            this.Text = "Form screen position = " + this.Location.ToString();
        }
        public Point mouse_offset;
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }
        private void frmlogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
            }
        } 
        #endregion
        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void thoat()
        {
            this.Close();
        }
        private void txtServer_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Dangnhap();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Dangnhap();
            }
        }

        private void pictureEdit4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}