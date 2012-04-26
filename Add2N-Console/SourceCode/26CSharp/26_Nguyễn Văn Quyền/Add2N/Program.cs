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
            Console.WriteLine("\n********** Add2N la chuong trinh cong 2 so nguyen duong lon **********");
            Console.WriteLine("\nMoi ban nhap theo cu phap sau : Add2N <sothunhat> <sothuhai> \n");
            string s = "";
            {
                s = Logic.Test(View.In());
                Console.WriteLine(s);
                if (Logic.ok && s != "exit") View.Out(View.Input, Logic.Out(View.Input));
            }
        }
    }
}
