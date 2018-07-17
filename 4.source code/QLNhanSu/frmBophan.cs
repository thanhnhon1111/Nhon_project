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
    public partial class frmBophan : DevExpress.XtraEditors.XtraForm
    {
        bool flag = true;
        string macu="";
        public frmBophan()
        {
            InitializeComponent();
        }
        public void binding()
        {
            txt_mabophan.DataBindings.Clear();
            txt_mabophan.DataBindings.Add("Text",grid_bophan.DataSource,"MaBoPhan");
            txt_tenbophan.DataBindings.Clear();
            txt_tenbophan.DataBindings.Add("Text", grid_bophan.DataSource, "TenBoPhan");
        }
        public void loadFull()
        {
            txt_mabophan.Text = txt_tenbophan.Text = "";
            txt_mabophan.Enabled = txt_tenbophan.Enabled = false;
            grid_bophan.Enabled = bt_them.Enabled = true;
            bt_restart.Enabled = bt_capnhat.Enabled = false;
            lb_loi.Text = "";
            grid_bophan.DataSource = BUS_Bophan.compoboxBophan();
            binding();
            if (grid_bophan.MainView.RowCount > 0)
            {
                bt_sua.Enabled = bt_xoa.Enabled = true;
            }
            else
            {
                bt_xoa.Enabled = bt_sua.Enabled = false;
            }
        }
        private void frmBophan_Load(object sender, EventArgs e)
        {
            loadFull();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            flag = true;
            txt_mabophan.DataBindings.Clear();
            txt_tenbophan.DataBindings.Clear();
            txt_mabophan.Text = txt_tenbophan.Text = "";
            txt_mabophan.Enabled = txt_tenbophan.Enabled = true;
            bt_capnhat.Enabled = bt_restart.Enabled = true;
            bt_them.Enabled = bt_xoa.Enabled = bt_sua.Enabled = false;
            grid_bophan.Enabled = false;
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            flag = false;
            macu = txt_mabophan.Text;
            txt_mabophan.DataBindings.Clear();
            txt_tenbophan.DataBindings.Clear();
            txt_mabophan.Enabled = txt_tenbophan.Enabled = true;
            bt_capnhat.Enabled = bt_restart.Enabled = true;
            bt_them.Enabled = bt_xoa.Enabled = bt_sua.Enabled = false;
            grid_bophan.Enabled = false;
        }

        private void bt_restart_Click(object sender, EventArgs e)
        {
            loadFull();
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                if (txt_mabophan.Text == "" || txt_tenbophan.Text == "")
                {
                    lb_loi.Text = "Hãy điền đầy đủ thông tin.";
                }
                else if (BUS_Bophan.KiemTraMabophan(txt_mabophan.Text) == "true")
                {
                    lb_loi.Text = "Mã bộ phận này đã tồn tại.";
                }
                else
                {
                    if (BUS_Bophan.insert(txt_mabophan.Text, txt_tenbophan.Text) == "true")
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadFull();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi từ hệ thống, hãy liên hệ với bộ phận kỹ thuật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadFull();
                    }
                }
            }
            else
            {
                if (txt_mabophan.Text == "" || txt_tenbophan.Text == "")
                {
                    lb_loi.Text = "Hãy điền đầy đủ thông tin.";
                }
                else if (BUS_Bophan.KiemTraMabophan_sua(macu, txt_mabophan.Text) == "true")
                {
                    lb_loi.Text = "Mã bộ phận này đã tồn tại.";
                }
                else
                {
                    if (BUS_Bophan.update(macu,txt_mabophan.Text, txt_tenbophan.Text) == "true")
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadFull();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi từ hệ thống, hãy liên hệ với bộ phận kỹ thuật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadFull();
                    }
                }
            }
        }

        private void bt_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa bộ phận có mã là " + txt_mabophan.Text + " hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BUS_Bophan.delete(txt_mabophan.Text);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadFull();
            }
        }
    }
}