using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace DAO
{
    public class DAO_Congdoan
    {
        // select cong doan
        public static DataTable select()
        {
            string s = " select nv.MaNV,nv.HoLot+' '+nv.Ten as hoten,GioiTinh = case GioiTinh when 1 then 'Nam' when 0 then N'Nữ' end, TenBoPhan,tenchucvu from NhanVien nv, BoPhan bp, ChucVu cv, CongDoan cd ";
                       s+="where nv.MaNV= cd.manv and nv.MaBoPhan=bp.MaBoPhan and nv.machucvu=cv.machucvu and nv.thoiviec=1";
                       return DA.Ketnoi.ExcecuteQuery(s);
        }
        // insert
        public static string insert(string manv)
        {
            string s = " insert into CongDoan values('" + manv + "')";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
        // delete 
        public static string delete(string manv)
        {
            string s = "delete Congdoan where manv='"+manv+"'";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
    }
}
