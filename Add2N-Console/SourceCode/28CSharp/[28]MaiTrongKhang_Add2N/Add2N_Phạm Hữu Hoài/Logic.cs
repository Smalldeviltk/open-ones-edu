using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class Logic
    {
        /// <summary>
        /// normalize the string whose length is less than the other
        /// </summary>
        /// <param name="s">string to be normalized</param>
        /// <param name="d">number of length difference</param>
        /// <returns>return normalized string (add 0 at first
        /// until we have two strings whose length are the same)</returns>
        private static string Normalize(string s, int d)
        {
            for (int i = 0; i < d; i++)
            {
                s = s.Insert(0, "0");
            }
            return s;
        }

        /// <summary>
        /// Convert char c to int
        /// </summary>
        /// <param name="c">in char</param>
        /// <param name="i">out int</param>
        /// <returns>return whether the convertibility</returns>
        private static bool Convert(char c, out int i)
        {
            if (c >= 48 && c <= 57)
            {
                i = c - 48;
                return true;
            }
            i = -1;
            return false;
        }

        /// <summary>
        /// Main logic method, add two number and return the result
        /// </summary>
        /// <param name="f">the first number</param>
        /// <param name="s">the second number</param>
        /// <returns>string that is the result, it can be an error message</returns>
        public static string Add2N(string f, string s)
        {
            int d = Math.Abs(f.Length - s.Length);
            string first = f;
            string second = s;
            if (d > 0)
            {
                if (first.Length > second.Length)
                {
                    second = Normalize(s, d);
                }
                else if (first.Length < second.Length)
                {
                    first = Normalize(f, d);
                }
            }

            int a = 0, b = 0, t;
            int o = 0;
            string r = string.Empty;
            bool ferror = false;
            bool serror = false;
            string strResult=string.Empty;
            for (int i = first.Length - 1; i >= 0; i--)
            {
                if (!ferror && !Convert(first[i], out a))
                {
                    strResult += f +",";
                    ferror = true;
                }
                if (!serror && !Convert(second[i], out b))
                {
                    strResult += s+",";
                    serror = true;
                }
                if (serror || serror)
                    continue;

                t = a + b + o;
                if (t > 9)
                {
                    t -= 10;
                    o = 1;
                }
                else
                {
                    o = 0;
                }
                r += t.ToString();
            }
            if (ferror || serror)
            {
                strResult = strResult.Substring(0, strResult.LastIndexOf(','));
                strResult += " khong hop le";
            }
            else
            {
                if (o > 0)
                    r += o;
                char[] arr = r.ToCharArray();
                Array.Reverse(arr);
                strResult = f + " + " + s + " = " + new string(arr);
            }
            return strResult;
        }
    }

}
