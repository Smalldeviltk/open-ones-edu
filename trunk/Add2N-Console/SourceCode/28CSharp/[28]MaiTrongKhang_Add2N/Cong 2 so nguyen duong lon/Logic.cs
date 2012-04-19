using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cong_2_so_nguyen_duong_lon
{
    class Logic
    {
        /// <summary>
        /// This method is used for caculating sum of 2 very big value numbers;
        /// </summary>
        /// <param name="first">The first inputted number.</param>
        /// <param name="second">The second inputted number.</param>
        /// <returns>A string that represents result's value</returns>
        public static string Add2N(string first, string second)
        {
            LinkedList<int> result = new LinkedList<int>();
            string rs = "";
            // exchange value between 2 inputted string
            if (first.Length < second.Length)
            {
                string temp = first;
                first = second;
                second = temp;
            }
            int flag = 0;// remember bit
            for (int j = 0; j < first.Length; j++)
            {
                int temp;
                if (j > second.Length - 1)
                    temp = first[first.Length - j - 1] - 48 + flag;
                else
                    temp = first[first.Length - j - 1] - 48 + second[second.Length - j - 1] - 48 + flag;
                if (temp >= 10)
                {
                    flag = 1;
                    temp = temp % 10;
                }
                else
                    flag = 0;
                result.AddFirst(temp);
            }
            //chaining result
            foreach (int i in result)
            {
                rs += i;
            }
            return rs;
        }
        /// <summary>
        /// Checking if inputed string s is a digit
        /// </summary>
        /// <param name="s">A string s need to be checked if it's a digit</param>
        /// <returns>True if s is a digit, otherwise</returns>
        public static bool isDigit(string s)
        {
            foreach (char c in s)
                if (c < 48 || c > 57)
                    return false;
            return true;
        }
    }
}
