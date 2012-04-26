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
    }
}
