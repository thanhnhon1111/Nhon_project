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
    public partial class frmChucvu : DevExpress.XtraEditors.XtraForm
    {
        bool flag = true;
        string macu = "";
        public frmChucvu()
        {
            InitializeComponent();
        }
        public void binding()
        {
            txt_machucvu.DataBindings.Clear();
            txt_machucvu.DataBindings.Add("Text", grid_chucvu.DataSource, "Machucvu");
            txt_tenchucvu.DataBindings.Clear();
            txt_tenchucvu.DataBindings.Add("Text", grid_chucvu.DataSource, "Tenchucvu");
        }
        public void loadFull()
        {
            txt_machucvu.Text = txt_tenchucvu.Text = "";
            txt_machucvu.Enabled = txt_tenchucvu.Enabled = false;
            grid_chucvu.Enabled = bt_them.Enabled = true;
            bt_restart.Enabled = bt_capnhat.Enabled = false;
            lb_loi.Text = "";
            grid_chucvu.DataSource = BUS_Chucvu.selectChucvu();
            binding();
            if (grid_chucvu.MainView.RowCount > 0)
            {
                bt_sua.Enabled = bt_xoa.Enabled = true;
            }
            else
            {
                bt_xoa.Enabled = bt_sua.Enabled = false;
            }
        }
        private void frmChucvu_Load(object sender, EventArgs e)
        {
            loadFull();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            flag = true;
            txt_machucvu.DataBindings.Clear();
            txt_tenchucvu.DataBindings.Clear();
            txt_machucvu.Text = txt_tenchucvu.Text = "";
            txt_machucvu.Enabled = txt_tenchucvu.Enabled = true;
            bt_capnhat.Enabled = bt_restart.Enabled = true;
            bt_them.Enabled = bt_xoa.Enabled = bt_sua.Enabled = false;
            grid_chucvu.Enabled = false;
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            flag = false;
            macu = txt_machucvu.Text;
            txt_machucvu.DataBindings.Clear();
            txt_tenchucvu.DataBindings.Clear();
            txt_machucvu.Enabled = txt_tenchucvu.Enabled = true;
            bt_capnhat.Enabled = bt_restart.Enabled = true;
            bt_them.Enabled = bt_xoa.Enabled = bt_sua.Enabled = false;
            grid_chucvu.Enabled = false;
        }

        private void bt_restart_Click(object sender, EventArgs e)
        {
            loadFull();
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                if (txt_machucvu.Text == "" || txt_tenchucvu.Text == "")
                {
                    lb_loi.Text = "Hãy điền đầy đủ thông tin.";
                }
                else if (BUS_Chucvu.KiemTraMaChucvu(txt_machucvu.Text) == "true")
                {
                    lb_loi.Text = "Mã bộ phận này đã tồn tại.";
                }
                else
                {
                    if (BUS_Chucvu.insert(txt_machucvu.Text, txt_tenchucvu.Text) == "true")
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
                if (txt_machucvu.Text == "" || txt_tenchucvu.Text == "")
                {
                    lb_loi.Text = "Hãy điền đầy đủ thông tin.";
                }
                else if (BUS_Chucvu.KiemTraMachucvu_sua(macu, txt_machucvu.Text) == "true")
                {
                    lb_loi.Text = "Mã bộ phận này đã tồn tại.";
                }
                else
                {
                    if (BUS_Chucvu.update(macu, txt_machucvu.Text, txt_tenchucvu.Text) == "true")
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
            if (MessageBox.Show("Bạn có muốn xóa chức vụ có mã là " + txt_machucvu.Text + " hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BUS_Chucvu.delete(txt_machucvu.Text);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadFull();
            }
        }
    }
}