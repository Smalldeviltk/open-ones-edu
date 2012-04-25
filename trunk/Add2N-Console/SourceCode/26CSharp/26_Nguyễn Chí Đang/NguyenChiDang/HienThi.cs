using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class HienThi
    {
        public static void GioiThieu()
        {
            Console.WriteLine("\n     Cong 2 So Nguyen Lon");
            Console.WriteLine("Nhap theo cu phap sau: Add2N So So");
        }

        public static string[] PhepTinh()
        {
            string strTam;
            string[] Tam;
            Console.Write("\n\tNhap Phep Tinh: ");
            strTam = Console.ReadLine().Trim();
            Tam = strTam.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return Tam;
        }

        public static void ThongTin(string KetQua)
        {
            Console.WriteLine(KetQua);
        }
    }
}