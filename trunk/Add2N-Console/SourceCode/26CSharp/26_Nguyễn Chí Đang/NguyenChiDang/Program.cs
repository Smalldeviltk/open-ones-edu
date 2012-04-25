using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            do
            {
                Console.Clear();
                HienThi.GioiThieu();
                HienThi.ThongTin(TinhToan.KetQuaPT());
                Console.WriteLine("\n\nChon [1] de tiep tuc, phim bat ki de ket thuc.");
                Console.Write("\t\tChon: ");
                t = Console.ReadLine().Trim();
            }
            while (t == "1");
        }
    }
}