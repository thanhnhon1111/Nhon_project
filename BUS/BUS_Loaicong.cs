using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_Loaicong
    {
        // select loai cong
        public static List<DTO.DMLoaicong> selectLoaicong()
        {
            return DAO.DAO_Loaicong.selectLoaicong();
        }
        //kiem tra ton tai ten loai cong
        #region kiem tra ton tai ten loai cong
        public static bool KT_tenloaicong(string tenlc)
        {
            return DAO.DAO_Loaicong.KT_tenloaicong(tenlc);
        }
        #endregion
        // insert 
        // them 1 loai cong
        public static bool insertLoaicong(DTO.DMLoaicong loaicong)
        {
            return DAO.DAO_Loaicong.InsertLoaicong(loaicong);
        }
        // kiem tra ma loai cong co trung hay khong trước khi them vao
        public static string kt_Trung(string maloaicong)
        {
            return DAO.DAO_Loaicong.kt_Trung(maloaicong);
        }
        // delete loai cong
        public static string deleteloaicong(string maloai)
        {
            return DAO.DAO_Loaicong.deleteloaicong(maloai);
        }

        // kiem tra sua loai cong
        public static string kt_sua_trungma(string mamoi, string macu)
        {
            return DAO.DAO_Loaicong.kt_sua_trungma(mamoi, macu);
        }
        // sua loai cong
        public static string _sua(DMLoaicong lc, string maloai)
        {
            return DAO.DAO_Loaicong._sua(lc, maloai);
        }
        // lay ten loai cong tu ma loai cong
        public static string laytenTuMa(string maloaicong)
        {
            return DAO.DAO_Loaicong.laytenTuMa(maloaicong);
        }

        #region Kiem tra ton tai ma loai cong
        public static bool KT_Tontaimalc(string maloaicong)
        {
            return DAO.DAO_Loaicong.KT_Tontaimalc(maloaicong);
        }
        #endregion

    }
}
