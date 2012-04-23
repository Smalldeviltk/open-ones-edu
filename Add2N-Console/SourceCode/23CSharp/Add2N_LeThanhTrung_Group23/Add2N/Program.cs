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
            string[] s = View.readInput();
            if (!Logic.checkInput(s)) return;
            View.writeResult(s[0], s[1]);

        }
    }
}
