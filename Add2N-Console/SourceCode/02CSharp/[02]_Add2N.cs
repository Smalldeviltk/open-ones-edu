using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cong2SoDuong
{
    class Program
    {
        private static string a;
        private static string b;
        private static bool isNumber = true;
        public static string Cong(string a, string b)
        {
            string temp = null;
            for (int l = 0; l < a.Length; l++)
            {
                if (a[l] < 48 || a[l] > 57)
                {
                    isNumber = false;
                }
                

            }
            for (int m = 0; m < b.Length; m++)
            {
                if (b[m] < 48 || b[m] > 57)
                {
                    isNumber = false;
                }


            }
            if (!isNumber)
            {
                
                return null;
            }
            else
            {
                
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
                while (i < a.Length && i >= 0)
                {
                    int t = 0;
                    t = (a[i]) - 48 + (b[i]) - 48 + biennho;
                    if (t >= 10)
                    {
                        biennho = 1;
                        t = t % 10;
                    }
                    else
                        biennho = 0;



                    temp += t.ToString();

                    i--;

                }
            }

            return temp;
        }
        static void Main(string[] args)
        {
            char[] kk = new char[100];
            
            Console.WriteLine("Nhập số thứ nhất");
            a = Console.ReadLine().Trim();
            Console.WriteLine("Nhập số thứ hai");
            b = Console.ReadLine().Trim();
            if (Cong(a, b) != null)
            {
                kk = Cong(a, b).ToCharArray();
                Array.Reverse(kk);
                string result = new string(kk);
                Console.WriteLine("Kết quả là: {0}", result);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Nhập vào chưa đúng! <Không phải số nguyên>");
                Console.ReadLine();
            }
        }
    }
}
