using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class View
    {
        public static string[] readInput()
        {
            Console.WriteLine("Nhap 2 so theo dang: Add2N <so nguyen thu 1> <so nguyen thu 2>");
            Console.Write("Add2N ");
            string strInput = Console.ReadLine();
            if (!strInput.Contains(' ')) return null;
            return strInput.Split(' ');
        }

        public static void writeInvalid(string strInvalid)
        {
            Console.Write(strInvalid + " khong hop le");
            Console.ReadKey();
        }

        public static void writeResult(string s1, string s2)
        {
            Console.Write(s1 + " + " + s2 + " = " + Logic.add2N(s1,s2));
            Console.ReadKey();
        }
    }
}
