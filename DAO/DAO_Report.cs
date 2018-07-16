using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAO
{
    public class DAO_Report
    {
        //nhan vien da het han hd
        public static DataTable HetHD(string tenbp, string tencv)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = DA.Ketnoi.Cmb();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "proc_nhanviendahethd";
            cm.Parameters.Add("@tenbophan", SqlDbType.NVarChar, 50).Value = tenbp;
            cm.Parameters.Add("@tenchucvu", SqlDbType.NVarChar, 50).Value = tencv;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //nhan vien con hd
        public static DataTable conHD(string tenbp, string tencv)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = DA.Ketnoi.Cmb();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "proc_conhieuluchd";
            cm.Parameters.Add("@tenbophan", SqlDbType.NVarChar, 50).Value = tenbp;
            cm.Parameters.Add("@tenchucvu", SqlDbType.NVarChar, 50).Value = tencv;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //nhan vien con hd -  da dong BH
        public static DataTable conHD_dadongBH(string tenbp, string tencv)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = DA.Ketnoi.Cmb();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "proc_conhieulucHD_dadongBH";
            cm.Parameters.Add("@tenbophan", SqlDbType.NVarChar, 50).Value = tenbp;
            cm.Parameters.Add("@tenchucvu", SqlDbType.NVarChar, 50).Value = tencv;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //nhan vien con hd - chua dong BH
        public static DataTable conHD_chuadongBH(string tenbp, string tencv)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = DA.Ketnoi.Cmb();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "proc_conhieulucHD_chuadongBH";
            cm.Parameters.Add("@tenbophan", SqlDbType.NVarChar, 50).Value = tenbp;
            cm.Parameters.Add("@tenchucvu", SqlDbType.NVarChar, 50).Value = tencv;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //nhan vien het hd - da dong BH
        public static DataTable HetHD_dadongBH(string tenbp, string tencv)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = DA.Ketnoi.Cmb();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "proc_hetHD_dadongBH";
            cm.Parameters.Add("@tenbophan", SqlDbType.NVarChar, 50).Value = tenbp;
            cm.Parameters.Add("@tenchucvu", SqlDbType.NVarChar, 50).Value = tencv;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //nhan vien het hd - chua dong BH
        public static DataTable HetHD_chuadongBH(string tenbp, string tencv)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = DA.Ketnoi.Cmb();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "proc_hetHD_chuadongBH";
            cm.Parameters.Add("@tenbophan", SqlDbType.NVarChar, 50).Value = tenbp;
            cm.Parameters.Add("@tenchucvu", SqlDbType.NVarChar, 50).Value = tencv;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //nhan vien da dong BH- HD=tat ca
        public static DataTable coBH(string tenbp, string tencv)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = DA.Ketnoi.Cmb();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "proc_coBH";
            cm.Parameters.Add("@tenbophan", SqlDbType.NVarChar, 50).Value = tenbp;
            cm.Parameters.Add("@tenchucvu", SqlDbType.NVarChar, 50).Value = tencv;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //nhan vien chua dong BH- HD=tat ca
        public static DataTable hetBH(string tenbp, string tencv)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = DA.Ketnoi.Cmb();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "proc_hetBH";
            cm.Parameters.Add("@tenbophan", SqlDbType.NVarChar, 50).Value = tenbp;
            cm.Parameters.Add("@tenchucvu", SqlDbType.NVarChar, 50).Value = tencv;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //nhan vien
        public static DataTable tatca(string tenbp, string tencv)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = DA.Ketnoi.Cmb();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "proc_tatca";
            cm.Parameters.Add("@tenbophan", SqlDbType.NVarChar, 50).Value = tenbp;
            cm.Parameters.Add("@tenchucvu", SqlDbType.NVarChar, 50).Value = tencv;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //report bang luong tung nhan vien
        public static DataTable bangluongtungNV(string thang, string nam)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = DA.Ketnoi.Cmb();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "proc_luongtungnhanvien";
            cm.Parameters.Add("@thang", SqlDbType.SmallInt).Value = thang;
            cm.Parameters.Add("@nam", SqlDbType.Int, 50).Value = nam;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
