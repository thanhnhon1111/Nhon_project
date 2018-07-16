using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class DAO_Tangca
    {
        //select 
        public static List<TangCa_Proc> select(string thang, string nam)
        {
            List<TangCa_Proc> tc = new List<TangCa_Proc>();
            SqlCommand cm = new SqlCommand();
            cm.Connection = DA.Ketnoi.Cmb();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "proc_tangca";
            cm.Parameters.Add("@thang", SqlDbType.SmallInt).Value = thang;
            cm.Parameters.Add("@nam", SqlDbType.SmallInt).Value = nam;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TangCa_Proc tc1 = new TangCa_Proc();
                tc1.Manv = dt.Rows[i]["manv"].ToString();
                tc1.Hoten = dt.Rows[i]["hoten"].ToString();
                tc1.Tenbophan = dt.Rows[i]["tenbophan"].ToString();
                tc1.Tongthuong = dt.Rows[i]["tongthuong"].ToString();
                tc1.Tongdem = dt.Rows[i]["tongdem"].ToString();
                tc1.Tongle = dt.Rows[i]["tongle"].ToString();
                tc1.Tongchunhat = dt.Rows[i]["tongchunhat"].ToString();
                tc.Add(tc1);
            }
            return tc;
        }
        // Them 
        public static string insert(DTO.Tangca tc)
        {
            string s = "insert into Qltangca values ('" + tc.Manv + "','" + tc.Ngay + "','" + tc.Thang + "','" + tc.Nam + "','" + tc.Maloaica + "','" + tc.Sogio + "')";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }

        //kiem tra trung tang ca
        public static bool kt_tangca_trung(string manv, DateTime ngaythang)
        {
            string ngay = ngaythang.Day.ToString();
            string thang = ngaythang.Month.ToString();
            string nam = ngaythang.Year.ToString();

            string s = "select * from Qltangca where manv='"+manv+"' and ngay='" + ngay + "' and thang='" + thang + "' and nam='" + nam + "'";
            DataTable dt = DA.Ketnoi.ExcecuteQuery(s);
            if (dt.Rows.Count > 0)
                return false;
            return true;
        }

        //xoa tang ca nhan vien theo thang/nam
        public static string delete_tangCaTheoThang(string manv, string thang, string nam)
        {
            string s = " delete from QLTangCa where manv='" + manv + "' and thang=" + thang + " and nam=" + nam + " ";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
        //lay chi tiet tang ca cua 1 nhan vien theo thang
        public static DataTable select_1NV_thang(string manv,string thang,string nam)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = DA.Ketnoi.Cmb();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "proc_chiTietTangCaNhanVienTheoThang";
            cm.Parameters.Add("@manv",SqlDbType.NVarChar,10).Value=manv;
            cm.Parameters.Add("@thang", SqlDbType.SmallInt).Value = thang;
            cm.Parameters.Add("@nam", SqlDbType.SmallInt).Value = nam;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //update chi tiet tang ca
        public static string update(Tangca tccu, Tangca tcmoi)
        {
            string s = "update QLTangCa set ngay="+tcmoi.Ngay+" , thang ="+tcmoi.Thang+" , nam="+tcmoi.Nam+",maloaica='"+tcmoi.Maloaica+"',sogio="+tcmoi.Sogio+" ";
                   s+=" where manv='"+tccu.Manv+"' and ngay="+tccu.Ngay+" and thang="+tccu.Thang+" and nam="+tccu.Nam+"";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
        // xoa ca nhan vien theo ngay
        public static string delete_tangCaNgay(string manv, string ngay,string thang, string nam)
        {
            string s = " delete from QLTangCa where manv='" + manv + "' and ngay="+ngay+" and thang=" + thang + " and nam=" + nam + " ";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
        // load loai ca
     
        #region load loai ca
        public static DataTable selectLoaica()
        {
            string s = "select * from Loaica";
            return DA.Ketnoi.ExcecuteQuery(s);
        }
        #endregion

        //update tien tang ca
        public static string update_heso(string maloai,string heso)
        {
            string s = "update Loaica set heso="+heso+" where maloai='"+maloai+"'";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
    }
}
