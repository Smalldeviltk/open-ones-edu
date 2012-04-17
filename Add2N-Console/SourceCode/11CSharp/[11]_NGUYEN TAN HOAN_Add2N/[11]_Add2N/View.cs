using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11__Add2N
{
    class View
    {
        // Ham neu cau truc de thuc hien chuong trinh
        public static void Introduce()
        {
            Console.WriteLine("\n\n******CHUONG TRINH CONG 2 SO NGUYEN LON ******");
            Console.WriteLine("Nhap thong tin theo cau truc: Add2N [So1] [So2]");
        }

        // Ham nhap thong tin va tra ve chuoi thong tin co ban
        public static string[] NhapThongTin()
        {
            string strTempt;
            string[] temp; 
            Console.Write("\n\tNHAP THONG TIN: ");
            strTempt = Console.ReadLine().Trim();
            temp = strTempt.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return temp;
        }

        // Ham hien thi thong tin
        public static void ThongTin(string result)
        {
            Console.WriteLine(result);
        }
    }
}
