using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "exit", a = "";
            while(s!=a)
            {
                a = Logic.KiemTra(View.Nhap());
                Console.WriteLine(a);
                if (Logic.kt && a!="exit") View.Xuat(View.Input, Logic.strOutput(View.Input));
            }
        }
    }
}
