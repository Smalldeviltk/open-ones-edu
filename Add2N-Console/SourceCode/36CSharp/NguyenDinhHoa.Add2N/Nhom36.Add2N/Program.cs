using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nhom36.Add2N
{
    class Program
    {
        static void Main(string[] args)
        {
            View.OpenProgram();
            View.Output(Logic.NumOutput());
            Console.WriteLine("Hen gap lai lan sau");
            Console.ReadLine();
        }
    }
}
