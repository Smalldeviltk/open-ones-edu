#region Copyright Group 19
//
// All rights are reserved. Reproduction or transmission in whole or 
// in part, in any form or by any means, electronic, mechanical or
// otherwise, is prohibited without the prior written consent of the 
// copyright owner.
// Filename: Program.cs
//
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Add2N
{
    class Logic
    {
        static string[] num; // Biến num lưu các chuỗi nhập vào
        static string strAlert; // Biến lưu chuỗi thông báo lỗi
        static bool blnCheck; // Biến trả về true nếu nhập đúng cú pháp
        // Hàm kiểm tra chuỗi kí tự nhập vào phải chuỗi kí tự không
        // dùng hàm IsDigit() có sắn trong thư viện .Net
        #region CheckDigit
        public static bool CheckDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsDigit(str[i]))
                    return false;
            }
            return true;
        }
        #endregion
        // Hàm kiểm tra cú pháp nhập vào
        #region CheckSyntax
        public static void CheckSyntax()
        {
            // Thiết lập giá trị ban đầu cho các biến
            num = null;
            strAlert = null;
            blnCheck = true;
            num=View.Input(); // Gọi hàm nhập thông tin từ class View.cs
            // Nếu nhập vào 3 chuỗi thì tiếp tục kiểm tra các chuỗi, ngược lại báo Không đúng cú pháp
            if (num.Length == 3)
            {
                // Kiểm tra chuỗi đầu tiên
                // Dùng hàm TolowerInvariant() để trả về chuỗi thường dạng add2n
                // nên không phân biệt chuỗi hoa thường 
                if (num[0].ToLowerInvariant().Equals("add2n") == false)
                {
                    if (strAlert == null)
                        strAlert += "Khong dung cu phap, "+ num[0] + " khong hop le";
                        blnCheck = false;
                }
                // Các bước kiểm tra 2 chuỗi kí tự nhập vào
                if (CheckDigit(num[1]) == false && CheckDigit(num[2]) == false)
                {
                    if(strAlert==null)
                    strAlert += num[1] + "," + num[2] + " khong hop le";
                    blnCheck = false;
                }
                if (CheckDigit(num[1]) == false)
                {
                    if (strAlert == null)

                    strAlert += num[1] + " khong hop le";
                    blnCheck = false;
                }
                if (CheckDigit(num[2]) == false)
                {
                    if (strAlert == null)
                    strAlert += num[2] + " khong hop le";
                    blnCheck = false;
                }
            }
            else if (num.Length!=3)
            {
                strAlert += "Khong dung cu phap";
                blnCheck = false;
            }
        }
        #endregion
        // Hàm thực hiện các phép xử lí trên chuỗi để hiển thị kết quả cộng 2 số
        #region Calculator
        public static string Calculator()
        {
            CheckSyntax();
            // Nếu blnCheck=true, đúng cú pháp do đó thực hiện xử lí để cộng chuỗi 
            if (blnCheck)
            {
                int intNho = 0; // Biến nhớ sau mỗi lần cộng
                int i = 0;
                // Dùng 2 biến chuỗi lưu các giá trị 2 chuỗi nhập vào và xử lí trên chúng
                // nhằm giữ giá trị ban đầu của chuỗi khi hiện ra,
                // không có chữ số 0 phía trước chuỗi ngắn hơn (sẽ xử lí bên dưới)
                string str1 = num[1];
                string str2 = num[2];
                string strResult = null; // Biến lưu chuỗi kết quả
                // Nếu chuỗi 1 dài hơn chuỗi 2
                if (str1.Length >= str2.Length)
                {
                    i = str1.Length - 1;
                    string strTemp1 = null;
                    for (int j = 0; j < str1.Length - str2.Length; j++)
                    {
                        strTemp1 += "0";
                    }
                    str2 = strTemp1 + str2; // Cộng vào trước chuỗi 2 các kí tự 0
                }
                    // Ngược lại nếu chuỗi 2 dài hơn chuỗi 1
                else
                {
                    i = str2.Length - 1;
                    string strTemp2 = null;
                    for (int j = 0; j < str2.Length - str1.Length; j++)
                    {
                        strTemp2 += "0";
                    }
                    str1 = strTemp2 + str1; // Cộng vào trước chuỗi 1 các kí tự 0
                }
                // Sau đó thực hiện cộng 2 chuỗi
                string strTemp3 = null;
                while (i < str1.Length && i >= 0)
                {
                    /**
                     * Thực hiện cộng từng kí tự từ phải qua trái để dễ thực hiện
                     * sau đó lưu chuỗi theo chiều ngược lại
                     * Thuật toán: chuyển từng kí tự về mã ASCII và trừ cho mã kí tự 0 để được số nguyên
                     * sau đó cộng bình thường như đối với số nguyên
                     */
                    int intTemp1 = 0;
                    intTemp1 = (str1[i]) - 48 + (str2[i]) - 48 + intNho;
                    intNho = intTemp1 / 10;
                    intTemp1 = intTemp1 % 10;
                    strTemp3 += intTemp1.ToString();
                    i--;
                }
                // Kí tự str[0] được cộng cuối cùng nên nếu >=10 thì thêm số 1 sau chuỗi (đã đảo ngược)
                if (((str1[0]) - 48 + (str2[0]) - 48 + intNho) >= 10)
                {
                    strTemp3 += "1";
                }
                // Thực hiện đảo chuỗi và lưu vào chuỗi strResult
                // đảo chuỗi tương tự như cách đã đảo chuỗi ở trên
                int intTemp2 = strTemp3.Length - 1;
                while (intTemp2 < strTemp3.Length && intTemp2 >= 0)
                {
                    int intTemp3 = 0;
                    intTemp3 = strTemp3[intTemp2] - 48;
                    strResult += intTemp3.ToString();
                    intTemp2--;
                }
                return "\tKet qustr1:" + num[1] + "+" + num[2] + "=" + strResult;
            }
            else
                return "\tLoi: " + strAlert;
        }
        #endregion
    }
}
