using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class Program
    {
		// Main function
        static void Main(string[] strArgs)
        {
            if (strArgs.Length == 2)
            {
                string str1 = strArgs[0];
                string str2 = strArgs[1];
                if (!CheckNumString(str1))
                    if (!CheckNumString(str2))
                        Console.WriteLine(str1 + ", " + str2 + " khong hop le");
                    else
                        Console.WriteLine(str1 + " khong hop le");
                else if (!CheckNumString(str2))
                    Console.WriteLine(str2 + " khong hop le");
                else
                {
                    string strSum = Add(str1, str2);
                    Console.WriteLine(str1 + " + " + str2 + " = " + strSum);
                }
            }
            else
                Console.WriteLine("Ban phai nhap 2 doi so cho chuong trinh");
        }

        /// <summary>
        /// Do the Sum of large numbers declare by String
        /// </summary>
        /// <param name="num1">First number</param>
        /// <param name="num2">Second number</param>
        /// <returns>Sum of numbers</returns>
        static string Add(string strNum1, string strNum2)
        {
            Stack myStack1 = new Stack();
            Stack myStack2 = new Stack();
            for (int i = 0; i < strNum1.Length; i++)
                myStack1.Push(byte.Parse(strNum1.Substring(i, 1)));
            for (int j = 0; j < strNum2.Length; j++)
                myStack2.Push(byte.Parse(strNum2.Substring(j, 1)));
            int intNum = 0;
            string returnStr = "";
            while (true)
            {
                int n1, n2;
                n1 = myStack1.Count > 0 ? (byte) myStack1.Pop() : 0;
                n2 = myStack2.Count > 0 ? (byte) myStack2.Pop() : 0;
                int tong = n1 + n2 + intNum;
                if (tong == 0)
                    break;
                intNum = tong > 9 ? 1 : 0;
                returnStr = (tong > 9 ? tong - 10 : tong).ToString() + returnStr;
            }
            return returnStr;
        }

        /// <summary>
        /// Check String that is full of character numbers
        /// </summary>
        /// <param name="num">String input</param>
        /// <returns>true if this string is a numbers string\n else return false</returns>
        static bool CheckNumString(string strNum)
        {
            char[] charArray = strNum.ToCharArray();
            string strCompare = "0123456789";
            foreach (char charNum in charArray)
                if (strCompare.IndexOf(charNum) < 0)
                    return false;
            return true;
        }
    }
}
