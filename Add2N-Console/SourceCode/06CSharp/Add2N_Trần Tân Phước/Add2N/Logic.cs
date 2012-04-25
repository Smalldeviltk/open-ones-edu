using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    static class Logic
    {
        public static string Add(string arg1, string arg2)
        {
            if (MathHelper.CheckSyntax(arg1) == false && MathHelper.CheckSyntax(arg2) == false) return arg1 + ", " + arg2 + " khong hop le";
            if (MathHelper.CheckSyntax(arg1) == false) return arg1 + " khong hop le";
            if (MathHelper.CheckSyntax(arg2) == false) return arg2 + " khong hop le";
            int intLength;
            string strResult = arg1 + " + " + arg2 + " = ";
            if (arg1.Length >= arg2.Length) intLength = arg1.Length;
            else
            {
                intLength = arg2.Length;
                MathHelper.Swap(ref arg1, ref arg2);
            }
            char[] chrTerm1 = arg1.ToCharArray();
            char[] chrTerm2 = arg2.ToCharArray();
            Array.Reverse(chrTerm1);
            Array.Reverse(chrTerm2);
            char[] chrResult = new char[intLength + 1];
            int intTemp = 0;
            int intMem = 0;
            for (int i = 0; i < chrTerm2.Length; i++)
            {
                intTemp = Convert.ToInt32(chrTerm1[i].ToString()) + Convert.ToInt32(chrTerm2[i].ToString()) + intMem;
                if (intTemp > 9)
                {
                    intTemp -= 10;
                    intMem = 1;
                }
                else
                    intMem = 0;
                chrResult[i] = Convert.ToChar(intTemp.ToString());
            }
            for (int i = chrTerm2.Length; i < chrTerm1.Length; i++)
            {
                intTemp = Convert.ToInt32(chrTerm1[i].ToString()) + intMem;
                if (intTemp > 9)
                {
                    intTemp -= 10;
                    intMem = 1;
                }
                else
                    intMem = 0;
                chrResult[i] = Convert.ToChar(intTemp.ToString());
            }
            if (intMem == 1) chrResult[chrResult.Length - 1] = '1';
            Array.Reverse(chrResult);
            strResult += new string(chrResult);
            return strResult;
        }
    }
    static class MathHelper
    {
        public static bool CheckSyntax(string arg)
        {
            for (int i = 0; i < arg.Length; i++)
            {
                if (!Char.IsDigit(arg[i])) return false;
            }
            return true;
        }
        public static void Swap(ref string s1, ref string s2)
        {
            string temp = s1;
            s1 = s2;
            s2 = temp;
        }
    }
}
