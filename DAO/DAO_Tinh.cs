using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class DAO_Tinh
    {
        public static List<Tinh> selectTinh()
        {
            List<Tinh> t1 = new List<DTO.Tinh>();
            string s = "select * from Tinh";
            DataTable dt = new DataTable();
            dt = DA.Ketnoi.ExcecuteQuery(s);
            for (int i = 0; i < dt.Rows.Count;i++ )
            {
                Tinh t2 = new Tinh();
                t2.Id=dt.Rows[i]["id"].ToString();
                t2.Tentinh = dt.Rows[i]["tentinh"].ToString();
                t1.Add(t2);
            }
            return t1;
        }
        #region Kiểm tra khi them
        public static string KiemTra(string ma)
        {
            string s = "select * from Tinh where id='" + ma + "'";
            string sql = string.Format(s);
            DataTable dt = DA.Ketnoi.ExcecuteQuery(sql);
            if (dt.Rows.Count > 0)
                return "true";
            return "false";
        }
        #endregion
        #region Kiểm tra khi sua
        public static string KiemTra_sua(string macu, string mamoi)
        {
            string s = "select id from Tinh where id='" + mamoi + "' and id !='" + macu + "'";
            string sql = string.Format(s);
            DataTable dt = DA.Ketnoi.ExcecuteQuery(sql);
            if (dt.Rows.Count > 0)
                return "true";
            return "false";
        }
        #endregion
        #region insert 
        public static string insert(string ma, string ten)
        {
            string s = "insert into Tinh values ('" + ma + "',N'" + ten + "')";
            return DA.Ketnoi.ExcuteNonQuery(s);

        }
        #endregion
        #region update 
        public static string update(string macu, string mamoi, string ten)
        {
            string s = "update Tinh set id='" + mamoi + "',Tentinh=N'" + ten + "' where id='" + macu + "'";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
        #endregion
        #region delete 
        public static string delete(string ma)
        {
            string s = "delete Tinh where id='" + ma + "'";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
        #endregion
    }
}
