using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class Logic
    {
        static bool KiemTraSoNguyen(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] - '0' < 0 || s[i] - '0' > 9) return false;
            }
            return true;
        }

        public static bool KiemTraChuoi(string[] s)
        {
            if (s == null || s[0] == "" || s[1] == "")
            {
                View.XuatThongBao("Nhap");
                return false;
            }
            string s1 = s[0];
            string s2 = s[1];
            bool k1 = KiemTraSoNguyen(s1);
            bool k2 = KiemTraSoNguyen(s2);
            string strChuoiSai = "";
            if (!k1 || !k2)
            {
                if (!k1)
                    {
                    strChuoiSai = s1;
                    if (!k2) strChuoiSai += " va " + s2;
                }
                else strChuoiSai =s2;
                View.XuatThongBao(strChuoiSai);
                return false;
            }
            return true;
        }

        public static string add2N(string s1, string s2)
        {
            string strKetQua = "";
            int i=1;
            int chrS1, chrS2, chrKetQua, R = 0;
            while (i <= s1.Length || i <= s2.Length)
            {
                chrS1 = chrS2 = 0;
                if (i <= s1.Length) chrS1 = s1[s1.Length - i] - '0';
                if (i <= s2.Length) chrS2 = s2[s2.Length - i] - '0';
                chrKetQua = (chrS1 + chrS2 + R) % 10;
                R = (chrS1 + chrS2 + R) / 10;
                strKetQua = chrKetQua.ToString() + strKetQua;
                i++;
            }
            if (R > 0) strKetQua = R.ToString() + strKetQua;
            while (strKetQua[0] == '0' & strKetQua.Length>1)  strKetQua = strKetQua.Remove(0, 1);
            return strKetQua;
        }
    }
}
