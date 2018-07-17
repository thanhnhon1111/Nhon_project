using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;
namespace BUS
{
    public class BUS_Khautru
    {
        // select khau tru
        public static DataTable select()
        {
            return DAO_Khautru.select();
        }
         // update khau tru
        public static string update(string makt, string sotien)
        {
            return DAO_Khautru.update(makt, sotien);
        }
    }
}
