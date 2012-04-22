using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADD2N_NHOM29
{
    class ADD
    {
        public string add(string strNum1, string strNum2)
        {
            // Phan xu ly so thap phan  ----------------
            //neu la so nguyen thi them .0
            if (strNum1.IndexOf('.') < 0)
                strNum1 = strNum1 + ".0";
            if (strNum2.IndexOf('.') < 0)
                strNum2 = strNum2 + ".0";

            //tach moi so thanh 2 phan nguyen va thap phan
            string strnum1_p1 = strNum1.Substring(0, strNum1.IndexOf('.'));
            string strnum1_p2 = strNum1.Substring(strNum1.IndexOf('.') + 1);
            string strnum2_p1 = strNum2.Substring(0, strNum2.IndexOf('.'));
            string strnum2_p2 = strNum2.Substring(strNum2.IndexOf('.') + 1);

            bool flag = false;
            string strNumBigger = "";
            if (strNum1.Length >= strNum2.Length)
                strNumBigger = strNum1;
            else
                strNumBigger = strNum2;

            if (strnum1_p1.Length == strnum2_p1.Length)
                flag = true;

            //them so 0 vao phan truoc va sau dau . cho du
            if (strnum1_p1.Length > strnum2_p1.Length)
                strnum2_p1 = strnum2_p1.PadLeft(strnum1_p1.Length, '0');
            else if (strnum1_p1.Length < strnum2_p1.Length)
                strnum1_p1 = strnum1_p1.PadLeft(strnum2_p1.Length, '0');

            if (strnum1_p2.Length > strnum2_p2.Length)
                strnum2_p2 = strnum2_p2.PadRight(strnum1_p2.Length, '0');
            else if (strnum1_p2.Length < strnum2_p2.Length)
                strnum1_p2 = strnum1_p2.PadRight(strnum2_p2.Length, '0');

            // lay ve vi tri dau .
            int x = strnum1_p1.Length;

            //Ghep 2 phan thanh 1 chuoi (bo dau .) va Dua vao mang int[]
            strNum1 = strnum1_p1 + strnum1_p2;
            strNum2 = strnum2_p1 + strnum2_p2;

            int[] arrNum1 = new int[strNum1.Length];
            int[] arrNum2 = new int[strNum2.Length];
            for (int i = 0; i < strNum1.Length; i++)
            {
                arrNum1[i] = Convert.ToInt32(strNum1.Substring(i, 1));
            }
            for (int i = 0; i < strNum2.Length; i++)
            {
                arrNum2[i] = Convert.ToInt32(strNum2.Substring(i, 1));
            }
            //------------------------------

            //Dao nguoc chuoi
            Array.Reverse(arrNum1);
            Array.Reverse(arrNum2);

            //so mu~ cua 10 chinh la chi so phan tu trong mang int[]
            int[] arrResult = new int[strNum1.Length + 1];
            int phanbu = 0;
            for (int i = 0; i < strNum1.Length; i++)
            {
                arrResult[i] = arrNum1[i] + arrNum2[i] + phanbu;
                if (arrResult[i] >= 10)
                {
                    arrResult[i] -= 10;
                    phanbu = 1;
                }
                else
                    phanbu = 0;
            }
            if (phanbu == 1)
                arrResult[arrResult.Length - 1] = 1;

            //Dao nguoc chuoi Result
            Array.Reverse(arrResult);
            StringBuilder strbd = new StringBuilder(arrResult.Length);
            foreach (int i in arrResult)
                strbd.Append(i);
            string strResult = "";
            if (phanbu == 1)
                strResult = strbd.ToString();
            else if (phanbu == 0)
                strResult = strbd.ToString().Substring(1);

            //dua dau . vao ket qua o vi tri x
            if (flag == true && strNumBigger.Length == strResult.Length)
                x += 1;
            strResult = strResult.Insert(x, ".");

            return strResult;

        }
    }
}
