using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BUS;
using DTO;
using System.IO;
using DevExpress.XtraEditors.Repository;
//http:// diendan.congdongcviet.com/showthread.php?t=12606
namespace QLNhanSu
{
    public partial class frmQLNhanvien : Form
    {
        int checkbar;
        public frmQLNhanvien()
        {
            InitializeComponent();

        }
        public frmQLNhanvien(int checkbar)
        {
            this.checkbar = checkbar;
            InitializeComponent();
        }
        //
        // form load
        //
        private void frmQLNhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hopDong._HopDong' table. You can move, or remove it, as needed.
            loadform();
        }
        private void loadform()
        {
            dataselectNV();
            selectHD();
            selectBH();
            LoadComboboxBophan();
        }
        #region selectNV
        //
        // select full information NV
        //
        public void dataselectNV()
        {
            int kt = 0;
            if (checkbophan.Checked == true)
                kt = 1;
            else
                kt = 0;
            GridNhanvien.DataSource = BUS_Nhanvien.selectNhanvien(combBophan.Text, txtten_manv.Text.ToString(), kt,checkbar);
            Binding_hsnv();
        }
        
        // load combobox bo phan
        public void LoadComboboxBophan()
        {
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
        //
        // chonse bo phan 
        //
        private void combBophan_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataselectNV();
            Binding_hsnv();
        }
        // search to ma NV or name NV
        private void txtten_manv_EditValueChanged_1(object sender, EventArgs e)
        {
            dataselectNV();
            Binding_hsnv();
        }

