using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTKS_GreatInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            //test
            GreatInt num1 =new GreatInt("34");
            GreatInt num2 = new GreatInt("43");
            GreatInt num3 = new GreatInt("15");

            Console.WriteLine((num1+num2+num3).Number);

            Console.ReadLine();
        }
    }
}
