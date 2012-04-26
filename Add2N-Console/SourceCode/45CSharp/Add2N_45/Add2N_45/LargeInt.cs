using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N_45
{
    public class LargeInt
    {
        //Chuỗi số nguyên
        private string LInt;
        //Biến kiểm tra số nguyên
        private bool IsLInt;


        //get,set cho chuỗi số nguyên
        public string Large_Int
        {
            get { return LInt; }
            set { LInt = value; }
        }

        //Khởi tạo một số nguyên bằng 0
        public LargeInt()
        {
            Large_Int = "0";
        }

        //Kiểm tra một chuỗi có phải là chuỗi số nguyên hay không
        public bool IsLargeInt
        {
            get
            {
                IsLInt = true;
                //Kiểm tra từ ký tự trong chuỗi nếu tồn tại 1 ký tự không phải số thì trả về false
                for (int i = 0; i < Large_Int.Length; i++)
                {
                    if (!Char.IsDigit(Large_Int[i]))
                    {
                        IsLInt = false;
                        break;
                    }

                }
                return IsLInt;
            }
        }

        //Khởi tạo một số nguyên lớn bằng 1 chuỗi có sẳn
        public LargeInt(string largeInt)
        {
            Large_Int = "";
            Large_Int = largeInt;
        }

        //Phương thức đảo chuỗi
        public string Rev(string largeInt)
        {
            string temp = "";
            for (int i = largeInt.Length - 1; i >= 0; i--)
            {
                temp += largeInt[i];
            }
            return temp;
        }

        //Phương thức cộng 2 số nguyên trả về 1 số nguyên
        public static LargeInt operator +(LargeInt a, LargeInt b)
        {
            int Count = a.Large_Int.Length > b.Large_Int.Length ? a.Large_Int.Length : b.Large_Int.Length;
            int res = 0;
            string temp = "";
            int x1, x2;
            string tempA = a.Rev(a.Large_Int);
            string tempB = b.Rev(b.Large_Int);

            //Cộng 2 số nguyên lớn
            if (a.IsLargeInt && b.IsLargeInt)
            {
                for (int i = 0; i < Count; i++)
                {
                    x1 = x2 = 0;
                    if (tempA.Length > i) x1 = Char.ConvertToUtf32(tempA, i) - 48;
                    if (tempB.Length > i) x2 = Char.ConvertToUtf32(tempB, i) - 48;

                    temp = ((x1 + x2 + res) % 10).ToString() + temp;
                    res = (x1 + x2 + res) / 10;
                }
            }
            else
                temp = "0";
            return new LargeInt(temp);
        }
    }
}
