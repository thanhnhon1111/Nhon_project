using System;
using System.Collections.Generic;
using System.Data;
using DAO;
using System.Text;

namespace BUS
{
    public class BUS_Report
    {
        //nhan vien da het han hd
        public static DataTable HetHD(string tenbp, string tencv)
        {
            return DAO_Report.HetHD(tenbp, tencv);
        }
        //nhan vien con hd
        public static DataTable conHD(string tenbp, string tencv)
        {
            return DAO_Report.conHD(tenbp, tencv);
        }

        //nhan vien con hd -  da dong BH
        public static DataTable conHD_dadongBH(string tenbp, string tencv)
        {
            return DAO_Report.conHD_dadongBH(tenbp, tencv);
        }
        //nhan vien con hd - chua dong BH
        public static DataTable conHD_chuadongBH(string tenbp, string tencv)
        {
            return DAO_Report.conHD_chuadongBH(tenbp, tencv);
        }

        //nhan vien het hd - da dong BH
        public static DataTable HetHD_dadongBH(string tenbp, string tencv)
        {
            return DAO_Report.HetHD_dadongBH(tenbp, tencv);
        }

        //nhan vien het hd - chua dong BH
        public static DataTable HetHD_chuadongBH(string tenbp, string tencv)
        {
            return DAO_Report.HetHD_chuadongBH(tenbp, tencv);
        }

        //nhan vien da dong BH- HD=tat ca
        public static DataTable coBH(string tenbp, string tencv)
        {
            return DAO_Report.coBH(tenbp, tencv);
        }

        //nhan vien chua dong BH- HD=tat ca
        public static DataTable hetBH(string tenbp, string tencv)
        {
            return DAO_Report.hetBH(tenbp, tencv);
        }
        //nhan vien
        public static DataTable tatca(string tenbp, string tencv)
        {
            return DAO_Report.tatca(tenbp, tencv);
        }
         //report bang luong tung nhan vien
        public static DataTable bangluongtungNV(string thang, string nam)
        {
            return DAO_Report.bangluongtungNV(thang, nam);
        }
    }
}
