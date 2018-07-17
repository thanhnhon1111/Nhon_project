using System;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAO;
namespace DAO
{
    public class DAO_ChitietChungminhnhandan
    {
        // kiểm tra chứng minh nhân dân có trùg hay không
        #region kiểm tra trùng
        public static Boolean KiemTraTrung(string cmnd)
        {
            string s = "select * from CTChungminhnhandan where Socmnd='"+cmnd+"'";
            string sql = string.Format(s);
            DataTable dt = DA.Ketnoi.ExcecuteQuery(sql);
            if (dt.Rows.Count > 0)
                return false;
            return true;
        }
        #endregion
        // thêm chứng minh nhân dân vào table
        #region thêm chứng minh nhân dân
        public static string insertCMND(ChungminhChitiet CM)
        {
            CM.Ngaycap = clConver.ConverDMY_MDY(DateTime.Parse(CM.Ngaycap));
            string s = "insert into CTChungminhnhandan values ('"+CM.Socmnd+"',N'"+CM.Noicap+"','"+CM.Ngaycap+"')";
            string sql = string.Format(s);
            return DA.Ketnoi.ExcuteNonQuery(sql);
        }
        #endregion
        // sửa CMND
        #region Sửa chứng minh nhân dân
        public static string UpdateCMND(ChungminhChitiet cm)
        {
            string s = "update CTChungminhnhandan set noicap='"+cm.Noicap+"',ngaycap='"+cm.Ngaycap+"' where socmnd='"+cm.Socmnd+"'";
            string sql = string.Format(s);
            return DA.Ketnoi.ExcuteNonQuery(sql);
        }
        #endregion
    }
}
