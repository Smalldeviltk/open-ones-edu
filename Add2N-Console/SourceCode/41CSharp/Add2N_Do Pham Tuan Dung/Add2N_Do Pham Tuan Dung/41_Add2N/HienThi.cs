using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _41_Add2N
{
    class HienThi
    {
        // Hàm giới thiệu chương trình
        public static void _GioiThieu()
        {
            Console.WriteLine("\n\n-------- Plus 2 Prime Large Program - GROUP 41 ---------");
            Console.WriteLine("Cu phap: Add2N [Num1] [Num2]");
        }

        //Hàm nhập thông tin, tách chuỗi và trả về chuỗi cơ bản.
        public static string[] _NhapThongTin()
        {
            string strTempt;
            string[] temp;
            Console.Write("Console: ");
            strTempt = Console.ReadLine().Trim();
            temp = strTempt.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return temp;
        }

        //Hàm hiển thị thông tin 
        public static void ThongTin(string strResult)
        {
            Console.WriteLine(strResult);
        }
    }
}
