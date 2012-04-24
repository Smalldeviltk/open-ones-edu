using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace N45_Add2N
{
    public class Add2N
    {
        private LargeInt N1, N2, N3;
        private string Str, Str1, Str2;

        //khởi tạo lớp Add2N
        public Add2N()
        {
            N3 = new LargeInt();
            Str = Str1 = Str2 = "";
            InPut();
        }

        //Khởi tạo và truyền tham số cho 2 số nguyên
        private void InPut()
        {
            Console.Write("Add2N: ");
            Str = Console.ReadLine();
            Split2N(Str);
            N1 = new LargeInt(Str1);
            N2 = new LargeInt(Str2);
        }

        //Cắt chuỗi vừa nhập  thành 2 chuỗi số nguyên
        private void Split2N(string Input)
        {
            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i] == ' ')
                {
                    Str1 = Input.Substring(0, i);
                    Str2 = Input.Substring(i + 1, Input.Length - i - 1);
                    break;
                }
            }
        }
    }
}
