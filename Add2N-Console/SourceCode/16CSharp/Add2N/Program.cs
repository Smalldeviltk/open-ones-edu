using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class Program
    {
        public static int CongSN()
        {
            return 1;
        }

        static void Main(string[] args)
        {

           //Huong dan
           Console.WriteLine("CHUONG TRINH CONG 2 SO NGUYEN LON");
           Console.WriteLine("\nNhap tu khoa \"Exit\" de ket thuc !!!\n\n\n");

           //Lap vo han cho toi khi gap "Exit"
           while (true)
           {
              //Dang ky vung nho cho cac bien
              string strS = "";
              ListSN snA;
              ListSN snB;

              //Nhap so A
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

              //Nhap so B
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

              //Tinh ket qua
              ListSN ketQua = CongSN(snA, snB);
              Console.WriteLine(ketQua.GetValueList());
              if (Console.ReadLine() == "EXIT")
                 return;
           }
        }
    }
}
