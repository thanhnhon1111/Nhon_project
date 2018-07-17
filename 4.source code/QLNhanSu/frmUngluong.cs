using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DTO;
namespace QLNhanSu
{
    public partial class frmUngluong : DevExpress.XtraEditors.XtraForm
    {
        public frmUngluong()
        {
            InitializeComponent();
        }

        private DateTime ngaycu;
        private void clear1()
        {
            txtBophan.Text= txtHoten.Text= txtManv.Text = dateNgay.Text = "";
            txtTienung.Text = "0";
        }
        #region Load
        private void frmUngluong_Load(object sender, EventArgs e)
        {
            loadFull();
            layoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization;
        }
        private void loadFull()
        {
            gridUngluong.DataSource = BUS_Ungluong.select(txtTimkiem.Text);
            txtManv.DataBindings.Clear();
            txtManv.DataBindings.Add("Text", gridUngluong.DataSource, "manv");
            dateNgay.DataBindings.Clear();
            dateNgay.DataBindings.Add("Datetime", gridUngluong.DataSource, "ngaythang");
            txtTienung.DataBindings.Clear();
            txtTienung.DataBindings.Add("Text", gridUngluong.DataSource, "tien");
            lbTitle.Text = "QUẢN LÝ ỨNG LƯƠNG";
        }
        private void clear()
        {
            txtManv.Text = "";
            txtBophan.Text = "";
            txtHoten.Text = "";
            dateNgay.Text = "";
            txtTienung.Text = "";
        }
        private void txtTienung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtManv_EditValueChanged(object sender, EventArgs e)
        {
            NhanVien nv = BUS_Nhanvien.Tennv(txtManv.Text);
            txtHoten.Text = nv.Hoten;
            txtBophan.Text = nv.Bophan;
            if (txtManv.Text == "")
            {
                txtManv.ForeColor = Color.Red;
                txtManv.ToolTip = "Mã nhân viên không tồn tại";
            }
            else if (BUS_Nhanvien.KiemTraMaNV(txtManv.Text) == "true")
            {
                txtManv.ForeColor = Color.Red;
                txtManv.ToolTip = "Mã nhân viên không tồn tại";
            }
            else
            {
                txtManv.ForeColor = Color.Blue;
                txtManv.ToolTip = "Mã nhân viên";
            }
        }


        private void txtTimkiem_EditValueChanged(object sender, EventArgs e)
        {
            loadFull();
            if (gridUngluong.MainView.RowCount <= 0)
                clear();
        }

        #endregion
        #region Insert 
        private void them()
        {
            txtManv.Enabled = dateNgay.Enabled = txtTienung.Enabled = true;
            txtManv.Text = dateNgay.Text = "";
            layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            gridUngluong.Enabled = txtTimkiem.Enabled = false;
            btThem.Enabled = btXoa.Enabled = btSua.Enabled = btDong.Enabled = false;
            txtTienung.Text = "0";
            lbTitle.Text = "THÊM ỨNG LƯƠNG CHO NHÂN VIÊN";
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            them();
        }

