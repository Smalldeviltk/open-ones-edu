using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
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
        private bool IsValid(string strnumber)
        {
            for (int i = 0; i < strnumber.Count(); i++)
            {
                if (!((strnumber[i] < 58) && (strnumber[i] > 47)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
