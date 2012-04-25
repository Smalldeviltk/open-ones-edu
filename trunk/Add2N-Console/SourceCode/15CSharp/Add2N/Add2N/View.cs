using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class View
    {
        public View()
        {
        }
        public void In(ref string _number)
        {
            Console.Write("Insert Number: ");
            _number = Console.ReadLine();
        }
        public void Out(string _number)
        {
            Console.WriteLine("" + _number);
        }
    }
}