        //
        // test search name bo phan or name or code nv
        //
        private void checkbophan_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkbophan.Checked == true)
                combBophan.Enabled = true;
            else
                combBophan.Enabled = false;
            dataselectNV();
            Binding_hsnv();
        }
        #endregion
        #region Tab_thongtinhnhanvien
        //
        // binding information NV
        //
        public void clearNhanvien()
        {
            maNVTextEdit.Text = "";
            hKTTTextEdit.Text = "";
            gioTinhTextEdit.Text = "";
            maTheTextEdit.Text = "";
            hoLotTextEdit.Text = "";
            tenTextEdit.Text = "";
            ngaySinhDateEdit.Text = "";
            queQuanTextEdit.Text = "";
            maBoPhanTextEdit.Text = "";
            aTMTextEdit.Text = "";
            quocTichTextEdit.Text = "";
            tTHonNhanTextEdit.Text = "";
            ngayLamViecDateEdit.Text = "";
            bangCapTextEdit.Text = "";
            danTocTextEdit.Text = "";
            sDTTextEdit.Text = "";
            cMNDTextEdit.Text = "";
            txtchucvu.Text = "";

        }
        public void Binding_hsnv()
        {
            if (GridNhanvien.MainView.RowCount > 0)
            {
                maNVTextEdit.DataBindings.Clear();
                maNVTextEdit.DataBindings.Add("Text", GridNhanvien.DataSource, "manv");
                hKTTTextEdit.DataBindings.Clear();
                hKTTTextEdit.DataBindings.Add("Text", GridNhanvien.DataSource, "hktt");
                gioTinhTextEdit.DataBindings.Clear();
                gioTinhTextEdit.DataBindings.Add("Text", GridNhanvien.DataSource, "gioitinh");
                maTheTextEdit.DataBindings.Clear();
                maTheTextEdit.DataBindings.Add("Text", GridNhanvien.DataSource, "mathe");
                hoLotTextEdit.DataBindings.Clear();
                hoLotTextEdit.DataBindings.Add("Text", GridNhanvien.DataSource, "holot");
                tenTextEdit.DataBindings.Clear();
                tenTextEdit.DataBindings.Add("Text", GridNhanvien.DataSource, "ten");
                //////////////////////////////
                ngaySinhDateEdit.DataBindings.Clear();
                ngaySinhDateEdit.DataBindings.Add("Text", GridNhanvien.DataSource, "ngaysinh");

                queQuanTextEdit.DataBindings.Clear();
                queQuanTextEdit.DataBindings.Add("Text", GridNhanvien.DataSource, "quequan");
                maBoPhanTextEdit.DataBindings.Clear();
                maBoPhanTextEdit.DataBindings.Add("Text", GridNhanvien.DataSource, "bophan");
                aTMTextEdit.DataBindings.Clear();
                aTMTextEdit.DataBindings.Add("Text", GridNhanvien.DataSource, "atm");
                quocTichTextEdit.DataBindings.Clear();
                quocTichTextEdit.DataBindings.Add("Text", GridNhanvien.DataSource, "quoctich");
                tTHonNhanTextEdit.DataBindings.Clear();
                tTHonNhanTextEdit.DataBindings.Add("Text", GridNhanvien.DataSource, "tthonnhan");
                ngayLamViecDateEdit.DataBindings.Clear();
                ngayLamViecDateEdit.DataBindings.Add("Text", GridNhanvien.DataSource, "ngaylamviec");
                bangCapTextEdit.DataBindings.Clear();
                bangCapTextEdit.DataBindings.Add("Text", GridNhanvien.DataSource, "bangcap");
                danTocTextEdit.DataBindings.Clear();
                danTocTextEdit.DataBindings.Add("Text", GridNhanvien.DataSource, "dantoc");
                sDTTextEdit.DataBindings.Clear();
                sDTTextEdit.DataBindings.Add("Text", GridNhanvien.DataSource, "sdt");
                cMNDTextEdit.DataBindings.Clear();
                cMNDTextEdit.DataBindings.Add("Text", GridNhanvien.DataSource, "cmnd");
                ImageNV.DataBindings.Clear();
                txtchucvu.DataBindings.Clear();
                txtchucvu.DataBindings.Add("Text", GridNhanvien.DataSource, "chucvu");
            }
            else
                clearNhanvien();
        }
        
        //
        // buttion OpenFiledialog to change iamge NV
        //
        private void bteditImage_Click(object sender, EventArgs e)
        {
            if (GridNhanvien.MainView.RowCount > 0)
            {
                OpenFileDialog fileImageChooser = new OpenFileDialog();
                fileImageChooser.Filter = "image file (*.jpg)|*.jpg|All files (*.*)|*.*";
                fileImageChooser.InitialDirectory = "C:\\Users\\Public\\Pictures\\Sample Pictures";
                fileImageChooser.Title = "Chọn 1 hình ảnh";
                if (fileImageChooser.ShowDialog() == DialogResult.OK)
                {
                    ImageNV.ImageLocation = fileImageChooser.FileName;
                }
            }
        }
        
        //
        // save and edit image to database where clip buttion saveImage
        //
        private void btsaveImage_Click(object sender, EventArgs e)
        {
            if (ImageNV.ImageLocation != null)
            {
                BUS_Nhanvien.SaveImageNV(BUS_Nhanvien.imageTobyte(ImageNV.Image), maNVTextEdit.Text);
            }
        }
        //
        // event changed textbox maNV will changee image NV
        //
        private void maNVTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (GridNhanvien.MainView.RowCount > 0)
            {
                ImageNV.Image = null;
                Image img = BUS_Nhanvien.bingImageNV(maNVTextEdit.Text);
                ImageNV.Image = img;
                selectHD();
                selectBH();
            }
                
        }
        #region them 1 nhan vien
        private void ThemNV()
        {
            frmThemNhanvien NV = new frmThemNhanvien();
            NV.reload = new frmThemNhanvien.ReloadNhanvien(dataselectNV);
            NV.Show();
        }
        private void btThem1NV_Click(object sender, EventArgs e)
        {
            ThemNV();
        }
        private void menutrip_nv_them_Click(object sender, EventArgs e)
        {
            ThemNV();
        }
        #endregion
        #region Xóa 1 nhân viên
        public void Xoa1NV()
        {
            if (GridNhanvien.MainView.RowCount > 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa nhân viên " + hoLotTextEdit.Text + " " + tenTextEdit.Text + " hay không", "Nhắc nhở", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (BUS.BUS_Nhanvien.deleteNhanvien(maNVTextEdit.Text) == "true")
                    {
                        MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadform();
                    }
                }
            }
        }
        private void btXoa1NV_Click(object sender, EventArgs e)
        {
            Xoa1NV();
        }
        private void menutris_nv_xoa_Click(object sender, EventArgs e)
        {
            Xoa1NV();
        }
        #endregion

        #region Sua 1 nhan vien
        private void sua1Nv()
        {
            if (GridNhanvien.MainView.RowCount > 0)
            {
                HoSoNhanVien nv = new HoSoNhanVien();
                nv.Gioitinh = gioTinhTextEdit.Text;
                nv.Atm = aTMTextEdit.Text;
                nv.Bangcap = bangCapTextEdit.Text;
                nv.Bophan = maBoPhanTextEdit.Text;
                nv.Chucvu = txtchucvu.Text;
                nv.Cmnd = cMNDTextEdit.Text;
                nv.Dantoc = danTocTextEdit.Text;
                nv.Gioitinh = gioTinhTextEdit.Text;
                nv.Hktt = hKTTTextEdit.Text;
                nv.Holot = hoLotTextEdit.Text;
                nv.Ten = tenTextEdit.Text;
                nv.Tthonnhan = tTHonNhanTextEdit.Text;
                nv.Manv = maNVTextEdit.Text;
                nv.Mathe = maTheTextEdit.Text;
                nv.Ngaylamviec = ngayLamViecDateEdit.Text;
                nv.Ngaysinh = ngaySinhDateEdit.Text;
                nv.Quequan = queQuanTextEdit.Text;
                nv.Quoctich = quocTichTextEdit.Text;
                nv.Sdt = sDTTextEdit.Text;
                frmSuaNhanvien suanv = new frmSuaNhanvien(nv);
                suanv.reload = new frmSuaNhanvien.ReloadNhanvien(dataselectNV);
                suanv.Show();
            }
        }
        private void btsua1NV_Click(object sender, EventArgs e)
        {
            sua1Nv();
        }


        private void menutris_nv_sua_Click(object sender, EventArgs e)
        {
            sua1Nv();
        }
        #endregion
        private void bt_restart_Click(object sender, EventArgs e)
        {
            dataselectNV();
            selectHD();
            selectBH();
        }

        private void menutrip_nv_restart_Click(object sender, EventArgs e)
        {
            dataselectNV();
            selectHD();
            selectBH();
        }
        #endregion
        #region TapHopDong
        public void clearHopdong()
        {
            sohdTextEdit.Text = "";
            loaihdTextEdit.Text = "";
            ngaydhDateEdit.Text = "";
            ngayhhDateEdit.Text = "";
            ngaykihdDateEdit.Text = "";
            dieukhoanTextEdit.Text = "";
            kilanthuSpinEdit.Text = "";
        }
        private void selectHD()
        {
                hopDongGridControl.DataSource = BUS_DMHopdong.selectHopdong(maNVTextEdit.Text);
                if (hopDongGridControl.MainView.RowCount > 0)
                {
                    sohdTextEdit.DataBindings.Clear();
                    sohdTextEdit.DataBindings.Add("Text", hopDongGridControl.DataSource, "sohd");
                    loaihdTextEdit.DataBindings.Clear();
                    loaihdTextEdit.DataBindings.Add("Text", hopDongGridControl.DataSource, "loaihd");
                    ngaykihdDateEdit.DataBindings.Clear();
                    ngaykihdDateEdit.DataBindings.Add("Text", hopDongGridControl.DataSource, "ngaykihd");
                    ngaydhDateEdit.DataBindings.Clear();
                    ngaydhDateEdit.DataBindings.Add("Text", hopDongGridControl.DataSource, "ngayhd");
                    ngayhhDateEdit.DataBindings.Clear();
                    ngayhhDateEdit.DataBindings.Add("Text", hopDongGridControl.DataSource, "ngayhh");
                    dieukhoanTextEdit.DataBindings.Clear();
                    dieukhoanTextEdit.DataBindings.Add("Text", hopDongGridControl.DataSource, "dieukhoan");
                    kilanthuSpinEdit.DataBindings.Clear();
                    kilanthuSpinEdit.DataBindings.Add("Text", hopDongGridControl.DataSource, "kilanthu");
                }
                else
                    clearHopdong();
        }
        private void themHD()
        {
            if (GridNhanvien.MainView.RowCount > 0)
            {
                frmThemHopdong themHD = new frmThemHopdong(maNVTextEdit.Text, hoLotTextEdit.Text, tenTextEdit.Text);
                themHD.Mygetstring = new frmThemHopdong.Getstring(selectHD);
                themHD.Show();
            }
            else
            {
                MessageBox.Show("Bạn hãy chọn nhân viên mới thêm hơp đồng được","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        private void btThem_1hopdong_Click(object sender, EventArgs e)
        {
            themHD();
        }
        private void XoaHD()
        {
            if (BUS.BUS_DMHopdong.DeleteHD(sohdTextEdit.Text) == "true")
            {
                if (hopDongGridControl.MainView.RowCount > 0)
                {

                    if (MessageBox.Show("Bạn có muốn xóa hợp đồng " + sohdTextEdit.Text + " hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("Xóa thành công hợp đồng " + sohdTextEdit.Text + " của nhân viên " + hoLotTextEdit.Text + " " + tenTextEdit.Text);
                        selectHD();
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại hợp đồng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btXoa_1hopdong_Click(object sender, EventArgs e)
        {
            XoaHD();
        }
        private void suaHD()
        {
            if (hopDongGridControl.MainView.RowCount > 0)
            {
                DTO.DMHopdong hd = new DMHopdong();
                hd.Sohd = sohdTextEdit.Text;
                hd.Loaihd = loaihdTextEdit.Text;
                hd.Kilanthu = kilanthuSpinEdit.Text;
                hd.Ngaykihd = ngaykihdDateEdit.Text;
                hd.Ngayhd = ngaydhDateEdit.Text;
                hd.Ngayhh = ngayhhDateEdit.Text;
                hd.Manv = maNVTextEdit.Text;
                hd.Dieukhoan = dieukhoanTextEdit.Text;
                frmSuaHopDong frm = new frmSuaHopDong(hd, hoLotTextEdit.Text + " " + tenTextEdit.Text);
                frm.Mygetvalue = new frmSuaHopDong.GetString(selectHD);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Nhân viên này không có hợp đồng để thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btCapnhat_1hopdong_Click(object sender, EventArgs e)
        {
            suaHD();
        }


        private void menutrip_hd_them_Click(object sender, EventArgs e)
        {
            themHD();
        }

        private void menutrip_hd_xoa_Click(object sender, EventArgs e)
        {
            XoaHD();
        }

        private void menutrip_hd_sua_Click(object sender, EventArgs e)
        {
            suaHD();
        }

        private void menutrip_hd_restart_Click(object sender, EventArgs e)
        {
            selectHD();
        }
        #endregion
        #region TabBaoHiem
        public void dongFormThem()
        {
            selectBH();
        }
        private void selectBH()
        {
                dMBaoHiemGridControl.DataSource = BUS_Baohiem.selectBaohiem(maNVTextEdit.Text);
                if (dMBaoHiemGridControl.MainView.RowCount > 0)
                {
                    sobaohiemTextedit.DataBindings.Clear();
                    sobaohiemTextedit.DataBindings.Add("Text", dMBaoHiemGridControl.DataSource, "sobaohiem");
                    loaibaohiemTextEdit.DataBindings.Clear();
                    loaibaohiemTextEdit.DataBindings.Add("Text", dMBaoHiemGridControl.DataSource, "loaibaohiem");
                    ngaycapDateEdit.DataBindings.Clear();
                    ngaycapDateEdit.DataBindings.Add("Text", dMBaoHiemGridControl.DataSource, "ngaycap");
                    noicapTextEdit.DataBindings.Clear();
                    noicapTextEdit.DataBindings.Add("Text", dMBaoHiemGridControl.DataSource, "noicap");
                    noikhambenhTextEdit.DataBindings.Clear();
                    noikhambenhTextEdit.DataBindings.Add("Text", dMBaoHiemGridControl.DataSource, "noikhambenh");
                    ngaynghiviecDateEdit.DataBindings.Clear();
                    ngaynghiviecDateEdit.DataBindings.Add("Text", dMBaoHiemGridControl.DataSource, "ngaynghiviec");
                }
                else
                    clearBaohiem();
        }
        
        // 
        // Insert thong tin bao hiem khach hang
        //
        public void clearBaohiem()
        {
            sobaohiemTextedit.Text = "";
            loaibaohiemTextEdit.Text = "";
            ngaycapDateEdit.Text = "";
            noicapTextEdit.Text = "";
            noikhambenhTextEdit.Text = "";
            ngaynghiviecDateEdit.Text = "";
        }
        public void ReloadBH()
        {
            selectBH();
        }
        private void themBH()
        {
            if (GridNhanvien.MainView.RowCount > 0)
            {
                string manv1 = maNVTextEdit.Text;
                frmThemBaohiem bh1 = new frmThemBaohiem(manv1, hoLotTextEdit.Text, tenTextEdit.Text);
                bh1.MygetData = new frmThemBaohiem.GetString(ReloadBH);
                bh1.Show();
            }
            else
            {
                MessageBox.Show("hãy chọn nhân viên để thêm bảo hiểm cho nhân viên","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        private void btThem_1baohiem_Click(object sender, EventArgs e)
        {
            themBH();
        }
        private void xoaBH()
        {
            string s = "Bạn có muốn xoá bảo hiểm " + sobaohiemTextedit.Text + " của nhân viên " + hoLotTextEdit.Text + " " + tenTextEdit.Text + " hay không?";
            if (dMBaoHiemGridControl.MainView.RowCount > 0)
            {
                if (MessageBox.Show(s, "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        if (BUS_Baohiem.deleteBaohiem(sobaohiemTextedit.Text) == "true")
                        {
                            if (dMBaoHiemGridControl.MainView.RowCount > 0)
                            {
                                MessageBox.Show("Xoá thành công", "thông báo");
                                selectBH();
                            }
                            else
                            {
                                MessageBox.Show("Không có gì để xoá", "thông báo");
                                clearBaohiem();
                            }
                        }
                        else
                            MessageBox.Show("Có Lỗi của hệ thống, liên hệ với kỹ thuật viên", "thông báo");
                    }
                    catch
                    {
                        MessageBox.Show("Có Lỗi của hệ thống, liên hệ với kỹ thuật viên", "thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có gì để xoá", "thông báo");
                clearBaohiem();
            }
        }
        private void btXoa_1baohiem_Click(object sender, EventArgs e)
        {
            xoaBH();
        }
        private void suaBH()
        {
            if (dMBaoHiemGridControl.MainView.RowCount > 0)
            {
                DMBaohiem BH = new DMBaohiem();
                BH.Sobaohiem = sobaohiemTextedit.Text;
                BH.Loaibaohiem = loaibaohiemTextEdit.Text;
                BH.Ngaycap = ngaycapDateEdit.Text;
                BH.Noicap = noicapTextEdit.Text;
                BH.Noikhambenh = noikhambenhTextEdit.Text;
                BH.Ngaynghiviec = ngaynghiviecDateEdit.Text;
                string manv1 = maNVTextEdit.Text;
                frmSuaBaohiem bh1 = new frmSuaBaohiem(BH, maNVTextEdit.Text, hoLotTextEdit.Text, tenTextEdit.Text);
                bh1.MyGetdata = new frmSuaBaohiem.GetString(ReloadBH);
                bh1.Show();
            }
            else
            {
                MessageBox.Show("Không có bảo hiểm để sửa đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btCapnhat_1baohiem_Click(object sender, EventArgs e)
        {
            suaBH();
        }
        private void menustrip_bh_them_Click(object sender, EventArgs e)
        {
            themBH();
        }

        private void menustrip_bh_xoa_Click(object sender, EventArgs e)
        {
            xoaBH();
        }

        private void menustrip_bh_sua_Click(object sender, EventArgs e)
        {
            suaBH();
        }

        private void menustrip_bh_restart_Click(object sender, EventArgs e)
        {
            selectBH();
        }
        #endregion   

    }
}

