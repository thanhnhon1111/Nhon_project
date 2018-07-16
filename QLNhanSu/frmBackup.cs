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
    public partial class frmBackup : DevExpress.XtraEditors.XtraForm
    {
        public frmBackup()
        {
            InitializeComponent();
        }
        #region browse_click
        private void bt_browse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txt_foldername.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        #endregion
        #region thucthi_click
        private void bt_thucthi_Click(object sender, EventArgs e)
        {
            if (txt_foldername.Text == "")
            {
                lb_loi.Text = "Hãy chọn đường dẫn.";
            }
            else if (txt_name.Text == "")
            {
                lb_loi.Text = "Hãy nhập tên cơ sở dữ liệu cần lưu.";
            }
            else
            {
                string url = "";
                string s = txt_foldername.Text;
                string c = s[2].ToString();
                string b = s[s.Length - 1].ToString();
                if (c != b)
                    s = s + c;
                url = s + txt_name.Text + ".bak";
                if (BUS_hethong.backup(url)=="true")
                {
                    lb_loi.Text = "Sao lưu thành công.";
                }
                else
                {
                    lb_loi.Text = "Sao lưu thất bại, hãy kiểm tra đường dẫn.";
                }
            }
        }
        #endregion
        private void bt_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}