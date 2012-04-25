using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    static class View
    {
        static internal void Input(ref string arg1, ref string arg2)
        {
            string[] strTemp;
            strTemp = Console.ReadLine().Trim().Split(new char[] { ' ' });
            arg1 = strTemp[1];
            arg2 = strTemp[2];
        }
        static internal void Output(string arg1, string arg2)
        {
            Console.WriteLine("{0}", Logic.Add(arg1, arg2));
        }
    }
}
