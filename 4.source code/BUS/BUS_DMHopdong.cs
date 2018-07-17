using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using System.Data;
using DTO;

namespace BUS
{
    public class BUS_DMHopdong
    {
        //lay ra thong tin cua 1 bao hiem theo manv
        public static List<DMHopdong> selectHopdong(string manv1)
        {
            List<DMHopdong> hd = new List<DMHopdong>();
            hd = DAO_DMHopdong.selectHopdongfromManv(manv1);
            return hd;
        }
        
        // kiem tra ton tai cua Hop dong co hay chua
        public static bool kiemtraSoHopdongTontai(string sohopdong)
        {
            return DAO_DMHopdong.kiemtraSoHopdongTontai(sohopdong);
        }
        //xoa 1 Hop dong
        public static string deleteHopdong(string sohd)
        {
            return DAO_DMHopdong.DeleteHopdong(sohd);
        }
        #region Tao So hop Dong
        // lay IdHopDong
        public static string SoHopDong()
        {
            string sohd ="";
            sohd+=DAO.DAO_DMHopdong.TenCT();  
            string id= DAO.DAO_DMHopdong.IdHopDong();
            for (int i = 6; i > id.Length; i--)
			{
			    sohd+="0";
			}
            sohd += id;
            return sohd;
        }

        #endregion
        //cmb Loai Hop Dong
        #region Loai Hop DOng
        public static List<LoaiHD> LoaiDopDong()
        {
            return DAO.DAO_DMHopdong.LoaiDopDong();
        }
        #endregion

        //Kiem tra dieu kien ngay ki HD va ngay HD
        #region kiem tra dieu kien ngay ky hop dong va ngay hop dong
        public static int NgayHopDong(string ngayhd,string manv,string sohd)
        {
            return DAO_DMHopdong.KT_NgayHopDong(ngayhd,manv,sohd);
        }
        #endregion
        // lấy thời hạn hợp đồng
        public static int layThoihanHD(string tenhopdong)
        {
            return DAO_DMHopdong.Laythoigianhopdong(tenhopdong);
        }

        // ngay 06/03/2013
        // Insert Hop Dong
        #region Insert Hop Dong
        public static string InsertHopDong(DMHopdong hd)
        {
            return DAO.DAO_DMHopdong.InsertHopDong(hd);
        }
        #endregion

        //update so id hop dong
        #region Update so id hd
        public static string UpdateSoIdHD()
        {
            return DAO.DAO_DMHopdong.UpdateSoIdHD();
        }
        #endregion

        //Xoa Hop Dong Nhan Vien
        #region Delete HD
        public static string DeleteHD(string soHD)
        {
            return DAO.DAO_DMHopdong.DeleteHD(soHD);
        }
        #endregion

        // update hop dong
        #region Update  HD
        public static string UpdatetHopDong(DMHopdong hd)
        {
            return DAO.DAO_DMHopdong.UpdatetHopDong(hd);
        }
        #endregion
    }
}
