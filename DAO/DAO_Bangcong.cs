using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class DAO_Bangcong
    {
        #region select bang cong
        public static List<Bangcong> selectBangcong(int thang,int nam)
        {
            List<Bangcong> bangcong = new List<Bangcong>();
            DataTable dt = new DataTable();
            SqlCommand cm = new SqlCommand();
            cm.Connection = DA.Ketnoi.Cmb();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "proc_bangcong";
            cm.Parameters.Add("@thang",SqlDbType.SmallInt).Value=thang;
            cm.Parameters.Add("@nam", SqlDbType.Int).Value = nam;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Bangcong bc = new Bangcong();
                bc.Manv = dt.Rows[i]["manv"].ToString();
                bc.Tennv = dt.Rows[i]["hoten"].ToString();
                bc.Tenbophan = dt.Rows[i]["tenbophan"].ToString();
                bc.Ngay1 = dt.Rows[i]["ngay1"].ToString();
                bc.Ngay2 = dt.Rows[i]["ngay2"].ToString();
                bc.Ngay3 = dt.Rows[i]["ngay3"].ToString();
                bc.Ngay4 = dt.Rows[i]["ngay4"].ToString();
                bc.Ngay5 = dt.Rows[i]["ngay5"].ToString();
                bc.Ngay6 = dt.Rows[i]["ngay6"].ToString();
                bc.Ngay7 = dt.Rows[i]["ngay7"].ToString();
                bc.Ngay8 = dt.Rows[i]["ngay8"].ToString();
                bc.Ngay9 = dt.Rows[i]["ngay9"].ToString();
                bc.Ngay10 = dt.Rows[i]["ngay10"].ToString();
                bc.Ngay11 = dt.Rows[i]["ngay11"].ToString();
                bc.Ngay12 = dt.Rows[i]["ngay12"].ToString();
                bc.Ngay13 = dt.Rows[i]["ngay13"].ToString();
                bc.Ngay14 = dt.Rows[i]["ngay14"].ToString();
                bc.Ngay15 = dt.Rows[i]["ngay15"].ToString();
                bc.Ngay16 = dt.Rows[i]["ngay16"].ToString();
                bc.Ngay17 = dt.Rows[i]["ngay17"].ToString();
                bc.Ngay18 = dt.Rows[i]["ngay18"].ToString();
                bc.Ngay19 = dt.Rows[i]["ngay19"].ToString();
                bc.Ngay20 = dt.Rows[i]["ngay20"].ToString();
                bc.Ngay21 = dt.Rows[i]["ngay21"].ToString();
                bc.Ngay22 = dt.Rows[i]["ngay22"].ToString();
                bc.Ngay23 = dt.Rows[i]["ngay23"].ToString();
                bc.Ngay24 = dt.Rows[i]["ngay24"].ToString();
                bc.Ngay25 = dt.Rows[i]["ngay25"].ToString();
                bc.Ngay26 = dt.Rows[i]["ngay26"].ToString();
                bc.Ngay27 = dt.Rows[i]["ngay27"].ToString();
                bc.Ngay28 = dt.Rows[i]["ngay28"].ToString();
                bc.Ngay29 = dt.Rows[i]["ngay29"].ToString();
                bc.Ngay30 = dt.Rows[i]["ngay30"].ToString();
                bc.Ngay31 = dt.Rows[i]["ngay31"].ToString();
                bc.Sl_ngaythuong = dt.Rows[i]["sl_ngaythuong"].ToString();
                bc.Sl_ngaycn = dt.Rows[i]["sl_ngaycong"].ToString();

                bangcong.Add(bc);
            }
            return bangcong;

        }
        #endregion
        // kiem tra trung ngay cong truoc khi them
        #region kiem tra ma cong trung truoc khi them
        public static bool kiemtra_ngaycong_trung(string manv,DateTime ngaycong)
        {
            string ngay = ngaycong.Day.ToString();
            string thang = ngaycong.Month.ToString();
            string nam = ngaycong.Year.ToString();
            string s = "select manv from bangcong where manv='" + manv + "' and ngay='" + ngay + "' and thang='" + thang + "' and nam='" + nam + "'";
            DataTable dt = DA.Ketnoi.ExcecuteQuery(s);
            if (dt.Rows.Count > 0)
                return false;
            return true;
        }
        #endregion
        // kiem tra trung ngay cong truoc khi sua
        #region kiem tra ma cong trung truoc khi sua
        public static bool kiemtra_ngaycong_trung_sua(string manv, DateTime ngaycong,string ngaycu)
        {
            string ngay = ngaycong.Day.ToString();
            string thang = ngaycong.Month.ToString();
            string nam = ngaycong.Year.ToString();
            string s = "select manv from bangcong where (manv='" + manv + "' and ngay='" + ngay + "' and thang='" + thang + "' and nam='" + nam + "') and ngay!='"+ngaycu+"'";
            DataTable dt = DA.Ketnoi.ExcecuteQuery(s);
            if (dt.Rows.Count > 0)
                return false;
            return true;
        }
        #endregion
        // them cong cho nhan vien
        #region them cong cho nhan vien
        // lay ma loaicong dua vao ten loaicong
        public static string laymaloaicongTutenloaicong(string tenloaicong)
        {
            string s = "select maloai from DMLoaiCong where tenloai=N'" + tenloaicong + "'";
            DataTable dt = DA.Ketnoi.ExcecuteQuery(s);
            return dt.Rows[0]["maloai"].ToString();
        }
        public static string _insert(DMBangcong b)
        {
            string maloaicong = laymaloaicongTutenloaicong(b.Maloaicong);
            string s = "insert into bangcong values ('"+b.Manv+"','"+maloaicong+"',"+b.Ngay+","+b.Thang+","+b.Nam+","+b.Giovao+","+b.Giora+","+b.Phutvao+","+b.Phutra+")";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
        #endregion
        // sua cong cho nhan vien
        #region sua cong cho nhan vien
        public static string _update(DMBangcong b,string ngay,string thang,string nam)
        {
            string maloaicong = laymaloaicongTutenloaicong(b.Maloaicong);
            string s = "update bangcong set maloaicong='" + maloaicong + "',ngay=" + b.Ngay + ",thang=" + b.Thang + ",nam=" + b.Nam + ",giovao=" + b.Giovao + ",giora=" + b.Giora + ",phutvao=" + b.Phutvao + ",phutra=" + b.Phutra + " ";
            s+= "where manv ='"+b.Manv+"' and ngay="+ngay+" and thang="+thang+" and nam="+nam+"";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
        #endregion
        // xoa cong cua mot nhan vien trong thang
        #region xoa cong cua mot nhan vien trong thang
        public static string _xoa(string manv,string thang,string nam)
        {
            string s = "delete Bangcong where manv='"+manv+"'and thang="+thang+" and nam="+nam+"";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
        #endregion 
        // xoa cong cua mot nhan vien trong ngay
        #region xoa cong cua mot nhan vien trong ngay
        public static string _xoaNgaycong(string manv,string ngay, string thang, string nam)
        {
            string s = "delete Bangcong where manv='" + manv + "'and thang=" + thang + " and nam=" + nam + " and ngay=" + ngay + "";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
        #endregion 
        // select bang cong cua 1 nhan vien theo thang
        #region select bang cong cua 1 nhan vien theo thang
        public static List<DMBangcong> selectBangcong_1NV(string manv, string thang, string nam)
        {
            string s = "select * from Bangcong where manv='"+manv+"' and thang="+thang+" and nam="+nam+"";
            DataTable dt = DA.Ketnoi.ExcecuteQuery(s);
            List<DMBangcong> bangcong = new List<DMBangcong>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DMBangcong bc = new DMBangcong();
                bc.Ngay = int.Parse(dt.Rows[i]["ngay"].ToString());
                bc.Maloaicong = dt.Rows[i]["maloaicong"].ToString();
                bc.Giophutvao = dt.Rows[i]["giovao"].ToString() + ":" + dt.Rows[i]["phutvao"].ToString();
                bc.Giophutra = dt.Rows[i]["giora"].ToString() + ":" + dt.Rows[i]["phutra"].ToString();
                bc.Giovao = int.Parse(dt.Rows[i]["giovao"].ToString());
                bc.Giora = int.Parse(dt.Rows[i]["giora"].ToString());
                bc.Phutvao = int.Parse(dt.Rows[i]["phutvao"].ToString());
                bc.Phutra = int.Parse(dt.Rows[i]["phutra"].ToString());
                bangcong.Add(bc);
            }
            return bangcong;
        }
        #endregion

        #region Rpt Nhan vien di tre
        public static DataTable Nhanvienditre(string gio,string phut,string thang,string nam)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = DA.Ketnoi.Cmb();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "proc_Nhanvienditre";
            cm.Parameters.Add("@gio", SqlDbType.SmallInt).Value = gio;
            cm.Parameters.Add("@phut", SqlDbType.SmallInt).Value = phut;
            cm.Parameters.Add("@thang", SqlDbType.SmallInt).Value = thang;
            cm.Parameters.Add("@nam", SqlDbType.SmallInt).Value = nam;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion


        #region rpt Bang cong
        public static DataTable selectAllBC(string thang,string nam)
        {
            DataTable dt = new DataTable();
            SqlCommand cm = new SqlCommand();
            cm.Connection = DA.Ketnoi.Cmb();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "proc_bangcong";
            cm.Parameters.Add("@thang", SqlDbType.SmallInt).Value = thang;
            cm.Parameters.Add("@nam", SqlDbType.Int).Value = nam;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            da.Fill(dt);
            return dt;
        }
        #endregion
    }
}