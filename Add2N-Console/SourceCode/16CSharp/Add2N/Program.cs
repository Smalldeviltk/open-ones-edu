using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class Program
    {
        public static ListSN CongSN(ListSN firstNumber, ListSN secondNumber)
        {
            int intRemember = 0;
            int intDiff = firstNumber.Count - secondNumber.Count;
            // Nếu số nguyên A nhiều hơn số nguyên B 1,2,.. thì thêm các số 0 vào số B
            if (intDiff > 0)
                for (int i = 0; i < intDiff; i++)
                    secondNumber.AddNext(0);
            // Nếu số nguyên A nhỏ hơn số nguyên B 1,2,.. thì thêm các số 0 vào số A
            else if (intDiff < 0)
            {
                intDiff = 0 - intDiff;
                for (int i = 0; i < intDiff; i++)
                    firstNumber.AddNext(0);
            }
            // Tạo 1 list C mới
            ListSN resultNumber = new ListSN();
            // Chuyển nodeCurrent trong A về chữ số cuối cùng của chuỗi A
            firstNumber.ToFirst();
            // Chuyển nodeCurrent trong B về chữ số cuối cùng của chuỗi B
            secondNumber.ToFirst();
            // Nếu chữ số hiện tại mà NodeCurrent trong A và trong B có thì ta thực hiện cộng nó lại
            while (firstNumber.NodeCurrent != null && secondNumber.NodeCurrent != null)
            {
                // Cộng giá trị 2 chỉ số hiện tại trong A và B
                int value = firstNumber.NodeCurrent.Value + secondNumber.NodeCurrent.Value + intRemember;
                // Add số này vào chuỗi C, nếu số này lớn hơn 10 thì lấy phần dư thôi và nhớ lại 1
                resultNumber.AddNext(value % 10);
                // Lấy số nhớ
                intRemember = value / 10;
                // Chuyển tới chỉ số tiếp theo của số A và B
                firstNumber.ToNext();
                secondNumber.ToNext();
            }
            // Nếu số nhớ cuối cùng khác 0 thì Add thêm vào chuỗi C(chuỗi kết quả)
            if (intRemember != 0)
                resultNumber.AddNext(intRemember);
            return resultNumber;

        }

        static void Main(string[] args)
        {
            ListSN snA = new ListSN(args[0]);
            ListSN snB = new ListSN(args[1]);
            //Tinh ket qua
            ListSN ketQua = CongSN(snA, snB);
            Console.WriteLine(ketQua.GetValueList());
            if (Console.ReadLine() == "EXIT")
                return;
        }
    }
}
