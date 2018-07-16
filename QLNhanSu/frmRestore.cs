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
    public partial class frmRestore : DevExpress.XtraEditors.XtraForm
    {
        int a = 0;

        public delegate void Reload();
        public Reload reload;
        public frmRestore()
        {
            InitializeComponent();
        }
        public frmRestore(int a)
        {
            InitializeComponent();
            this.a = a;
            labelControl1.Text = "TẠO CƠ SỞ DỮ LIỆU";
        }
        #region buttion browse
        private void bt_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.Filter = "bak file|*.bak";
            fileChooser.InitialDirectory = "C:\\";
            fileChooser.Title = "Chọn file *.bak để phục hồi";
            if (fileChooser.ShowDialog() == DialogResult.OK)
            {
                txt_foldername.Text = fileChooser.FileName;
            }
        }
        #endregion
        #region close
        private void bt_dong_Click(object sender, EventArgs e)
        {
            Dispose();
            this.Close();
        }
        #endregion
        #region thuc thi
        private void bt_thucthi_Click(object sender, EventArgs e)
        {

            if (txt_foldername.Text == "")
            {
                lb_loi.Text = "Hãy chọn đường dẫn.";
            }
            else
            {
                string url = txt_foldername.Text;
                if (BUS_hethong.restore(url,a))
                {
                    if (a == 0)
                        lb_loi.Text = "Phục hồi lưu thành công.";
                    else
                    {
                        lb_loi.Text = "Tạo cơ sở dữ liệu thành công";
                        reload();
                        this.Close();
                    }
                }
                else
                {
                    if (a == 0)
                        lb_loi.Text = "Phục hồi thất bại, hãy kiểm tra đường dẫn.";
                    else
                        lb_loi.Text = "Tạo cơ sở dữ liệu thất bại";
                }
            }
        }
        #endregion
        private void frmRestore_Load(object sender, EventArgs e)
        {

        }

        private void frmRestore_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}