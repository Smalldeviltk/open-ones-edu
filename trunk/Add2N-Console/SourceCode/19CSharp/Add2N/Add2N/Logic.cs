using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Add2N
{
    class Logic
    {
        static string[] num;
        static string strAlert;
        static bool blnCheck;
        public static string Calculator()
        {
            CheckSyntax();
            if (blnCheck)
            {
                int intNho = 0;
                int i = 0;
                string str1 = num[1];
                string str2 = num[2];
                string strResult = null;
                if (str1.Length >= str2.Length)
                {
                    i = str1.Length - 1;
                    string strTemp1 = null;
                    for (int j = 0; j < str1.Length - str2.Length; j++)
                    {
                        strTemp1 += "0";
                    }
                    str2 = strTemp1 + str2;
                }
                else
                {
                    i = str2.Length - 1;
                    string strTemp2 = null;
                    for (int j = 0; j < str2.Length - str1.Length; j++)
                    {
                        strTemp2 += "0";
                    }
                    str1 = strTemp2 + str1;
                }
                string strTemp3 = null;
                while (i < str1.Length && i >= 0)
                {
                    int intTemp1 = 0;
                    intTemp1 = (str1[i]) - 48 + (str2[i]) - 48 + intNho;
                    intNho = intTemp1 / 10;
                    intTemp1 = intTemp1 % 10;
                    strTemp3 += intTemp1.ToString();
                    i--;
                }
                if (((str1[0]) - 48 + (str2[0]) - 48 + intNho) >= 10)
                {
                    strTemp3 += "1";
                }
                int intTemp2 = strTemp3.Length - 1;
                while (intTemp2 < strTemp3.Length && intTemp2 >= 0)
                {
                    int intTemp3 = 0;
                    intTemp3 = strTemp3[intTemp2] - 48;
                    strResult += intTemp3.ToString();
                    intTemp2--;
                }
                return "\tKet qustr1:" + num[1] + "+" + num[2] + "=" + strResult;
            }
            else
                return "\tLoi: " + strAlert;
        }
    }
}
