#region Copyright Group 23
//
// All rights are reserved. Reproduction or transmission in whole or // in part, in any form or by any means, electronic, mechanical or
// otherwise, is prohibited without the prior written consent of the // copyright owner.
//
// Filename: Program.cs
//
#endregion
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
            Program NewProgram      = new Program();
            string strInput         = "";
            string strFirstNumber   = "";
            string strSecondNumber  = "";
            bool blnCheck           = true;
            NewProgram.InputOutput(ref strInput,ref strFirstNumber,ref strSecondNumber,ref blnCheck);
            string strSum = NewProgram.Add2N(strFirstNumber, strSecondNumber);
            if (blnCheck == true)
            {
                Console.Write("{0} + {1} = {2}",strFirstNumber,strSecondNumber, strSum);
            }
            Console.ReadLine();
        }
        public void InputOutput(ref string strInput,ref string strFirstNumber,ref 
        string strSecondNumber,ref bool blnCheck)
        {
            Console.WriteLine("Cu phap: Add2N <So thu nhat> <So thu hai>");
            Console.WriteLine("Vi du  : Add2N 123 456");
           strInput = Console.ReadLine();
           strInput = strInput.Trim();
           #region Kiểm tra tính hợp lệ
           Program NewProgram           = new Program();
           string strSyntax = "";
           byte bytCount                = 0;
           NewProgram.SplitString(strInput,ref strSyntax,ref strFirstNumber,
           ref strSecondNumber,ref bytCount);
           int intCheckError1 = 0;
           int intCheckError2 = 0;
           foreach (char i in strFirstNumber)
           {
               if (!Char.IsDigit(i))
               {
                   intCheckError1++;
               }
           }
           foreach (char i in strSecondNumber)
           {
               if (!Char.IsDigit(i))
               {
                   intCheckError1++;
               }
           }
           if (strSyntax != "Add2N" || intCheckError1 != 0 || intCheckError2 != 0)
           {
               Console.WriteLine("{0} {1} {2} khong hop le!", strSyntax, strFirstNumber, strSecondNumber);
               blnCheck = false;
           }
           if (bytCount != 2)
           {
               Console.WriteLine("Sai cu phap, kiem tra lai: Add2N <So thu nhat> <So thu hai>");
               blnCheck = false;
           }
           #endregion
        }
        public void SplitString(string strInput,ref string strSyntax,ref string strFirstNumber,
        ref string strSecondNumber,ref byte bytCount)
        {
            int intCountSpace = 0;
            for (int i = 0; i < strInput.Length; i++)
            {
                if (strInput[i] == ' ')
                {
                    if (intCountSpace == 0)
                    {
                        strSyntax = strInput.Substring(intCountSpace, i);
                        intCountSpace = i + 1;
                        bytCount ++;
                    }
                    if (intCountSpace > 0 && i>intCountSpace)
                    {
                        strFirstNumber = strInput.Substring(intCountSpace, i-intCountSpace);
                        intCountSpace = i + 1;
                        bytCount ++;
                    }
                }
                if (i == strInput.Length - 1)
                {
                    strSecondNumber = strInput.Substring(intCountSpace, strInput.Length-intCountSpace);
                }
            }
        }
        public string Add2N(string strFirstNumber, string strSecondNumber)
        {
            int intRemember    = 0;
            int intSumLength   = 0;
            int intFirstLength = strFirstNumber.Length - 1;
            int intSecondLegth = strSecondNumber.Length - 1;
            if (intFirstLength > intSecondLegth) intSumLength = intFirstLength+1;
            else intSumLength = intSecondLegth+1;
            char[] strResult = new char[intSumLength+1]; //Trường hợp kết quả nhiều chữ số hơn số hạng.
            for (int i = intSumLength - 1; i >= 0; i--)
            {
                if (intFirstLength >=0 && intSecondLegth >=0)
                {
                    int intFirstLetter = strFirstNumber[intFirstLength--] - '0';
                    int intSecondLetter = strSecondNumber[intSecondLegth--] - '0';
                    if (intFirstLetter + intSecondLetter > 9)
                    {

                        int intTemp = (int)((intFirstLetter + intSecondLetter) % 10 + intRemember);
                        strResult[intSumLength--] = (char)(intTemp + 48); // Vì 48=(int)'0'
                        intRemember = 1;
                        if (i == 0)
                        {
                            strResult[0] = '1';
                        }
                    }
                    else
                    {
                        int intTemp = (int)((intFirstLetter + intSecondLetter) + intRemember);
                        strResult[intSumLength--] = (char)(intTemp+48);
                        intRemember = 0;
                    }
                }
                else
                {
                    if (intFirstLength < 0)
                    {
                        int intSecondLetter = strSecondNumber[intSecondLegth--] - '0';
                        int intTemp = (int)(intSecondLetter + intRemember);
                        strResult[intSumLength--] = (char)(intTemp + 48);
                    }
                    else if (intSecondLegth < 0)
                    {
                        int intFirstLetter = strFirstNumber[intFirstLength--] - '0';
                        int intTemp = (int)(intFirstLetter + intRemember);
                        strResult[intSumLength--] = (char)(intTemp+48);
                    }
                }
            }
            string strSum = new string(strResult);
            return strSum.Trim();
        }
    }
}
