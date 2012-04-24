using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            Integer integer1, integer2, integer3;
            integer1 = new Integer();
            integer2 = new Integer();
            integer3 = new Integer();

            Console.Write("Add2N ");

            Input(ref integer1, ref integer2);
            Output(integer1, integer2, ref integer3);
        }
    }
}
