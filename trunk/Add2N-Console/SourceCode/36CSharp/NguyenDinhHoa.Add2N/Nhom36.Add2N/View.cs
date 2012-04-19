using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nhom36.Add2N
{
    //Class  Nhap, Xuat so lieu.
    class View
    {
        // Ham gioi thieu chuong trinh.
        public static void OpenProgram()
        {
            Console.WriteLine("Bai tap Cong hai so nguyen cua nhom 36");
            Console.WriteLine("Chuong trinh chi dung de tinh tong 2 so nguyen duong");
            Console.WriteLine("Cac ban can nhap chinh xac: Add2N <sothu1> <sothu2>");
        }

        // Ham nhap du lieu.
        public static string[] InputNumber()
        {
            string Input;
            string[] strInput;
            Input = Console.ReadLine().Trim();
            strInput = Input.Split(' ');
            
            return strInput;
        }

        // Ham xuat ra ket qua.
        public static void Output(string NumOutput)
        {
            Console.WriteLine(NumOutput);
        }
    }
}
