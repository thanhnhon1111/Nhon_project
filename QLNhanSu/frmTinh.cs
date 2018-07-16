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
    public partial class frmTinh : DevExpress.XtraEditors.XtraForm
    {
        bool flag = true;
        string macu = "";
        public frmTinh()
        {
            InitializeComponent();
        }
        public void binding()
        {
            txt_ma.DataBindings.Clear();
            txt_ma.DataBindings.Add("Text", grid_tinh.DataSource, "Id");
            txt_ten.DataBindings.Clear();
            txt_ten.DataBindings.Add("Text", grid_tinh.DataSource, "Tentinh");
        }
        public void loadFull()
        {
            txt_ma.Text = txt_ten.Text = "";
            txt_ma.Enabled = txt_ten.Enabled = false;
            grid_tinh.Enabled = bt_them.Enabled = true;
            bt_restart.Enabled = bt_capnhat.Enabled = false;
            lb_loi.Text = "";
            grid_tinh.DataSource = BUS_Tinh.selectTinh();
            binding();
            if (grid_tinh.MainView.RowCount > 0)
            {
                bt_sua.Enabled = bt_xoa.Enabled = true;
            }
            else
            {
                bt_xoa.Enabled = bt_sua.Enabled = false;
            }
        }
        private void frmTinh_Load(object sender, EventArgs e)
        {
            loadFull();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            flag = true;
            txt_ma.DataBindings.Clear();
            txt_ten.DataBindings.Clear();
            txt_ma.Text = txt_ten.Text = "";
            txt_ma.Enabled = txt_ten.Enabled = true;
            bt_capnhat.Enabled = bt_restart.Enabled = true;
            bt_them.Enabled = bt_xoa.Enabled = bt_sua.Enabled = false;
            grid_tinh.Enabled = false;
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            flag = false;
            macu = txt_ma.Text;
            txt_ma.DataBindings.Clear();
            txt_ten.DataBindings.Clear();
            txt_ma.Enabled = txt_ten.Enabled = true;
            bt_capnhat.Enabled = bt_restart.Enabled = true;
            bt_them.Enabled = bt_xoa.Enabled = bt_sua.Enabled = false;
            grid_tinh.Enabled = false;
        }

        private void bt_restart_Click(object sender, EventArgs e)
        {
            loadFull();
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                if (txt_ma.Text == "" || txt_ten.Text == "")
                {
                    lb_loi.Text = "Hãy điền đầy đủ thông tin.";
                }
                else if (BUS_Tinh.KiemTra(txt_ma.Text) == "true")
                {
                    lb_loi.Text = "Mã tỉnh này đã tồn tại.";
                }
                else
                {
                    if (BUS_Tinh.insert(txt_ma.Text, txt_ten.Text) == "true")
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
                if (txt_ma.Text == "" || txt_ten.Text == "")
                {
                    lb_loi.Text = "Hãy điền đầy đủ thông tin.";
                }
                else if (BUS_Tinh.KiemTra_sua(macu, txt_ma.Text) == "true")
                {
                    lb_loi.Text = "Mã tỉnh này đã tồn tại.";
                }
                else
                {
                    if (BUS_Tinh.update(macu, txt_ma.Text, txt_ten.Text) == "true")
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
            if (MessageBox.Show("Bạn có muốn xóa Tỉnh có mã là " + txt_ma.Text + " hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BUS_Tinh.delete(txt_ma.Text);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadFull();
            }
        }
    }
}