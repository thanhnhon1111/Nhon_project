using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTO;
namespace DAO
{
    public class DAO_Ungluong
    {
        // lay danh sach ung luong chua thanh toan
        public static DataTable select(string manv)
        {
            if (manv == "")
                manv = "%";
            string s = "select manv,ngay+'/'+thang+'/'+nam as ngaythang,tien from QlUngluong where trangthai=0";
            s += "  and manv like '" + manv + "' ";
            return DA.Ketnoi.ExcecuteQuery(s);
        }
        // insert ung luong
        public static string insert(Ungluong ul)
        {
            string s = "insert into QLUngLuong values ('" + ul.Manv + "'," + ul.Ngay + "," + ul.Thang + "," + ul.Nam + "," + ul.Tien + "," + ul.Trangthai + ")";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
        // kiem tra trung truoc khi them
        public static bool kt_trung_them(Ungluong ul)
        {
            string s = "select manv from QLungluong where manv='"+ul.Manv+"' and thang="+ul.Thang+" and nam="+ul.Nam+"";
            DataTable dt = DA.Ketnoi.ExcecuteQuery(s);
            if (dt.Rows.Count > 0)
                return false;
            return true;
        }
        // delete 
        public static string delete(string manv, string thang, string nam)
        {
            string s = "delete QLungluong where manv='"+manv+"' and thang="+thang+" and nam="+nam+"";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
        // update 
        public static string update(Ungluong ulc, Ungluong ul)
        {
            string s = " update QlUngluong set ngay="+ul.Ngay+", thang="+ul.Thang+", nam="+ul.Nam+", tien="+ul.Tien+" ";
            s += " where manv='" + ul.Manv + "' and thang="+ulc.Thang+" and nam="+ ulc.Nam +"";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }

        // update 
        public static string update_(Ungluong ul,string thang,string nam)
        {
            string s = " update QlUngluong set ngay=" + ul.Ngay + ", thang=" + ul.Thang + ", nam=" + ul.Nam + ", tien=" + ul.Tien + " ";
            s += " where manv='" + ul.Manv + "' and thang=" + thang + " and nam=" + nam + "";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
    }
}
