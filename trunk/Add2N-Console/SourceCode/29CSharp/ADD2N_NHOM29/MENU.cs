using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADD2N_NHOM29
{
    class MENU
    {
        public string menu(string s1, string s2)
        {
            Console.WriteLine("CHUONG TRINH CONG HAI SO NGUYEN LON:");
            Console.WriteLine("MENU");
            Console.WriteLine("\tNHAN  ENTER  DE THOAT KHOI CHUONG TRINH");
            Console.WriteLine("\tNHAP 1 DE CONG HAI SO NGUYEN LON");
            string X;
            string result1;
            X = Console.ReadLine();
            ADD2N addn = new ADD2N();
            switch (X)
            {
                case "1":
                    {
                        result1 = addn.addN(s1, s2);
                        return result1;
                        break;
                    }
                default:
                    {
                        Environment.Exit(0);
                        break;
                    }
            }
            return "";
        }
    }
}
