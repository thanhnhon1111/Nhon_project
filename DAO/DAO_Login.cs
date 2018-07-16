using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using System.Data;
namespace DAO
{
    public class DAO_Login
    {
        public static bool Dangnhap(string server, string name, string pass)
        {
            bool t = Ketnoi.Dangnhap(server,name, pass);
            return t;
        }
        public static string Laytentaikhoangluulai()
        {
            string s = "select * from storeTaikhoan";
            string sql = string.Format(s);
            DataTable dt = DA.Ketnoi.ExcecuteQuery(sql);
            return dt.Rows[0]["TenTk"].ToString();
        }
        public static string CapnhapTantaikhoang(string name)
        {
            string s = "Update storeTaikhoan set TenTk='" + name + "'";
            string sql = string.Format(s);
            return DA.Ketnoi.ExcuteNonQuery(sql);
        }
    }
}
