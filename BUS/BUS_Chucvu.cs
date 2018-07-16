using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_Chucvu
    {
        public static List<ChucVu> selectChucvu()
        {
            return DAO.DAO_Chucvu.selectChucvu();
        }
        // Kiểm tra ma chức vụ có tồn tại hay không
        #region Kiểm tra mã chức vụ có tồn tại hay không
        public static string KiemTraMaChucvu(string macv)
        {
            return DAO.DAO_Chucvu.KiemTraMaChucvu(macv);
        }
        #endregion
        public static string KiemTraMachucvu_sua(string macu, string mamoi)
        {
            return DAO_Chucvu.KiemTraMachucvu_sua(macu, mamoi);
        }
        public static string insert(string ma, string ten)
        {
            return DAO_Chucvu.insert(ma, ten);
        }
        public static string update(string macu, string mamoi, string ten)
        {
            return DAO_Chucvu.update(macu, mamoi, ten);
        }
        public static string delete(string ma)
        {
            return DAO_Chucvu.delete(ma);
        }
    }
}
