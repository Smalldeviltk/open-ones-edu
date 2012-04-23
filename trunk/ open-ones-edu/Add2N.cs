using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    partial class Program
    {
        /* Khai bao chi tiet ham cong 2 chuoi*/
        public static void Add2N(String x, String y)
        {
            Calculator c = new Calculator();// Tao lop Calculator dung de tinh toan phep cong
            if (c.CanAdd(x, y))// x va y la nhung chuoi hop le ?
            {
                Console.WriteLine(x + " + " + y + " = " + c.AddResult(x, y)); // In ra ket qua
            }
            else
            {
                Console.WriteLine(c.ErrorMessage); // Xuat ra dong bao loi 
            }
        }
    }
}
