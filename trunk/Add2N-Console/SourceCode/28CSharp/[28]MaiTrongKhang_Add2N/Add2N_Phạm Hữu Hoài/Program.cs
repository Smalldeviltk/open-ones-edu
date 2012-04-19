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
            string first,second;
            View.Input(out first, out second);
            View.Output(Logic.Add2N(first, second));
            Console.ReadLine();
        }
    }
}
