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
        // Ham hien thi thong tin va cach su dung chuong trinh
        public static void TitleIntro()
        {
            Console.WriteLine(" ---------------------------------------------------");
            Console.WriteLine("|        CHUONG TRINH CONG HAI SO NGUYEN LON        |");
            Console.WriteLine("| Cu phap chuong trinh: Add2N <thamso1> <thamso2>   |");
            Console.WriteLine(" ---------------------------------------------------");
        }
        // Ham nhap thong so dau vao
        public static string[] Input()
        {
            string strTemp; // Bien tam dang chuoi de nhap cac chuoi
            string[] temp; // Bien tam dang mang chuoi de luu cac chuoi
            Console.Write("Nhap: ");
            /**
             * Dung ket hop Trim() va Split() de tach chuoi rieng voi cac khoang trang
             * StringSplitOption.RemoveEmptyEntries de xoa bo cac khoang trang
             */
            strTemp = Console.ReadLine().Trim();
            temp = strTemp.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return temp;
        }
        // Ham hien thi ket qua ra man hinh console
        public static void Output(string strResult)
        {
            Console.WriteLine(strResult);
        } 
    }
}