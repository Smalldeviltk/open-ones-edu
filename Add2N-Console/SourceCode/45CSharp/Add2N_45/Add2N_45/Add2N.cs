using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N_45
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

        //Kiểm tra lỗi ,thực thì và hiển thị kết quả nếu không lỗi
        public void Action()
        {
            //Nếu cả 2 số nguyên đều hợp lệ thì thực thi chương trình
            if (N1.IsLargeInt && N2.IsLargeInt)
            {
                N3 = N1 + N2;
                Console.WriteLine(N1.Large_Int + "+" + N2.Large_Int + "=" + N3.Large_Int);
            }
            //Thông báo số nguyên thứ I không hợp lệ
            if (!N1.IsLargeInt)
                Console.WriteLine(N1.Large_Int + " Khong Hop Le");
            //Thông báo số nguyên thứ II không hợp lệ
            if (!N2.IsLargeInt)
                Console.WriteLine(N2.Large_Int + " Khong Hop Le");
        }
    }
}
