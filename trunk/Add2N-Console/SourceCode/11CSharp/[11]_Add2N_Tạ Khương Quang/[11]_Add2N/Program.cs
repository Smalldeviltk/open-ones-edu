using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11__Add2N
{
    class Program
    {
        static void Main(string[] args)
        {
        c:
                Console.Clear();
                View.Introduce();
                View.ThongTin(Logic.Result());
                Console.WriteLine("\n**************************************\nBan co muon tiep tuc khong? 0. Khong\t1.Co");
                Console.Write("\t\tChon: ");
                string t = Console.ReadLine().Trim();
                if (t.Equals("1") || t.ToLowerInvariant().Equals("co"))
                    goto c;
        }
    }
}
