using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class DAO_Bangluong
    {
        public static DataTable selectBangluong(string thang, string nam)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = DA.Ketnoi.Cmb();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "proc_bangluong";
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cm.Parameters.Add("@thang",SqlDbType.SmallInt).Value=thang;
            cm.Parameters.Add("@nam", SqlDbType.Int).Value = nam;
            da.SelectCommand = cm;
            da.Fill(dt);
            return dt;
        }
    }
}
