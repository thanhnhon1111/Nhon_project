using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;
using DA;
namespace DAO
{
    public class DAO_Nhanvien
    {
        // hàm liet ke nhan vien
        #region Liệt kê nhân viên nhan vien
        public static List<HoSoNhanVien> selectNhanvienfull(int luachon,string k)
        {
            List<HoSoNhanVien> nv = new List<HoSoNhanVien>();
            HoSoNhanVien nv1;
            DataTable dt;
            string sql="";
            string s="";
            if (luachon == 1)
            {
                s+=" and bp.tenbophan=N'"+k+"'";
            }
            else if (luachon == 2)
            {
                s += " and cv.tenchucvu=N'"+k+"'";
            }
            sql += "select  nv.*";
            sql += " from NhanVien nv,bophan bp, chucvu cv ";
            sql += " where nv.mabophan=bp.mabophan and nv.machucvu=cv.machucvu "+s+"";
            dt = DA.Ketnoi.ExcecuteQuery(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                nv1 = new HoSoNhanVien();
                nv1.Manv = dt.Rows[i]["Manv"].ToString();
                nv1.Mathe = dt.Rows[i]["mathe"].ToString();
                nv1.Holot = dt.Rows[i]["holot"].ToString();
                nv1.Ten = dt.Rows[i]["ten"].ToString();
                nv1.Gioitinh = dt.Rows[i]["gioitinh"].ToString();
                nv1.Ngaysinh = dt.Rows[i]["ngaysinh"].ToString();
                String.Format("{0:d}", nv1.Ngaysinh);
                nv1.Quequan = dt.Rows[i]["quequan"].ToString();
                nv1.Chucvu = dt.Rows[i]["machucvu"].ToString();
                nv1.Hktt = dt.Rows[i]["Hktt"].ToString();
                nv1.Cmnd = dt.Rows[i]["Cmnd"].ToString();
                nv1.Bophan = dt.Rows[i]["mabophan"].ToString();
                nv1.Hoten = dt.Rows[i]["Holot"].ToString() + " " + dt.Rows[i]["ten"].ToString();
                nv1.Atm = dt.Rows[i]["Atm"].ToString();
                nv1.Quoctich = dt.Rows[i]["Quoctich"].ToString();
                nv1.Ngaylamviec = dt.Rows[i]["Ngaylamviec"].ToString();
                nv1.Bangcap = dt.Rows[i]["Bangcap"].ToString();
                nv1.Tthonnhan = dt.Rows[i]["tthonnhan"].ToString();
                nv1.Dantoc = dt.Rows[i]["Dantoc"].ToString();
                nv1.Sdt = dt.Rows[i]["Sdt"].ToString();
                System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
                string s1 = dt.Rows[i]["Anh"].ToString();
                nv1.Anh = encoding.GetBytes(s1);
                nv1.Thoiviec = dt.Rows[i]["thoiviec"].ToString();
                nv.Add(nv1);
            }
            return nv;
        }
        #endregion
        // hàm li?t kê nhân viên(ma,ten,bophan,gioitinh)
        #region Liệt kê nhân viên
        public static List<HoSoNhanVien> selectNhanvien(string bophan, string ten_ma, int ktcheck, int checkbar)
        {
            List<HoSoNhanVien> nv = new List<HoSoNhanVien>();
            HoSoNhanVien nv1;
            DataTable dt;

            string s1, s2; s1 = s2 = "";
            string sql_hopdong = "";
            string sql_baohiem = "";
            string sql_thoiviec = "";
            switch (checkbar)
            {
                case 1:
                    sql_hopdong = "and nv.manv not in (select manv from HopDong)";
                    break;
                case 2:
                    sql_hopdong = "  and GETDATE()>= all (select MAX(ngayhh) from HopDong  where manv=nv.manv)";
                    break;
                case 3:
                    sql_hopdong = "and year(getdate())=(select year(MAX(ngayhh)) from HopDong  where manv=nv.manv) and MONTH(getdate())+1 = (select MONTH(MAX(ngayhh)) from HopDong  where manv=nv.manv) ";
                    break;
                case 4:
                    sql_hopdong = "and getdate()< (select MAX(ngayhh) from HopDong  where manv=nv.manv)";
                    break;
                case 5:
                    sql_baohiem = "and nv.manv not in (select manv from DMBaoHiem)";
                    break;
                case 6:
                    sql_baohiem = "and( (year(getdate()) >(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv)) or ";
                    sql_baohiem += " (year(getdate()) =(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv) ";
                    sql_baohiem += " and (month(getdate()) >(select month(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv))) ";
                    sql_baohiem += " or(year(getdate()) =(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv) ";
                    sql_baohiem += " and (month(getdate()) =(select month(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv)) ";
                    sql_baohiem += " and (day(getdate()) >(select day(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv))) )";
                    break;
                case 7:
                    sql_baohiem = "and( (year(getdate()) =(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv) ";
                    sql_baohiem += " and (month(getdate())+1 =(select month(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv))) )";
                    break;
                case 8:
                    sql_baohiem = "and( (year(getdate()) <(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv)) or ";
                    sql_baohiem += " (year(getdate()) =(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv) ";
                    sql_baohiem += " and (month(getdate()) <(select month(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv))) ";
                    sql_baohiem += " or(year(getdate()) =(select year(MAX(ngaycap))+1 from DMBaoHiem where manv=nv.manv) ";
                    sql_baohiem += " and (month(getdate()) =(select month(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv)) ";
                    sql_baohiem += " and (day(getdate()) <(select day(MAX(ngaycap)) from DMBaoHiem where manv=nv.manv))) )";
                    break;
                case 9:
                    sql_thoiviec = " and nv.thoiviec=0";
                    break;
                default:
                    sql_baohiem = sql_hopdong = "";

                    break;
            }
            if (ktcheck == 1)
            {
                s1 = " and bp.tenbophan =N'" + bophan + "' ";
            }
            s2 = "and (nv.ten like N'%" + ten_ma + "%'or nv.manv like N'%" + ten_ma + "%') ";
            string sql = "select  nv.*, dt.tendantoc,bp.tenbophan, cv.tenchucvu ";
            sql += "from NhanVien nv,bophan bp,dantoc dt, chucvu cv ";
            sql+=" where cv.machucvu=nv.machucvu and dt.id = nv.dantoc and nv.mabophan=bp.mabophan ";
            sql += "  "+sql_hopdong+" "+sql_baohiem+" "+sql_thoiviec+" "+s1+" "+s2+" ";
            dt = DA.Ketnoi.ExcecuteQuery(sql);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                nv1 = new HoSoNhanVien();
                nv1.Manv = dt.Rows[i]["Manv"].ToString();
                nv1.Mathe = dt.Rows[i]["mathe"].ToString();
                nv1.Holot = dt.Rows[i]["holot"].ToString();
                nv1.Ten = dt.Rows[i]["ten"].ToString();
                if (dt.Rows[i]["gioitinh"].ToString() == "1")
                    nv1.Gioitinh = "Nam";
                else nv1.Gioitinh = "Nữ";
                nv1.Ngaysinh = dt.Rows[i]["ngaysinh"].ToString();
                String.Format("{0:d}", nv1.Ngaysinh);
                nv1.Quequan = dt.Rows[i]["quequan"].ToString();
                nv1.Chucvu = dt.Rows[i]["tenchucvu"].ToString();
                nv1.Hktt = dt.Rows[i]["Hktt"].ToString();
                nv1.Cmnd = dt.Rows[i]["Cmnd"].ToString();
                nv1.Bophan = dt.Rows[i]["tenbophan"].ToString();
                nv1.Hoten = dt.Rows[i]["Holot"].ToString() + " " + dt.Rows[i]["ten"].ToString();
                nv1.Atm = dt.Rows[i]["Atm"].ToString();
                nv1.Quoctich = dt.Rows[i]["Quoctich"].ToString();
                nv1.Ngaylamviec = dt.Rows[i]["Ngaylamviec"].ToString();
                nv1.Bangcap = dt.Rows[i]["Bangcap"].ToString();
                if (dt.Rows[i]["Tthonnhan"].ToString() == "0")
                    nv1.Tthonnhan = "Chưa kết hôn";
                else nv1.Tthonnhan = "Ðã kết hôn";
                nv1.Dantoc = dt.Rows[i]["tenDantoc"].ToString();
                nv1.Sdt = dt.Rows[i]["Sdt"].ToString();
                System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
                string s = dt.Rows[i]["Anh"].ToString();
                nv1.Anh = encoding.GetBytes(s);
                nv1.Thoiviec=dt.Rows[i]["thoiviec"].ToString();
                nv.Add(nv1);
            }
            return nv;
        }
        #endregion
        #region Lưu hình vào CSDL
        public static void SaveImageNV(byte[] imageNV, string manv)
        {
            try
            {
                SqlConnection cnn = DA.Ketnoi.Cmb();
                SqlCommand cmm = new SqlCommand("saveImage", cnn);
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.Parameters.AddWithValue("@manv", manv);
                cmm.Parameters.AddWithValue("@image", imageNV);
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                cmm.ExecuteNonQuery();
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống tại Stored procedure vì tên SaveImage không tồn tại, hãy liên hệ với bộ phận kỹ thuật", "Thông báo");
            }
        }
        #endregion
        #region tao ma nhan vien tu dong
        //lay so Id
        public static string IDManhanvien()
        {
            string s = "select Id from IdNhanvien";
            string sql = string.Format(s);
            DataTable dt = DA.Ketnoi.ExcecuteQuery(sql);
            int i = Int32.Parse(dt.Rows[0]["id"].ToString());
            i += 1;
            return i.ToString();
        }

