using System;
using System.Collections.Generic;
using DTO;
using System.Data;
namespace DAO
{
    public class DAO_Dantoc
    {
        public static List<DTO.Dantoc> selectDantoc()
        {
            List<Dantoc> dantoc = new List<Dantoc>();
            string s = "select * from dantoc";
            DataTable dt = DA.Ketnoi.ExcecuteQuery(s);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Dantoc dantoc1 = new Dantoc();
                dantoc1.Id = dt.Rows[i]["id"].ToString();
                dantoc1.Tendantoc = dt.Rows[i]["tendantoc"].ToString();
                dantoc.Add(dantoc1);
            }
            return dantoc;
        }
        // Kiểm tra ma dân tộc có tồn tại hay không
        #region Kiểm tra mã dẫn tộc có tồn tại hay không
        public static string KiemTraMadantoc(string madt)
        {
            string s = "select id from Dantoc where id='"+madt+"'";
            string sql = string.Format(s);
            DataTable dt = DA.Ketnoi.ExcecuteQuery(sql);
            if (dt.Rows.Count > 0)
                return "true";
            return "false";
        }
        #endregion
    }
}
