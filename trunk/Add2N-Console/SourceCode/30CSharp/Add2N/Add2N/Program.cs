using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo biến
            List<int> listNumber1;
            List<int> listNumber2;
            List<int> sum;

            // Cấp phát bộ nhớ
            View view = new View();
            Calculate calculate = new Calculate();

            // Phần chính
            if (view.Input(out listNumber1, out listNumber2)) // Thực hiện nhập và kiểm tra đầu vào
            {
                sum = calculate.Sum(listNumber1, listNumber2); // Tiến hành tính toán
                view.Output(sum); // In ra kết quả
            }
            Console.ReadLine();
        }
    }
}
