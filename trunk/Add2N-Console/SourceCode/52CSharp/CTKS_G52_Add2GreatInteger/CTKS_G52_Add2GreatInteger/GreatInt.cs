using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTKS_GreatInteger
{
    class GreatInt
    {
        public string Number {get;set;}
        public GreatInt()
        {
            Number = "0";
        }
        public GreatInt(string _Number)
        {
            Number = _Number;
        }
       
        public static GreatInt operator +(GreatInt GInt1, GreatInt GInt2)
        {                      
            //Cộng lần lượt các chữ số theo thứ tự phải qua trái.
            string s = ""; //lưu lại kết quả, theo chiều ngược;
            int extra = 0; //Số bù dư của phép cộng 2 chữ số
            //Việc cộng bắt đầu từ cuối 2 số đến đầu của Số dài nhất
            for (int i = GInt1.Number.Length-1, j = GInt2.Number.Length-1; (j>=0)||(i>=0); i--, j--)
            {
                //Quy đồi chữ số kiểu char ra kiểu int để cộng
                int IntNum1 =(i < 0)?  IntNum1 = 48:(int)GInt1.Number[i];                   
                int IntNum2 =(j < 0)? IntNum2 = 48:(int)GInt2.Number[j];                                 
                int t = IntNum1-48 + IntNum2-48+extra;
                //Khi tổng 2 số không đến 10 (không có số dư) thì extra=0;
                if (t < 10)
                {
                    s += (char)(t + 48);
                    extra = 0;
                }
                else //Còn khi cộng có số dư thì extra =1;
                {
                    s+=(char)(t-10+48);
                    extra = 1;
                }

            }

            //thêm chữ số 1 nếu tràn
            if (extra == 1)
            {
                s += "1";
            }

            //reverse Result String 
            char[] sArr = s.ToCharArray();
            Array.Reverse(sArr);
            string rs=new string(sArr);

            GreatInt result = new GreatInt(rs);
            return result;
        }
        
    }
}
