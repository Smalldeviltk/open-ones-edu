using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _51__Add2N_PHANDUYHAI_10520593
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tChuong trinh dac ta 2 so nguyen duong lon");
            Console.WriteLine("\t\tDinh dang chuong trinh: Add2N [so1] [so2]");
            string s = "exit", a = "";
            while (s != a)
            {
                a = Logic.KiemTra(View.Nhap());
                Console.WriteLine(a);
                if (Logic.kt && a != "exit") View.Xuat(View.Input, Logic.strOutput(View.Input));
            }
        }
    }
}
