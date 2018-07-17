using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace DAO
{
    public class DAO_Khautru
    {
        // select khau tru
        public static DataTable select()
        {
            string s = "select * from khautru";
            return DA.Ketnoi.ExcecuteQuery(s);
        }
        // update khau tru
        public static string update(string makt,string sotien)
        {
            string s = "update Khautru set tien ="+sotien+" where makt ='"+makt+"'";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
    }
}
