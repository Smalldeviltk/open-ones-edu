using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Add2N
{
    partial class Calculator
    {
        /* Ham AddResult muc dich de cong 2 chuoi tham so nguoi dung nhap vao
         * su dung cau lenh CanAdd de kiem tra chuoi co hop le hay khong */
        public String AddResult(String x, String y)
        {
            /*Dieu chinh lai sao cho 2 chuoi nhap vao co cung do dai
             * nham de thuc hien phep cong, chuoi nao co do dai nho hon 
             * se duoc bo sung vao nhung con so 0 */
            if (x.Length > y.Length)
            {
                y=y.PadLeft(x.Length, '0');
              }
            else
            {
                x=x.PadLeft(y.Length, '0');
              
            }
            bool remember = false;// Bien nho, neu bien nho la true thi phep cong truoc cho ra ket qua > 10
            int ix, iy; // Bien int dung de cong, phai thuc hien thao tac chuyen doi tu kieu char sang int
            String result = string.Empty;
            for (int i = x.Length - 1; i >= 0; i--) 
            {
                /* Chuyen doi sang kieu int:
                 * Theo bang ma ASCII thi giua '0' (kieu char) va so 0
                 * chenh lech nhau 48 don vi, vi vay de chuyen tu kieu char
                 * sang int ta lay kieu char tru di 48 don vi */
                ix = x[i] - 48;
                iy = y[i] - 48;
                
                /*Cac thao tac cong nhu ta cong thu cong */
                int value = ix + iy;
                if (remember)
                {
                    value += 1;
                }
                if (value >= 10)
                {
                    result = result.Insert(0, (value - 10).ToString());
                    remember = true;
                }
                else
                {
                    result = result.Insert(0, value.ToString());
                    remember = false;
                }
            }
            if (remember)
            {
                result = result.Insert(0,"1");
            }
            return result;
        }
        public String ErrorMessage
        {
            get;
            set;
        }
        
        
    }
}
