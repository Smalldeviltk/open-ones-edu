using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _39_ADD2N
{
    class AddNumber
    {
        /// <summary>
        ///   include 4 methods 
        ///   check string, use to check the string input. will return true or false if string is valid or not
        ///   Convert char[] to string,
        ///   Convert string to char[]
        ///   Add 2 strings
        /// </summary>
        /// 
        //Pham hoang phu

        public bool IsValid(string strChecked)
        {
            char[] chrTemp = new char[strChecked.Length];
            chrTemp = strChecked.ToCharArray();
            for (int i = 0; i < chrTemp.Length; i++)
            {
                if (chrTemp[i] < '0' || chrTemp[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }

        //Van Trung Duy
        public string ConvertToString(char[] chrIn)
        {
            char[] chrOut = new char[chrIn.Length];
            int j = chrIn.Length - 1;
            for (int i = 0; i < chrIn.Length; i++)
            {
                chrOut[i] = chrIn[j];
                j--;
            }
            return new string(chrOut);
        }

        //Nguyen Dinh Hien
        public char[] ConverToChar(string strIn, int intLength)
        {
            char[] chrIn = new char[strIn.Length];
            chrIn = strIn.ToCharArray();
            char[] chrOut = new char[intLength];
            int j = 0;
            for (int i = chrIn.Length - 1; i >= 0; i--)
            {
                chrOut[j] = chrIn[i];
                j++;
            }
            for (; j < intLength; j++)
            {
                chrOut[j] = '0';
            }
            return chrOut;
        }

        //Nguyen Thanh Sang
        public string AddTwoStrings(string strFirstOperator, string strSecondOperator)
        {
            char[] chrFirstOprator = new char[strFirstOperator.Length];
            char[] chrSecondOperator = new char[strSecondOperator.Length];
            int intResultLength = ((strFirstOperator.Length < strSecondOperator.Length) ? strSecondOperator.Length : strFirstOperator.Length);
            chrFirstOprator = ConverToChar(strFirstOperator, intResultLength);
            chrSecondOperator = ConverToChar(strSecondOperator, intResultLength);
            char[] chrResult = new char[intResultLength];
            int intOdd = 0;
            for (int i = 0; i < intResultLength; i++)
            {
                int intAdd = ((int)chrFirstOprator[i] + (int)chrSecondOperator[i]) + intOdd;
                if (intAdd < 106)
                {
                    intOdd = 0;
                    chrResult[i] = (char)(intAdd - '0');
                }
                else
                {
                    chrResult[i] = (char)(intAdd - '0' - 10);
                    intOdd = 1;
                }
            }
            if (intOdd == 1)
            {
                char[] chrNewResult = new char[intResultLength + 1];
                for (int i = 0; i < chrResult.Length; i++)
                {
                    chrNewResult[i] = chrResult[i];
                    chrNewResult[intResultLength] = '1';
                }
                return ConvertToString(chrNewResult);
            }
            else
            {
                return ConvertToString(chrResult);
            }
        }

    }
}
