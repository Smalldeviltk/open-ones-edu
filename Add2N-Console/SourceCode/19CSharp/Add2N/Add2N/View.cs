#region Copyright Group 19
//
// All rights are reserved. Reproduction or transmission in whole or 
// in part, in any form or by any means, electronic, mechanical or
// otherwise, is prohibited without the prior written consent of the 
// copyright owner.
// Filename: View.cs
//
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Add2N
{
    class View
    {
        public static void TitleIntro()
        {
            Console.WriteLine(" ---------------------------------------------------");
            Console.WriteLine("|        CHUONG TRINH CONG HAI SO NGUYEN LON        |");
            Console.WriteLine("| Cu phap chuong trinh: Add2N <thamso1> <thamso2>   |");
            Console.WriteLine(" ---------------------------------------------------");
        }
        public static string[] Input()
        {
            string strTemp;
            string[] temp;
            Console.Write("Nhap: ");
            strTemp = Console.ReadLine().Trim();
            temp = strTemp.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return temp;
        }
        public static void Output(string strResult)
        {
            Console.WriteLine(strResult);
        } 
    }
}