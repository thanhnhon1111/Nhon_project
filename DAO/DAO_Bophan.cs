using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;
using DA;

namespace DAO
{
   public class DAO_Bophan
    {
       public static List<Bophan> compoboxBophan()
       {
           List<Bophan> bp = new List<Bophan>();
           Bophan bp1;
            DataTable ds = DA.Ketnoi.ExcecuteQuery("select * from Bophan");
            for (int i = 0; i < ds.Rows.Count; i++)
            {
                bp1 = new Bophan();
                bp1.Mabophan = ds.Rows[i]["Mabophan"].ToString();
                bp1.Tenbophan = ds.Rows[i]["Tenbophan"].ToString();
                bp.Add(bp1);
            }
            return bp;
        }

       public static void Cmb()
       {
           SqlConnection cs = Ketnoi.Cmb();
           SqlDataAdapter da = new SqlDataAdapter("select * from BoPhan",cs);
           DataTable dt = new DataTable();
           da.Fill(dt);
       }
       // Kiểm tra ma bo phan có tồn tại hay không
       #region Kiểm tra mã bộ phận có tồn tại hay không
       public static string KiemTraMabophan(string mabp)
       {
           string s = "select mabophan from Bophan where mabophan='" + mabp + "'";
           string sql = string.Format(s);
           DataTable dt = DA.Ketnoi.ExcecuteQuery(sql);
           if (dt.Rows.Count > 0)
               return "true";
           return "false";
       }
       #endregion
       #region Kiểm tra mã bộ phận khi sua
       public static string KiemTraMabophan_sua(string macu,string mamoi)
       {
           string s = "select mabophan from Bophan where mabophan='" + mamoi + "' and mabophan !='"+macu+"'";
           string sql = string.Format(s);
           DataTable dt = DA.Ketnoi.ExcecuteQuery(sql);
           if (dt.Rows.Count > 0)
               return "true";
           return "false";
       }
       #endregion
        #region insert bophan
       public static string insert(string ma,string ten)
       {
           string s = "insert into bophan values ('"+ma+"',N'"+ten+"')";
           return DA.Ketnoi.ExcuteNonQuery(s);

       }
        #endregion
        #region update bophan
       public static string update(string macu, string mamoi, string ten)
       {
           string s = "update bophan set mabophan='"+mamoi+"',tenbophan=N'"+ten+"' where mabophan='"+macu+"'";
           return DA.Ketnoi.ExcuteNonQuery(s);
       }
        #endregion
        #region delete bophan
       public static string delete(string ma)
       {
           string s = "delete bophan where mabophan='" + ma + "'";
           return DA.Ketnoi.ExcuteNonQuery(s);
       }
        #endregion
    }
}
