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
    public partial class frmSuaBaohiem : DevExpress.XtraEditors.XtraForm
    {
        private string soBH_truoc;
        private string loaiBH;
        private string ngayCapBH;
        private string noiCapBH;
        private string noikhamBenh;
        private string ngayNghiviec;
        private string hoten;
        private string manv;
        public delegate void GetString();
        public GetString MyGetdata;
        public frmSuaBaohiem()
        {
            InitializeComponent();
        }
        public frmSuaBaohiem(DMBaohiem BH, string manv1, string ho, string ten)
        {
            this.manv = manv1;
            this.hoten = ho+" "+ten;
            this.soBH_truoc = BH.Sobaohiem;
            this.loaiBH = BH.Loaibaohiem;
            this.ngayCapBH = BH.Ngaycap;
            this.noiCapBH = BH.Noicap;
            this.noikhamBenh = BH.Noikhambenh;
            this.ngayNghiviec = BH.Ngaynghiviec;
            
            InitializeComponent();
        }
        private void frmSuaBaohiem_Load(object sender, EventArgs e)
        {
            lbTennv.Text = hoten;
            cbloaibaohiem.Items.Add("Bảo hiểm y tế");
            cbloaibaohiem.Items.Add("Bảo hiểm tai nạn");
            LoadThongTinVaoFrom();
            //btCapnhat.Select();
            trangThai(); // trang thai iamge_no
        }

        #region LoadThongTin
        private void LoadThongTinVaoFrom()
        {
            sobaohiemTextEdit.Text = soBH_truoc;
            cbloaibaohiem.Text = loaiBH;
            noicapTextEdit.Text = noiCapBH;
            ngaycapDateEdit.Text = ngayCapBH;
            noikhambenhTextEdit.Text = noikhamBenh;
            ngaynghiDateEdit.Text = ngayNghiviec;
            // tooltip
            sobaohiemTextEdit.ToolTip="Nhập vào số bảo hiểm";
            noicapTextEdit.ToolTip="Nhập vào nơi cấp thẻ bảo hiểm";
            ngaycapDateEdit.ToolTip="Chọn ngày cấp thẻ bảo hiểm";
            noikhambenhTextEdit.ToolTip="Nhập nơi khám bảo hiểm";
            ngaynghiDateEdit.ToolTip = "Chọn ngày nghĩ do đi khám bệnh từ bảo hiểm này";
        }
        #endregion
        #region KiemTraHople
        private bool KT_SuaBaohiem()
        {
            if (BUS.BUS_Baohiem.kiemtraSobaohiemTontai(sobaohiemTextEdit.Text))
            {
                if (soBH_truoc != sobaohiemTextEdit.Text)
                {
                    MessageBox.Show("Số bảo hiểm đã tồn tại, bạn hãy thay đổi số bảo hiểm khác", "Chú ý");
                    return false;
                }
            }
            if (sobaohiemTextEdit.Text == "" || ngaycapDateEdit.Text == "" || noicapTextEdit.Text == "" || noikhambenhTextEdit.Text == "")
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
        #region Suabaohiem
        private void updateBaohiem()
        {

            if (KT_SuaBaohiem())
            {
                DMBaohiem bh = new DMBaohiem();
                bh.Sobaohiem = sobaohiemTextEdit.Text;
                if (cbloaibaohiem.Text == "Bảo hiểm y tế")
                    bh.Loaibaohiem = "yt";
                else
                    bh.Loaibaohiem = "tn";
                bh.Ngaycap = ngaycapDateEdit.Text;
                bh.Noicap = noicapTextEdit.Text;
                bh.Noikhambenh = noikhambenhTextEdit.Text;
                bh.Ngaynghiviec = ngaynghiDateEdit.Text;
                if (BUS_Baohiem.updateBaohiem(bh, soBH_truoc) == "true")
                {
                    MessageBox.Show("Đã sửa thành công bảo hiểm cho nhân viên:" + hoten + "", "Thông báo");
                    MyGetdata();
                    this.Close();
                }
                else
                    MessageBox.Show("Chú ý, Sửa thông tin thất bại", "chú ý");
            }
        }
        #endregion
        #region moveMouse_From
        /*private void frmSuaBaohiem_Move(object sender, EventArgs e)
        {
            this.Text = "Form screen position = " + this.Location.ToString();
        }
        public Point mouse_offset;
        private void frmSuaBaohiem_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void frmSuaBaohiem_MouseMove(object sender, MouseEventArgs e)
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
            updateBaohiem();
        }

        private void sobaohiemTextEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if (BUS_Baohiem.kiemtraSobaohiemTontai(sobaohiemTextEdit.Text))
            {
                if (soBH_truoc != sobaohiemTextEdit.Text)
                {
                    image_no_sbh.Visible = true;
                    image_yes_sbh.Visible = false;
                    sobaohiemTextEdit.ToolTip = "Số bảo hiểm này đã tồn tại";
                }
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
        #region ButtionSua
        private void Them_Baohiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { btCapnhat.Select(); }
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
            image_no_nc.Visible = false;
            image_no_nk.Visible = false;
            image_no_sbh.Visible = false;
            image_yes_nc.Visible = true;
            image_yes_nk.Visible = true;
            image_yes_sbh.Visible = true;
        }
        #endregion

    }
}
