//chuong trinh dung kieu string de (+) cong 2 so nguyen rat lon
//To Ngoc Khanh
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CongHaiSoNguyenLon
{
    class Program
    {
        //Ham kiem tra 1 chuoi nhap vao co phai la mot so hay khong.
        static bool ktso(string str)
        {
            try
            {
                int p;
                for (int i = 0; i < str.Length;i++ )
                {
                    p = int.Parse(str[i].ToString());
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }//ket thuc ham kt so

        //ham main
        static void Main(string[] args)
        {
            string str,s="",kq="";
            string[] s1;
            int n1, n2, a, du=0,p,q;
            //nhap 2 choi so
            do
            {
                //Add2N <so thu nhat> <sso thu hai>	
                Console.Write("Add2N ");
                str = Console.ReadLine();
                //bo khoang trang
                for (int i = 0; i < str.Length; i++)
                    str = str.Replace("  ", " ");
                s1 = str.Split(' ');//tach <so thu nhat> <sso thu hai> thanh <so thu nhat> va <sso thu hai>	
                //kiem tra chuoi s1 s2 nhap vao co phai la mot so hay khong
                if (!ktso(s1[0]) && !ktso(s1[1])) Console.WriteLine("<{0}>,<{1}> khong hop le",s1[0],s1[1]);
                if (!ktso(s1[0]) && ktso(s1[1])) Console.WriteLine("<{0}> khong hop le", s1[0]);
                if (ktso(s1[0]) && !ktso(s1[1])) Console.WriteLine("<{0}> khong hop le", s1[1]);
            } while (!ktso(s1[0])||!ktso(s1[1]));
            
            //gan do dai 2 chuoi cho n1 va n2
            n1 = s1[0].Length;
            n2 = s1[1].Length;
            //vong while tinh tnong
            while (n1>0||n2>0)
            {
                a = 0;
                if (n1 <= 0)//Neu chuoi het ky tu
                    p = 0;
                else
                p = int.Parse(s1[0][n1 - 1].ToString());

                if (n2 <= 0)//Neu chuoi het ky tu
                    q = 0;
                else
                q = int.Parse(s1[1][n2 - 1].ToString());
                
                a = p + q +du;
                if (a >= 10)//tinh so du
                {
                    a = a % 10;
                    du = 1;
                }
                else du = 0;
                s += a.ToString();//them so a vao chuoi s

                n1--;
                n2--;
            }//het vong lap while
            if (du > 0) s += du.ToString();
            //Dao nguoc lai chuoi s
            for (int i = s.Length; i > 0; i--)
            {
                kq += s[i-1];
            }
            Console.WriteLine("Ket qua: {0} + {1} = {2} ", s1[0], s1[1], kq);
            Console.ReadKey();
        }
    }
}
