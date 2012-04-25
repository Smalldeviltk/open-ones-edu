using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Add2N
{
    class BigInts
    {
        private string d;   //chuỗi lưu số nguyên lớn theo thứ tự ngược, VD: số 127 sẽ lưu thành 721.

        public BigInts(string x)     //hàm khởi tạo
        {
            d = Utilities.Reverse(x);
        }

        public string show()
        {
            return d;
        }

        public static bool Test(string x) //truyền vào 1 chuỗi, kiểm tra xem đó có phải là số nguyên hợp lệ ko
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (!char.IsDigit(x[i])) //nếu có một ký tự không phải là số thì trả về false; 
                    return false;
            }
            return true;
        }


    }
}
