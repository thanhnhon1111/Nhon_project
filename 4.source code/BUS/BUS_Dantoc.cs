using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class BUS_Dantoc
    {
        public static List<DTO.Dantoc> selectDantoc()
        {
            return DAO.DAO_Dantoc.selectDantoc();
        }
        // Kiểm tra ma dân tộc có tồn tại hay không
        #region Kiểm tra mã dẫn tộc có tồn tại hay không
        public static string KiemTraMadantoc(string madt)
        {
            return DAO.DAO_Dantoc.KiemTraMadantoc(madt);
        }
        #endregion
    }
}
