using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_Bophan
    {
        // ham lay du lieu trong bang bophan gan vao combobox bo phan
        public static List<Bophan> compoboxBophan()
        {
            return DAO_Bophan.compoboxBophan();
        }
        // Kiểm tra ma bo phan có tồn tại hay không
        #region Kiểm tra mã bộ phận có tồn tại hay không
        public static string KiemTraMabophan(string mabp)
        {
            return DAO_Bophan.KiemTraMabophan(mabp);
        }
        #endregion
        public static string KiemTraMabophan_sua(string macu, string mamoi)
        {
            return DAO_Bophan.KiemTraMabophan_sua(macu, mamoi);
        }
        public static string insert(string ma, string ten)
        {
            return DAO_Bophan.insert(ma, ten);
        }
        public static string update(string macu, string mamoi, string ten)
        {
            return DAO_Bophan.update(macu, mamoi, ten);
        }
        public static string delete(string ma)
        {
            return DAO_Bophan.delete(ma);
        }
    }
}
