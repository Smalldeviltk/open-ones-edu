using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    /// <summary>
    /// Nguyen Nam Khanh
    /// </summary>
    public partial class Program
    {
        /// <summary>
        /// Ham nhap 2 so nguyen
        /// </summary>
        static void Input(ref Integer integer1, ref Integer integer2)
        {
            char c;

            c = (char)Console.Read();

            //Nhap so nguyen thu 1: Nhap phan tu tu ban phim cho den khi gap phim Space
            while (c != 32)
            {
                integer1.Input(c);
                c = (char)Console.Read();
            };

            c = (char)Console.Read();

            //Nhap so nguyen thu 2: Nhap phan tu tu ban phim cho den khi gap phim Enter
            while (c != 13)
            {
                integer2.Input(c);
                c = (char)Console.Read();
            };
        }

        /// <summary>
        /// Ham Xuat ket qua sau khi cong 2 so nguyen
        /// </summary>
        static void Output(Integer integer1, Integer integer2, ref Integer integer3)
        {
            string s;

            if (!integer1.CheckErrorCharacter())
            {
                if (!integer2.CheckErrorCharacter())
                {
                    s = integer1.Output() + "," + integer2.Output() + " ko hop le";
                    Console.WriteLine("{0}", s);
                    Console.ReadKey();
                }
                else
                {
                    s = integer1.Output() + " ko hop le";
                    Console.WriteLine("{0}", s);
                    Console.ReadKey();
                }
            }
            else
            {
                if (!integer2.CheckErrorCharacter())
                {
                    s = integer2.Output() + " ko hop le";
                    Console.WriteLine("{0}", s);
                    Console.ReadKey();
                }
                else
                {
                    integer3 = integer1.Sum(integer2);
                    integer3.InvertSequence();
                    integer3.ReduceSequence();
                    Console.Write("Ket qua hien thi la: ");
                    s = integer1.Output() + " +" + integer2.Output() + " =" + integer3.Output();
                    Console.WriteLine("{0}", s);
                    Console.ReadKey();
                }
            }
        }
    }
}
