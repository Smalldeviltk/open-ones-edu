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
           
        }

        //Hàm tổng 2 số nguyên từ người nhập
        public static string Add2N(string s1, string s2)
        {
           
        }


    }
    
}
