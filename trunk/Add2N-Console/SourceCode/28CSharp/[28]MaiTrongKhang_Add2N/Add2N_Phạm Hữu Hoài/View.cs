using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class View
    {
        /// <summary>
        /// Handle user's input
        /// </summary>
        /// <param name="first">first number</param>
        /// <param name="second">second number</param>
        public static void Input(out string first, out string second)
        {   
            Console.WriteLine("Cu phap Add2N <so thu nhat> <so thu hai>");
            Console.Write("Add2N ");
            string strInput = Console.ReadLine();
            string[] strSplit = strInput.Split(new char[]{' '});
            first = strSplit[0];
            second = strSplit[1];
        }
        /// <summary>
        /// Print out result
        /// </summary>
        /// <param name="str"></param>
        public static void Output(string str)
        {
            Console.WriteLine(str);
        }
    }
}
