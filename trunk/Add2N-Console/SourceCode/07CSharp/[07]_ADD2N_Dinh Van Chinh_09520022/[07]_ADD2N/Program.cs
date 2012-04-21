/*
 * 1052 0530 - Nguyen Cong Quynh
 * 21/04/2012
 */
using System;

namespace Add2N
{
    public class Program
    {
        /*
         * Ham chinh
         */
        static void Main(string[] args)
        {
            string s = string.Empty;
            string[] sArray = new string[]{};

            // Nhap du lieu dau vao
            Console.Write("Cu phap\t\t- Add2N <So thu nhat> <So thu hai> \nDau vao\t\t- Add2N ");
            s = Console.ReadLine();

            // Goi ham kiem tra
            if (Check.functionCheck(s))
            {
                // Goi ham cong
                sArray = s.Split(' ');
                Console.WriteLine("Thong bao\t- Ket qua: <" + sArray[0] + "> + <" + sArray[1] + "> = <" + Add.functionAdd(sArray[0], sArray[1]) + ">");
            }

            Console.Write("...............................................................................");
            Console.ReadKey();
        }
    }
}
