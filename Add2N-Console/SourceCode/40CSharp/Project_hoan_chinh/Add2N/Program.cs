using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class Program
    {
        public static ListSN CongSN(ListSN A, ListSN B)
        {
            int intRemember = 0;
            int intDiff = A.Count - B.Count;
            if (intDiff > 0)
                for (int i = 0; i < intDiff; i++)
                    B.AddNext(0);
            else if (intDiff < 0)
            {
                intDiff = 0 - intDiff;
                for (int i = 0; i < intDiff; i++)
                    A.AddNext(0);
            }
            ListSN C = new ListSN();
            A.ToFirst();
            B.ToFirst();
            while (A.NodeCurrent != null && B.NodeCurrent != null)
            {
                int value = A.NodeCurrent.Value + B.NodeCurrent.Value + intRemember;
                C.AddNext(value % 10);
                intRemember = value / 10;
                A.ToNext();
                B.ToNext();
            }
            
            return C;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("CHUONG TRINH CONG 2 SO NGUYEN LON");
            Console.WriteLine("\nNhap tu khoa \"Exit\" de ket thuc !!!\n\n\n");
            while (true)
            {
                string strS = "";
                ListSN snA;
                ListSN snB;

                try
                {
                    Console.Write("Nhap so nguyen lon A: ");
                    strS = Console.ReadLine();
                    if (strS.ToUpper() == "EXIT")
                        return;
                    snA = new ListSN(strS);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    strS = Console.ReadLine();
                    if (strS == "EXIT")
                        return;
                    else
                        continue;
                }

                try
                {
                    Console.Write("Nhap so nguyen lon B: ");
                    strS = Console.ReadLine();
                    if (strS.ToUpper() == "EXIT")
                        return;
                    snB = new ListSN(strS);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    if (Console.ReadLine() == "EXIT")
                        return;
                    else
                        continue;
                }

                ListSN ketQua = CongSN(snA, snB);
                Console.WriteLine(ketQua.GetValueList());
                if (Console.ReadLine() == "EXIT")
                    return;
            }
        }
    }
}
