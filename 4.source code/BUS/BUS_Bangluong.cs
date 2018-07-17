using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;
namespace BUS
{
    public class BUS_Bangluong
    {
        public static DataTable selectBangluong(string thang, string nam)
        {
            return DAO_Bangluong.selectBangluong(thang, nam);
        }
    }
}
