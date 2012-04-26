using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    #region Fields:
    ///------------------------------------------------------------------
    /// Program		            :	Add2N
    /// Written by	            :	Doan Minh Tien
    /// Email		            :	ctks_g20@gmail.com
    /// Created date	        :	10/04/2012
    /// Modified by	            :	Nguyen Le Anh, Nguyen Ngoc Sang, Dang Huy Chuong, Le Hoang Tuan
    /// Lasted modified date	:	26/04/2012
    /// Version		            :	1.0
    /// Description	            :	Do the Sum of two large numbers
    ///------------------------------------------------------------------
    class Program
    {
        ///-----------------------------------------------------------
        /// Description	    :	Do the program
        /// Method name	    :	Main
        /// Parameters	    :	_strArgs
        /// Return value	:	void
        ///---------------------------------------------------------
        static void Main(string[] _strArgs)
        {
            Console.WriteLine("Ban hay nhap vao hai so cach nhau bang khoang trang: ");
            string value = Console.ReadLine();
            _strArgs = value.Split(' ');
            if (_strArgs.Length == 2)
            {
                string str1 = _strArgs[0];
                string str2 = _strArgs[1];
                if (!checkNumString(str1))
                    if (!checkNumString(str2))
                        Console.WriteLine(str1 + ", " + str2 + " khong hop le");
                    else
                        Console.WriteLine(str1 + " khong hop le");
                else if (!checkNumString(str2))
                    Console.WriteLine(str2 + " khong hop le");
                else
                {
                    string strSum = add(str1, str2);
                    Console.WriteLine(str1 + " + " + str2 + " = " + strSum);
                }
            }
            else
                Console.WriteLine("Ban phai nhap 2 doi so cho chuong trinh");
            Console.ReadLine();
        }

        ///-----------------------------------------------------------
        /// Description	    :	Do Adding-Operator
        /// Method name	    :	add
        /// Parameters	    :	_strNum1, _strNum2
        /// Return value	:	string
        ///---------------------------------------------------------
        static string add(string _strNum1, string _strNum2)
        {
            Stack m_myStack1 = new Stack();
            Stack m_myStack2 = new Stack();
            for (int i = 0; i < _strNum1.Length; i++)
                m_myStack1.Push(byte.Parse(_strNum1.Substring(i, 1)));
            for (int j = 0; j < _strNum2.Length; j++)
                m_myStack2.Push(byte.Parse(_strNum2.Substring(j, 1)));
            int intNum = 0;
            string returnStr = "";
            while (true)
            {
                int n1, n2;
                n1 = m_myStack1.Count > 0 ? (byte)m_myStack1.Pop() : 0;
                n2 = m_myStack2.Count > 0 ? (byte)m_myStack2.Pop() : 0;
                int tong = n1 + n2 + intNum;
                if (tong == 0)
                    break;
                intNum = tong > 9 ? 1 : 0;
                returnStr = (tong > 9 ? tong - 10 : tong).ToString() + returnStr;
            }
            return returnStr;
        }

        ///-----------------------------------------------------------
        /// Description	    :	Check String that is full of character numbers
        /// Method name	    :	checkNumString
        /// Parameters	    :	_strNum
        /// Return value	:	true if this string is a numbers string\n else return false
        ///---------------------------------------------------------
        static bool checkNumString(string _strNum)
        {
            char[] charArray = _strNum.ToCharArray();
            string strCompare = "0123456789";
            foreach (char charNum in charArray)
                if (strCompare.IndexOf(charNum) < 0)
                    return false;
            return true;
        }
    }
    #endregion
}
