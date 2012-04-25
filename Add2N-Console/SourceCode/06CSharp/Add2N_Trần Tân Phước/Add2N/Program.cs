using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
///
/// Program.cs 
///
namespace Add2N
{
    class Program
    {
        static void Main(string[] args)
        {
            string strArg1 = null;      //Hạng tử thứ nhất
            string strArg2 = null;      //Hạng tử thứ hai
            View.Input(ref strArg1, ref strArg2);       //Nhập dữ liệu
            View.Output(strArg1, strArg2);              //Xuất kết quả
        }
    }
}
