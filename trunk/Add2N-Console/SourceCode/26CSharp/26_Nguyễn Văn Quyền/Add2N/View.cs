using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class View
    {
        public static string[] Input;
        public static string[] In() //hàm nhận tham số đầu vào
        {            
            Input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return Input;
        }
        public static void Out(string[] strInput, string strOutput) //hàm lấy kết quả để xuất
        {
            Console.WriteLine(string.Format("{0} + {1} = {2}\n", strInput[1], strInput[2], strOutput));
        }
    }
}
