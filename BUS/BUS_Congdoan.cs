using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace BUS
{
    public class BUS_Congdoan
    {
        // select cong doan
        public static DataTable select()
        {
            return DAO.DAO_Congdoan.select();
        }
        // insert
        public static string insert(string manv)
        {
            return DAO.DAO_Congdoan.insert(manv);
        }
        // delete 
        public static string delete(string manv)
        {
            return DAO.DAO_Congdoan.delete(manv);
        }
    }
}
