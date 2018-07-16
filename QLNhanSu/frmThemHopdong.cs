using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;

namespace QLNhanSu
{
    public partial class frmThemHopdong : DevExpress.XtraEditors.XtraForm
    {
        public delegate void Getstring();
        public Getstring Mygetstring;

        private string hoten;
        private string manv;
        public frmThemHopdong()
        {
            InitializeComponent();
        }
        public frmThemHopdong(string manv, string ho, string ten)
        {
            hoten = ho + " " + ten;
            this.manv = manv;
            InitializeComponent();
        }
        private void frmThemHopdong_Load(object sender, EventArgs e)
        {
            lbTennv.Text = hoten; 
            //lay so hop Dong
            sohdTextEdit.Text = BUS.BUS_DMHopdong.SoHopDong();
            //cmb Loai Hop Dong
            LoaiHopDong();
            //Ki lan thu
            KiLanThu();
            TrangthaiBandau();
        }
        private void TrangthaiBandau()
        {
            ngayhdDateEdit.ToolTip = "Hãy chọn ngày hợp đồng";
            ngaykihdDateEdit.ToolTip = "Hãy chọn ngày ký hợp đồng";
            dieukhoanTextEdit.ToolTip = "Nhập điều khoản hợp đồng";  
        }
        private void InsertHD()
        {
            DTO.DMHopdong hd = new DTO.DMHopdong();
            hd.Sohd = sohdTextEdit.Text;
            hd.Manv = manv;
            hd.Loaihd = loaihdTextEdit.Text;
            hd.Ngaykihd = ngaykihdDateEdit.Text;
            hd.Ngayhd = ngayhdDateEdit.Text;
            hd.Ngayhh = ngayhhDateEdit.Text;
            hd.Kilanthu = combKilanthu.Text;
            hd.Dieukhoan = dieukhoanTextEdit.Text;
            if (clConver.KT(hd))
            {
                if (BUS.BUS_DMHopdong.InsertHopDong(hd) == "true")
                {
                    MessageBox.Show("Thêm hợp đồng thành công cho nhân viên " + hoten + " ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BUS.BUS_DMHopdong.UpdateSoIdHD();
                    Mygetstring();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm hợp đồng cho nhân viên " + hoten + " thất bại do hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
 
            }
        }
        private void btCapnhat_Click(object sender, EventArgs e)
        {
            InsertHD();
        }


        #region cmb Loai Hop DOng
        private void LoaiHopDong()
        {
            List<DTO.LoaiHD> lhd = new List<DTO.LoaiHD>();
            lhd = BUS.BUS_DMHopdong.LoaiDopDong();
            loaihdTextEdit.Text =lhd[0].Tenloai;

            for (int i = 0; i < lhd.Count; i++)
            {
                loaihdTextEdit.Items.Add(lhd[i].Tenloai);
                loaihdTextEdit.DisplayMember = lhd[i].Tenloai;
                loaihdTextEdit.ValueMember=lhd[i].Thoihan.ToString();
            }
        }
        #endregion

        #region Ki Lan Thu
        private void KiLanThu()
        {
            combKilanthu.Text = "1";
            for (int i = 1; i <= 10; i++)
            {
                combKilanthu.Items.Add(i);
                loaihdTextEdit.DisplayMember = i.ToString();
                loaihdTextEdit.ValueMember = i.ToString();
            }
        }
        #endregion

        
        private void LayraNgayhethanHD()
        {
            string ngay = (ngayhdDateEdit.DateTime.Day).ToString();
            int thang = int.Parse((ngayhdDateEdit.DateTime.Month).ToString());
            int nam = int.Parse((ngayhdDateEdit.DateTime.Year).ToString());

            string s = (BUS.BUS_DMHopdong.layThoihanHD(loaihdTextEdit.Text)).ToString();
            int sothang = int.Parse(s);
            for (int i = 1; i <= sothang; i++)
            {
                thang++;
                if (thang == 13)
                {
                    thang = 1;
                    nam++;
                }
            }
            if (sothang != 0)
                ngayhhDateEdit.Text = ngay + "/" + thang + "/" + nam;
            else
                ngayhhDateEdit.Text = "01/01/9999";
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            sohdTextEdit.Text = "";
            ngaykihdDateEdit.Text = "";
            ngayhdDateEdit.Text = "";
            combKilanthu.Text = "1";
            dieukhoanTextEdit.Text = "";
        }

        #region Hinh hien thi V or X
        private void ngaykihdDateEdit_EditValueChanged(object sender, EventArgs e)
        {

            if (ngaykihdDateEdit.DateTime > DateTime.Now)
            {
                image_no_nkhd.Visible = true;
                image_yes_nkhd.Visible = false;
                ngaykihdDateEdit.ToolTip = "Ngày ký hợp đồng phải bé hơn hơn ngày hiện tại";
            }
            else
            {
                image_no_nkhd.Visible = false;
                image_yes_nkhd.Visible = true;
                ngaykihdDateEdit.ToolTip = "Chọn ngày ký hợp đồng";
            }
        }
        private void ngayhdDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (loaihdTextEdit.Text != "" && ngayhdDateEdit.Text != "")
                LayraNgayhethanHD();
            if (ngayhdDateEdit.DateTime >= ngaykihdDateEdit.DateTime)
            {
                if (BUS.BUS_DMHopdong.NgayHopDong(ngayhdDateEdit.Text, manv,"1") == 1)
                {
                    image_yes_nhd.Visible = true;
                    image_no_nhd.Visible = false;
                    ngayhdDateEdit.ToolTip = "Chọn ngày hợp đồng";
                }
                else
                {
                    if (BUS.BUS_DMHopdong.NgayHopDong(ngayhdDateEdit.Text, manv,"1") == 2)
                    {
                        image_yes_nhd.Visible = true;
                        image_no_nhd.Visible = false;
                        ngayhdDateEdit.ToolTip = "Chọn ngày hợp đồng";
                    }
                    else
                    {
                        image_yes_nhd.Visible = false;
                        image_no_nhd.Visible = true;
                        ngayhdDateEdit.ToolTip = "Có 1 hợp đồng của nhân viên " + hoten + " đang còn hiệu lực trong thời gian này";
                    }
                }
            }
            else
            {
                image_yes_nhd.Visible = false;
                image_no_nhd.Visible = true;
                ngayhdDateEdit.ToolTip = "Ngày hợp đồng không được nhỏ hơn ngày ký hợp đồng";
            }
        }
        private void loaihdTextEdit_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loaihdTextEdit.Text != "" && ngayhdDateEdit.Text != "")
                LayraNgayhethanHD();
            if (loaihdTextEdit.Text == "")
            {
                image_no_lhd.Visible = true;
                image_yes_lhd.Visible = false;
            }
            else
            {
                image_no_lhd.Visible = false;
                image_yes_lhd.Visible = true;
            }
        }

        private void combKilanthu_SelectedValueChanged(object sender, EventArgs e)
        {
            if (combKilanthu.Text == "")
            {
                image_no_klt.Visible = true;
                image_yes_klt.Visible = false;
            }
            else
            {
                image_no_klt.Visible = false;
                image_yes_klt.Visible = true;
            }
        }
        #endregion

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region moveMouse_From
        /*public Point mouse_offset;
        
        private void frmThemHopdong_Move(object sender, EventArgs e)
        {
            this.Text = "Form screen position = " + this.Location.ToString();
        }

        private void frmThemHopdong_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void frmThemHopdong_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
            }
        }*/
        #endregion

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
