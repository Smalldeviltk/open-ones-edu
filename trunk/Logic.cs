using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

///
/// Logic.cs
/// Thực hiện các tính toán, kiểm tra lỗi dữ liệu
///

namespace Add2N
{
    static class Logic
    {
        public static string Add(string arg1, string arg2)
        {
            int intLength;                                          //Độ dài lớn nhất trong 2 chuỗi
            string strResult = arg1 + " + " + arg2 + " = ";         //Kết quả sau khi tính nếu dữ liệu hợp lệ
            char[] chrTerm1 = null;                                 //Mảng kí tự của hạng tử 1
            char[] chrTerm2 = null;                                 //Mảng kí tự của hạng tử 2
            char[] chrResult = null;                                //Mảng kí tự của kết quả
            int intTemp = 0;                                        //Kết quả cộng trên từng chữ số
            int intMem = 0;                                         //Số nhớ
            //Kiểm tra lỗi nhập liệu
            if (MathHelper.CheckSyntax(arg1) == false && MathHelper.CheckSyntax(arg2) == false) return arg1 + ", " + arg2 + " khong hop le";
            if (MathHelper.CheckSyntax(arg1) == false) return arg1 + " khong hop le";
            if (MathHelper.CheckSyntax(arg2) == false) return arg2 + " khong hop le";

            //Xác định độ dài lớn nhất của 2 chuỗi, hoán vị 2 chuỗi để chuỗi 1 có độ dài luôn lớn hơn hoặc bằng chuỗi 2
            if (arg1.Length >= arg2.Length) intLength = arg1.Length;
            else
            {
                intLength = arg2.Length;
                MathHelper.Swap(ref arg1, ref arg2);
            }

            //Chuyển từ chuỗi sang mảng kí tự, sau đó đảo mảng kí tự để dễ thao tác
            chrResult = new char[intLength + 1];
            chrTerm1 = arg1.ToCharArray();
            chrTerm2 = arg2.ToCharArray();
            Array.Reverse(chrTerm1);
            Array.Reverse(chrTerm2);

            //Thực hiện phép cộng
            for (int i = 0; i < chrTerm2.Length; i++)
            {
                intTemp = Convert.ToInt32(chrTerm1[i].ToString()) + Convert.ToInt32(chrTerm2[i].ToString()) + intMem;
                if (intTemp > 9)
                {
                    intTemp -= 10;
                    intMem = 1;
                }
                else
                    intMem = 0;
                chrResult[i] = Convert.ToChar(intTemp.ToString());
            }
            for (int i = chrTerm2.Length; i < chrTerm1.Length; i++)
            {
                intTemp = Convert.ToInt32(chrTerm1[i].ToString()) + intMem;
                if (intTemp > 9)
                {
                    intTemp -= 10;
                    intMem = 1;
                }
                else
                    intMem = 0;
                chrResult[i] = Convert.ToChar(intTemp.ToString());
            }

            //Kiểm tra số nhớ để đảm bảo 9+1=10
            if (intMem == 1) chrResult[chrResult.Length - 1] = '1';

            //Đảo mảng kí tự kết quả sau khi tính toán xong
            Array.Reverse(chrResult);

            //Nối mảng kí tự kết quả vào chuỗi kết quả
            strResult += new string(chrResult);

            //Trả về chuỗi kết quả để Output
            return strResult;
        }
    }
    static class MathHelper
    {
        public static bool CheckSyntax(string arg)
        {
            //Kiểm tra xem dữ liệu của hạng tử có hợp lệ hay không
            for (int i = 0; i < arg.Length; i++)
            {
                if (!Char.IsDigit(arg[i])) return false;
            }
            return true;
        }
        public static void Swap(ref string s1, ref string s2)
        {
            //Hoán đổi 2 chuỗi
            string temp = s1;
            s1 = s2;
            s2 = temp;
        }
    }
}
