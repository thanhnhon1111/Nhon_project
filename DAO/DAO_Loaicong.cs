using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class DAO_Loaicong
    {
        // select loai cong
        #region select loai cong
        public static List<DTO.DMLoaicong> selectLoaicong()
        {
            List<DTO.DMLoaicong> lc = new List<DMLoaicong>();
            DataTable tb = new DataTable();
            tb = DA.Ketnoi.ExcecuteQuery("select * from DMLoaicong");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                DMLoaicong lc1 = new DMLoaicong();
                lc1.Maloai=tb.Rows[i]["maloai"].ToString();
                lc1.Tenloai = tb.Rows[i]["tenloai"].ToString();
                lc1.Heso = tb.Rows[i]["heso"].ToString();
                lc.Add(lc1);
            }
            return lc;
        }
        #endregion
        // kiem tra ma loai cong co trung hay khong truoc khi them vao
        #region kiem tra trung ma truoc khi them
        public static string kt_Trung(string maloaicong)
        {
            try
            {
                SqlCommand cm = new SqlCommand();
                cm.Connection = DA.Ketnoi.Cmb();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select * from DMloaicong where maloai=@maloai"; ;
                cm.Parameters.Add("@maloai", SqlDbType.NVarChar, 10).Value = maloaicong;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cm;
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                    return "2";
                return
                    "1";
            }
            catch
            {
                return "0";
            }
        }
        #endregion
        //kiem tra ton tai ten loai cong
        #region kiem tra ton tai ten loai cong
        public static bool KT_tenloaicong(string tenlc)
        {
            string s = "select tenloai from DMloaicong where tenloai=N'"+tenlc+"'";
            DataTable dt = DA.Ketnoi.ExcecuteQuery(s);
            if (dt.Rows.Count > 0)
                return false;
            return true;
        }
        #endregion
        // insert loai cong
        #region them loai cong
        public static bool InsertLoaicong(DMLoaicong loaicong)
        {
            try
            {
                DataTable dt = new DataTable("DMLoaiCong");
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cm = new SqlCommand();
                cm.Connection = DA.Ketnoi.Cmb();
                cm.CommandType = CommandType.Text;
                cm.CommandText = @"insert into DMloaicong(maloai,tenloai,heso) values (@maloai,@tenloai,@heso)";
                cm.Parameters.Add("@maloai", SqlDbType.NVarChar, 10).Value = loaicong.Maloai;
                cm.Parameters.Add("@tenloai", SqlDbType.NVarChar, 100).Value = loaicong.Tenloai;
                cm.Parameters.Add("@heso", SqlDbType.Float, 50).Value = loaicong.Heso;
                da.SelectCommand = cm;
                da.Fill(dt);
                return true;
            }
            catch
            {
                return false;
            }
            //string s= "Insert into DMloaicong values ('"+loaicong.Maloai+"','"+loaicong.Tenloai+"',"+loaicong.Heso+")";
            //string sql = string.Format(s);
            //return DA.Ketnoi.ExcuteNonQuery(sql);    
        }
        #endregion

        // xóa loại công
        #region xoa loai cong
        public static bool kiemtraxoa(string maloai)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = DA.Ketnoi.Cmb();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select distinct maloaicong from BangCong where maloaicong=@maloaicong";
            cm.Parameters.Add("@maloaicong",SqlDbType.NVarChar,10).Value=maloai;
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cm;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return false;
            return true;
        }
        public static string deleteloaicong(string maloai)
        {
            if (kiemtraxoa(maloai))
            {
                string s = "delete DMloaicong where maloai='"+maloai+"'";
                string sql = string.Format(s);
                return DA.Ketnoi.ExcuteNonQuery(sql);
            }
            return "false";
        }
        #endregion
        // sua loai cong
        #region sua loai cong

        public static string kt_sua_trungma(string mamoi, string macu)
        {
            string s = "select * from DMLoaiCong where maloai!='"+macu+"' and maloai='"+mamoi+"'";
            string sql = string.Format(s);
            DataTable dt= DA.Ketnoi.ExcecuteQuery(sql);
            if (dt.Rows.Count > 0)
                return "false";
            return "true";
        }

        public static string _sua(DMLoaicong lc,string maloai)
        {
            string s = "update DMloaicong set maloai='"+lc.Maloai+"', tenloai=N'"+lc.Tenloai+"', heso='"+lc.Heso+"' where maloai='"+maloai+"'";
            string sql = string.Format(s);
            return DA.Ketnoi.ExcuteNonQuery(sql);
        }
        #endregion
        // lay ten loai cong tu ma loai cong
        #region lay ten loai cong tu ma loai cong
        public static string laytenTuMa(string maloaicong)
        {
            string s = "select tenloai from DMloaicong where maloai='" + maloaicong + "'";
            DataTable dt = DA.Ketnoi.ExcecuteQuery(s);
            return dt.Rows[0]["tenloai"].ToString();
        }
        #endregion

        #region Kiem tra ton tai ma loai cong
        public static bool KT_Tontaimalc(string maloaicong)
        {
            string s = "select maloai from  DMloaicong where maloai='" + maloaicong + "'";
            DataTable dt = DA.Ketnoi.ExcecuteQuery(s);
            if (dt.Rows.Count > 0)
                return true;//ma loai cong da ton tai
            return false;
        }
        #endregion
    }
}
