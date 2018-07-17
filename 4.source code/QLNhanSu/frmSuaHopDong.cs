using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNhanSu
{
    public partial class frmSuaHopDong : DevExpress.XtraEditors.XtraForm
    {
        public delegate void GetString();
        public GetString Mygetvalue;

        private string hoten;
        private DTO.DMHopdong HD = new DTO.DMHopdong();
        public frmSuaHopDong()
        {
            InitializeComponent();
        }
        public frmSuaHopDong(DTO.DMHopdong HD,string hoten)
        {
            this.hoten = hoten;
            this.HD = HD;
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void frmSuaHopDong_Load(object sender, EventArgs e)
        {
            loadDuLieu();
            
        }
        public void loadDuLieu()
        {
            LoaiHopDong();
            LanKiHD();
            combKilanthu.Text = HD.Kilanthu;
            loaihdTextEdit.Text = HD.Loaihd;
            sohdTextEdit.Text = HD.Sohd;
            loaihdTextEdit.Text = HD.Loaihd;
            combKilanthu.Text = HD.Kilanthu;
            ngayhdDateEdit.Text = HD.Ngayhd;
            ngaykihdDateEdit.Text = HD.Ngaykihd;
            ngayhhDateEdit.Text = HD.Ngayhh;
            dieukhoanTextEdit.Text = HD.Dieukhoan;
            lbTennv.Text = hoten;
            
        }
        #region cmb Loai Hop DOng
        private void LoaiHopDong()
        {
            List<DTO.LoaiHD> lhd = new List<DTO.LoaiHD>();
            lhd = BUS.BUS_DMHopdong.LoaiDopDong();
            loaihdTextEdit.Text = lhd[0].Tenloai;

            for (int i = 0; i < lhd.Count; i++)
            {
                loaihdTextEdit.Items.Add(lhd[i].Tenloai);  
            }
        }
        #endregion
        #region moveMouse_From
       /* public Point mouse_offset;

        

        private void frmSuaHopDong_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }
        private void frmSuaHopDong_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
            }
        }
        
        private void frmSuaHopDong_Move(object sender, EventArgs e)
        {
            this.Text = "Form screen position = " + this.Location.ToString();
        }*/
        #endregion
        #region cmb Lan Ki HD
        private void LanKiHD()
        {
            for (int i = 1 ; i <=10; i++)
            {
                combKilanthu.Items.Add(i);
            }
        }
        #endregion
        #region Hien thi hinh kiem tra
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
        private void loaihdTextEdit_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loaihdTextEdit.Text != "" && ngayhdDateEdit.Text != "")
                LayraNgayhethanHD();
        }

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
                if (BUS.BUS_DMHopdong.NgayHopDong(ngayhdDateEdit.Text, HD.Manv,HD.Sohd) == 1)
                {
                    image_yes_nhd.Visible = true;
                    image_no_nhd.Visible = false;
                    ngayhdDateEdit.ToolTip = "Chọn ngày hợp đồng";
                }
                else
                {
                    if (BUS.BUS_DMHopdong.NgayHopDong(ngayhdDateEdit.Text, HD.Manv,HD.Sohd) == 2)
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

        #endregion

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            DTO.DMHopdong hopdong = new DTO.DMHopdong();
            hopdong.Manv = HD.Manv;
            hopdong.Sohd = sohdTextEdit.Text;
            hopdong.Loaihd = loaihdTextEdit.Text;
            hopdong.Ngaykihd = ngaykihdDateEdit.Text;
            hopdong.Ngayhd = ngayhdDateEdit.Text;
            hopdong.Ngayhh = ngayhhDateEdit.Text;
            hopdong.Dieukhoan = dieukhoanTextEdit.Text;
            hopdong.Kilanthu = combKilanthu.Text;
            if (clConver.KT(hopdong))
            {
                if (BUS.BUS_DMHopdong.UpdatetHopDong(hopdong) == "true")
                {
                    MessageBox.Show("Sửa thành công hợp đồng " + HD.Sohd + " cho nhân viên " + hoten + "! ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mygetvalue();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi update từ hệ thống!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lỗi update từ hệ thống!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            loadDuLieu();
        }


    }
}
