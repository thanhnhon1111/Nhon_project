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
    public partial class frmCongdoan : DevExpress.XtraEditors.XtraForm
    {
        public frmCongdoan()
        {
            InitializeComponent();
        }

        private void frmCongdoan_Load(object sender, EventArgs e)
        {
            loadFull();
        }
        private void loadFull()
        {
            gridCongdoan.DataSource = BUS_Congdoan.select();
            txtManv.DataBindings.Clear();
            txtManv.DataBindings.Add("Text",gridCongdoan.DataSource,"MaNV");
            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("Text", gridCongdoan.DataSource, "hoten");
            txtGioitinh.DataBindings.Clear();
            txtGioitinh.DataBindings.Add("Text", gridCongdoan.DataSource, "GioiTinh");
            txtBophan.DataBindings.Clear();
            txtBophan.DataBindings.Add("Text", gridCongdoan.DataSource, "TenBoPhan");
            txtChucvu.DataBindings.Clear();
            txtChucvu.DataBindings.Add("Text", gridCongdoan.DataSource, "tenchucvu");
            layoutCapnhat.Visibility = layoutHuy.Visibility = layoutNhapMaNV.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization;
            btThem.Enabled = true;
            if (gridCongdoan.MainView.RowCount > 0)
                btXoa.Enabled = true;
            else
                btXoa.Enabled = false;
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            btThem.Enabled = false;
            layoutCapnhat.Visibility = layoutHuy.Visibility = layoutNhapMaNV.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            loadFull();
        }
        private void btCapnhat_Click(object sender, EventArgs e)
        {
            if (BUS_Congdoan.insert(txtNhapMaNV.Text) == "true")
            {
                loadFull();
            }
            else
                MessageBox.Show("Mã nhân viên không tồn tại hoặc đã tồn tại trong công đoàn","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên có mã " + txtManv.Text + " ra khỏi công đoàn hay không",
               "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BUS_Congdoan.delete(txtManv.Text);
                loadFull();
            }
        }
    }
}