using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    partial class Program
    {
        /* Noi chay chinh cua chuong trinh, ham Main co them tham so args
         * chua tham so nguoi dung nhap vao trong cau lenh. 
         * Vi du voi cau lenh Add2N x y:
         * args.Length = 2, args[0] = x, args[1] = y
         * */
        static void Main(string[] args)
        {
            if (args.Length == 0)// Kiem tra truong hop nguoi dung khong nhap tham so nao
            {
                Console.WriteLine("No arguments");
                Console.ReadKey();
                return;
            }
            else if (args.Length > 2)// Nhap qua nhieu tham so ? (chi can 2 tham so cho phep cong)
            {
                Console.WriteLine("Too much arguments");
                Console.ReadKey();
                return;
            }
            /*Chay cau lenh cong 2 chuoi lai voi nhau va
             * in ket qua ra man hinh */
            Add2N(args[0], args[1]);
            Console.ReadKey();
        }
        
    }
}
