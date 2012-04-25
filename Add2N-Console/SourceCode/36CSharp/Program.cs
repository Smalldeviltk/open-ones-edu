using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nhom36.Add2N
{
    class Program
    {
        # region Written by Trần Thanh Trường: Hàm main
        static void Main(string[] args)
        {
            retype:
            Console.Clear();
            View.OpenProgram();
            View.Output(Logic.NumOutput());
            rechoose:
            Console.WriteLine("\nDo you want to try again?\nY: Yes, Try Again\tN: No, Exit\n");// Hoi xem co muon thoat khong?
            string str = Console.ReadLine().Trim();
            if (str.ToUpper() == "Y" || str.ToLowerInvariant().Equals("Yes"))
                goto retype;
            else
            {
                if (str.ToUpper() != "N" && str.ToUpper() != "NO")
                    goto rechoose;
            }
            Console.WriteLine("Hen gap lai lan sau");
            Console.ReadLine();
        }
        #endregion
    }
}