        //lay ma
        public static string MaNhanvien()
        {
            string name;
            string s = "select tenvt from TenVietTatMaNV";
            string sql = string.Format(s);
            DataTable dt = DA.Ketnoi.ExcecuteQuery(sql);
            name = dt.Rows[0]["TenVT"].ToString();
            return name;
        }
        #endregion

        // dua vao ma nhan vien de lay ra image nhanvien
        #region lấy image dạng byte từ manv
        public static byte[] bingImageNV(string manv1)
        {
            DataTable dt = Ketnoi.getImage(manv1);
            byte[] img = (Byte[])dt.Rows[0]["Anh"];
            return img;
        }
        #endregion
        #region Thêm 1 nhân viên mới

        public static string LayMaBoPhan(string bophan)
        { 
            string s="select mabophan from bophan where tenbophan=N'"+bophan+"' ";
            string sql = string.Format(s);
            DataTable dt= DA.Ketnoi.ExcecuteQuery(sql);
            return dt.Rows[0]["mabophan"].ToString();
        }

        public static string LayChucVu(string chucvu)
        { 
            string s="select machucvu from chucvu where tenchucvu=N'"+chucvu+"' ";
            string sql = string.Format(s);
            DataTable dt = DA.Ketnoi.ExcecuteQuery(sql);
            return dt.Rows[0]["machucvu"].ToString();
        }

