using System;
using System.Collections.Generic;
using System.Text;
using DA;
using DTO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace DAO
{
    public class DAO_DMHopdong
    {
        //
        // tu ma nhan vien lay ra thong tin hop dong cua nhan vien do
        //
        #region Lấy hợp đồng
        public static List<DMHopdong> selectHopdongfromManv(string manv1)
        {
            List<DMHopdong> hd = new List<DMHopdong>();
            DMHopdong hd1;
            DataTable dt;
            string s = "select hd.*,lhd.tenloai as ten from Hopdong hd,loaihd lhd where lhd.loaihd=hd.loaihd and  hd.manv='" + manv1 + "'";
            dt = DA.Ketnoi.ExcecuteQuery(s);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                hd1 = new DMHopdong();
                hd1.Sohd = dt.Rows[i]["Sohd"].ToString();
                hd1.Manv = dt.Rows[i]["Manv"].ToString();
                hd1.Loaihd = dt.Rows[i]["ten"].ToString();
                hd1.Ngaykihd = dt.Rows[i]["Ngaykihd"].ToString();
                hd1.Ngayhd = dt.Rows[i]["Ngayhd"].ToString();
                string ngayhethan = dt.Rows[i]["ngayhh"].ToString();
                DateTime day = DateTime.Parse(ngayhethan);
                DateTime day1 = DateTime.Parse("1/1/9999");
                if (day == day1)
                    hd1.Ngayhh = "Không thời hạn";
                else hd1.Ngayhh = dt.Rows[i]["ngayhh"].ToString();
                hd1.Kilanthu = dt.Rows[i]["Kilanthu"].ToString();
                hd1.Dieukhoan = dt.Rows[i]["Dieukhoan"].ToString();
                hd.Add(hd1);
            }
            return hd;
        }
        #endregion
        // kiem tra su ton tai
        #region Kiểm tra tồn tại
        public static bool kiemtraSoHopdongTontai(string sohopdong)
        {
            DataTable DT = Ketnoi.ExcecuteQuery("SELECT * FROM Hopdong where sohopdong='" + sohopdong + "'");
            if (DT.Rows.Count > 0)
                return true;
            return false;
        }
        #endregion
        // xoa 1 Hop don
        #region Xóa hợp đồng
        public static string DeleteHopdong(string sohopdong)
        {
            string sql = string.Format("delete From Hopdong where sohopdong ='{0}';", sohopdong);
            return Ketnoi.ExcuteNonQuery(sql);
        }
        #endregion
        // ngay 4/3/2013 lay So Hop Dong  = TenCT+"0000"+IdHopDong
        #region Tao So Hop Dong
        //lay so IdHopDong
        public static string IdHopDong()
        { 
            string s = "select Id from IdHopDong;";
            string sql = string.Format(s);
            DataTable dt = DA.Ketnoi.ExcecuteQuery(sql);
            int i = Int32.Parse(dt.Rows[0]["id"].ToString());
            i += 1;
            return i.ToString();
        }

        //lay ma cong ty
        public static string TenCT()
        {
            string name;
            string s = "select TenCT from TenCT;";
            string sql = string.Format(s);
            DataTable dt = DA.Ketnoi.ExcecuteQuery(sql);
            name = dt.Rows[0]["TenCT"].ToString();
            return name; 
        }
        //tang IdHopDong

        #endregion

        // load combobox loại hd
        #region Loai Hop Dong
        public static List<LoaiHD> LoaiDopDong()
        {

            List<LoaiHD> lhd = new List<LoaiHD>();
            LoaiHD lhd1;
            DataTable dt;
            string s = "select * from LoaiHD";
            string sql = string.Format(s);
            dt = DA.Ketnoi.ExcecuteQuery(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lhd1 = new LoaiHD();
                lhd1.Loaihd = Int32.Parse(dt.Rows[i]["Loaihd"].ToString());
                lhd1.Tenloai = dt.Rows[i]["Tenloai"].ToString();
                lhd1.Thoihan = Int32.Parse(dt.Rows[i]["Thoihan"].ToString());
                lhd1.Hsl = float.Parse(dt.Rows[i]["Hsl"].ToString());
                lhd.Add(lhd1);
            }

            return lhd;
        }
        #endregion
        // Kiem tra ngay Hop Dong
        #region Kiem tra Ngay Hop Dong
        public static int KT_NgayHopDong(string ngayhd, string manv,string sohd)
        {
            string s1 = "select * from HopDong where manv='" + manv + "';";
            string sql1 = string.Format(s1);
            DataTable dt1 = DA.Ketnoi.ExcecuteQuery(sql1);
            if (dt1.Rows.Count < 1) // chua co hd nao
            {
                    return 1;
            }
            else
            {
                ngayhd = clConver.ConverDMY_MDY(DateTime.Parse(ngayhd));
                string s = "select * from IdHopDong where '" + ngayhd + "' >= (select MAX(ngayhh) from HopDong where manv = '" + manv + "' and sohd <> '"+sohd+"')";
                string sql = string.Format(s);
                DataTable dt = DA.Ketnoi.ExcecuteQuery(sql);
                if (dt.Rows.Count >0)
                    return 2;
            }
            return 0;
        }
        #endregion
        // lay thoi han hop dong tu ten hop dong
        #region Lấy thời gian hợp đồng
        public static int Laythoigianhopdong(string tenhopdong)
        {
            string sql = "select * from loaiHD where tenloai =N'"+tenhopdong+"'";
            DataTable dt = Ketnoi.ExcecuteQuery(sql);
            string thoihan = dt.Rows[0]["thoihan"].ToString();
            return int.Parse(thoihan);
        }
        #endregion
        //ngay 6/3/2013 
        // Tao so HD moi
        #region Update SoHopDong
        public static string UpdateSoIdHD()
        {
            string s = "update IdHopDong set Id=Id+1;";
            string sql = string.Format(s);
            return DA.Ketnoi.ExcuteNonQuery(sql);
        }
        #endregion

        #region Them Hop Dong
        public static string InsertHopDong(DMHopdong hd)
        {
            try
            {

                hd.Loaihd = LoaiHD(hd.Loaihd);
                hd.Ngayhd = clConver.ConverDMY_MDY(DateTime.Parse(hd.Ngayhd));
                hd.Ngayhh = clConver.ConverDMY_MDY(DateTime.Parse(hd.Ngayhh));
                hd.Ngaykihd = clConver.ConverDMY_MDY(DateTime.Parse(hd.Ngaykihd));
            }
            catch
            {
                MessageBox.Show("Cấu hình ngày tháng trên máy phải là ngày/tháng/năm, hãy liên hệ với bộ phận kỹ thuật","Lỗi từ hệ thống",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            string s = "insert into HopDong(sohd,manv,loaihd,ngaykihd,ngayhd,ngayhh,kilanthu,dieukhoan) values('{0}','{1}',{2},'{3}','{4}','{5}',{6},N'{7}')";
            string sql = string.Format(s, hd.Sohd, hd.Manv, hd.Loaihd,hd.Ngaykihd,hd.Ngayhd,hd.Ngayhh,hd.Kilanthu,hd.Dieukhoan);
            return DA.Ketnoi.ExcuteNonQuery(sql);
        }
        #endregion 

        #region Lay loai hop dong
        public static string LoaiHD(string tenloai)
        {
            DataTable dt = new DataTable();
            string s = "select LoaiHD from LoaiHD where tenloai=N'" + tenloai + "'";
            string sql = string.Format(s);
            dt=DA.Ketnoi.ExcecuteQuery(sql);
            return dt.Rows[0]["LoaiHD"].ToString();
        }
        #endregion

        // XOA HOP DONG
        #region Xoa 1 Hop Dong cua nhan vien
        public static string DeleteHD(string soHD)
        {
            string s="Delete from HopDong where sohd='"+soHD+"'";
            string sql = string.Format(s);
            return DA.Ketnoi.ExcuteNonQuery(sql);
        }
        #endregion

        #region Update hop dong
        public static string UpdatetHopDong(DMHopdong hd)
        {
                hd.Loaihd = LoaiHD(hd.Loaihd);
                hd.Ngayhd = clConver.ConverDMY_MDY(DateTime.Parse(hd.Ngayhd));
                hd.Ngayhh = clConver.ConverDMY_MDY(DateTime.Parse(hd.Ngayhh));
                hd.Ngaykihd=clConver.ConverDMY_MDY(DateTime.Parse(hd.Ngaykihd));
                string s="Update HopDong set loaihd='"+hd.Loaihd+"',ngaykihd='"+hd.Ngaykihd+"',ngayhd='"+hd.Ngayhd+"',ngayhh='"+hd.Ngayhh+"',kilanthu="+hd.Kilanthu+",dieukhoan=N'"+hd.Dieukhoan+"' where sohd='"+hd.Sohd+"'";
                string sql = string.Format(s);
                return DA.Ketnoi.ExcuteNonQuery(sql);
        }
        #endregion
       
        // lay Datatable co manv= manv
        #region Lay table HopDOng where manv=@manv
         /*public static bool Kiemtrangayhd(string manv,string sohd, string ngayhd, string ngayhh)
        {
            string sql = string.Format("select ngayhd,ngayhh from HopDong where manv='" + manv + "'");
            DataTable dt = DA.Ketnoi.ExcecuteQuery(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["sohd"].ToString() == sohd)
                {
                    if (i - 1 >= 0)
                    {
                        if (DateTime.Parse(dt.Rows[i - 1]["ngayhh"].ToString()) > ngayhd)
                            return false;
                    }
                    if (i + 1 <= dt.Rows.Count)
                    {
                        if (DateTime.Parse(dt.Rows[i + 1]["ngayhd"].ToString()) < ngayhh)
                            return false;
                    }
                }
            }
            return true;
        }*/
        #endregion
    }
}
