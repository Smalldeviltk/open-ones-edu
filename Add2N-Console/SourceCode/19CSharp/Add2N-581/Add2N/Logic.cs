#region Copyright Group 19
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
    class Logic
    {
        public static string Cong(string a, string b)
        {
            char[] ch = new char[100];
            if (MathHelper.CheckSyntax(a) == false && MathHelper.CheckSyntax(b) == false) return a + ", " + b + " khong hop le";
            if (MathHelper.CheckSyntax(a) == false) return a + " khong hop le";
            if (MathHelper.CheckSyntax(b) == false) return b + " khong hop le";
            string temp = a + " + " + b + " = ";

            int biennho = 0;
            int i = 0;
            if (a.Length >= b.Length)
            {
                i = a.Length - 1;
                string t = null;
                for (int j = 0; j < a.Length - b.Length; j++)
                {
                    t += "0";
                }
                b = t + b;
            }
            else
            {
                i = b.Length - 1;
                string t = null;
                for (int j = 0; j < b.Length - a.Length; j++)
                {
                    t += "0";
                }
                a = t + a;
            }
            string te = null;

            while (i < a.Length && i >= 0)
            {
                int t = 0;
                t = (a[i]) - 48 + (b[i]) - 48 + biennho;
                biennho = t / 10;
                t = t % 10;
                te += t.ToString();
                i--;
            }
            if (((a[0]) - 48 + (b[0]) - 48 + biennho) >= 10)
            {
                te += "1";
            }
            int x = te.Length - 1;
            while (x < te.Length && x >= 0)
            {
                int z = 0; z = te[x] - 48; temp += z.ToString(); x--;
            }
            return temp;
        }
    }
}
