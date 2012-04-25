using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class Utilities
    {
        public static bool Test(string a, string b) //hàm kiểm tra xem hai số vừa nhập vào có hợp lệ hay ko
        {
            if (!BigInts.Test(a))
            {
                Console.Write(a);
                if (!BigInts.Test(b))
                    Console.Write(", " + b);
                Console.Write(" khong hop le");
                return false;
            }
            else
                if (!BigInts.Test(b))
                {
                    Console.Write(b + " khong hop le");
                    return false;
                }
            return true;
        }

        public static string Reverse(string a)  //hàm đảo ngược chuỗi
        {
            string temp = "";
            for(int i = a.Length-1; i >= 0; i--)
            {
                temp += a[i];
            }
            return temp;
        }
    }
}
