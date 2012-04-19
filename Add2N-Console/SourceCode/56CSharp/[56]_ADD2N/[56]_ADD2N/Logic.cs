using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _56__ADD2N
{
    class Logic
    {
        // Hàm kiểm tra 1 chuỗi có phải là số không
        private static bool SoNguyen(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] - '0' < 0 || s[i] - '0' > 9) return false;
            }
            return true;
        }

        //Hàm kiểm tra chuỗi có hợp lê, có phải là chuỗi số nguyên hay không
        public static bool KiemTraChuoi(string[] s)
        { 
           try
            {
                string s1 = s[0];
                string s2 = s[1];
                string ChuoiSai;
                bool test1 = SoNguyen(s1);
                bool test2 = SoNguyen(s2);

                if (!test1 || !test2)
                {
                    if (!test1)
                    {
                        ChuoiSai = s1;
                        if (!test2) ChuoiSai += " va " + s2;
                    }
                    else ChuoiSai = s2;
                    View.BaoLoi(ChuoiSai);
                    return false;
                }
                return true;
            }
            catch
            {
                View.BaoLoi("Nhap");
                return false;
            }
        }

        //Hàm tổng 2 số nguyên từ người nhập
        public static string Add2N(string s1, string s2)
        {
           string strKetQua = "";
            int i = 1;
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
            while (strKetQua[0] == '0' & strKetQua.Length > 1) strKetQua = strKetQua.Remove(0, 1);
            return strKetQua;
        }


    }
    
}
