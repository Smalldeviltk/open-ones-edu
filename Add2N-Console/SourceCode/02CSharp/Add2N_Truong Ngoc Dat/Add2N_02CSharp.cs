﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N_csharp
{
    class Program
    {
        private static string a;//chuoi so thu 1
        private static string b;//chuoi so thu 2
        private static string chuoi_nhap;//chuoi nhap vao
        private static bool isNumber = true;//bien kiem tra hop le
        private static int tt = 0;//trang thai so hop le
        //Hàm thực hiện việc cộng.
        //Thực hiện: Trương Ngọc Đạt, Phạm Mạnh
        public static string Cong(string a, string b)//ham cong 2 so a,b
        {
            string temp = null;
            for (int l = 0; l < a.Length; l++)
            {
                if (a[l] < 48 || a[l] > 57)
                {
                    isNumber = false;
                    tt = 1;
                }


            }
            for (int m = 0; m < b.Length; m++)
            {
                if (b[m] < 48 || b[m] > 57)
                {
                    isNumber = false;
                    tt = 2;
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
                if (biennho != 0)
                {
                    int t = 1;
                    temp += t.ToString();
                }
            }
            
            return temp;
        }
        //hàm tách chuỗi.
        //Thực hiện : Nguyễn Mạnh Huy
        public static void tachchuoi()//ham tach chuoi nhap thanh a, b
        {
            try
            {
                string[] tmp;
                tmp = chuoi_nhap.Split(new char[] { ' ' });
                a = tmp[0];
                b = tmp[1];
            }
            catch
            {
                Console.WriteLine("cu phap khong hop le");
                a = "";
                b = "";
            }
        }
        //Hàm Main.
        //Thực hiện: Huỳnh Chí Tài, Trần Thị Mỹ Thú.
        static void Main(string[] args)
        {
            char[] kk = new char[100];
            
            Console.WriteLine("Add2N <so thu nhat> <so thu hai>.");
            Console.Write("Add2N ");
            chuoi_nhap = Console.ReadLine().Trim();
            tachchuoi();
            if (a != "" && b != "")
            {
                
                    kk = Cong(a, b).ToCharArray();
                    Array.Reverse(kk);
                    string result = new string(kk);
                    Console.WriteLine("{0} + {1} = {2}", a, b, result);
                    Console.ReadLine();
                
            }
            else
            {
                if (tt == 1)
                {
                    Console.WriteLine("{0} khong hop le.", a);
                }
                else
                {
                    if (tt == 2)
                    {
                        Console.WriteLine("{0} khong hop le.", a);
                        Console.WriteLine("{1} khong hop le.", b);
                    }
                }

                Console.ReadLine();
            }
        }
    }
}
