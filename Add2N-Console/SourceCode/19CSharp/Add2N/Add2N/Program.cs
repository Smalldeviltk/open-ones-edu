#region Copyright Group 19
//
// All rights are reserved. Reproduction or transmission in whole or 
// in part, in any form or by any means, electronic, mechanical or
// otherwise, is prohibited without the prior written consent of the 
// copyright owner.
// Filename: Program.cs
//
#endregion
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
            Console.Clear();
                try
                {
                    View.TitleIntro(); // Goi phan hien thi thong tin chuong trinh
                    string strChoice;
                    // Tiep tuc chuong trinh neu nhan 1 hoac yes
                    do
                    {
                        // Goi ham Calculator cua class Logic de thuc hien tinh toan
                        // va goi ham Output de hien thi ket qua tu class View
                        // luc nay ham Input cung duoc goi thong qua ham Calculator de nhap thong tin
                        View.Output(Logic.Calculator());
                        Console.WriteLine("\nBan co muon tiep tuc khong?");
                        Console.Write("\t\tChon (Yes=1/No=0): ");
                        strChoice=Console.ReadLine().Trim();
                    }
                    while (strChoice.Equals("1") || strChoice.ToLowerInvariant().Equals("yes"));
                }
                    // Kiem tra truong hop ngoai le khong mong muon
                catch (Exception e)
                {
                    Console.WriteLine("Loi:" + e.Message);
                }
                finally
                {
                    Console.ReadKey();
                }
        }
        ///<summary>
        /// Dung cau truc try() catch() giup kiem tra hau het cac loi ngoai le ngoai y muon
        /// Nhưng viec su dung cau truc nay se lam cham qua trinh Debug chuong trinh
        /// Co the khong can dung trong ct nay vi cac truong hop loi da duoc kiem soat kha tot
        ///<summary>
    }
}
