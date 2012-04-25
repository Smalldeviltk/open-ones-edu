using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add_2n
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Khoi tao doi tuong cua lop Logic
            Logic logic = new Logic();

            View view = new View();
            String s1 = "", s2 = "";

            Console.WriteLine("\t\tChuong trinh cong 2 so nguyen duong lon.");
            ///Nhap 2 so: so1 so2
            Console.Write("\tAdd2N: ");
            String s = Console.ReadLine();

            //Gan gia tri cho s1, s2
            int x = s.IndexOf(" "); //Vi tri cua khoang trang
            if (x == -1)            //Neu khong co khoang trang thi nhap theo nhan Enter
            {
                s1 = s;
                Console.Write("\t\tNhap so thu 2: ");
                s2 = Console.ReadLine();
            }
            else
            {
                //Nhap theo kieu: 123 456 -> s1 = 123, s2 = 456
                s1 = s.Substring(0, x);
                s2 = s.Substring(x + 1);
            }

            //Xu ly cac loi du lieu nhap
            if ((logic.isNumber(s1) == false) && (logic.isNumber(s2) == false))
            {
                Console.Write("\t{0}, {1} khong hop le.", s1, s2);
            }
            else if (logic.isNumber(s1) == false)
            {
                Console.Write("\t{0} khong hop le.", s1);
            }
            else if (logic.isNumber(s2) == false)
            {
                Console.Write("\t{0} khong hop le.", s2);
            }
            else
            {
                //Dua du lieu vao class
                view.setNumber(s1, s2);
                view.showResult(s1, s2);
            }
            Console.ReadLine();
        }
    }
}
