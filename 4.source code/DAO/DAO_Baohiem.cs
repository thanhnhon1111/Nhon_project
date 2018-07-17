using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DA;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class DAO_Baohiem
    {
        //
        // tu ma nhan vien lay ra thong tin bao hiem cua nhan vien do
        //
        #region lấy thông tin bảo hiểm từ mã nhân viên
        public static List<DMBaohiem> selectBaohiemfromManv(string manv1)
        {
            List<DMBaohiem> bh = new List<DMBaohiem>();
            DMBaohiem bh1;
            DataTable dt;
            string s="select * from DMBaohiem where manv='"+manv1+"'";
            dt = DA.Ketnoi.ExcecuteQuery(s);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bh1 = new DMBaohiem();
                bh1.Sobaohiem = dt.Rows[i]["sobaohiem"].ToString();
                if (dt.Rows[i]["loaibaohiem"].ToString() == "yt")
                    bh1.Loaibaohiem = "Bảo hiểm y tế";
                else
                    bh1.Loaibaohiem = "Bảo hiểm tai nạn";
                bh1.Ngaycap = dt.Rows[i]["ngaycap"].ToString();
                bh1.Noicap = dt.Rows[i]["noicap"].ToString();
                bh1.Noikhambenh = dt.Rows[i]["noikhambenh"].ToString();
                bh1.Ngaynghiviec = dt.Rows[i]["ngaynghiviec"].ToString();
                bh.Add(bh1);
            }
            return bh;
        }
        #endregion
        //
        // lay ra toan bo thong tin bao hiem tat ca bao hiem
        //
        #region lấy thông tin bảo hiểm full
        public static List<DMBaohiem> selectBaohiemFull()
        {
            List<DMBaohiem> bh = new List<DMBaohiem>();
            DMBaohiem bh1;
            DataTable dt;
            string s = "select * from DMBaohiem";
            dt = DA.Ketnoi.ExcecuteQuery(s);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bh1 = new DMBaohiem();
                string k = dt.Rows[i]["id"].ToString();
                bh1.Id1 = int.Parse(k);
                bh1.Loaibaohiem = dt.Rows[i]["loaibaohiem"].ToString();
                bh1.Ngaycap = dt.Rows[i]["ngaycap"].ToString();
                bh1.Noicap = dt.Rows[i]["noicap"].ToString();
                bh1.Noikhambenh = dt.Rows[i]["noikhambenh"].ToString();
                bh1.Sobaohiem = dt.Rows[i]["sobaohiem"].ToString();
                bh.Add(bh1);
            }
            return bh;
        }
        #endregion
        // them 1 bao hiem
        #region thêm 1 bảo hiểm
        public static string insetBaohiem(DMBaohiem BH,string manv1)
        {
            BH.Ngaycap = clConver.ConverDMY_MDY(DateTime.Parse(BH.Ngaycap));
            string s = "insert into DMBaoHiem (sobaohiem,loaibaohiem,ngaycap,noicap,noikhambenh,manv) values ('{0}','{1}','{2}',N'{3}',N'{4}','{5}');";
            string sql = string.Format(s, BH.Sobaohiem,BH.Loaibaohiem,BH.Ngaycap,BH.Noicap,BH.Noikhambenh, manv1);
            return DA.Ketnoi.ExcuteNonQuery(sql);
        }
        #endregion
        // kiem tra su ton tai
        #region Kiểm tra bảo hiểm có tồn tại hay không
        public static bool kiemtraSobaohiemTontai(string sobaohiem)
        {
            DataTable DT = Ketnoi.ExcecuteQuery("SELECT * FROM DMBaohiem where sobaohiem='"+sobaohiem+"'");
            if (DT.Rows.Count > 0)
                return true;
            return false;
        }
        #endregion
        // xoa 1 bao hiem
        #region xóa bảo hiểm
        public static string DeleteBaohiem(string sobh)
        {
            string sql = string.Format("delete From DMBaohiem where sobaohiem ='{0}';",sobh);
            return Ketnoi.ExcuteNonQuery(sql);
        }
        #endregion
        // sua 1 bao hiem
        #region sửa bảo hiểm
        public static string UpdateBaohiem(DMBaohiem bh,string sobaohiemcu)
        {
            bh.Ngaycap = clConver.ConverDMY_MDY(DateTime.Parse(bh.Ngaycap));
            bh.Ngaynghiviec = clConver.ConverDMY_MDY(DateTime.Parse(bh.Ngaynghiviec));
            string SET = "sobaohiem='"+bh.Sobaohiem+"',loaibaohiem='"+bh.Loaibaohiem+"',ngaycap='"+bh.Ngaycap+"',";
            SET += "noicap=N'"+bh.Noicap+"',noikhambenh=N'"+bh.Noikhambenh+"',ngaynghiviec='"+bh.Ngaynghiviec+"'";
            string sql = string.Format("Update DMbaohiem SET {0} where sobaohiem= '{1}';", SET, sobaohiemcu);
            return DA.Ketnoi.ExcuteNonQuery(sql);
        }
        #endregion
    }
}
