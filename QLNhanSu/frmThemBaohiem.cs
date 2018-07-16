using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QLNhanSu
{
    public partial class frmThemBaohiem : Form
    {
        public delegate void GetString();
        public GetString MygetData;
        private string manv;
        private string hoten;
        public frmThemBaohiem()
        {
            InitializeComponent();
        }
        public frmThemBaohiem(string manv1,string ho, string ten)
        {
            this.hoten = ho +" "+ ten;
            this.manv = manv1;
            //lbTennv.Text = hoten;
            InitializeComponent();
        }
        private void Them_Baohiem_Load(object sender, EventArgs e)
        {
            lbTennv.Text = hoten;
            image_no_sbh.Visible = image_yes_sbh.Visible = false;
            image_no_nk.Visible = image_yes_nk.Visible = false;
            image_no_nc.Visible = image_yes_nc.Visible = false;
            cbloaibaohiem.Items.Add("Bảo hiểm y tế");
            cbloaibaohiem.Items.Add("Bảo hiểm tai nạn");
            cbloaibaohiem.Text = "Bảo hiểm y tế";
            btCapnhat.Select();
            trangThai(); // trang thai iamge_no
        }


        #region KiemTraHople
        private bool KT_ThemBaohiem()
        {
            if (BUS.BUS_Baohiem.kiemtraSobaohiemTontai(sobaohiemTextEdit.Text))
            {

                MessageBox.Show("Số bảo hiểm đã tồn tại, bạn hãy thay đổi số bảo hiểm khác", "Chú ý");
            }
            else if (sobaohiemTextEdit.Text == "" || ngaycapDateEdit.Text == "" || noicapTextEdit.Text == "" || noikhambenhTextEdit.Text == "")
            {
                
                MessageBox.Show("Thông tin không được để trống", "Thông báo");
                return false;
            }
            else if (sobaohiemTextEdit.Text.Length >= 15)
            {

                MessageBox.Show("Số bảo hiểm không được quá 15 ký tự", "Thông báo");
                return false;
            }
            else if (noicapTextEdit.Text.Length >= 70)
            {

                MessageBox.Show("Nơi cấp bảo hiểm không được quá 70 ký tự", "Thông báo");
                return false;
            }
            else if (noikhambenhTextEdit.Text.Length >= 70)
            {

                MessageBox.Show("Nơi khám bệnh không được quá 70 ký tự", "Thông báo");
                return false;
            }
            return true;
        }
        #endregion
        #region Thembaohiem
        private void insertBaohiem()
        {

                if (KT_ThemBaohiem())
                {
                    DMBaohiem bh = new DMBaohiem();
                    bh.Sobaohiem = sobaohiemTextEdit.Text;
                    if (cbloaibaohiem.Text == "Bảo hiểm y tế")
                        bh.Loaibaohiem = "yt";
                    else
                        bh.Loaibaohiem = "tn";
                    bh.Ngaycap = ngaycapDateEdit.Text;
                    bh.Ngaynghiviec = "";
                    bh.Noicap = noicapTextEdit.Text;
                    bh.Noikhambenh = noikhambenhTextEdit.Text;
                    if (BUS_Baohiem.insertBaohiem(bh, manv) == "true")
                    {
                        MessageBox.Show("Đã thêm thành công bảo hiểm cho nhân viên:" + hoten + "", "Thông báo");
                        MygetData();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Chú ý, Thêm thông tin thất bại", "chú ý");
                }
        }
        #endregion
        #region moveMouse_From
        /*private void Them_Baohiem_Move(object sender, EventArgs e)
        {
            this.Text = "Form screen position = " + this.Location.ToString();
        }
        public Point mouse_offset;
        private void Them_Baohiem_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void Them_Baohiem_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
            }
        }*/
        #endregion
        #region cacSukienKey
        private void btCapnhat_Click(object sender, EventArgs e)
        {
            insertBaohiem();
        }

        private void sobaohiemTextEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if (BUS_Baohiem.kiemtraSobaohiemTontai(sobaohiemTextEdit.Text))
            {
                image_no_sbh.Visible = true;
                image_yes_sbh.Visible = false;
                sobaohiemTextEdit.ToolTip = "Số bảo hiểm này đã tồn tại";
            }
            else if (sobaohiemTextEdit.Text == "")
            {
                image_no_sbh.Visible = true;
                image_yes_sbh.Visible = false;
                sobaohiemTextEdit.ToolTip = "Số bảo hiểm không được để trống";
            }
            else if (sobaohiemTextEdit.Text.Length >= 15)
            {
                image_no_sbh.Visible = true;
                image_yes_sbh.Visible = false;
                sobaohiemTextEdit.ToolTip = "Số bảo hiểm không được quá 15 ký tự";
            }
            else
            {
                image_no_sbh.Visible = false;
                image_yes_sbh.Visible = true;
                sobaohiemTextEdit.ToolTip = "Hãy nhập vào số bảo hiểm";
            }
            if (e.KeyCode == Keys.Enter) { btCapnhat.Select(); }
        }
        private void noicapTextEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if (noicapTextEdit.Text.Length >= 70)
            {
                image_no_nc.Visible = true;
                image_yes_nc.Visible = false;
                noicapTextEdit.ToolTip = "Bạn đã nhập quá 15 ký tự";
            }
            else if (noicapTextEdit.Text == "")
            {
                image_no_nc.Visible = true;
                image_yes_nc.Visible = false;
                sobaohiemTextEdit.ToolTip = "Bạn không được để trống thông tin này";
            }
            else
            {
                image_no_nc.Visible = false;
                image_yes_nc.Visible = true;
                sobaohiemTextEdit.ToolTip = "Nhập nơi cấp bảo hiểm";
            }
        }
        private void noikhambenhTextEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if (noikhambenhTextEdit.Text.Length >= 70)
            {
                image_no_nk.Visible = true;
                image_yes_nk.Visible = false;
                sobaohiemTextEdit.ToolTip = "Bạn đã nhập quá 70 ký tự";
            }
            else if (noikhambenhTextEdit.Text == "")
            {
                image_no_nk.Visible = true;
                image_yes_nk.Visible = false;
                sobaohiemTextEdit.ToolTip = "Bạn không được để trống thông tin này";
            }
            else
            {
                image_no_nk.Visible = false;
                image_yes_nk.Visible = true;
                sobaohiemTextEdit.ToolTip = "Nhập nơi khám bệnh";
            }
        }
        private void ngaycapDateEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { btCapnhat.Select(); }
        }
        #endregion 
        #region buttion_Huy
        private void btHuy_Click(object sender, EventArgs e)
        {
            sobaohiemTextEdit.Text = "";
            noikhambenhTextEdit.Text = "";
            noicapTextEdit.Text = "";
        }
        #endregion
        #region ButtionThoat
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region ButtionThem
        private void Them_Baohiem_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter){btCapnhat.Select();}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        #region iamgeThoat
        private void cbloaibaohiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { btCapnhat.Select(); }
        }
        #endregion
        #region Trangthay
        private void trangThai()
        {
            image_no_nc.Visible = true;
            image_no_nk.Visible=true;
            image_no_sbh.Visible = true;
        }
        #endregion

        private void sobaohiemTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
