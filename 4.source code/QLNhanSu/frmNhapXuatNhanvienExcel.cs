using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Excel1 = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Data.OleDb;
using Excel;
using System.Reflection;
namespace QLNhanSu
{
    public partial class frmNhapXuatNhanvienExcel : DevExpress.XtraEditors.XtraForm
    {
        public frmNhapXuatNhanvienExcel()
        {
            InitializeComponent();
            cmb_luachon.SelectedItem = "Xuất toàn bộ thông tin nhân viên";
        }

        public void loadThongTinForm()
        {
            
        }

        private void radioNhapXuatExcel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioNhapXuatExcel.SelectedIndex == 0)
            {
                XuatNvExcel_group.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization;
                NhapNvExcel_group.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                XuatNvExcel_group.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                NhapNvExcel_group.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization;
            }
        }
        public void LoadBophan()
        {
            List<DTO.Bophan> bp = new List<DTO.Bophan>();
            bp = BUS.BUS_Bophan.compoboxBophan();
            if (cmb_bophan.Items.Count > 0)
                cmb_bophan.Items.Clear();
            cmb_bophan.Items.Add("---Chọn tên bộ phận cần thực thi---");
            for (int i = 0; i < bp.Count; i++)
            {
                 cmb_bophan.Items.Add(bp[i].Tenbophan);
                 cmb_bophan.ValueMember = bp[i].Mabophan;
                 cmb_bophan.DisplayMember = bp[i].Mabophan;
            }
            cmb_bophan.SelectedItem = "---Chọn tên bộ phận cần thực thi---";
        }
        public void LoadChucvu()
        {
            List<DTO.ChucVu> cv = new List<DTO.ChucVu>();
            cv = BUS.BUS_Chucvu.selectChucvu();
            if (cmb_bophan.Items.Count > 0)
                cmb_bophan.Items.Clear();
            cmb_bophan.Items.Add("---Chọn tên chức vụ thực thi---");
            for (int i = 0; i < cv.Count; i++)
            {
                cmb_bophan.Items.Add(cv[i].Tenchucvu);
                cmb_bophan.DisplayMember = cv[i].Machucvu;
                cmb_bophan.ValueMember = cv[i].Machucvu;
            }
            cmb_bophan.SelectedItem = "---Chọn tên chức vụ thực thi---";
        }
        private void cmb_luachon_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_luachon.SelectedItem == "Xuất toàn bộ thông tin nhân viên")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization;
            }
            else if (cmb_luachon.SelectedItem == "Chỉ xuất theo bộ phận")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                LoadBophan();
            }
            else
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                LoadChucvu();
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Xuat excel
        public void selectNhanvienExcle(int luachon,string k)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            Excel1.Workbook xlWorkBook = xla.Workbooks.Add(Excel1.XlSheetType.xlWorksheet);
            Excel1.Worksheet xlWorkSheet = (Excel1.Worksheet)xla.ActiveSheet;
            xla.Visible = true;
            List<DTO.HoSoNhanVien> nv = new List<DTO.HoSoNhanVien>();
            nv = BUS.BUS_Nhanvien.selectNhanvienfull(luachon,k);

            xlWorkSheet.get_Range("a1", "s1").Merge(false);
            xlWorkSheet.get_Range("a1", "s1").HorizontalAlignment = 3;
            xlWorkSheet.get_Range("a1", "s1").VerticalAlignment = 3;
            xlWorkSheet.Cells[1][1] = "Công Ty Cổ Phần SANFAN Việt Nam";

            xlWorkSheet.get_Range("a2", "s2").Merge(false);
            xlWorkSheet.get_Range("a2", "s2").HorizontalAlignment = 3;
            xlWorkSheet.get_Range("a2", "s2").VerticalAlignment = 3;
            xlWorkSheet.Cells[1][2] = "DANH SÁCH NHÂN VIÊN";

            xlWorkSheet.Range["A4:s4"].Font.Color = Color.Red;
            xlWorkSheet.get_Range("a4", "s4").Font.Bold = true;

            xlWorkSheet.Cells[1][4] = "Mã NV"; //xlWorkSheet.get_Range("a1", "s1").Merge(false);
            xlWorkSheet.Cells[2][4] = "Mã Thẻ";
            xlWorkSheet.Cells[3][4] = "Họ lót";
            xlWorkSheet.Cells[4][4] = "Tên";
            xlWorkSheet.Cells[5][4] = "Ngày sinh";
            xlWorkSheet.Cells[6][4] = "Giới tính(1/0:Nam/Nữ)";
            xlWorkSheet.Cells[7][4] = "Quê quán";
            xlWorkSheet.Cells[8][4] = "Quốc tịch";
            xlWorkSheet.Cells[9][4] = "Số điện thoại";
            xlWorkSheet.Cells[10][4] = "Bằng cấp";
            xlWorkSheet.Cells[11][4] = "Bộ phận";
            xlWorkSheet.Cells[12][4] = "Chức vụ";
            xlWorkSheet.Cells[13][4] = "Số CMND";
            xlWorkSheet.Cells[14][4] = "Dân tộc";
            xlWorkSheet.Cells[15][4] = "Hộ khẩu tt";
            xlWorkSheet.Cells[16][4] = "TT hôn nhân";
            xlWorkSheet.Cells[17][4] = "Số thẻ ATM";
            xlWorkSheet.Cells[18][4] = "Ngày làm việc";
            xlWorkSheet.Cells[19][4] = "Ghi chú";
            for (int i = 0; i < nv.Count; i++)
            {
                int j=1;
                xlWorkSheet.Cells[j++][i + 5] = "'"+nv[i].Manv.ToString();
                xlWorkSheet.Cells[j++][i + 5] = "'" + nv[i].Mathe.ToString();
                xlWorkSheet.Cells[j++][i + 5] = nv[i].Holot.ToString();
                xlWorkSheet.Cells[j++][i + 5] =  nv[i].Ten.ToString();
                xlWorkSheet.Cells[j++][i + 5] = "'" + nv[i].Ngaysinh.ToString();
                xlWorkSheet.Cells[j++][i + 5] = "" + nv[i].Gioitinh.ToString();
                xlWorkSheet.Cells[j++][i + 5] = nv[i].Quequan.ToString();
                xlWorkSheet.Cells[j++][i + 5] = nv[i].Quoctich.ToString();
                xlWorkSheet.Cells[j++][i + 5] = "'" + nv[i].Sdt.ToString();
                xlWorkSheet.Cells[j++][i + 5] = nv[i].Bangcap.ToString();
                xlWorkSheet.Cells[j++][i + 5] = "'" + nv[i].Bophan.ToString();
                xlWorkSheet.Cells[j++][i + 5] = "'" + nv[i].Chucvu.ToString();
                xlWorkSheet.Cells[j++][i + 5] = "'" + nv[i].Cmnd.ToString();
                xlWorkSheet.Cells[j++][i + 5] = "'" + nv[i].Dantoc.ToString();
                xlWorkSheet.Cells[j++][i + 5] = nv[i].Hktt.ToString();
                xlWorkSheet.Cells[j++][i + 5] = "'" + nv[i].Tthonnhan.ToString();
                xlWorkSheet.Cells[j++][i + 5] = "'" + nv[i].Atm.ToString();
                xlWorkSheet.Cells[j++][i + 5] = "'" + nv[i].Ngaylamviec.ToString();
                if (nv[i].Thoiviec == "0")
                    xlWorkSheet.Cells[j++][i + 5] = "Đã Thôi việc";
                else
                    xlWorkSheet.Cells[j++][i + 5] = "";
            }
        }
        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            
        }

        
        #endregion
        private void bt_thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bt_thucthi_Click(object sender, EventArgs e)
        {
            if (radioNhapXuatExcel.SelectedIndex == 1)
            {
                if (cmb_luachon.SelectedItem == "Xuất toàn bộ thông tin nhân viên")
                {
                    selectNhanvienExcle(0,"null");
                }
                else if (cmb_luachon.SelectedItem == "Chỉ xuất theo bộ phận")
                {
                    if (cmb_bophan.Text != "---Chọn tên bộ phận cần thực thi---")
                        selectNhanvienExcle(1, cmb_bophan.Text);
                    else
                        MessageBox.Show("Bạn chưa chọn bộ phận để thực thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cmb_bophan.Text != "---Chọn tên chức vụ thực thi---")
                        selectNhanvienExcle(2, cmb_bophan.Text);
                    else
                        MessageBox.Show("Bạn chưa chọn chức vụ để thực thi","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                if (comboBox1.Text == "")
                    return;
                DataTable tbl = dsSource.Tables[comboBox1.Text];
                datagrid_nhanvien_excel.DataSource = tbl;




                InsetNhanVien_();

            }
        }
        #region Nhap tu file excel
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
        public bool KT_Insert(DTO.HoSoNhanVien nv) //kiem tra hop le
        {
            bool hl = true;
            if (nv.Holot == "")
            {
                hl = false;
                MessageBox.Show("Lỗi! Nhân viên có mã "+nv.Manv+" không thêm vào được vì họ lót nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nv.Holot.Length > 26)
            {
                hl = false;
                MessageBox.Show("Lỗi! Nhân viên có mã " + nv.Manv + " không thêm vào được vì Họ lót của nhân viên không được quá 26 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nv.Ten == "")
            {
                hl = false;
                MessageBox.Show("Lỗi! Nhân viên có mã " + nv.Manv + " không thêm vào được vì Tên nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nv.Ten.Length > 10)
            {
                hl = false;
                MessageBox.Show("Lỗi! Nhân viên có mã " + nv.Manv + " không thêm vào được vì Tên nhân viên không được quá 10 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nv.Ngaysinh == "")
            {
                hl = false;
                MessageBox.Show("Lỗi! Nhân viên có mã " + nv.Manv + " không thêm vào được vì Ngày sinh không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DateTime.Parse(nv.Ngaysinh) > DateTime.Now)
            {
                hl = false;
                MessageBox.Show("Lỗi! Nhân viên có mã " + nv.Manv + " không thêm vào được vì Ngày sinh được lơn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!KT_Ngay(DateTime.Parse(nv.Ngaysinh), DateTime.Now))
            {
                hl = false;
                MessageBox.Show("Lỗi! Nhân viên có mã " + nv.Manv + " không thêm vào được vì Ngày sinh không hợp lệ, Nhân viên này chưa đủ 18 tuổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!KT_Ngay(DateTime.Parse(nv.Ngaysinh),DateTime.Parse(nv.Ngaylamviec)))
            {
                hl = false;
                MessageBox.Show("Lỗi! Nhân viên có mã " + nv.Manv + " không thêm vào được vì Ngày làm việc không hợp lệ, Nhân viên này chưa đủ 18 tuổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nv.Quequan == "")
            {
                hl = false;
                MessageBox.Show("Lỗi! Nhân viên có mã " + nv.Manv + " không thêm vào được vì Quê quán không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nv.Quequan.Length >= 75)
            {
                hl = false;
                MessageBox.Show("Lỗi! Nhân viên có mã " + nv.Manv + " không thêm vào được vì Quê quán không được quá 75 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nv.Hktt == "")
            {
                hl = false;
                MessageBox.Show("Lỗi! Nhân viên có mã " + nv.Manv + " không thêm vào được vì Hộ khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nv.Hktt.Length >= 75)
            {
                hl = false;
                MessageBox.Show("Lỗi! Nhân viên có mã " + nv.Manv + " không thêm vào được vì Hộ khẩu không được quá 75 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nv.Bangcap.Length > 15)
            {
                hl = false;
                MessageBox.Show("Lỗi! Nhân viên có mã " + nv.Manv + " không thêm vào được vì Bằng cấp không được quá 15 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nv.Atm.Length >= 16)
            {
                hl = false;
                MessageBox.Show("Lỗi! Nhân viên có mã " + nv.Manv + " không thêm vào được vì Số thẻ ATM không được quá 16 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nv.Quoctich.Length >= 16)
            {
                hl = false;
                MessageBox.Show("Lỗi! Nhân viên có mã " + nv.Manv + " không thêm vào được vì Quốc tịch không được quá 16 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nv.Sdt.Length >= 12)
            {
                hl = false;
                MessageBox.Show("Lỗi! Nhân viên có mã " + nv.Manv + " không thêm vào được vì Số điện thoại không được quá 12 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nv.Cmnd == "")
            {
                hl = false;
                MessageBox.Show("Lỗi! Nhân viên có mã " + nv.Manv + " không thêm vào được vì Số chứng minh nhân dân không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!BUS.BUS_Nhanvien.kiemtramathe_tontai(nv.Mathe))
            {
                hl = false;
                MessageBox.Show("Lỗi! Nhân viên có mã " + nv.Manv + " không thêm vào được vì Mã thẻ đã tồn tại bởi một nhân viên khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(nv.Gioitinh != "1" && nv.Gioitinh != "0")
            {
                hl = false;
                MessageBox.Show("Lỗi! Nhân viên có mã " + nv.Manv + " không thêm vào được vì Giới tính chỉ có thể là 1:Nam hoặc 0:Nữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (BUS.BUS_Nhanvien.KiemTraMaNV(nv.Manv)!="true")
            {
                hl = false;
                MessageBox.Show("Lỗi! Nhân viên có mã " + nv.Manv + " không thêm vào được vì Mã nhân viên của nhân viên " + nv.Holot + " " + nv.Ten + " đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (BUS.BUS_Chucvu.KiemTraMaChucvu(nv.Chucvu)!="true")
            {
                hl = false;
                MessageBox.Show("Lỗi! Nhân viên có mã " + nv.Manv + " không thêm vào được vì Mã chức vụ của nhân viên " + nv.Holot + " " + nv.Ten + " không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (BUS.BUS_Dantoc.KiemTraMadantoc(nv.Dantoc)!="true")
            {
                hl = false;
                MessageBox.Show("Lỗi! Nhân viên có mã " + nv.Manv + " không thêm vào được vì Mã dân tộc của nhân viên " + nv.Holot + " " + nv.Ten + " không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (BUS.BUS_Bophan.KiemTraMabophan(nv.Bophan) != "true")
            {
                hl = false;
                MessageBox.Show("Lỗi! Nhân viên có mã " + nv.Manv + " không thêm vào được vì Mã bộ phận của nhân viên " + nv.Holot + " " + nv.Ten + " không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return hl;
        }
        DataSet dsSource = null;//Biến toàn cục chứa DataSet đã Load

        void LoadComboBox(DataSet ds)
        {
            foreach (DataTable tbl in ds.Tables)
            {
                comboBox1.Items.Add(tbl.TableName);
            }
        }

        DataSet GetDatasetFromExcel(string path)
        {
            try
            {
                FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read);
                IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                excelReader.IsFirstRowAsColumnNames = true;
                DataSet result = excelReader.AsDataSet();

                return result;
            }
            catch
            {
                MessageBox.Show("Bạn hãy đóng file đang hiện hành trước khi được thực thi", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                return null;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "*.xls|*.xls";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                dsSource = GetDatasetFromExcel(dlg.FileName);
                LoadComboBox(dsSource);//Hiển thị danh sách các TableName lên Combobox
                txtFileName.Text = dlg.FileName;
            }
        }


        // tao doi tuong nhan vien tu datagrid
        public void InsetNhanVien_()
        {
            int count = 0;
            for (int i = 0; i < datagrid_nhanvien_excel.RowCount-1; i++)
            {
                DTO.HoSoNhanVien nv = InsertNhanVien_Excel(i);
                if (KT_Insert(nv))
                {
                    if (BUS.BUS_Nhanvien.InsertNhanVien_Excel(nv) != "true")
                    {
                        MessageBox.Show("loi he thong", "thong bao");
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            MessageBox.Show("Đã thêm thành công "+count+" nhân viên");
        }
        public DTO.HoSoNhanVien InsertNhanVien_Excel(int i)
        {
            DTO.HoSoNhanVien nv = new DTO.HoSoNhanVien();
            
            int j = 0;
            nv.Manv = datagrid_nhanvien_excel.Rows[i].Cells[j++].Value.ToString();
            nv.Mathe = datagrid_nhanvien_excel.Rows[i].Cells[j++].Value.ToString();
            nv.Holot = datagrid_nhanvien_excel.Rows[i].Cells[j++].Value.ToString();
            nv.Ten = datagrid_nhanvien_excel.Rows[i].Cells[j++].Value.ToString();
            nv.Ngaysinh = datagrid_nhanvien_excel.Rows[i].Cells[j++].Value.ToString();
            nv.Gioitinh = datagrid_nhanvien_excel.Rows[i].Cells[j++].Value.ToString();
            nv.Quequan = datagrid_nhanvien_excel.Rows[i].Cells[j++].Value.ToString();
            nv.Quoctich = datagrid_nhanvien_excel.Rows[i].Cells[j++].Value.ToString();
            nv.Sdt = datagrid_nhanvien_excel.Rows[i].Cells[j++].Value.ToString();
            nv.Bangcap = datagrid_nhanvien_excel.Rows[i].Cells[j++].Value.ToString();
            nv.Bophan = datagrid_nhanvien_excel.Rows[i].Cells[j++].Value.ToString();
            nv.Chucvu = datagrid_nhanvien_excel.Rows[i].Cells[j++].Value.ToString();
            nv.Cmnd = datagrid_nhanvien_excel.Rows[i].Cells[j++].Value.ToString();
            nv.Dantoc = datagrid_nhanvien_excel.Rows[i].Cells[j++].Value.ToString();
            nv.Hktt = datagrid_nhanvien_excel.Rows[i].Cells[j++].Value.ToString();
            nv.Tthonnhan = datagrid_nhanvien_excel.Rows[i].Cells[j++].Value.ToString();
            nv.Atm = datagrid_nhanvien_excel.Rows[i].Cells[j++].Value.ToString();
            nv.Ngaylamviec = datagrid_nhanvien_excel.Rows[i].Cells[j++].Value.ToString();
       
            return nv;
        }
        #endregion

        private void frmNhapXuatNhanvienExcel_Load(object sender, EventArgs e)
        {

        }
    }
}