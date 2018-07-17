using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DevExpress.XtraEditors;

namespace QLNhanSu
{
    public partial class frmQltangca : DevExpress.XtraEditors.XtraForm
    {
        public frmQltangca()
        {
            InitializeComponent();
        }
        #region load
        private void frmQltangca_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                cmbThang.Items.Add(i.ToString());
            }
            cmbThang.SelectedItem = DateTime.Now.Month.ToString();
            for (int i = 1990; i <= DateTime.Now.Year; i++)
            {
                cmbNam.Items.Add(i.ToString());
            }
            cmbNam.SelectedItem = DateTime.Now.Year.ToString();
        }
        private void loadFull()
        {
            gridTangca.DataSource = BUS.BUS_Tangca.select(cmbThang.Text, cmbNam.Text);
            bind();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            loadFull();
        }
        private void restart_Click(object sender, EventArgs e)
        {
            loadFull();
        }
        #endregion
        #region them
        public void them_1()
        {
            frmThemtangca frm = new frmThemtangca();
            frm.reload = new frmThemtangca.Reload(loadFull);
            frm.Show();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            them_1();
        }
        private void them_Click(object sender, EventArgs e)
        {
            them_1();
        }
        private void bind()
        {
            lbManv.DataBindings.Clear();
            lbManv.DataBindings.Add("Text", gridTangca.DataSource, "Manv");
        }
        #endregion
        #region xoa
        private void xoa_1()
        {
            if (gridTangca.MainView.RowCount > 0)
            {
                if (MessageBox.Show(
                    "Bạn có muốn xóa toàn bộ tăng ca trong tháng " + cmbThang.Text + "-" + cmbNam.Text + " của nhân viên " + lbManv.Text + " ",
                    "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (BUS_Tangca.delete_tangCaTheoThang(lbManv.Text, cmbThang.Text, cmbNam.Text) != "true")
                    {
                        MessageBox.Show("Lỗi từ hệ thống! xin liên hệ bộ phận kỹ thuật", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        gridTangca.DataSource = BUS_Tangca.select(cmbThang.Text, cmbNam.Text);
                }
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            xoa_1();
        }
        private void xoa_Click(object sender, EventArgs e)
        {
            xoa_1();
        }
        #endregion
        #region chi tiet Gio Tang ca Nhan vien
        private void chitiet()
        {
            if (gridTangca.MainView.RowCount > 0)
            {
                frmChitietTangca frm = new frmChitietTangca(lbManv.Text, cmbThang.Text, cmbNam.Text);
                frm.reload = new frmChitietTangca.Reload(loadFull);
                frm.Show();
            }
        }
        private void btChitiet_Click(object sender, EventArgs e)
        {
            chitiet();
        }
        private void xemchitiet_Click(object sender, EventArgs e)
        {
            chitiet();
        }
        #endregion
        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inbaocao_Click(object sender, EventArgs e)
        {

        }

       
    }
}