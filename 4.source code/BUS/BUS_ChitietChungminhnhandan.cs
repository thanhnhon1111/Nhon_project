using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
namespace BUS
{
    public class BUS_ChitietChungminhnhandan
    {
        public static Boolean KiemTraTrung(string cmnd)
        {
            return DAO_ChitietChungminhnhandan.KiemTraTrung(cmnd);
        }
        public static string insertCMND(ChungminhChitiet cm)
        {
            return DAO_ChitietChungminhnhandan.insertCMND(cm);
        }
        public static string updateCMND(ChungminhChitiet cm)
        {
            return DAO_ChitietChungminhnhandan.UpdateCMND(cm);
        }
    }
}
