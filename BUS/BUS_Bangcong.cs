using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;
namespace BUS
{
    public class BUS_Bangcong
    {
        public static List<Bangcong> selectBangcong(int thang, int nam)
        {
            return DAO.DAO_Bangcong.selectBangcong(thang,nam);
        }
        // kiem tra trung ngay cong khi them
        public static bool kiemtra_ngaycong_trung(string manv, DateTime ngaycong)
        {
            return DAO.DAO_Bangcong.kiemtra_ngaycong_trung(manv, ngaycong);
        }
        // kiem tra trung ngay cong khi sua
        public static bool kiemtra_ngaycong_trung_sua(string manv, DateTime ngaycong, string ngaycu)
        {
            return DAO.DAO_Bangcong.kiemtra_ngaycong_trung_sua(manv, ngaycong,ngaycu);
        }
        // them cong cho nhan vien
        public static string _insert(DMBangcong b)
        {
            return DAO.DAO_Bangcong._insert(b);
        }
        // sua cong cho nhan vien
        public static string _update(DMBangcong b, string ngay, string thang, string nam)
        {
            return DAO.DAO_Bangcong._update(b,ngay,thang,nam);
        }
        // xoa cong cua mot nhan vien trong thang
        #region xoa cong cua mot nhan vien trong thang
        public static string _xoa(string manv, string thang, string nam)
        {
            return DAO.DAO_Bangcong._xoa(manv, thang, nam);
        }
        #endregion 
        // xoa cong cua mot nhan vien trong ngay
        #region xoa cong cua mot nhan vien trong ngay
        public static string _xoaNgaycong(string manv,string ngay, string thang, string nam)
        {
            return DAO.DAO_Bangcong._xoaNgaycong(manv,ngay, thang, nam);
        }
        #endregion 
        // select bang cong cua 1 nhan vien theo thang
        #region select bang cong cua 1 nhan vien theo thang
        public static List<DMBangcong> selectBangcong_1NV(string manv, string thang, string nam)
        {
            return DAO.DAO_Bangcong.selectBangcong_1NV(manv, thang, nam);
        }
        #endregion
        //  tong ngay cong thuong
        public static string tongNgayCongThuong(string manv, string thang, string nam)
        {
            List<DMBangcong> bc = new List<DMBangcong>();
            bc = DAO.DAO_Bangcong.selectBangcong_1NV(manv, thang, nam);
            int t = 0;
            for (int i = 0; i < bc.Count; i++)
            {
                if (bc[i].Maloaicong == "1")
                    t++;
            }
            return t.ToString();
        }
        //  tong ngay cong
        public static string tongNgayTong(string manv, string thang, string nam)
        {
            List<DMBangcong> bc = new List<DMBangcong>();
            bc = DAO.DAO_Bangcong.selectBangcong_1NV(manv, thang, nam);
            return bc.Count.ToString();
        }

        #region Rpt Nhan vien di tre
        public static DataTable Nhanvienditre(string gio, string phut, string thang, string nam)
        {
            return DAO.DAO_Bangcong.Nhanvienditre(gio, phut, thang, nam);
        }
        #endregion
        #region rpt Bang cong
        public static DataTable selectAllBC(string thang, string nam)
        {
            return DAO_Bangcong.selectAllBC(thang, nam);
        }
        #endregion
    }
}
