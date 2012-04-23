using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class Logic
    {
        static bool checkN(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] - '0' < 0 || s[i] - '0' > 9) return false;
            }
            return true;
        }

        public static bool checkInput(string[] s)
        {
            if (s == null || s[0] == "" || s[1] == "")
            {
                View.writeInvalid("Nhap");
                return false;
            }
            string s1 = s[0];
            string s2 = s[1];
            bool c1 = checkN(s1);
            bool c2 = checkN(s2);
            string strInvalid = "";
            if (!c1 || !c2)
            {
                if (!c1)
                {
                    strInvalid = s1;
                    if (!c2) strInvalid += " va " + s2;
                }
                else strInvalid =s2;
                View.writeInvalid(strInvalid);
                return false;
            }
            return true;
        }

        public static string add2N(string s1, string s2)
        {
            string strResult = "";
            int i=1;
            int x, y, z, R = 0;
            while (i<=s1.Length || i<=s2.Length)
            {
                x = y = 0;
                if (i <= s1.Length) x = s1[s1.Length - i] - '0';
                if (i <= s2.Length) y = s2[s2.Length - i] - '0';
                z = (x + y + R)%10;
                R = z/10;
                strResult = z.ToString() + strResult;
                i++;
            }
            return strResult;
        }
    }
}
