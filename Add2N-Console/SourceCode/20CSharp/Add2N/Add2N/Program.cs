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

        }

        /// <summary>
        /// Check String that is full of character numbers
        /// </summary>
        /// <param name="num">String input</param>
        /// <returns>true if this string is a numbers string\n else return false</returns>
        static bool checkNumString(string num)
        {
            char[] numArray = num.ToCharArray();
            string strCompare = "0123456789";
            foreach (char eNum in numArray)
                if (strCompare.IndexOf(eNum) < 0)
                    return false;
            return true;
        }
    }
}
