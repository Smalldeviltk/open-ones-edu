using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADD2N_NHOM29
{
    class ADD2N
    {
        public string addN(String s1, string s2)
        {
            ADD a = new ADD();
            CHECK_INPUT c = new CHECK_INPUT();
            Console.WriteLine("NHOM 29\n\n");
            do
            {
                Console.WriteLine("nhap hai so nguyen can tinh: ");
                Console.Write("SO THU NHAT:\t");
                s1 = Console.ReadLine();
                Console.Write("SO THU HAI:\t");
                s2 = Console.ReadLine();
                Console.WriteLine("\n");
                if (!c.checkInput(s1))
                {
                    Console.Write(s1 + "\tkhong hop le\n");
                    Console.WriteLine("++++++++++++++++++++++++++++");
                }
                if (!c.checkInput(s2))
                {
                    Console.Write(s2 + "\tkhong hop le\n");
                    Console.WriteLine("+++++++++++++++++++++++++++++");
                }

            }
            while (!c.checkInput(s1, s2));
            Console.Write("KET QUA:\t" + s1 + "+" + s2 + "=");
            return a.add(s1, s2);
        }
    }
}
