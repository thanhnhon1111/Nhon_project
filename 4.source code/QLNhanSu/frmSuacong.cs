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
    public partial class frmSuacong : DevExpress.XtraEditors.XtraForm
    {
        public delegate void Reload();
        public Reload reload;
        DTO.DMBangcong b = new DMBangcong();
        #region load
        public frmSuacong()
        {
            InitializeComponent();
        }
        public frmSuacong(DTO.DMBangcong bc)
        {
            InitializeComponent();
            
            b = bc;
        }
        private void frmThemcong_Load(object sender, EventArgs e)
        {
            loadDanhsach();
        }
        public void loadDanhsach()
        {
            List<DTO.DMLoaicong> dt = BUS.BUS_Loaicong.selectLoaicong();
            cmbLoaicong.DataSource = dt;
            cmbLoaicong.DisplayMember = "tenloai";
            txtManv.Text = b.Manv;
            string s = BUS_Loaicong.laytenTuMa(b.Maloaicong);
            cmbLoaicong.SelectedItem = s;
            date_ngaycong.DateTime = DateTime.Parse((b.Ngay + "/" + b.Thang + "/" + b.Nam));
            txtGiovao.Text = b.Giovao.ToString();
            txtGiora.Text = b.Giora.ToString();
            txtPhutvao.Text = b.Phutvao.ToString();
            txtphutra.Text = b.Phutra.ToString();
        }
        #endregion
        // kiem tra thoi gian
        #region kiem tra thoi gian gio phut
        public bool kiemtra_thoigian()
        {
            if (int.Parse(txtGiovao.Text.ToString()) < 0) return false;
            if (int.Parse(txtGiovao.Text.ToString()) > 23) return false;
            if (int.Parse(txtGiora.Text.ToString()) > 23) return false;
            if (int.Parse(txtGiora.Text.ToString()) < 0) return false;
            if (int.Parse(txtphutra.Text.ToString()) < 0) return false;
            if (int.Parse(txtPhutvao.Text.ToString()) < 0) return false;
            if (int.Parse(txtphutra.Text.ToString()) > 59) return false;
            if (int.Parse(txtPhutvao.Text.ToString()) > 59) return false;
            return true;
        }
        #endregion
        // kiem tra toan bo truoc khi them
        #region kiem tra toan bo truoc khi them
        private bool kiemtra_update()
        {
            bool kt = true;
            if (txtManv.Text == "" || date_ngaycong.Text == "" || txtGiora.Text == "" || txtGiovao.Text == "" || txtphutra.Text == "" || txtPhutvao.Text == "")
            {
                kt = false;
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (date_ngaycong.DateTime > DateTime.Now)
            {
                kt = false;
                MessageBox.Show("Ngày công của nhân viên phải nhỏ hơn ngày hiện tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!BUS.BUS_Nhanvien.kiemtra_ngaycong_ngayvaolam(txtManv.Text, date_ngaycong.DateTime))
            {
                kt = false;
                MessageBox.Show("Ngày công của nhân viên phải lớn hơn ngày vào làm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!BUS_Bangcong.kiemtra_ngaycong_trung_sua(txtManv.Text, date_ngaycong.DateTime,b.Ngay.ToString()))
            {
                kt = false;
                MessageBox.Show("Ngày công " + date_ngaycong.Text + " của nhân viên có mã " + txtManv.Text + " đã tồn tại ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!kiemtra_thoigian())
            {
                kt = false;
                MessageBox.Show("Thời gian giờ/ phút không hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return kt;
        }
        #endregion
        // them sua cong
        #region sua cong
        private void _update()
        {
            if (kiemtra_update())
            {
                DMBangcong bc = new DMBangcong();
                bc.Ngay = date_ngaycong.DateTime.Day;
                bc.Thang = date_ngaycong.DateTime.Month;
                bc.Nam = date_ngaycong.DateTime.Year;
                bc.Manv = txtManv.Text;
                bc.Maloaicong = cmbLoaicong.Text;
                bc.Giovao = int.Parse(txtGiovao.Text.ToString());
                bc.Giora = int.Parse(txtGiora.Text.ToString());
                bc.Phutra = int.Parse(txtphutra.Text.ToString());
                bc.Phutvao = int.Parse(txtPhutvao.Text.ToString());
                if (BUS_Bangcong._update(bc,b.Ngay.ToString(),b.Thang.ToString(),b.Nam.ToString()) == "true")
                {
                    MessageBox.Show("Sửa công thành công cho nhân viên có mã là: " + txtManv.Text + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reload();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi từ hệ thống, hãy liên hệ với bộ phận kỹ thuật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            _update();
        }
        #endregion
        // event kiem tra
        #region su kien kiem tra
        private void txtGiovao_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtGiovao.Text == "")
            {
                txtGiovao.ForeColor = Color.Red;
                txtGiovao.ToolTip = "Giờ vào không hợp lệ";
            }
            else if (int.Parse(txtGiovao.Text.ToString()) < 0 || int.Parse(txtGiovao.Text.ToString()) > 23)
            {
                txtGiovao.ForeColor = Color.Red;
                txtGiovao.ToolTip = "Giờ vào không hợp lệ";
            }
            else
            {
                txtGiovao.ForeColor = Color.DodgerBlue;
                txtGiovao.ToolTip = "Nhập giờ vào";
            }
        }

        private void txtGiora_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtGiora.Text == "")
            {
                txtGiora.ForeColor = Color.Red;
                txtGiora.ToolTip = "Giờ ra không hợp lệ";
            }
            else if (int.Parse(txtGiora.Text.ToString()) < 0 || int.Parse(txtGiora.Text.ToString()) > 23)
            {
                txtGiora.ForeColor = Color.Red;
                txtGiora.ToolTip = "Giờ ra không hợp lệ";
            }
            else
            {
                txtGiora.ForeColor = Color.DodgerBlue;
                txtGiora.ToolTip = "Nhập giờ ra";
            }
        }

        private void txtPhutvao_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPhutvao.Text == "")
            {
                txtPhutvao.ForeColor = Color.Red;
                txtPhutvao.ToolTip = "Phút vào không hợp lệ";
            }
            else if (int.Parse(txtPhutvao.Text.ToString()) < 0 || int.Parse(txtPhutvao.Text.ToString()) > 59)
            {
                txtPhutvao.ForeColor = Color.Red;
                txtPhutvao.ToolTip = "Phút vào không hợp lệ";
            }
            else
            {
                txtPhutvao.ForeColor = Color.DodgerBlue;
                txtPhutvao.ToolTip = "Nhập phút vào";
            }
        }

        private void txtphutra_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtphutra.Text == "")
            {
                txtphutra.ForeColor = Color.Red;
                txtphutra.ToolTip = "Phút ra không hợp lệ";
            }
            else if (int.Parse(txtphutra.Text.ToString()) < 0 || int.Parse(txtphutra.Text.ToString()) > 59)
            {
                txtphutra.ForeColor = Color.Red;
                txtphutra.ToolTip = "Phút ra không hợp lệ";
            }
            else
            {
                txtphutra.ForeColor = Color.DodgerBlue;
                txtphutra.ToolTip = "Nhập phút ra";
            }
        }

        private void txtGiovao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhutvao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtphutra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void date_ngaycong_EditValueChanged(object sender, EventArgs e)
        {
            if (date_ngaycong.Text == "")
            {
                date_ngaycong.ForeColor = Color.Red;
            }
            else if (date_ngaycong.DateTime > DateTime.Now)
            {
                date_ngaycong.ForeColor = Color.Red;
            }
            else if (!BUS.BUS_Nhanvien.kiemtra_ngaycong_ngayvaolam(txtManv.Text, date_ngaycong.DateTime))
            {
                date_ngaycong.ForeColor = Color.Red;
            }
            else if (!BUS_Bangcong.kiemtra_ngaycong_trung_sua(txtManv.Text, date_ngaycong.DateTime, b.Ngay.ToString()))
            {
                date_ngaycong.ForeColor = Color.Red;
            }
            else
            {
                date_ngaycong.ForeColor = Color.DodgerBlue;
            }
        }
        #endregion
        #region close
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}