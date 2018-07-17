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
    public partial class frmPhucapNhanvien : DevExpress.XtraEditors.XtraForm
    {
        int checkbar;
        private string macu, mamoi;
        int flag = 0;
        public frmPhucapNhanvien()
        {
            InitializeComponent();
        }

        private void frmPhucapNhanvien_Load(object sender, EventArgs e)
        {
            loadFull();
        }
        #region load
        private void loadFull()
        {
            LoadComboboxBophan();
            dataselectNV();
            cmbmapc.Items.Clear();
            cmbmapc.Items.Add("Hãy chọn phụ cấp cho nhân viên");
            List<DMPhucap> pc =BUS_Phucap.selectPhucap();
            for (int i = 0; i < pc.Count; i++)
                cmbmapc.Items.Add(pc[i].Maloaipc);
            if (GridNhanvien.MainView.RowCount <= 0)
                    clear();
            flag = 0;

        }
        private void clear()
        {
            txtManv.Text = txtHoten.Text = txtBophan.Text = "";
            cmbmapc.Text = txtTenpc.Text = txtTenpc.Text = "";
        }
        public void dataselectNV()
        {
            int kt = 0;
            if (checkbophan.Checked == true)
                kt = 1;
            else
                kt = 0;
            GridNhanvien.DataSource = BUS_Nhanvien.selectNhanvien(combBophan.Text, txtten_manv.Text.ToString(), kt, checkbar);
            Binding_hsnv();
        }

        // load combobox bo phan
        public void LoadComboboxBophan()
        {
            combBophan.Items.Clear();
            List<Bophan> bp = new List<Bophan>();
            bp = BUS_Bophan.compoboxBophan();
            combBophan.Text = "Chọn bộ phận";
            for (int i = 0; i < bp.Count; i++)
            {
                combBophan.Items.Add(bp[i].Tenbophan);
                combBophan.DisplayMember = bp[i].Tenbophan;
                combBophan.ValueMember = bp[i].Mabophan;
            }
        }
        public void Binding_hsnv()
        {
            txtManv.DataBindings.Clear();
            txtManv.DataBindings.Add("Text",GridNhanvien.DataSource,"Manv");
            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("Text", GridNhanvien.DataSource, "Hoten");
            txtBophan.DataBindings.Clear();
            txtBophan.DataBindings.Add("Text", GridNhanvien.DataSource, "Bophan");
        }

        private void checkbophan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbophan.Checked == true)
                combBophan.Enabled = true;
            else
                combBophan.Enabled = false;
            dataselectNV();
            Binding_hsnv();
        }

        private void combBophan_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataselectNV();
            Binding_hsnv();
        }

        private void txtten_manv_EditValueChanged(object sender, EventArgs e)
        {
            dataselectNV();
            Binding_hsnv();
        }

#endregion
        public void loadPhucap()
        {
            DataTable dt = BUS_Phucap.selectPC_Nhanvien(txtManv.Text);
            gridPhucapNhanvien.DataSource = dt;
            cmbmapc.DataBindings.Clear();
            cmbmapc.DataBindings.Add("Text", gridPhucapNhanvien.DataSource, "maloaipc");
            txtTenpc.DataBindings.Clear();
            txtTenpc.DataBindings.Add("Text", gridPhucapNhanvien.DataSource, "tenloai");
            txtTienpc.DataBindings.Clear();
            txtTienpc.DataBindings.Add("Text", gridPhucapNhanvien.DataSource, "tien");
            btThem.Enabled = true;
            if (gridPhucapNhanvien.MainView.RowCount > 0)
            {
                btXoa.Enabled = btSua.Enabled = true;
            }
            else
            {
                btXoa.Enabled = btSua.Enabled = false;
                cmbmapc.Text = "Hãy chọn phụ cấp cho nhân viên";
                txtTenpc.Text=txtTienpc.Text= "";
            }
            cmbmapc.Enabled = false;
            btCapnhat.Enabled = false;
            btThem.Enabled =  true;
            flag = 0;
        }
        private void txtManv_EditValueChanged(object sender, EventArgs e)
        {
            loadPhucap();
        }

        private void cmbmapc_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbmapc.Text != "Hãy chọn phụ cấp cho nhân viên")
            {
                DataTable dt = BUS_Phucap.select_ma(cmbmapc.Text);
                txtTenpc.Text = dt.Rows[0]["tenloai"].ToString();
                txtTienpc.Text = dt.Rows[0]["tien"].ToString();
            }
            else
            {
                txtTenpc.Text = "";
                txtTienpc.Text = "";
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            cmbmapc.Enabled = true;
            cmbmapc.SelectedItem = "Hãy chọn phụ cấp cho nhân viên";
            btThem.Enabled = btSua.Enabled = btXoa.Enabled = false;
            btCapnhat.Enabled = true;
        }
        private void them()
        {
            if (GridNhanvien.MainView.RowCount > 0)
            {
                if (cmbmapc.Text != "Hãy chọn phụ cấp cho nhân viên")
                {
                    if (BUS_Phucap.insert_chitietphucap(txtManv.Text, cmbmapc.Text) != "true")
                    {
                        MessageBox.Show("Nhân viên " + txtHoten.Text + " đã tồn tại phụ cấp " + txtTenpc.Text + " rồi", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        loadPhucap();
                }
            }
        }
        public void update()
        {
            if (cmbmapc.Text != "Hãy chọn phụ cấp cho nhân viên")
            {
                if (BUS_Phucap.update_chitietPC(txtManv.Text, macu, cmbmapc.Text) == "true")
                {
                    loadPhucap();
                }
                else
                {
                    MessageBox.Show("Nhân viên " + txtHoten.Text + " đã tồn tại phụ cấp " + txtTenpc.Text + " rồi", "Thông báo",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btCapnhat_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                them();
            }
            else
            {
                update();
            }
        }

        private void bt_restart_Click(object sender, EventArgs e)
        {
            loadFull();
        }

        private void btRestart_Phucap_Click(object sender, EventArgs e)
        {
            loadPhucap();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xoaPC()
        {
            if (MessageBox.Show("Bạn muốn xóa phụ cấp "+txtTenpc.Text+" của nhân viên "+txtHoten.Text+" ", "Thông báo", 
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (BUS_Phucap.delete_PC(txtManv.Text, cmbmapc.Text) == "true")
                {
                    loadPhucap();
                }
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            xoaPC();
        }

        private void cmbmapc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void btSua_Click(object sender, EventArgs e)
        {
            flag = 0;
            btSua.Enabled = btThem.Enabled = btXoa.Enabled = false;
            btCapnhat.Enabled = true;
            macu = cmbmapc.Text;
            cmbmapc.Enabled = true;
        }
    }
}