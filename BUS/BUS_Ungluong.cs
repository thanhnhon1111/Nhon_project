using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using System.Data;
using DTO;
namespace BUS
{
    public class BUS_Ungluong
    {
        // select ung luong theo ma nv
        public static DataTable select(string manv)
        {
            return DAO_Ungluong.select(manv);
        }
        // insert ung luong
        public static string insert(Ungluong ul)
        {
            return DAO_Ungluong.insert(ul);
        }
        // kiem tra trung truoc khi them
        public static bool kt_trung_them(Ungluong ul)
        {
            return DAO_Ungluong.kt_trung_them(ul);
        }
         // delete 
        public static string delete(string manv, string thang, string nam)
        {
            return DAO.DAO_Ungluong.delete(manv, thang, nam);
        }
         // update 
        public static string update(Ungluong ulc, Ungluong ul)
        {
            return DAO_Ungluong.update(ulc,ul);
        }
        public static string update_(Ungluong ul, string thang, string nam)
        {
           return DAO_Ungluong.update_(ul, thang, nam);
        }
    }
}
