using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    /*
     * Lớp View, giao tiếp với người dùng
     */
    class View
    {
        public View()
        {
        }

        /*
         * Hàm xuất kết quả ra màn hình
         */
        public void Output(List<int> sum)
        {
            string temp1 = "";
            for (int i = 0; i < sum.Count; i++)
            {
                temp1 = sum[i].ToString() + temp1;
            }
            Console.WriteLine("Ans = {0}", temp1);
        }

        /*
         * Kiểm tra các số có hợp lệ
         */
        private bool IsValid(string strnumber)
        {
            for (int i = 0; i < strnumber.Count(); i++)
            {
                // Kiểm tra từng chữ cái coi có nằm ngoài dãy chữ số 0 -> 9 ko
                if (!((strnumber[i] < 58) && (strnumber[i] > 47)))
                {
                    return false;
                }
            }
            return true;
        }

        /*
         *  Hàm chuyển từ char array to List<int>
         */
        private List<int> CharArrayToList(char[] number)
        {
            List<int> result = new List<int>();
            for (int i = number.Count() - 1; i >= 0; i--)
            {
                result.Add(number[i] - '0');
            }
            return result;
        }

        /*
         * Hàm kiểm tra người dùng nhập
         */
        public bool Input(out List<int> listNumber1, out List<int> listNumber2)
        {
            // Định nghĩa và khởi tạo vùng nhớ
            listNumber1 = new List<int>();
            listNumber2 = new List<int>();
            string strInput = Console.ReadLine();
            string[] strTemp1 = strInput.Split(' ');

            if (strTemp1[0] == "Add2N") // Kiểm tra câu lệnh Add2N
            {
                if (!IsValid(strTemp1[1]) || (!IsValid(strTemp1[2]))) // Kiểm tra các tham số có phải là chử số không
                {
                    // In ra màn hình lỗi chi tiết (nếu có)
                    if (!IsValid(strTemp1[1]))
                    {
                        Console.Write("{0} ", strTemp1[1]);
                    }
                    if (!IsValid(strTemp1[2]))
                    {
                        Console.Write("{0} ", strTemp1[2]);
                    }
                    Console.WriteLine("is not valid", strTemp1[1]);

                    return false; 
                }
                else
                {
                    // Nếu không có lỗi thì tiến hành chuyễn dữ liệu từ string sang List<>
                    listNumber1 = CharArrayToList(strTemp1[1].ToCharArray());
                    listNumber2 = CharArrayToList(strTemp1[2].ToCharArray());

                    return true; // Trả về true
                }
            }
            else
            {
                // In ra màn hình lỗi Command
                Console.WriteLine("{0} command does not exist", strTemp1[0]);
                return false;
            }
        }
    }
}
