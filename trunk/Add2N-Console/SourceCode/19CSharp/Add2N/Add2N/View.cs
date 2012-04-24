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
        // Hàm hiển thị thông tin và cách sử dụng chương trình
        public static void TitleIntro()
        {
            Console.WriteLine(" ---------------------------------------------------");
            Console.WriteLine("|        CHUONG TRINH CONG HAI SO NGUYEN LON        |");
            Console.WriteLine("| Cu phap chuong trinh: Add2N <thamso1> <thamso2>   |");
            Console.WriteLine(" ---------------------------------------------------");
        }
        // Hàm nhập thông số đầu vào
        public static string[] Input()
        {
            string strTemp;
            string[] temp;
            Console.Write("Nhap: ");
            /**
             * Dùng kết hợp Trim() và Split() để tách chuỗi riêng với các khoảng trắng
             * StringSplitOption.RemoveEmptyEntries để xóa bỏ khoảng trắng
             */
            strTemp = Console.ReadLine().Trim();
            temp = strTemp.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return temp;
        }
        // Hàm hiển thị kết quả ra màn hình Console
        public static void Output(string strResult)
        {
            Console.WriteLine(strResult);
        }
    }
}