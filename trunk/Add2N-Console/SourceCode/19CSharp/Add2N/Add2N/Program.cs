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
                    View.TitleIntro(); // Gọi phần hiển thị giới thiệu chương trình
                    string strChoice;
                    // Nhập cho đến khi nhấn khác 1 hoặc yes
                    do
                    {
                        // Gọi hàm Calculator từ class Logic để tính toán
                        // và hàm Output để hiển thị kết quả từ class View
                        // lúc này hàm Input cũng được gọi thông qua Calculator để nhập thông tin
                        View.Output(Logic.Calculator());
                        Console.WriteLine("\nBan co muon tiep tuc khong?");
                        Console.Write("\t\tChon (Yes=1/No=0): ");
                        strChoice=Console.ReadLine().Trim();
                    }
                    while (strChoice.Equals("1") || strChoice.ToLowerInvariant().Equals("yes"));
                }
                    // Kiểm tra các trường hợn ngoại lệ không mong muốn
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
        /// Dung cau truc try() catch() giup kiem soat hau het cac ngoai le phat sinh
        /// ngoai y muon, nhưng sẽ làm chậm quá trình Debug chương trình
        /// có thể không dùng cấu trúc này để Debug chương trình nhanh hơn
        /// vì các trường hợp lỗi cũng đã được kiểm soát khá chặt chẽ
        ///<summary>
    }
}
