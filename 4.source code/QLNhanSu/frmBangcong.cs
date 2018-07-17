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
    public partial class frmBangcong : DevExpress.XtraEditors.XtraForm
    {
        private string manv;
        private string ngay;
        private string thang;
        private string nam;
        public frmBangcong()
        {
            InitializeComponent();
        }
        #region load
        private void frmBangcong_Load(object sender, EventArgs e)
        {
            loadFrom();
        }
        public void loadFrom()
        {
            for(int i=1;i<=12;i++)
            {
                cmbThang.Items.Add(i.ToString());
            }
            cmbThang.SelectedItem= DateTime.Now.Month.ToString();
            for(int i=1990;i<=DateTime.Now.Year;i++)
            {
                cmbNam.Items.Add(i.ToString());
            }
            cmbNam.SelectedItem = DateTime.Now.Year.ToString();
        }
        #endregion
        #region xem
        private void  _xem()
        {
            gridBangcong.DataSource = BUS.BUS_Bangcong.selectBangcong(int.Parse(cmbThang.Text), int.Parse(cmbNam.Text));
            lbManv.DataBindings.Clear();
            lbManv.DataBindings.Add("Text",gridBangcong.DataSource,"manv");
        }
        private void btXem_Click(object sender, EventArgs e)
        {
            _xem();
        }
        #endregion
        #region them
        private void _them()
        {
            frmThemcong frm = new frmThemcong();
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            _them();
        }
        private void them_Click(object sender, EventArgs e)
        {
            _them();
        }
        #endregion
        #region xoa
        private void _xoa()
        {
            if (gridBangcong.MainView.RowCount > 0)
            {
                if (MessageBox.Show("Bạn có chắc xoá toàn bộ ngày công của nhân viên có mã là " + lbManv.Text + " trong tháng " + cmbThang.Text + "/" + cmbNam.Text + " hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (BUS_Bangcong._xoa(lbManv.Text, cmbThang.Text, cmbNam.Text) == "true")
                    {
                        MessageBox.Show("Xoá thành công toàn bộ ngày công của nhân viên " + lbManv.Text + " trong tháng " + cmbThang.Text + "/" + cmbNam.Text + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _xem();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi từ hệ thống, hãy liên hệ với bộ phận kỹ thuật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            _xoa();
        }
        private void xoa_Click(object sender, EventArgs e)
        {
            _xoa();
        }
        #endregion
        #region chitiet
        private void _chiTiet()
        {
            if (gridBangcong.MainView.RowCount > 0)
            {
                frmChitietBangcongNhanvien frm = new frmChitietBangcongNhanvien(lbManv.Text,cmbThang.Text,cmbNam.Text);
                frm.Show();
            }
        }
        private void btChitiet_Click(object sender, EventArgs e)
        {
            _chiTiet();
        }
        private void xemchitiet_Click(object sender, EventArgs e)
        {
            _chiTiet();
        }
        #endregion
        private void _restart()
        {
            _xem();
        }
        private void restart_Click(object sender, EventArgs e)
        {
            _restart();
        }
        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btIn_Click(object sender, EventArgs e)
        {

        }
    }
}