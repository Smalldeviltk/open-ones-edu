using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class Program
    {
        //Bài làm của nhóm 31, gồm 5 thành viên:
        //Nguyễn Quý Danh       09520032
        //Nguyễn Trung Việt     10520649
        //Lưu Nguyễn Hữu Đức    10520210
        //Võ Huỳnh Đức Huy      10520461
        //Đỗ Văn Tuấn           10520312
        static void Main(string[] args)
        {
            string x, y;
            try
            {   //nhập từ cmd
                x = args[0];
                y = args[1];
            }
            catch
            {   //nhập từ chương trình
                x = Console.ReadLine();
                y = Console.ReadLine();
            }

            //nếu có số nhập vào không hợp lệ thì thông báo rồi thoát khỏi chương trình
            if (!Utilities.Test(x, y))  
            {
                Console.ReadLine();
                return;
            }

            //khởi tạo hai đối tượnng
            BigInts a = new BigInts(x);
            BigInts b = new BigInts(y);

            //thực hiện phép cộng
            a.Add(b);

            //xuất kết quả ra màn hình
            Console.WriteLine(x + " + " + y + " = " + Utilities.Reverse(a.show()));
            Console.ReadLine();
        }
    }
}
