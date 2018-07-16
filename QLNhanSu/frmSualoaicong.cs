using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;
namespace QLNhanSu
{
    public partial class frmSualoaicong : DevExpress.XtraEditors.XtraForm
    {
        DTO.DMLoaicong lc = new DMLoaicong();
        public delegate void Reload();
        public Reload reload;
        public frmSualoaicong()
        {
            InitializeComponent();
        }
        public frmSualoaicong(DTO.DMLoaicong loaicong)
        {
            InitializeComponent();
            this.lc = loaicong;
        }
        

        private void frmSualoaicong_Load(object sender, EventArgs e)
        {
            loadtoanbothongtin();
        }
        public void loadtoanbothongtin()
        {
            txtMaloaicong.Text = lc.Maloai;
            txtTenloaicong.Text = lc.Tenloai;
            txtHesoluong.Text = lc.Heso;
            image_no_hesoluong.Visible = false;
            image_no_maloaicong.Visible = false;
            image_no_tenloaicong.Visible = false;
            image_yes_hesoluong.Visible = true;
            image_yes_maloaicong.Visible = true;
            image_yes_tenloaicong.Visible = true;
            if (txtMaloaicong.Text == "CN" || txtMaloaicong.Text == "1" || txtMaloaicong.Text == "L")
                txtMaloaicong.Enabled = false;
        }
        public bool KT_sothuc(string val)
        {
            try
            {
                float t = float.Parse(val);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool kiemtraNhap()
        {
            bool kt = true;
            if (txtMaloaicong.Text == "" || txtTenloaicong.Text == "" || txtHesoluong.Text == "")
            {
                kt = false;
                MessageBox.Show("Bạn vẫn chưa điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtMaloaicong.Text.Length >= 5)
            {
                kt = false;
                MessageBox.Show("Mã loại công không được quá 4 ký tự, xin bạn hãy chọn lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtTenloaicong.Text.Length >= 76)
            {
                kt = false;
                MessageBox.Show("Tên loại công không được quá 75 ký tự, xin bạn hãy chọn lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!KT_sothuc(txtHesoluong.Text))
            {
                kt = false;
                MessageBox.Show("Hệ số lương phải là kiểu số, xin bạn hãy chọn lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (BUS.BUS_Loaicong.kt_sua_trungma(txtMaloaicong.Text,lc.Maloai) == "false")
            {
                kt = false;
                MessageBox.Show("Mã loại công đã tồn tại, bạn hãy thay đổi mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return kt;
        }
        private void txtMaloaicong_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtMaloaicong.Text.Length >= 5)
            {
                image_no_maloaicong.Visible = true;
                image_yes_maloaicong.Visible = false;
                txtMaloaicong.ToolTip = "Mã loại công không được lớn hơn 4 ký tự";
            }
            else if (txtMaloaicong.Text == "")
            {
                image_no_maloaicong.Visible = true;
                image_yes_maloaicong.Visible = false;
                txtMaloaicong.ToolTip = "không được để trống thông tin này";
            }
            else if (BUS.BUS_Loaicong.kt_sua_trungma(txtMaloaicong.Text,lc.Maloai) == "false")
            {
                image_no_maloaicong.Visible = true;
                image_yes_maloaicong.Visible = false;
                txtMaloaicong.ToolTip = "Mã loại công đã tồn tại";
            }
            else
            {
                image_no_maloaicong.Visible = false;
                image_yes_maloaicong.Visible = true;
                txtMaloaicong.ToolTip = "Nhập mã loại công";
            }
        }

        private void txtTenloaicong_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTenloaicong.Text == "")
            {
                image_no_tenloaicong.Visible = true;
                image_yes_tenloaicong.Visible = false;
                txtTenloaicong.ToolTip = "Không được để trống nội dung này";
            }
            else if (txtTenloaicong.Text.Length >= 76)
            {
                image_no_tenloaicong.Visible = true;
                image_yes_tenloaicong.Visible = false;
                txtTenloaicong.ToolTip = "Không được quá 75 ký tự";
            }
            else
            {
                image_no_tenloaicong.Visible = false;
                image_yes_tenloaicong.Visible = true;
                txtTenloaicong.ToolTip = "Nhập tên loạ công";
            }
        }

        private void txtHesoluong_KeyUp(object sender, KeyEventArgs e)
        {
            if (!KT_sothuc(txtHesoluong.Text))
            {
                image_no_hesoluong.Visible = true;
                image_yes_hesoluong.Visible = false;
                txtHesoluong.ToolTip = "Đây phải là kiểu số";
            }
            else if (txtHesoluong.Text == "")
            {
                image_no_hesoluong.Visible = true;
                image_yes_hesoluong.Visible = false;
                txtHesoluong.ToolTip = "Nội dung này không được để trống";
            }
            else
            {
                image_no_hesoluong.Visible = false;
                image_yes_hesoluong.Visible = true;
                txtHesoluong.ToolTip = "Nhập vào hệ số tiền";
            }
        }
        public void Capnhat()
        {
            if (kiemtraNhap())
            {
                DMLoaicong loaicong = new DMLoaicong();
                loaicong.Maloai= txtMaloaicong.Text;
                loaicong.Tenloai = txtTenloaicong.Text;
                loaicong.Heso=txtHesoluong.Text;
                if (BUS.BUS_Loaicong._sua(loaicong, lc.Maloai) == "true")
                {
                    MessageBox.Show("Sửa thành công loại công có mã " + txtMaloaicong.Text + "", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reload();
                    this.Close();
                }
            }
        }
        private void btCapnhat_Click(object sender, EventArgs e)
        {
            Capnhat();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}