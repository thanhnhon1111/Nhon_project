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
    public partial class frmTaikhoan : DevExpress.XtraEditors.XtraForm
    {
        string flag1 = "0";
        int quyen;
        string ten;
        string tencu;
        #region contrustor
        public frmTaikhoan()
        {
            InitializeComponent();
        }
        public frmTaikhoan(string ten, string quyen)
        {
            InitializeComponent();
            this.quyen = int.Parse(quyen);
            this.ten = ten;
        }
        #endregion
        #region cac ham enable va clear
        private void EnableText(bool flag)
        {
            txt_hoten.Enabled = flag;
            txt_tenTK.Enabled = flag;
            radio_Quyen.Properties.ReadOnly = !flag;
        }
        private void Binding()
        {
            txt_hoten.DataBindings.Clear();
            txt_hoten.DataBindings.Add("Text", grid_Taikhoan.DataSource, "hoten");
            txt_tenTK.DataBindings.Clear();
            txt_tenTK.DataBindings.Add("Text", grid_Taikhoan.DataSource, "ten");
            lb_quyen.DataBindings.Clear();
            lb_quyen.DataBindings.Add("Text", grid_Taikhoan.DataSource, "quyen");
        }
        private void clearBinding()
        {
            txt_hoten.DataBindings.Clear();
            txt_tenTK.DataBindings.Clear();
            lb_quyen.DataBindings.Clear();
        }
        private void clear()
        {
            txt_hoten.Text = "";
            txt_MK.Text = "";
            txt_tenTK.Text = "";
            txt_xacNhanMK.Text = "";
        }
        #endregion
        #region load
        private void loadfull()
        {
            grid_Taikhoan.DataSource = BUS_hethong.selectTaikhoan();
            Binding();
            EnableText(false);
            layoutmatkhau.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization;
            layoutxacnhanmk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization;
            bt_them.Enabled = true;
            grid_Taikhoan.Enabled = true;
            bt_luu.Enabled = false;
            bt_restart.Enabled = false;
            lb_loi.Text = "";
            if (grid_Taikhoan.MainView.RowCount > 0)
            {
                bt_sua.Enabled = bt_xoa.Enabled = true;
            }
            else
            {
                bt_sua.Enabled = bt_xoa.Enabled = false;
                txt_hoten.Text = txt_tenTK.Text = lb_quyen.Text = "";
            }
        }
        private void frmTaikhoan_Load(object sender, EventArgs e)
        {
            loadfull();
        }
        #endregion

        #region them
        private void bt_them_Click(object sender, EventArgs e)
        {
            flag1 = "1";
            clear();
            grid_Taikhoan.Enabled = false;
            clearBinding();
            EnableText(true);
            layoutmatkhau.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutxacnhanmk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            bt_them.Enabled = bt_xoa.Enabled = bt_sua.Enabled = false;
            bt_luu.Enabled = bt_restart.Enabled = true;
        }
        #endregion
        #region bt_restart
        private void bt_restart_Click(object sender, EventArgs e)
        {
            loadfull();
        }
        #endregion
        #region kiem tra truoc khi thuc thi
        private bool kiemtra()
        {
            if (flag1 != "2" && (txt_MK.Text == "" || txt_xacNhanMK.Text == ""))
            {
                lb_loi.Text = "Hãy điền đầy đủ thông tin.";
                return false;
            }
            else if (txt_hoten.Text == "" || txt_tenTK.Text == "")
            {
                lb_loi.Text = "Hãy điền đầy đủ thông tin.";
                return false;
            }
            else if (txt_MK.Text != txt_xacNhanMK.Text)
            {
                lb_loi.Text = "Mật khẩu và xác nhận mật khẩu không khớp với nhau.";
                return false;
            }
            lb_loi.Text = "";
            return true;
        }
        #endregion

        #region luu
        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (flag1 == "1")
            {
                if (kiemtra())
                {
                    if (BUS_hethong.insertTaikhoan(txt_hoten.Text, txt_tenTK.Text, txt_MK.Text, radio_Quyen.SelectedIndex.ToString())=="true")
                    {
                        lb_loi.Text = "Thêm tài khoản Thành công.";
                        loadfull();
                    }
                    else
                    {
                        lb_loi.Text = "Tên tài khoản đã tồn tại.";
                    }
                }
            }
            else
            {
                sua();
            }
        }
        #endregion
        #region sua
        private void sua()
        {
            if (kiemtra())
            {
                string q = radio_Quyen.SelectedIndex.ToString();
                if (quyen == 2)
                {
                    q = "2";
                }
                if (BUS_hethong.updateTaikhoan(txt_hoten.Text, tencu, txt_tenTK.Text, txt_MK.Text, q)=="true")
                {
                    lb_loi.Text = "Sửa tài khoản thành công.";
                    loadfull();
                }
                else
                    lb_loi.Text = "Tên tài khoản đã trùng.";
            }
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {

            if ((ten == txt_tenTK.Text) || (quyen > radio_Quyen.SelectedIndex))
            {
                tencu = txt_tenTK.Text;
                flag1 = "2";
                grid_Taikhoan.Enabled = false;
                clearBinding();
                EnableText(true);
                layoutmatkhau.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutxacnhanmk.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                bt_them.Enabled = bt_xoa.Enabled = bt_sua.Enabled = false;
                bt_luu.Enabled = bt_restart.Enabled = true;
                if ((quyen == 2 && ten == txt_tenTK.Text))
                {
                    radio_Quyen.Properties.ReadOnly = true;
                }
            }
        }
        #endregion

        #region xoa
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (quyen > radio_Quyen.SelectedIndex)
            {
                if (ten == txt_tenTK.Text)
                {
                    lb_loi.Text = "Bạn không thể xoá chính bạn";
                }
                else if (MessageBox.Show("Bạn có muốn xóa tài khoản " + txt_tenTK.Text + " hay không?", "thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (BUS_hethong.deleteTaikhoan(txt_tenTK.Text)=="true")
                    {
                        lb_loi.Text = "Xóa tài khoản thành công.";
                        loadfull();
                    }
                    else
                        lb_loi.Text = "Lỗi từ hệ thống";
                }
            }
            else
                lb_loi.Text = "Bạn không thể xóa tài khoản admin";
        }
        #endregion
        #region cac su kien value change
        private void lb_quyen_TextChanged(object sender, EventArgs e)
        {
            if (lb_quyen.Text == "Admin")
                radio_Quyen.SelectedIndex = 1;
            else
                radio_Quyen.SelectedIndex = 0;
        }
        private void txt_tenTK_EditValueChanged(object sender, EventArgs e)
        {
            if ((ten == txt_tenTK.Text) || (quyen > radio_Quyen.SelectedIndex))
            {
                bt_sua.Enabled = bt_xoa.Enabled = true;
            }
            else
                bt_sua.Enabled = bt_xoa.Enabled = false;
            if (quyen == 2)
                lb_loi.Text = "2";
        }
        #endregion
        private void bt_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}