        public static string LayDanToc(string dantoc)
        {
            string s = "select id from dantoc where tendantoc=N'"+dantoc+"'";
            string sql = string.Format(s);
            DataTable dt = DA.Ketnoi.ExcecuteQuery(sql);
            return dt.Rows[0]["id"].ToString();
        }

        public static void updateMaNhanVien()
        {
            string s = "update IdNhanVien set id=id+1";
            string sql = string.Format(s);
            DA.Ketnoi.ExcuteNonQuery(sql);
        }
        public static string InsertNhanVien(HoSoNhanVien nv)
        {
            nv.Bophan = LayMaBoPhan(nv.Bophan);
            nv.Chucvu = LayChucVu(nv.Chucvu);
            nv.Dantoc = LayDanToc(nv.Dantoc);
            nv.Ngaysinh = clConver.ConverDMY_MDY(DateTime.Parse(nv.Ngaysinh));
            nv.Ngaylamviec = clConver.ConverDMY_MDY(DateTime.Parse(nv.Ngaylamviec));
            string s = "insert into NhanVien (manv,holot,ten,mabophan,machucvu,dantoc,mathe,atm,gioitinh,ngaysinh,hktt,cmnd,QueQuan,ngaylamviec,bangcap,tthonnhan,quoctich,sdt";
            s += ",anh,thoiviec) values ('{0}',N'{1}',N'{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}',N'{10}','{11}',N'{12}',";
            s += "'{13}',N'{14}','{15}',N'{16}','{17}','','')";
            string sql = string.Format(s, nv.Manv, nv.Holot, nv.Ten,nv.Bophan,nv.Chucvu,nv.Dantoc,nv.Mathe,nv.Atm,nv.Gioitinh,
                nv.Ngaysinh, nv.Hktt, nv.Cmnd, nv.Quequan, nv.Ngaylamviec, nv.Bangcap, nv.Tthonnhan, nv.Quoctich, nv.Sdt);
            if (DA.Ketnoi.ExcuteNonQuery(sql) == "true")
            {
                updateMaNhanVien();
                return "true";
            }
            return "false";
        }
        #endregion
        //Xóa nhân viên
        #region Xóa nhân viên
        public static string DeleteNhanvien(string manv1)
        {
            string s = "delete from nhanvien where manv='"+manv1+"'";
            string sql = string.Format(s);
            return DA.Ketnoi.ExcuteNonQuery(sql);
        }
        #endregion
        // sửa nhân viên
        #region Sửa nhân viên
        public static string updateNhanVien(HoSoNhanVien nv)
        {
            nv.Bophan = LayMaBoPhan(nv.Bophan);
            nv.Chucvu = LayChucVu(nv.Chucvu);
            nv.Dantoc = LayDanToc(nv.Dantoc);
            nv.Ngaysinh = clConver.ConverDMY_MDY(DateTime.Parse(nv.Ngaysinh));
            nv.Ngaylamviec = clConver.ConverDMY_MDY(DateTime.Parse(nv.Ngaylamviec));
            string s1 = "Update Nhanvien set holot=N'"+nv.Holot+"',ten=N'"+nv.Ten+"',mabophan='"+nv.Bophan+"',machucvu='"+nv.Chucvu+"',dantoc='"+nv.Dantoc+"',mathe='"+nv.Mathe+"',atm='"+nv.Atm+"',gioitinh='"+nv.Gioitinh+"',ngaysinh='"+nv.Ngaysinh+"',";
            s1+="hktt=N'"+nv.Hktt+"',cmnd='"+nv.Cmnd+"',QueQuan=N'"+nv.Quequan+"',ngaylamviec='"+nv.Ngaylamviec+"',bangcap=N'"+nv.Bangcap+"',tthonnhan='"+nv.Tthonnhan+"',quoctich=N'"+nv.Quoctich+"',sdt='"+nv.Sdt+"',thoiviec='1'";
            s1+=" where manv='"+nv.Manv+"'";
            string sql = string.Format(s1);
            return DA.Ketnoi.ExcuteNonQuery(sql);
         }
        #endregion
        //kiem tra ma the có ton tai hay chu
        #region kiểm tra mã thẻ tồn tại
        public static bool kiemtramathe_tontai(string mathe)
        {
            string s = "select mathe from nhanvien where mathe='"+mathe+"'";
            DataTable dt = DA.Ketnoi.ExcecuteQuery(s);
            if (dt.Rows.Count > 0)
                return false;
            return true;
        }
        #endregion
        // thêm 1 nhân viên từ file excel
        #region thêm nhân viên từ file excel
        public static string InsertNhanVien_Exccel(HoSoNhanVien nv)
        {

            nv.Ngaysinh = clConver.ConverDMY_MDY(DateTime.Parse(nv.Ngaysinh));
            nv.Ngaylamviec = clConver.ConverDMY_MDY(DateTime.Parse(nv.Ngaylamviec));
            string s = "insert into NhanVien (manv,holot,ten,mabophan,machucvu,dantoc,mathe,atm,gioitinh,ngaysinh,hktt,cmnd,QueQuan,ngaylamviec,bangcap,tthonnhan,quoctich,sdt";
            s += ",anh,thoiviec) values ('{0}',N'{1}',N'{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}',N'{10}','{11}',N'{12}',";
            s += "'{13}',N'{14}','{15}',N'{16}','{17}','','1')";
            string sql = string.Format(s, nv.Manv, nv.Holot, nv.Ten, nv.Bophan, nv.Chucvu, nv.Dantoc, nv.Mathe, nv.Atm, nv.Gioitinh,
                nv.Ngaysinh, nv.Hktt, nv.Cmnd, nv.Quequan, nv.Ngaylamviec, nv.Bangcap, nv.Tthonnhan, nv.Quoctich, nv.Sdt);
            return DA.Ketnoi.ExcuteNonQuery(sql);
        }
        #endregion
        // kiểm tra tồn tại mã nhân viên
        #region Kiểm tra tôn tại mã nhân viên
        public static string KiemTraMaNV(string manv)
        {
            string s = "select manv from nhanvien where manv='"+manv+"'";
            string sql = string.Format(s);
            DataTable dt= DA.Ketnoi.ExcecuteQuery(sql);
            if (dt.Rows.Count > 0)
                return "false";
            return "true";
        }
        #endregion
        // select theo ngay/thang/nam
        #region select ngay/thang/nam
        public static List<HoSoNhanVien> NgayVaoLam(int thang, int nam)
        {
            List<HoSoNhanVien> nv = new List<HoSoNhanVien>();
            HoSoNhanVien nv1;
            string dk = "";
            if (thang >= 1 && thang <= 12)
                dk = " month(ngaylamviec)=thang and year(ngaylamviec)=nam";
            else dk = " month(ngaylamviec)=thang ";
            string s = "slect * from NhanVien where "+dk+" ";
            string sql = string.Format(s);
            DataTable dt= DA.Ketnoi.ExcecuteQuery(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                nv1 = new HoSoNhanVien();
                nv1.Manv = dt.Rows[i]["Manv"].ToString();
                nv1.Mathe = dt.Rows[i]["mathe"].ToString();
                nv1.Holot = dt.Rows[i]["holot"].ToString();
                nv1.Ten = dt.Rows[i]["ten"].ToString();
                if (dt.Rows[i]["gioitinh"].ToString() == "1")
                    nv1.Gioitinh = "Nam";
                else nv1.Gioitinh = "Nữ";
                nv1.Ngaysinh = dt.Rows[i]["ngaysinh"].ToString();
                String.Format("{0:d}", nv1.Ngaysinh);
                nv1.Quequan = dt.Rows[i]["quequan"].ToString();
                nv1.Chucvu = dt.Rows[i]["tenchucvu"].ToString();
                nv1.Hktt = dt.Rows[i]["Hktt"].ToString();
                nv1.Cmnd = dt.Rows[i]["Cmnd"].ToString();
                nv1.Bophan = dt.Rows[i]["tenbophan"].ToString();
                nv1.Hoten = dt.Rows[i]["Holot"].ToString() + " " + dt.Rows[i]["ten"].ToString();
                nv1.Atm = dt.Rows[i]["Atm"].ToString();
                nv1.Quoctich = dt.Rows[i]["Quoctich"].ToString();
                nv1.Ngaylamviec = dt.Rows[i]["Ngaylamviec"].ToString();
                nv1.Bangcap = dt.Rows[i]["Bangcap"].ToString();
                if (dt.Rows[i]["Tthonnhan"].ToString() == "0")
                    nv1.Tthonnhan = "Chưa kết hôn";
                else nv1.Tthonnhan = "Ðã kết hôn";
                nv1.Dantoc = dt.Rows[i]["tenDantoc"].ToString();
                nv1.Sdt = dt.Rows[i]["Sdt"].ToString();
                System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
                string s1 = dt.Rows[i]["Anh"].ToString();
                nv1.Anh = encoding.GetBytes(s1);
                nv1.Thoiviec = dt.Rows[i]["thoiviec"].ToString();
                nv.Add(nv1);
            }
            return nv;
        }
        #endregion
        //bao cao cac nhan vien vao lam theo thang/nam
        #region bao cao nhan vien vao lam theo ngay
        public static DataTable baocaonvvaolamtheongay()
        {
            string s = "SELECT Report_NhanVien_ngaylamviec.* FROM Report_NhanVien_ngaylamviec";
            return DA.Ketnoi.ExcecuteQuery(s);
        }
        #endregion
        //bao cao cac nhan vien da nghi viec theo thang/nam
        #region bao cao nhan vien nghi viec theo ngay
        public static DataSet baocaonghiviectheongay()
        {
            DataSet ds = new DataSet();
            string s = "SELECT Report_NhanVien_nghiviec.* FROM Report_NhanVien_nghiviec";
            SqlDataAdapter da = new SqlDataAdapter(s, DA.Ketnoi.Cmb());
            da.Fill(ds);
            return ds;
        }
        #endregion
        // kiem tra trung ma nhan vien
        #region kiem tra trung ma
        public static bool kiemtra_trung(string manv,DateTime ngaycong)
        {
            string s = "select manv from Nhanvien where manv = '" + manv + "'";
            DataTable dt = DA.Ketnoi.ExcecuteQuery(s);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        #endregion
        //ngay cong > ngay vao lam
        #region kiem tra ngay cong phai lon hon ngay vao lam cua nhan vien
        public static bool kiemtra_ngaycong_ngayvaolam(string manv,DateTime ngaycong)
        {
            string nc=clConver.ConverDMY_MDY(ngaycong);
            string s = "select manv from nhanvien where manv='"+manv+"' and ngaylamviec <'"+nc+"' ";
            DataTable dt = DA.Ketnoi.ExcecuteQuery(s);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        #endregion
        // lay ten nhan vien tu ma nhan vien
        #region lay ten nhan vien tu ma
        public static NhanVien Tennv(string manv)
        {
            string s = "select nv.holot+' '+nv.ten as hoten,bp.tenbophan from nhanvien nv,Bophan bp where nv.manv='"+manv+"' and nv.mabophan=bp.mabophan";
            DataTable dt = DA.Ketnoi.ExcecuteQuery(s);
            NhanVien nv = new NhanVien();
            if (dt.Rows.Count > 0)
            {
                nv.Hoten = dt.Rows[0]["hoten"].ToString();
                nv.Bophan = dt.Rows[0]["tenbophan"].ToString();
            }
            return nv;
        }
        #endregion

        #region bao cao nhan vien nghi viec theo thang
        public static DataTable rpt_nvNghiviecThang()
        {
            string s = "select * from view_Nhanviennghiviectheothang";
            return DA.Ketnoi.ExcecuteQuery(s);
        }
        #endregion
    }
}