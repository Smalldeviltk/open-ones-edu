﻿using System;
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

        public void Add(BigInts x)  //hàm cộng dồn thêm một số nguyên dương
        {
            string k = x.d;
            string kq = "";
            int i, n, s, len = (d.Length < k.Length) ? d.Length : k.Length; //len = chiều dài của số nhỏ hơn
            for (i = n = s = 0; i < len; i++)  //n là số dùng để nhớ, s là số dùng để lưu tổng tạm thời
            {
                s = int.Parse(d[i].ToString()) + int.Parse(k[i].ToString()) + n;    //cộng chữ số với nhau và cộng thêm số nhớ
                kq += (s % 10).ToString();
                n = s / 10;
            }
            while (i < d.Length)
            {
                s = int.Parse(d[i].ToString()) + n;    //cộng chữ số với nhau và cộng thêm số nhớ
                kq += (s % 10).ToString();
                n = s / 10;
                i++;
            }
            while (i < k.Length)
            {
                s = int.Parse(k[i].ToString()) + n;    //cộng chữ số với nhau và cộng thêm số nhớ
                kq += (s % 10).ToString();
                n = s / 10;
                i++;
            }
            if (n > 0)
                kq += n.ToString();
            this.d = kq;
        }
    }
}
