using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _41_Add2N
{
    class Program
    {
        static void Main(string[] args)
        {
        c:
            Console.Clear();
            HienThi._GioiThieu();
            HienThi.ThongTin(TinhToan._KetQua());
            Console.WriteLine("\n_____________________________\n \n Ban co muon tiep tuc khong? 0. Khong\t1.Co");
            Console.Write("\t\tChon: ");
            string t = Console.ReadLine().Trim();
            if (t.Equals("1") || t.ToLowerInvariant().Equals("co"))
                goto c;
        }
    }
}
