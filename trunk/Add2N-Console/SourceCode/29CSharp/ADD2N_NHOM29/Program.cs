using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADD2N_NHOM29
{
    class Program
    {
        static String s1, s2;
        static void Main(string[] args)
        {

            MENU M = new MENU();
            String result;
            result = M.menu(s1, s2);

            Console.Write(result);
        }
    }
}
