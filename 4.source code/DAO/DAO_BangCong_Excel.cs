using System;
using System.Collections.Generic;
using DAO;
using DTO;
using System.Data;
using System.Text;

namespace DAO
{
    public class DAO_BangCong_Excel
    {

        public static bool KT_TonTaiBangCong(BangCong_Excel bc)
        {
            string s = " select * from BangCong ";
                    s+=" where manv='"+bc.Manv+"' and maloaicong=N'"+bc.Maloaicong+"' ";
                    s+=" and ngay="+bc.Ngay+" and thang="+bc.Thang+" and nam="+bc.Nam+" ";
            DataTable dt = DA.Ketnoi.ExcecuteQuery(s);
            if (dt.Rows.Count > 0)
                        return false;// nhan vien da ton tai ngay cong
            return true;

        }

        //insert du lieu vao bang cong
        public static bool insert(BangCong_Excel bc)
        {
            string s = " insert into BangCong values ";
            s += " ('"+bc.Manv+"','"+bc.Maloaicong+"',"+bc.Ngay+","+bc.Thang+","+bc.Nam+","+bc.Giovao+","+bc.Giora+","+bc.Phutvao+","+bc.Phutra+") ";
            if (DA.Ketnoi.ExcuteNonQuery(s)=="true")
                return true;
            return false;
        }
    }
}
