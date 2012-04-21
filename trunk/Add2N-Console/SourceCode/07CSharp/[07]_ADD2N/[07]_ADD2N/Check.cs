/*
 * 1052 0622 - Bui Trong Phu
 * 1052 0302 - Bui Nguyen Manh Cuong
 * Ngay sua doi - 19/04/2012
 */

using System;
using System.Text.RegularExpressions;

namespace Add2N
{
    public class Check
    {
        /*
         * Ham kiem tra chuoi
         */
        public static bool functionCheck(string sNumber)
        {
            // Tach chuoi theo ' ' va dua vao mang moi
            string[] sArray = new string[] { };
            sArray = sNumber.Split(' ');

            // Kiem tra cu phap chuoi
            switch (sArray.Length)
            {
                case 2:     // Dung cu phap
                    Regex regex = new Regex(@"^[0-9]*$");
                    bool flag1 = regex.IsMatch(sArray[0]);
                    bool flag2 = regex.IsMatch(sArray[1]);
                    if (flag1 && flag2)                                                     // So thu nhat dung - So thu hai dung
                    {
                        return true;
                    }
                    else
                    {
                        string error = "Thong bao\t- Loi dau vao: <";
                        if (!flag1 && !flag2) { error += sArray[0] + "> , <" + sArray[1]; } // So thu nhat sai  - So thu hai sai
                        else if (!flag1) { error += sArray[0]; }                            // So thu nhat sai  - So thu hai dung
                        else { error += sArray[1]; }                                        // So thu nhat dung - So thu hai sai
                        error += "> khong hop le!";
                        Console.WriteLine(error);
                    }
                    break;
                default:    // Sai cu phap
                    Console.WriteLine("Thong bao\t- Loi dau vao: Sai cu phap!");
                    break;
            }
            return false;
        }
    }
}
