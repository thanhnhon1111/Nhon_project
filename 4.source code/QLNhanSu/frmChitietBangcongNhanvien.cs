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
    public partial class frmChitietBangcongNhanvien : DevExpress.XtraEditors.XtraForm
    {
        private string nam;
        private string thang;
        NhanVien nv;
        public frmChitietBangcongNhanvien()
        {
            InitializeComponent();
        }
        public frmChitietBangcongNhanvien(string manv,string thang,string nam)
        {
            InitializeComponent();
            txtManv.Text = manv;
            this.thang = thang;
            this.nam = nam;
            nv = BUS.BUS_Nhanvien.Tennv(manv);
            img_anhdaidien.Image = null;
            Image img = BUS_Nhanvien.bingImageNV(manv);
            img_anhdaidien.Image = img;
        }
        #region load
        private void frmChitietBangcongNhanvien_Load(object sender, EventArgs e)
        {
            loadFull();
        }
        private void loadFull()
        {
            lbthangnam.Text = thang.ToString() + "/" + nam.ToString();
            txtTennv.Text = nv.Hoten;
            txtBophan.Text = nv.Bophan;
            gridChitietcongNV.DataSource = BUS.BUS_Bangcong.selectBangcong_1NV(txtManv.Text, thang, nam);
            txtNgay.DataBindings.Clear();
            txtNgay.DataBindings.Add("Text", gridChitietcongNV.DataSource, "ngay");
            lbLoaicong.DataBindings.Clear();
            lbLoaicong.DataBindings.Add("Text", gridChitietcongNV.DataSource, "maloaicong");
            lbgiovao.DataBindings.Clear();
            lbgiovao.DataBindings.Add("Text", gridChitietcongNV.DataSource, "giovao");
            lbGiora.DataBindings.Clear();
            lbGiora.DataBindings.Add("Text", gridChitietcongNV.DataSource, "giora");
            lbPhutvao.DataBindings.Clear();
            lbPhutvao.DataBindings.Add("Text", gridChitietcongNV.DataSource, "phutvao");
            lbPhutra.DataBindings.Clear();
            lbPhutra.DataBindings.Add("Text", gridChitietcongNV.DataSource, "phutra");
            lbThuong.Text = BUS.BUS_Bangcong.tongNgayCongThuong(txtManv.Text, thang, nam);
        }
        private void menurestart_Click(object sender, EventArgs e)
        {
            loadFull();
        }
        #endregion
        #region them
        public void _them()
        {
            frmThemcong frm = new frmThemcong(txtManv.Text);
            frm.reload = new frmThemcong.Reload(loadFull);
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            _them();
        }
        private void menuthem_Click(object sender, EventArgs e)
        {
            _them();
        }
        #endregion
        #region xoa
        private void _xoa()
        {
            if (gridChitietcongNV.MainView.RowCount > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xoá ngày công " + txtNgay.Text + "/" + thang + "/" + nam + " này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (BUS.BUS_Bangcong._xoaNgaycong(txtManv.Text, txtNgay.Text, thang, nam) == "true")
                    {
                        MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadFull();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi từ hệ thống, hãy liên hệ với bộ phận kỹ thuật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            _xoa();
        }
        private void menuxoa_Click(object sender, EventArgs e)
        {
            _xoa();
        }
        #endregion
        #region sua
        private void _sua()
        {
            DTO.DMBangcong b = new DMBangcong();
            b.Manv = txtManv.Text;
            b.Ngay = int.Parse(txtNgay.Text.ToString());
            b.Thang = int.Parse(thang);
            b.Nam = int.Parse(nam);
            b.Giovao = int.Parse(lbgiovao.Text.ToString());
            b.Giora = int.Parse(lbGiora.Text.ToString());
            b.Phutvao = int.Parse(lbPhutvao.Text.ToString());
            b.Phutra = int.Parse(lbPhutra.Text.ToString());
            b.Maloaicong = lbLoaicong.Text;
            frmSuacong frm = new frmSuacong(b);
            frm.WindowState = FormWindowState.Normal;
            frm.reload = new frmSuacong.Reload(loadFull);
            frm.Show();
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            _sua();
        }
        private void menusua_Click(object sender, EventArgs e)
        {
            _sua();
        }
        #endregion
        
        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}