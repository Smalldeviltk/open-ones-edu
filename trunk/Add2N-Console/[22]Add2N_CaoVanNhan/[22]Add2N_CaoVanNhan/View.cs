using System;

namespace _22_Add2N_CaoVanNhan
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
