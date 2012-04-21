using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Add2N
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        /// <summary>
        /// Do the Sum of large numbers declare by String
        /// </summary>
        /// <param name="num1">First number</param>
        /// <param name="num2">Second number</param>
        /// <returns>Sum of numbers</returns>
        static string Add(string num1, string num2)
        {
            Stack myStack1 = new Stack();
            Stack myStack2 = new Stack();
            for (int i = 0; i < num1.Length; i++)
                myStack1.Push(byte.Parse(num1.Substring(i, 1)));
            for (int j = 0; j < num2.Length; j++)
                myStack2.Push(byte.Parse(num2.Substring(j, 1)));
            int mNum = 0;
            string returnNum = "";
            while (true)
            {
                int n1, n2;
                n1 = myStack1.Count > 0 ? (byte)myStack1.Pop() : 0;
                n2 = myStack2.Count > 0 ? (byte)myStack2.Pop() : 0;
                int tong = n1 + n2 + mNum;
                if (tong == 0)
                    break;
                mNum = tong > 9 ? 1 : 0;
                returnNum = (tong > 9 ? tong - 10 : tong).ToString() + returnNum;
            }
            return returnNum;
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