        #endregion
        #region Huy
        private void huy()
        {
            txtManv.Enabled = dateNgay.Enabled = txtTienung.Enabled = false;
            layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization;
            layoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization;
            gridUngluong.Enabled = txtTimkiem.Enabled = true;
            btThem.Enabled = btXoa.Enabled = btSua.Enabled = btDong.Enabled = true;
            loadFull();
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            huy();
        }
        #endregion
        #region Delete
        private void xoa()
        {
            if (gridUngluong.MainView.RowCount > 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa số tiền nhân viên " + txtHoten.Text + " đã ứng hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (BUS_Ungluong.delete(txtManv.Text, dateNgay.DateTime.Month.ToString(), dateNgay.DateTime.Year.ToString()) == "true")
                    {
                        loadFull();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi từ hệ thống hãy liên hệ với bộ phận kỹ thuật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (gridUngluong.MainView.RowCount == 0)
                clear1();
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            xoa();
        }
        #endregion
        #region kiemtra
        private bool kt_them()
        {
            bool kt = true;
            if (txtManv.Text == "" || dateNgay.Text == "" || txtTienung.Text == "")
            {
                kt = false;
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (BUS_Nhanvien.KiemTraMaNV(txtManv.Text) == "true")
            {
                kt = false;
                MessageBox.Show("Không có nhân viên này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (dateNgay.DateTime > DateTime.Now)
            {
                kt = false;
                MessageBox.Show("Ngày này chưa tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (!BUS.BUS_Nhanvien.kiemtra_ngaycong_ngayvaolam(txtManv.Text, dateNgay.DateTime))
            {
                kt = false;
                MessageBox.Show("Ngày ứng lương không hợp lệ, ngày này nhân viên chưa vào làm trong công ty", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(txtTienung.Text)==0)
            {
                kt = false;
                MessageBox.Show("Số tiền ứng phải lớn hơn 0vnđ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }/*
            else
            {
                Ungluong ul = new Ungluong();
                ul.Manv = txtManv.Text;
                ul.Thang = dateNgay.DateTime.Month.ToString();
                ul.Nam = dateNgay.DateTime.Year.ToString();
                if (!BUS_Ungluong.kt_trung_them(ul))
                {
                    if (ul.Thang == ngaycu.Month.ToString() && ul.Nam == ngaycu.Year.ToString())
                    {

                    }
                    else
                    {
                        kt = false;
                        MessageBox.Show("Tháng này nhân viên đã ứng tiền rồi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }*/
            else
            {
                Ungluong ul = new Ungluong();
                ul.Manv = txtManv.Text;
                if (ngaycu.Month != DateTime.Parse(dateNgay.Text).Month || ngaycu.Year != DateTime.Parse(dateNgay.Text).Year)
                {
                    ul.Thang = dateNgay.DateTime.Month.ToString();
                    ul.Nam = dateNgay.DateTime.Year.ToString();
                    if (!BUS_Ungluong.kt_trung_them(ul))
                    {
                        kt = false;
                        MessageBox.Show("Tháng này nhân viên đã ứng tiền rồi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return kt;
        }
        #endregion
        #region sua
        private void btCapnhat_Click(object sender, EventArgs e)
        {
            if (txtManv.Enabled == true)
            {
                if (kt_them())
                {
                    Ungluong ul = new Ungluong();
                    ul.Manv = txtManv.Text;
                    ul.Ngay = dateNgay.DateTime.Day.ToString();
                    ul.Thang = dateNgay.DateTime.Month.ToString();
                    ul.Nam = dateNgay.DateTime.Year.ToString();
                    ul.Tien = txtTienung.Text;
                    ul.Trangthai = "0";
                    if (BUS_Ungluong.insert(ul) == "true")
                    {
                        huy();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi từ hệ thống, hãy liên hệ với bộ phận kỹ thuật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {/*
                Ungluong ul_new = new Ungluong();
                ul_new.Manv = txtManv.Text;
                ul_new.Thang = dateNgay.DateTime.Month.ToString();
                ul_new.Nam = dateNgay.DateTime.Year.ToString();

                if (kt_them())
                {
                    Ungluong ul_n = new Ungluong();
                    ul_new.Ngay = dateNgay.DateTime.Day.ToString();
                    ul_new.Thang = dateNgay.DateTime.Month.ToString();
                    ul_new.Nam = dateNgay.DateTime.Year.ToString();
                    ul_new.Tien = txtTienung.Text;
                    Ungluong ul_c = new Ungluong();
                    ul_c.Manv = txtManv.Text;
                    ul_c.Thang = ngaycu.Month.ToString();
                    ul_c.Nam = ngaycu.Year.ToString();
                    //if (BUS_Ungluong.update(ul_c, ul_n) == "true")
                    {
                        huy();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi từ hệ thống, hãy liên hệ với bộ phận kỹ thuật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                */
                Ungluong ul = new Ungluong();
                ul.Ngay = dateNgay.DateTime.Day.ToString();
                ul.Manv = txtManv.Text;
                ul.Tien = txtTienung.Text;
                if (kt_them())
                {
                    if (ngaycu != DateTime.Parse(dateNgay.Text))
                    {
                        ul.Thang = dateNgay.DateTime.Month.ToString();
                        ul.Nam = dateNgay.DateTime.Year.ToString();
                        if (BUS_Ungluong.update_(ul, ngaycu.Month.ToString(), ngaycu.Year.ToString()) == "true")
                        {
                            huy();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi từ hệ thống, hãy liên hệ với bộ phận kỹ thuật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {

                        ul.Thang = ngaycu.Month.ToString();
                        ul.Nam = ngaycu.Month.ToString();
                        if (BUS_Ungluong.update_(ul, ngaycu.Month.ToString(), ngaycu.Month.ToString()) == "true")
                        {
                            huy();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi từ hệ thống, hãy liên hệ với bộ phận kỹ thuật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                
            }
        }
        private void sua()
        {
            if(gridUngluong.MainView.RowCount>0)
            {
                dateNgay.Enabled = txtTienung.Enabled = true;
                layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                gridUngluong.Enabled = txtTimkiem.Enabled = false;
                btThem.Enabled = btXoa.Enabled = btSua.Enabled = btDong.Enabled = false;
                lbTitle.Text = "SỬA ỨNG LƯƠNG CHO NHÂN VIÊN";
                ngaycu = DateTime.Parse(dateNgay.Text);
            }
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            sua();
        }
        #endregion

        #region Menu strip
        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu_xoa_Click(object sender, EventArgs e)
        {
            xoa();
        }

        private void menu_them_Click(object sender, EventArgs e)
        {
            them();
        }

        private void menu_sua_Click(object sender, EventArgs e)
        {
            sua();
        }

        private void menu_restart_Click(object sender, EventArgs e)
        {
            loadFull();
        }

        private void menu_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}