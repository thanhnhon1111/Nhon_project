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
using BUS;
using DTO;
using System.Reflection;

namespace QLNhanSu
{
    public partial class frmNhapExcelBangCong : DevExpress.XtraEditors.XtraForm
    {
        public frmNhapExcelBangCong()
        {
            InitializeComponent();
        }

        #region Load data
        DataSet dsSource = null;//Biến toàn cục chứa DataSet đã Load
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

        void LoadComboBox(DataSet ds)
        {
            foreach (DataTable tbl in ds.Tables)
            {
                cmb_sheet.Items.Add(tbl.TableName);
            }
        }
        #endregion

        #region Tim file excel de thuc thi
        private void bt_Brows_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "*.xls|*.xls";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                dsSource = GetDatasetFromExcel(dlg.FileName);
                LoadComboBox(dsSource);//Hiển thị danh sách các TableName lên Combobox
                textFileName.Text = dlg.FileName;
            }
        }
        #endregion

        #region kiem tra so

        public bool KT_so(string so)
        {
            int s;
            try
            {
                s = int.Parse(so);
                if (s >= 0)
                    return true;
            }
            catch
            {
                return false;
            }
            return false;
        }
        #endregion
        #region Kiem tra Bang cong hop le
        public bool KT_Insert(BangCong_Excel bc,int i) //kiem tra hop le
        {
            string s = bc.Ngay + "/" + bc.Thang + "/" + bc.Nam;

            bool hl = true;
            if (bc.Manv == "")
            {
                hl = false;
                MessageBox.Show("Dòng "+i+" Lỗi! Nhân viên có mã " + bc.Manv + " >> Mã nhân viên không được để trống", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (bc.Maloaicong == "")
            {
                hl = false;
                MessageBox.Show("Dòng "+i+" Lỗi! Nhân viên có mã " + bc.Manv + " >> Mã loại công không được để trống", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (bc.Ngay == "" || bc.Thang == "" || bc.Nam == "")
            {
                hl = false;
                MessageBox.Show("Dòng "+i+" Lỗi! Nhân viên có mã " + bc.Manv + " >> Ngày công không được để trống", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (bc.Giovao == "" || bc.Giora == "" || bc.Phutvao == "" || bc.Phutra == "")
            {
                hl = false;
                MessageBox.Show("Dòng "+i+" Lỗi! Nhân viên có mã " + bc.Manv + " >> Thời gian không được để trống", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                // kiem tra kieu so cua ngay thang nam
            else if (!KT_so(bc.Ngay) || !KT_so(bc.Thang) || !KT_so(bc.Nam))
            {
                hl = false;
                MessageBox.Show("Dòng "+i+" Lỗi! Nhân viên có mã " + bc.Manv + " >> Ngày " + bc.Ngay + " tháng " + bc.Thang + " năm " + bc.Nam + " không phải kiểu số nguyên", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!KT_so(bc.Giovao) || !KT_so(bc.Giora) || !KT_so(bc.Phutvao) || !KT_so(bc.Phutra))
            {
                hl = false;
                MessageBox.Show("Dòng "+i+" Lỗi! Nhân viên có mã " + bc.Manv + " >> Thời gian vào " + bc.Giovao + "h" + bc.Phutvao + " ra " + bc.Giora + "h" + bc.Phutra + " không hợp lệ", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(bc.Ngay.ToString()) > 31 || int.Parse(bc.Ngay.ToString()) < 0
                || int.Parse(bc.Thang.ToString()) > 12 || int.Parse(bc.Thang.ToString()) < 0)
            {
                hl = false;
                MessageBox.Show("Dòng "+i+" Lỗi! Nhân viên có mã " + bc.Manv + " >> Ngày " + bc.Ngay + " tháng " + bc.Thang + " năm " + bc.Nam + " không hợp lệ", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (int.Parse(bc.Giovao.ToString()) > 23 || int.Parse(bc.Giovao.ToString()) < 0
                || int.Parse(bc.Giora.ToString()) > 23 || int.Parse(bc.Giora.ToString()) < 0
                || int.Parse(bc.Phutvao.ToString()) > 59 || int.Parse(bc.Phutvao.ToString()) < 0
                || int.Parse(bc.Phutra.ToString()) > 59 || int.Parse(bc.Phutra.ToString()) < 0)
            {
                hl = false;
                MessageBox.Show("Dòng "+i+" Lỗi! Nhân viên có mã " + bc.Manv + " >> Thời gian vào " + bc.Giovao + "h" + bc.Phutvao + " ra " + bc.Giora + "h" + bc.Phutra + " không hợp lệ", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DateTime.Parse(s) > DateTime.Now)
            {
                hl = false;
                MessageBox.Show("Dòng "+i+" Lỗi! Nhân viên có mã " + bc.Manv + " >> Ngày công không được lớn hơn ngày hiện tại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (BUS.BUS_Nhanvien.KiemTraMaNV(bc.Manv) == "true")
            {
                hl = false;
                MessageBox.Show("Dòng "+i+" Lỗi! Nhân viên có mã " + bc.Manv + " >> Nhân viên này không tồn tại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // kiem tra hop le ma loai cong
            else if (!BUS_Loaicong.KT_Tontaimalc(bc.Maloaicong))
            {
                hl = false;
                MessageBox.Show("Dòng "+i+" Lỗi! Nhân viên có mã " + bc.Manv + " >> Mã loại công " + bc.Maloaicong + " này không tồn tại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //kiem tra nhan vien lam ngay do chua
            else if (!BUS_BangCong_Excel.KT_TonTaiBangCong(bc))
            {
                hl = false;
                MessageBox.Show("Dòng "+i+" Lỗi! Nhân viên có mã " + bc.Manv + " >> đã tồn tại ngày công " + bc.Ngay + "/" + bc.Thang + "/ " + bc.Nam + " rồi", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return hl;
        }
        #endregion

        #region tao doi tuong nhan vien tu datagrid
        public BangCong_Excel InsertBangCong_Excel(int i)
        {
            BangCong_Excel bc = new BangCong_Excel();

            int j = 0;
            bc.Manv = grid_BangCong.Rows[i].Cells[j++].Value.ToString();
            bc.Maloaicong = grid_BangCong.Rows[i].Cells[j++].Value.ToString();
            bc.Ngay = grid_BangCong.Rows[i].Cells[j++].Value.ToString();
            bc.Thang = grid_BangCong.Rows[i].Cells[j++].Value.ToString();
            bc.Nam = grid_BangCong.Rows[i].Cells[j++].Value.ToString();
            bc.Giovao = grid_BangCong.Rows[i].Cells[j++].Value.ToString();
            bc.Giora = grid_BangCong.Rows[i].Cells[j++].Value.ToString();
            bc.Phutvao = grid_BangCong.Rows[i].Cells[j++].Value.ToString();
            bc.Phutra = grid_BangCong.Rows[i].Cells[j++].Value.ToString();
            return bc;
        }
        #endregion
        public void InsetBangCong()
        {
            int count = 0;
            for (int i = 0; i < grid_BangCong.RowCount - 1; i++)
            {

                BangCong_Excel bc = InsertBangCong_Excel(i);
                
                if (KT_Insert(bc,i))
                {                
                    if (!BUS_BangCong_Excel.insert(bc))
                    {
                        MessageBox.Show("Lỗi từ hệ thống! xin liên hệ bộ phận kỹ thuật", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            MessageBox.Show("Đã thêm thành công " + count + " dòng dữ liệu vào bảng công");
        }
       

        private void bt_Thucthi_Click(object sender, EventArgs e)
        {
            if (cmb_sheet.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn trang excel để nhập dữ liệu!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            InsetBangCong();
        }

        private void cmb_sheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tbl = dsSource.Tables[cmb_sheet.Text];
            grid_BangCong.DataSource = tbl;
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhapExcelBangCong_Load(object sender, EventArgs e)
        {
             
        }
    }
}