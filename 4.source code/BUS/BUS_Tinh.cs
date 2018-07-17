using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_Tinh
    {
        public static List<Tinh> selectTinh()
        {
            return DAO.DAO_Tinh.selectTinh();
        }
        public static string KiemTra(string mabp)
        {
            return DAO_Tinh.KiemTra(mabp);
        }
        public static string KiemTra_sua(string macu, string mamoi)
        {
            return DAO_Tinh.KiemTra_sua(macu, mamoi);
        }
        public static string insert(string ma, string ten)
        {
            return DAO_Tinh.insert(ma, ten);
        }
        public static string update(string macu, string mamoi, string ten)
        {
            return DAO_Tinh.update(macu, mamoi, ten);
        }
        public static string delete(string ma)
        {
            return DAO_Tinh.delete(ma);
        }
    }
}
