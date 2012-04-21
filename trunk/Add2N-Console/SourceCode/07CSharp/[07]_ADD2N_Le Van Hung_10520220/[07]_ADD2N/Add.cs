/*
 * 0952 0022 - Dinh Van Chinh
 * 1052 0220 - Le Van Hung
 * Ngay sua doi - 20/04/2012
 */
using System;
using System.Text;

namespace Add2N
{
    class Add
    {
        /*
         * Ham cong 2 chuoi
         */
        public static string functionAdd(string sNumber1, string sNumber2)
        {
            // Them '0' vao dau chuoi ngan hon sao cho do dai 2 chuoi bang nhau
            if (sNumber1.Length > sNumber2.Length)
            {
                sNumber2 = sNumber2.PadLeft(sNumber1.Length, '0');
            }
            else if (sNumber2.Length > sNumber1.Length)
            {
                sNumber1 = sNumber1.PadLeft(sNumber2.Length, '0');
            }

            // Dua 2 chuoi vao 2 mang so nguyen
            int[] arrNum1 = new int[sNumber1.Length];
            int[] arrNum2 = new int[sNumber2.Length];
            for (int i = 0; i < sNumber1.Length; i++)
            {
                arrNum1[i] = Convert.ToInt32(sNumber1.Substring(i, 1));
            }
            for (int i = 0; i < sNumber2.Length; i++)
            {
                arrNum2[i] = Convert.ToInt32(sNumber2.Substring(i, 1));
            }

            // Dao nguoi 2 mang
            Array.Reverse(arrNum1);
            Array.Reverse(arrNum2);

            // Cong 2 mang va luu ket qua vao mang moi
            int[] arrResult = new int[sNumber1.Length + 1];
            int temp = 0;
            for (int i = 0; i < sNumber1.Length; i++)
            {
                arrResult[i] = arrNum1[i] + arrNum2[i] + temp;
                if (arrResult[i] >= 10)
                {
                    arrResult[i] -= 10;
                    temp = 1;
                }
                else
                {
                    temp = 0;
                }
            }
            if (temp == 1)
            {
                arrResult[arrResult.Length - 1] = 1;
            }

            // Dao nguoc mang ket qua va luu vao chuoi moi
            Array.Reverse(arrResult);
            StringBuilder sTemp = new StringBuilder(arrResult.Length);
            foreach (int i in arrResult)
            {
                sTemp.Append(i);
            }
            string sResult = "";
            if (temp == 1)
            {
                sResult = sTemp.ToString();
            }
            else if (temp == 0)
            {
                sResult = sTemp.ToString().Substring(1);
            }

            return sResult;
        }
    }
}
