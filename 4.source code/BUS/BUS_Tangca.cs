using System;
using System.Collections.Generic;
using DAO;
using DTO;
using System.Data;
using System.Text;

namespace BUS
{
    public class BUS_Tangca
    {
        public static List<TangCa_Proc> select(string thang, string nam)
        {
            return DAO_Tangca.select(thang, nam);
        }
        // Them 
        public static string insert(DTO.Tangca tc)
        {
            return DAO_Tangca.insert(tc);
        }

        //kiem tra trung tang ca
        public static bool kt_tangca_trung(string manv, DateTime ngaythang)
        {
            return DAO_Tangca.kt_tangca_trung(manv, ngaythang);
        }
        // xoa ca nhan vien theo ngay
        public static string delete_tangCaTheoThang(string manv, string thang, string nam)
        {
            return DAO_Tangca.delete_tangCaTheoThang(manv, thang, nam);
        }
        // lay chi tiet tang ca cua 1 nhan vien theo thang
        public static DataTable select_1NV_thang(string manv, string thang, string nam)
        {
            return DAO_Tangca.select_1NV_thang(manv, thang, nam);
        }
        //update chi tiet tang ca
        public static string update(Tangca tccu, Tangca tcmoi)
        {
            return DAO_Tangca.update(tccu, tcmoi);
        }
          // xoa ca nhan vien theo ngay
        public static string delete_tangCaNgay(string manv, string ngay, string thang, string nam)
        {
            return DAO_Tangca.delete_tangCaNgay(manv, ngay, thang, nam);
        }
        // load loai ca
        public static DataTable selectLoaica()
        {
            return DAO_Tangca.selectLoaica();
        }
         //update tien tang ca
        public static string update_heso(string maloai, string heso)
        {
            return DAO_Tangca.update_heso(maloai, heso);
        }
    }
}
