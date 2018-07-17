using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
namespace DA
{
    public class Ketnoi
    {
        // private static string s = ConfigurationManager.ConnectionStrings["ConnectString"].ConnectionString;
        private static string s = @"Server=(local);Database=QLNS;Trusted_Connection=True;";
        private SqlConnection connect;
        public Ketnoi(string sql)
        {
            s = sql;
        }
        public Ketnoi()
        {
            connect = new SqlConnection(s);
            connect.Open();
        }
        public static SqlConnection Cmb()
        {
            SqlConnection cn = new SqlConnection(s);
            return cn;
        }
        public static bool Dangnhap(string server,string name,string pass)
        {
            try
            {
                SqlConnection connect1 = new SqlConnection("Server="+server+";UID="+name+";PWD="+pass+";Database=QLNS");
                connect1.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool Open()
        {
            try
            {
                connect = new SqlConnection(s);
                connect.Open();
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại", "Thông báo");
                return false;
            }
            return true;
        }
        public void Disconnect()
        {
            if (connect != null)
            {
                connect.Close();
                MessageBox.Show("Đã đóng kết nối", "Thông báo");
            }
        }
        public static DataTable ExcecuteQuery(string sql)
        {

            SqlConnection cn = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataTable kq = new DataTable();
            dt.Fill(kq);
            return kq;
        }
        public static string ExcuteNonQuery(string sql)
        {
            try
            {
                SqlConnection cn = new SqlConnection(s);
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cn.Close();
                return "true";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public static DataTable selectAllImage()
        { 
            SqlConnection cn = new SqlConnection(s);
            SqlDataAdapter dda = new SqlDataAdapter("getAllImage", cn);
            dda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            dda.Fill(dt);
            cn.Close();
            return dt;
        }

        public static DataTable getImage(string manv)
        {
            SqlConnection cn = new SqlConnection(s);
            SqlDataAdapter dda = new SqlDataAdapter("getImg", cn);
            dda.SelectCommand.Parameters.AddWithValue("@manv", manv);
            dda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            dda.Fill(dt);
            cn.Close();
            return dt;
        }

         
    }

}
