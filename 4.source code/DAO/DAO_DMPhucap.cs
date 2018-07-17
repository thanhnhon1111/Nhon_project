using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class DAO_DMPhucap
    {
        // select phu cap
        #region select phu cap
        public static List<DMPhucap> selectPhucap()
        {
            List<DTO.DMPhucap> pc = new List<DMPhucap>();
            DataTable dt = new DataTable();
            dt = DA.Ketnoi.ExcecuteQuery("Select * from DMPhucap");
            for (int i = 0; i < dt.Rows.Count;i++ )
            {
                DMPhucap pc1 = new DMPhucap();
                pc1.Maloaipc = dt.Rows[i]["maloaipc"].ToString();
                pc1.Tenloai = dt.Rows[i]["tenloai"].ToString();
                pc1.Tien = dt.Rows[i]["tien"].ToString();
                pc.Add(pc1);
            }
            return pc;
        }
        #endregion
        // select phu cap theo mapc
        #region select phu cap theo ma phu cap
        public static DataTable select_ma(string maloaipc)
        {
            string s = "select * from DMphucap where maloaipc='" + maloaipc + "'";
            return DA.Ketnoi.ExcecuteQuery(s);
        }
        #endregion
        // kiem tra trung ma phu cap
        #region kiem tra trung ma truoc khi them
        public static string kt_Trung(string maphucap)
        {
            try
            {
                SqlCommand cm = new SqlCommand();
                cm.Connection = DA.Ketnoi.Cmb();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select * from DMPhucap where maloaipc=@maloaipc"; ;
                cm.Parameters.Add("@maloaipc", SqlDbType.NVarChar, 10).Value = maphucap;
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
        // kiem tra trung ten phu cap
        #region kiem tra trung ten
        public static bool kt_trungten(string tenpc)
        {
            string s = "select tenloai from DMphucap where tenloai=N'"+tenpc+"'";
            DataTable dt = DA.Ketnoi.ExcecuteQuery(s);
            if (dt.Rows.Count > 0)
                return false;
            return true;
        }
        #endregion
        // insert DmPhuCap
        #region them phu cap
        public static bool _insert(DMPhucap phucap)
        {
            try
            {
                DataTable dt = new DataTable("DMPhuCap");
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cm = new SqlCommand();
                cm.Connection = DA.Ketnoi.Cmb();
                cm.CommandType = CommandType.Text;
                cm.CommandText = @"insert into DMPhuCap(maloaipc,tenloai,tien) values (@maloaipc,@tenloai,@tien)";
                cm.Parameters.Add("@maloaipc", SqlDbType.NVarChar, 10).Value = phucap.Maloaipc;
                cm.Parameters.Add("@tenloai", SqlDbType.NVarChar, 100).Value = phucap.Tenloai;
                cm.Parameters.Add("@tien", SqlDbType.Real).Value = phucap.Tien;
                da.SelectCommand = cm;
                da.Fill(dt);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
      // xoa phu cap
        #region xoa phu cap
        public static bool kiemtraxoa(string maloai)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = DA.Ketnoi.Cmb();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select distinct maloaipc from ChiTietPhuCap where maloaipc=@maloai";
            cm.Parameters.Add("@maloai", SqlDbType.NVarChar, 10).Value = maloai;
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cm;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return false;
            return true;
        }
        public static string delete(string maloai)
        {
            if (kiemtraxoa(maloai))
            {
                string s = "delete DMphucap where maloaipc='" + maloai + "'";
                string sql = string.Format(s);
                return DA.Ketnoi.ExcuteNonQuery(sql);
            }
            return "false";
        }
        #endregion
        // sua phu cap
        #region sua phu cap

        public static string kt_sua_trungma(string mamoi, string macu)
        {
            string s = "select * from DMPhucap where maloaipc!='" + macu + "' and maloaipc='" + mamoi + "'";
            string sql = string.Format(s);
            DataTable dt = DA.Ketnoi.ExcecuteQuery(sql);
            if (dt.Rows.Count > 0)
                return "false";
            return "true";
        }

        public static string _sua(DMPhucap pc, string maloai)
        {
            string s = "update DMPhucap set maloaipc='" + pc.Maloaipc + "', tenloai=N'" + pc.Tenloai + "', tien='" + pc.Tien + "' where maloaipc='" + maloai + "'";
            string sql = string.Format(s);
            return DA.Ketnoi.ExcuteNonQuery(sql);
        }
        #endregion
        // lay chi tiet phu cap cua nhan vien co ma nhan vien
        #region select chi tiet phu cap theo ma nhan vien
        public static DataTable selectPC_Nhanvien(string manv)
        {
            string s = "select pc.* from DMPhuCap pc, ChiTietPhuCap ct where ct.manv='"+manv+"' and pc.maloaipc=ct.maloaipc";
            return DA.Ketnoi.ExcecuteQuery(s);
        }
        #endregion
        // insert vào chi tiết phụ cấp
        #region them vao chi tiet phu cap
        public static string insert_chitietphucap(string manv, string mapc)
        {
            string s = "insert into ChiTietPhuCap values ('"+mapc+"','"+manv+"')";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
        #endregion

        #region xoa chi tiet phu cap
        public static string delete_PC(string manv, string mapc)
        {
            string s = " delete ChiTietPhuCap where manv='" + manv + "' and maloaipc='" + mapc + "'";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
        #endregion

        #region update chi tiet phu cap
        public static string update_chitietPC(string manv,string macu, string mamoi)
        {
            string s = "update ChiTietPhuCap set maloaipc='"+mamoi+"' where manv='"+manv+"' and maloaipc='"+macu+"'";
            return DA.Ketnoi.ExcuteNonQuery(s);
        }
        #endregion
    }
}
