using System;
using DAO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_Phucap
    {
        // select phu cao
        public static List<DTO.DMPhucap> selectPhucap()
        {
            return DAO.DAO_DMPhucap.selectPhucap();
        }
        public static DataTable select_ma(string maloaipc)
        {
            return DAO.DAO_DMPhucap.select_ma(maloaipc);
        }
        // kiem tra trung ten phu cap
        #region kiem tra trung ten
        public static bool kt_trungten(string tenpc)
        {
            return DAO.DAO_DMPhucap.kt_trungten(tenpc);
        }
        #endregion
        // them phu cap
        public static bool _insert(DMPhucap phucap)
        {
            return DAO.DAO_DMPhucap._insert(phucap);
        }
        // kiem tra trung ma trươc khi them
        public static string kt_Trung(string maphucap)
        {
            return DAO.DAO_DMPhucap.kt_Trung(maphucap);
        }
        // xoa phu cap
        public static string delete(string maloai)
        {
            return DAO.DAO_DMPhucap.delete(maloai);
        }
        // kiem tra trung ma truoc khi sua
        public static string kt_sua_trungma(string mamoi, string macu)
        {
            return DAO.DAO_DMPhucap.kt_sua_trungma(mamoi, macu);
        }
        // sua phu cap
        public static string _sua(DMPhucap pc, string maloai)
        {
            return DAO.DAO_DMPhucap._sua(pc, maloai);
        }
        // lay phu cua nhan vien
        public static DataTable selectPC_Nhanvien(string manv)
        {
            return DAO.DAO_DMPhucap.selectPC_Nhanvien(manv);
        }
        // insert vào bang chi tiet phu cap
        public static string insert_chitietphucap(string manv, string mapc)
        {
            return DAO.DAO_DMPhucap.insert_chitietphucap(manv, mapc);
        }

        #region xoa chi tiet phu cap
        public static string delete_PC(string manv, string mapc)
        {
            return DAO.DAO_DMPhucap.delete_PC(manv, mapc);
        }

        #endregion
        public static string update_chitietPC(string manv, string macu, string mamoi)
        {
            return DAO_DMPhucap.update_chitietPC(manv, macu, mamoi);
        }
    }
}
