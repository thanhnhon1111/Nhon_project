using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
    public class BUS_Baohiem
    {
        //lay ra thong tin cua 1 bao hiem theo manv
        public static List<DMBaohiem> selectBaohiem(string manv1)
        {
            List<DMBaohiem> bh = new List<DMBaohiem>();
            bh = DAO_Baohiem.selectBaohiemfromManv(manv1);
            return bh;
        }
        // them 1 bao hiem
        public static string insertBaohiem(DMBaohiem BH, string manv1)
        {
            return DAO_Baohiem.insetBaohiem(BH, manv1);
        }
        // kiem tra ton tai cua bao hiem co hay chua
        public static bool kiemtraSobaohiemTontai(string sobaohiem)
        {
            return DAO_Baohiem.kiemtraSobaohiemTontai(sobaohiem);
        }
        //xoa 1 bao hiem
        public static string deleteBaohiem(string sobh)
        {
            return DAO_Baohiem.DeleteBaohiem(sobh);
        }
        // sua bao hiem
        public static string updateBaohiem(DMBaohiem bh, string sobaohiemcu)
        {
            return DAO_Baohiem.UpdateBaohiem(bh, sobaohiemcu);
        }
    }
}
