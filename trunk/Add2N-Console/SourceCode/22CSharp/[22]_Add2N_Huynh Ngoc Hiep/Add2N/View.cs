using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class View
    {
        public static string[] Input;
        public static string[] Nhap()
        {
            Input= Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            return Input;
        }
        public static void Xuat(string[] strInput, string strOutput)
        {
            Console.WriteLine(string.Format("{0} + {1} = {2}", strInput[1], strInput[2], strOutput));
        }
    }
}
