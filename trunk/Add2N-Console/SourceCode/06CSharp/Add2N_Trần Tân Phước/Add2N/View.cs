using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

///
/// View.cs
/// 
///

namespace Add2N
{
    static class View
    {
        static internal void Input(ref string arg1, ref string arg2)
        {
            //Nhập dữ liệu
            string[] strTemp;
            strTemp = Console.ReadLine().Trim().Split(new char[] { ' ' });      //Tách chuỗi nhập
            arg1 = strTemp[1];      //Trả về hạng tử 1
            arg2 = strTemp[2];      //Trả về hạng tử 2
        }
        static internal void Output(string arg1, string arg2)
        {
            //Xuất kết quả sau khi tính toán
            Console.WriteLine("{0}", Logic.Add(arg1, arg2));
        }
    }
}
