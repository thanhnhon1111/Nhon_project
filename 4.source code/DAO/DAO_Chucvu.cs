using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
namespace DAO
{
    public class DAO_Chucvu
    {
        public static List<ChucVu> selectChucvu()
        {
            List<ChucVu> cv = new List<ChucVu>();
            string s = "select * from chucvu";
            DataTable dt = DA.Ketnoi.ExcecuteQuery(s);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChucVu cv1 = new ChucVu();
                cv1.Machucvu = dt.Rows[i]["machucvu"].ToString();
                cv1.Tenchucvu = dt.Rows[i]["tenchucvu"].ToString();
                cv1.Hsl = float.Parse(dt.Rows[i]["hsl"].ToString());
                cv.Add(cv1);
            }
            return cv;
        }

        // Kiểm tra ma chức vụ có tồn tại hay không
        #region Kiểm tra mã chức vụ có tồn tại hay không
        public static string KiemTraMaChucvu(string macv)
        {
            string s = "select machucvu from Chucvu where machucvu='" + macv + "'";
            string sql = string.Format(s);
            DataTable dt = DA.Ketnoi.ExcecuteQuery(sql);
            if (dt.Rows.Count > 0)
                return "true";
            return "false";
        }
        #endregion
        #region Kiểm tra mã chức vụ khi sua
        public static string KiemTraMachucvu_sua(string macu, string mamoi)
        {
            string s = "select machucvu from chucvu where machucvu='" + mamoi + "' and machucvu !='" + macu + "'";
            string sql = string.Format(s);
            DataTable dt = DA.Ketnoi.ExcecuteQuery(sql);
            if (dt.Rows.Count > 0)
                return "true";
            return "false";
        }
        #endregion
        #region insert chuc vu
        public static string insert(string ma, string ten)
        {
            string s = "insert into chucvu values ('" + ma + "',N'" + ten + "','')";
            return DA.Ketnoi.ExcuteNonQuery(s);

        }
        #endregion
        #region update chucvu
        public static string update(string macu, string mamoi, string ten)
        {
            string s = "update chucvu set machucvu='" + mamoi + "',tenchucvu=N'" + ten + "' where machucvu='" + macu + "'";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
        #endregion
        #region delete chucvu
        public static string delete(string ma)
        {
            string s = "delete chucvu where machucvu='" + ma + "'";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
        #endregion
    }
}
