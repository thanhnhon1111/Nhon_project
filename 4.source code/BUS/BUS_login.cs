using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
namespace BUS
{
    public class BUS_login
    {
        public static bool Dangnhap(string server, string name, string pass)
        {
            return DAO_Login.Dangnhap(server,name,pass);
        }
        public static string Laytentaikhoangluulai()
        {
            return DAO_Login.Laytentaikhoangluulai();
        }
        public static string CapnhapTantaikhoang(string name)
        {
            return DAO_Login.CapnhapTantaikhoang(name);
        }
    }
}
