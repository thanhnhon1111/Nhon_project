using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QLNhanSu
{
    public partial class frmSuaNhanvien : DevExpress.XtraEditors.XtraForm
    {
        public delegate void ReloadNhanvien();
        public ReloadNhanvien reload;
        public string sochungminh = "";
        public string noicap = "";
        public DateTime ngaycap;
        public HoSoNhanVien nv= new HoSoNhanVien();
        public frmSuaNhanvien()
        {
            InitializeComponent();
        }
        public frmSuaNhanvien(HoSoNhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;
        }
        public void loadcacchucnang()
        {
            maNVTextEdit.Text = BUS.BUS_Nhanvien.MaNhanvien();
            gioTinhTextEdit.Items.Add("Nam");
            gioTinhTextEdit.Items.Add("Nữ");
            gioTinhTextEdit.SelectedItem = "Nam";
            LoadComboboxBophan();
            LoadComboboxChucvu();
            LoadComboboxDantoc();
            cmbHonNhan.Items.Add("Đã kết hôn");
            cmbHonNhan.Items.Add("Độc thân");
            cmbHonNhan.SelectedItem = "Độc thân";
            LoadDataFromQLNV();
        }
        private void LoadDataFromQLNV()
        {
            maNVTextEdit.Text = nv.Manv;
            maTheTextEdit.Text = nv.Mathe;
            hoLotTextEdit.Text = nv.Holot;
            tenTextEdit.Text = nv.Ten;
            gioTinhTextEdit.SelectedItem = nv.Gioitinh;
            ngaySinhDateEdit.Text = nv.Ngaysinh;
            queQuanTextEdit.Text = nv.Quequan;
            hKTTTextEdit.Text = nv.Hktt;
            cMNDTextEdit.Text = nv.Cmnd;
            ngayLamViecDateEdit.Text = nv.Ngaylamviec;
            combBophan.SelectedItem = nv.Bophan;
            bangCapTextEdit.Text = nv.Bangcap;
            aTMTextEdit.Text = nv.Atm;
            cmbHonNhan.SelectedText = nv.Tthonnhan;
            quocTichTextEdit.Text = nv.Quoctich;
            cmbDantoc.SelectedText = nv.Dantoc;
            cmbChucvu.SelectedText = nv.Chucvu;
            sDTTextEdit.Text = nv.Sdt;
            lbhoten.Text = nv.Holot + " " + nv.Ten;

        }
        private void ThemNhanvien_Load(object sender, EventArgs e)
        {
            loadcacchucnang();
        }
        // truyen du lieu tu chi tiet cmnd
        public void GetValue(string s1, string s2, DateTime d)
        {
            cMNDTextEdit.Text = s1;
            sochungminh = s1;
            noicap = s2;
            ngaycap = d;
            this.Show();
        }
        // lay tên bộ phân từ CSDL
        public void LoadComboboxBophan()
        {
            List<Bophan> bp = new List<Bophan>();
            bp = BUS.BUS_Bophan.compoboxBophan();
            for (int i = 0; i < bp.Count; i++)
            {
                combBophan.Items.Add(bp[i].Tenbophan);
            }
            combBophan.SelectedItem = bp[0].Tenbophan;
        }
        // load Combobox chucvu
        public void LoadComboboxChucvu()
        {
            List<ChucVu> cv = new List<ChucVu>();
            cv = BUS.BUS_Chucvu.selectChucvu();
            for (int i = 0; i < cv.Count; i++)
            {
                cmbChucvu.Items.Add(cv[i].Tenchucvu);
            }
            cmbChucvu.SelectedItem = cv[0].Tenchucvu;
        }
        // load Combobox dan toc
        public void LoadComboboxDantoc()
        {
            List<Dantoc> dt = new List<Dantoc>();
            dt = BUS.BUS_Dantoc.selectDantoc();
            for (int i = 0; i < dt.Count; i++)
            {
                cmbDantoc.Items.Add(dt[i].Tendantoc);
            }
            cmbDantoc.SelectedItem = dt[0].Tendantoc;
        }
        public bool KT_Insert()
        {
            bool hl = true;
            if (hoLotTextEdit.Text == "")
            {
                hl = false;
                MessageBox.Show("Lỗi! họ lót nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (hoLotTextEdit.Text.Length > 26)
            {
                hl = false;
                MessageBox.Show("Lỗi! Họ lót của nhân viên không được quá 26 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tenTextEdit.Text == "")
            {
                hl = false;
                MessageBox.Show("Lỗi! Tên nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tenTextEdit.Text.Length > 10)
            {
                hl = false;
                MessageBox.Show("Lỗi! Tên nhân viên không được quá 10 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ngaySinhDateEdit.Text == "")
            {
                hl = false;
                MessageBox.Show("Lỗi! Ngày sinh không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ngaySinhDateEdit.DateTime > DateTime.Now)
            {
                hl = false;
                MessageBox.Show("Lỗi! Ngày sinh được lơn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!KT_Ngay(ngaySinhDateEdit.DateTime, DateTime.Now))
            {
                hl = false;
                MessageBox.Show("Lỗi! Ngày sinh không hợp lệ, Nhân viên này chưa đủ 18 tuổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!KT_Ngay(ngaySinhDateEdit.DateTime, ngayLamViecDateEdit.DateTime))
            {
                hl = false;
                MessageBox.Show("Lỗi! Ngày làm việc không hợp lệ, Nhân viên này chưa đủ 18 tuổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (queQuanTextEdit.Text == "")
            {
                hl = false;
                MessageBox.Show("Lỗi! Quê quán không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (queQuanTextEdit.Text.Length >= 75)
            {
                hl = false;
                MessageBox.Show("Lỗi! Quê quán không được quá 75 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (hKTTTextEdit.Text == "")
            {
                hl = false;
                MessageBox.Show("Lỗi! Hộ khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (hKTTTextEdit.Text.Length >= 75)
            {
                hl = false;
                MessageBox.Show("Lỗi! Hộ khẩu không được quá 75 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (bangCapTextEdit.Text.Length > 15)
            {
                hl = false;
                MessageBox.Show("Lỗi! Bằng cấp không được quá 15 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (aTMTextEdit.Text.Length >= 16)
            {
                hl = false;
                MessageBox.Show("Lỗi! Số thẻ ATM không được quá 16 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (quocTichTextEdit.Text.Length >= 16)
            {
                hl = false;
                MessageBox.Show("Lỗi! Quốc tịch không được quá 16 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sDTTextEdit.Text.Length >= 12)
            {
                hl = false;
                MessageBox.Show("Lỗi! Số điện thoại không được quá 12 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return hl;
        }
        #region Kiem tra Ho lot
        private void hoLotTextEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if (hoLotTextEdit.Text == "")
            {
                image_no_holot.Visible = true;
                image_yes_holot.Visible = false;
                hoLotTextEdit.ToolTip = "Họ lót của nhân viên không được để trống";
            }
            else if (hoLotTextEdit.Text.Length > 26)
            {
                image_no_holot.Visible = true;
                image_yes_holot.Visible = false;
                hoLotTextEdit.ToolTip = "Họ lót của nhân viên không được quá 26 ký tự";
            }
            else
            {
                image_no_holot.Visible = false;
                image_yes_holot.Visible = true;
                hoLotTextEdit.ToolTip = "Nhập họ lót cho nhân viên";
            }
        }
        #endregion
        #region Kiểm tra tên
        private void tenTextEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if (tenTextEdit.Text == "")
            {
                image_no_ten.Visible = true;
                image_yes_ten.Visible = false;
                tenTextEdit.ToolTip = "Tên của nhân viên không được để trống";
            }
            else if (tenTextEdit.Text.Length > 10)
            {
                image_no_ten.Visible = true;
                image_yes_ten.Visible = false;
                tenTextEdit.ToolTip = "Tên của nhân viên không được quá 26 ký tự";
            }
            else
            {
                image_no_ten.Visible = false;
                image_yes_ten.Visible = true;
                tenTextEdit.ToolTip = "Nhập Tên cho nhân viên";
            }
        }
        #endregion
        // kiem tra ngay hop le so voi ngay sinh và ngày hiện tại
        #region Kiểm tra 2 ngày nhân viên đủ 18 tuổi 2 không
        public bool KT_Ngay(DateTime ngay1, DateTime ngay2)
        {
            int ngayht = ngay2.Day;
            int thanght = ngay2.Month;
            int namht = ngay2.Year;
            int ngay = ngay1.Day;
            int thang = ngay1.Month;
            int nam = ngay1.Year;
            bool hople = false;
            if (nam + 18 <= namht)
            {
                if (nam + 18 == namht)
                {
                    if (thang >= thanght)
                    {
                        if (thang == thanght)
                        {
                            if (ngay >= ngayht)
                            {
                                hople = true;
                            }
                            else hople = false;
                        }
                        else hople = true;
                    }
                    else hople = false;
                }
                else hople = true;
            }
            else hople = false;
            return hople;
        }
        #endregion
        #region Kiểm tra ngày sinh
        private void ngaySinhDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (ngaySinhDateEdit.Text == "")
            {
                image_yes_ngaysinh.Visible = false;
                image_no_ngaysinh.Visible = true;
                ngaySinhDateEdit.ToolTip = "Lỗi ! Ngày sinh không được để trống";
            }
            else
            {
                if (ngaySinhDateEdit.DateTime > DateTime.Now)
                {
                    image_yes_ngaysinh.Visible = false;
                    image_no_ngaysinh.Visible = true;
                    ngaySinhDateEdit.ToolTip = "Lỗi ! Ngày sinh không được lớn hơn ngày hiện tại";
                }
                else
                {
                    bool hople = KT_Ngay(ngaySinhDateEdit.DateTime, DateTime.Now);
                    if (hople == false)
                    {
                        image_yes_ngaysinh.Visible = false;
                        image_no_ngaysinh.Visible = true;
                        ngaySinhDateEdit.ToolTip = "Chú ý! nhân viên này chưa đủ 18 tuổi";
                    }
                    else
                    {
                        image_yes_ngaysinh.Visible = true;
                        image_no_ngaysinh.Visible = false;
                        ngaySinhDateEdit.ToolTip = "Chọn ngày sinh cho nhân viên";
                    }
                }
            }
            if (ngayLamViecDateEdit.Text != "")
            {
                bool hople = KT_Ngay(ngaySinhDateEdit.DateTime, ngayLamViecDateEdit.DateTime);
                if (!hople)
                {
                    image_yes_ngaylamviec.Visible = false;
                    image_no_ngaylamviec.Visible = true;
                    ngayLamViecDateEdit.ToolTip = "Nhân viên chưa đủ 18 tuổi";
                }
                else
                {
                    image_yes_ngaylamviec.Visible = true;
                    image_no_ngaylamviec.Visible = false;
                    ngayLamViecDateEdit.ToolTip = "Hợp lệ";
                }
            }
        }
        #endregion
        #region kiểm tra quê quán
        private void queQuanTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (queQuanTextEdit.Text == "")
            {
                image_no_quequan.Visible = true;
                image_yes_quequan.Visible = false;
                queQuanTextEdit.ToolTip = "Lỗi ! Nội dung này không được để trống";
            }
            else if (queQuanTextEdit.Text.Length >= 75)
            {
                image_no_quequan.Visible = true;
                image_yes_quequan.Visible = false;
                queQuanTextEdit.ToolTip = "Lỗi ! Không được quá 75 ký tự";
            }
            else
            {
                image_no_quequan.Visible = false;
                image_yes_quequan.Visible = true;
                queQuanTextEdit.ToolTip = "Nhập quê quán cho nhân viên";
            }
        }
        #endregion
        #region Kiểm tra hộ khẩu
        private void hKTTTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (hKTTTextEdit.Text == "")
            {
                image_no_hktt.Visible = true;
                image_yes_hktt.Visible = false;
                hKTTTextEdit.ToolTip = "Lỗi ! Nội dung này không được để trống";
            }
            else if (hKTTTextEdit.Text.Length >= 75)
            {
                image_no_hktt.Visible = true;
                image_yes_hktt.Visible = false;
                hKTTTextEdit.ToolTip = "Lỗi ! Không được quá 75 ký tự";
            }
            else
            {
                image_no_hktt.Visible = false;
                image_yes_hktt.Visible = true;
                hKTTTextEdit.ToolTip = "Nhập Hộ khẩu thường trú cho nhân viên";
            }
        }
        #endregion
        #region kiểm tra ngày làm việc
        private void ngayLamViecDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (ngayLamViecDateEdit.Text == "")
            {
                image_no_ngaylamviec.Visible = image_yes_ngaylamviec.Visible = false;
            }
            else
            {
                if (ngaySinhDateEdit.Text != "")
                {
                    bool hople = KT_Ngay(ngaySinhDateEdit.DateTime, ngayLamViecDateEdit.DateTime);
                    if (!hople)
                    {
                        image_yes_ngaylamviec.Visible = false;
                        image_no_ngaylamviec.Visible = true;
                        ngayLamViecDateEdit.ToolTip = "Nhân viên chưa đủ 18 tuổi";
                    }
                    else
                    {
                        image_yes_ngaylamviec.Visible = true;
                        image_no_ngaylamviec.Visible = false;
                        ngayLamViecDateEdit.ToolTip = "Nhân viên chưa đủ 18 tuổi";
                    }
                }
            }
        }
        #endregion
        #region kiểm tra bằng cấp
        private void bangCapTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (bangCapTextEdit.Text == "")
            {
                image_no_bangcap.Visible = image_yes_bangcap.Visible = false;
                bangCapTextEdit.ToolTip = "Nhập bằng cấp cho nhân viên";
            }
            else if (bangCapTextEdit.Text.Length > 15)
            {
                image_yes_bangcap.Visible = false;
                image_no_bangcap.Visible = true;
                bangCapTextEdit.ToolTip = "Lỗi! nội dung này không được nhập quá 15 ký tự";
            }
            else
            {
                image_yes_bangcap.Visible = true;
                image_no_bangcap.Visible = false;
                bangCapTextEdit.ToolTip = "Bằng cấp của nhân viên";
            }
        }
        #endregion
        #region click bution image Chứng minh nhân dân
        private void image_yes_cmnd_Click(object sender, EventArgs e)
        {
            if (ngaySinhDateEdit.Text != "" && KT_Ngay(ngaySinhDateEdit.DateTime, DateTime.Now))
            {
                frmThemCmndChitiet cmnd = new frmThemCmndChitiet(DateTime.Parse(ngaySinhDateEdit.Text), sochungminh, noicap, ngaycap);
                cmnd.Myget = new frmThemCmndChitiet.Getstring(GetValue);
                this.Hide();
                cmnd.Show();
            }

        }
        #endregion
        #region Kiểm tra ATM
        private void aTMTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (aTMTextEdit.Text == "")
            {
                image_no_atm.Visible = false;
                image_yes_atm.Visible = false;
                aTMTextEdit.ToolTip = "Nhập số thẻ ATM nhân viên";
            }
            else if (aTMTextEdit.Text.Length >= 16)
            {
                image_no_atm.Visible = true;
                image_yes_atm.Visible = false;
                aTMTextEdit.ToolTip = "Số tài thẻ không được quá 16 ký tự";
            }
            else
            {
                image_no_atm.Visible = false;
                image_yes_atm.Visible = true;
                aTMTextEdit.ToolTip = "Nhập số thẻ ATM nhân viên";
            }

        }
        #endregion
        #region kiểm tra quốc tịch
        private void quocTichTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (quocTichTextEdit.Text == "")
            {
                image_no_quoctich.Visible = false;
                image_yes_quoctich.Visible = false;
                quocTichTextEdit.ToolTip = "Nhập quốc tịch cho nhân viên";
            }
            else if (quocTichTextEdit.Text.Length >= 16)
            {
                image_no_quoctich.Visible = true;
                image_yes_quoctich.Visible = false;
                aTMTextEdit.ToolTip = "Quốc tịch không được quá 16 ký tự";
            }
            else
            {
                image_no_quoctich.Visible = false;
                image_yes_quoctich.Visible = true;
                quocTichTextEdit.ToolTip = "Nhập quốc tịch cho nhân viên";
            }
        }
        #endregion
        #region Kiểm tra số điện thoại
        private void sDTTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void sDTTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (sDTTextEdit.Text == "")
            {
                image_sdt_no.Visible = image_sdt_yes.Visible = false;
                sDTTextEdit.ToolTip = "Nhập số điện thoài liên hệ với nhân viên";
            }
            else if (sDTTextEdit.Text.Length >= 12)
            {
                image_sdt_yes.Visible = false;
                image_sdt_no.Visible = true;
                sDTTextEdit.ToolTip = "Số điện thoại bạn nhập không hợp lệ";
            }
            else
            {
                image_sdt_no.Visible = false;
                image_sdt_yes.Visible = true;
                sDTTextEdit.ToolTip = "Nhập số điện thoài liên hệ với nhân viên";
            }
        }
        #endregion

        private void btCapnhat_Click(object sender, EventArgs e)
        {
           if (KT_Insert())
            {
            HoSoNhanVien nv = new HoSoNhanVien();
            ChungminhChitiet cmnd = new ChungminhChitiet();
            nv.Manv = maNVTextEdit.Text;
            nv.Holot = hoLotTextEdit.Text;
            nv.Ten = tenTextEdit.Text;
            nv.Mathe = maTheTextEdit.Text;
            nv.Bophan = combBophan.Text;
            nv.Atm = aTMTextEdit.Text;
            nv.Thoiviec = "";
            nv.Chucvu = cmbChucvu.Text;

            if (gioTinhTextEdit.Text == "Nam")
                nv.Gioitinh = "1";
            else nv.Gioitinh = "0";
            nv.Ngaysinh = ngaySinhDateEdit.Text;

            nv.Quequan = queQuanTextEdit.Text;

            nv.Hktt = hKTTTextEdit.Text;
            nv.Cmnd = cMNDTextEdit.Text;

            nv.Ngaylamviec = ngayLamViecDateEdit.Text;

            nv.Bangcap = bangCapTextEdit.Text;

            if (cmbHonNhan.Text == "Đã kết hôn")
                nv.Tthonnhan = "1";
            else nv.Tthonnhan = "0";
            nv.Dantoc = cmbDantoc.Text;
            nv.Quoctich = quocTichTextEdit.Text;
            nv.Sdt = sDTTextEdit.Text;
            cmnd.Socmnd = sochungminh;
            cmnd.Noicap = noicap;
            cmnd.Ngaycap = ngaycap.ToString();

            if (BUS.BUS_Nhanvien.updateNhanVien(nv) == "true")
            {
                MessageBox.Show("Sửa thông tin cho nhân viên "+lbhoten.Text+" thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reload();
                this.Close();
            }
            else
            {
                MessageBox.Show("lỗi từ hệ thống không thể thêm sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
