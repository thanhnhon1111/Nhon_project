using System;
using System.Collections.Generic;
using DTO;
using DAO;
using System.Text;

namespace BUS
{
    public class BUS_BangCong_Excel
    {
        public static bool KT_TonTaiBangCong(BangCong_Excel bc)
        {
            return DAO_BangCong_Excel.KT_TonTaiBangCong(bc);
        }

        //insert du lieu vao bang cong
        public static bool insert(BangCong_Excel bc)
        {
            return DAO_BangCong_Excel.insert(bc);
        }
    }
}
