using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using DAO;
using DTO;
using System.IO;
using System.Windows.Forms;
using System.Data;
namespace BUS
{
    public class BUS_Nhanvien
    {

        //lay thong tin ma,ten,bophan cua nhan vien
        #region Lấy thông tin nhân viên
        public static List<HoSoNhanVien> selectNhanvienfull(int luachon,string k)
        {
            List<HoSoNhanVien> nv = new List<HoSoNhanVien>();
            nv = DAO_Nhanvien.selectNhanvienfull(luachon,k);
            return nv;
        }
        #endregion
        //lay thong tin ma,ten,bophan cua nhan vien
        #region Lấy thông tin nhân viên
        public static List<HoSoNhanVien> selectNhanvien(string bophan, string ten_ma, int ktcheck,int checkbar)
        {
            List<HoSoNhanVien> nv = new List<HoSoNhanVien>();
            nv = DAO_Nhanvien.selectNhanvien(bophan,ten_ma,ktcheck,checkbar);
            return nv;
        }
        #endregion
        //
        // conver byte to image
        //
        #region chuyển đổi image và byte
        public static Image ByteToImage(Byte[] byt)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byt);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
            catch (ArgumentException)
            {
                //MessageBox.Show("Hình ảnh rỗng trong danh mục nhân viên", "Chú ý");
            }
            return null;
        }
        //
        // conver image to by
        //
        public static byte[] imageTobyte(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        #endregion
        // luu hinh nhan vien vao CSDL
        #region Lưu hình ảnh vào csdl
        public static void SaveImageNV(byte[] imageNV,string manv)
        {
            DAO_Nhanvien.SaveImageNV(imageNV, manv);
        }
        public static Image bingImageNV(string manv1)
        {
            Image img = ByteToImage(DAO_Nhanvien.bingImageNV(manv1));
            return img;
        }
        #endregion
        #region Tao ma nhan vien tu dong
        // lay ma nhan vien
        public static string MaNhanvien()
        {
            string manv = "";
            manv += DAO_Nhanvien.MaNhanvien();
            string id = DAO_Nhanvien.IDManhanvien();
            for (int i = 5; i > id.Length; i--)
            {
                manv += "0";
            }
            manv += id;
            return manv;
        }
        #endregion

        #region Them 1 nhan vien moi

        public static string InsertNhanVien(HoSoNhanVien nv)
        {
            return DAO.DAO_Nhanvien.InsertNhanVien(nv);
        }
        #endregion
        // xóa 1 nhân viên
        #region Xóa nhân viên
        public static string deleteNhanvien(string manv1)
        {
            return DAO_Nhanvien.DeleteNhanvien(manv1);
        }
        #endregion
        // sửa nhân viên
        #region sửa nhân viên
        public static string updateNhanVien(HoSoNhanVien nv)
        {
            return DAO_Nhanvien.updateNhanVien(nv);
        }
        #endregion
        // kiểm tra mã thẻ tồn tại
        #region Kiểm tra mã thẻ có tôn tại hay không
        public static bool kiemtramathe_tontai(string mathe)
        {
            return DAO_Nhanvien.kiemtramathe_tontai(mathe);
        }
        #endregion

        #region InsertNhanVien_Excel

        public static string InsertNhanVien_Excel(HoSoNhanVien nv)
        {
            return DAO.DAO_Nhanvien.InsertNhanVien_Exccel(nv);
        }
        #endregion
        // kiem tra ton tai ma nhan vien
        #region Kiểm tra mã nhân viên có tồn tại hay không
        public static string KiemTraMaNV(string manv)
        {
            return DAO.DAO_Nhanvien.KiemTraMaNV(manv);
        }
        #endregion

        //Bao cao nhan vien theo ngay vao lam
        public static List<HoSoNhanVien> NgayVaoLam(int thang, int nam)
        {
            return DAO.DAO_Nhanvien.NgayVaoLam(thang, nam);
        }
        #region bao cao nhan vien vao lam theo ngay
        public static DataTable baocaonvvaolamtheongay()
        {
            return DAO.DAO_Nhanvien.baocaonvvaolamtheongay();
        }
        #endregion
        #region bao cao nhan vien nghi viec theo ngay
        public static DataSet baocaonghiviectheongay()
        {
            return DAO.DAO_Nhanvien.baocaonghiviectheongay();
        }
        #endregion
        // kiem tra ma nv co trung hay khong
        public static bool kiemtra_trung(string manv, DateTime ngaycong)
        {
            return DAO.DAO_Nhanvien.kiemtra_trung(manv, ngaycong);
        }
         //ngay cong > ngay vao lam
        #region kiem tra ngay cong phai lon hon ngay vao lam cua nhan vien
        public static bool kiemtra_ngaycong_ngayvaolam(string manv, DateTime ngaycong)
        {
            return DAO.DAO_Nhanvien.kiemtra_ngaycong_ngayvaolam(manv, ngaycong);
        }
        #endregion
        // lay ten nhan vien tu ma nhan vien
        #region lay ten nhan vien tu ma
        public static NhanVien Tennv(string manv)
        {
            return DAO_Nhanvien.Tennv(manv);
        }
        #endregion

        #region bao cao nhan vien nghi viec theo thang
        public static DataTable rpt_nvNghiviecThang()
        {
            return DAO_Nhanvien.rpt_nvNghiviecThang();
        }
        #endregion

    }
}