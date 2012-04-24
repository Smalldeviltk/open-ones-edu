#region Copyright Group 19
//
// All rights are reserved. Reproduction or transmission in whole or 
// in part, in any form or by any means, electronic, mechanical or
// otherwise, is prohibited without the prior written consent of the 
// copyright owner.
// Filename: Logic.cs
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
        static string[] num; // Bien num luu cac chuoi nhap vao
        static string strAlert; // Bien luu chuoi thong bao loi
        static bool blnCheck; // Bien tra ve false neu nhap sai cu phap
        // Ham kiem tra chuoi ki tu nhap vao co phai chuoi ki tu khong
        // dung ham IsDigit() co san trong thu vien .Net
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
        // Ham kiem tra cu phap nhap vao
        #region CheckSyntax
        public static void CheckSyntax()
        {
            // Thiet lap gia tri ban dau cho cac bien
            num = null;
            strAlert = null;
            blnCheck = true;
            num=View.Input(); // Goi phuong thuc Input tu class View.cs
            // Neu nhap vao 3 chuoi thi tiep tuc kiem tra chuoi, nguoc lai
            // thong bao Khong dung cu phap
            if (num.Length == 3)
            {
                // Kiem tra chuoi dau tien
                // Dung ham TolowerInvariant() de tra ve chuoi thuong dang add2n
                // nen khong phan biet chuoi hoa thuong
                if (num[0].ToLowerInvariant().Equals("add2n") == false)
                {
                    if (strAlert == null)
                        strAlert += "Khong dung cu phap, "+ num[0] + " khong hop le";
                        blnCheck = false;
                }
                // Cac buoc kiem tra 2 chuoi ki tu nhap vao
                if (CheckDigit(num[1]) == false && CheckDigit(num[2]) == false)
                {
                    if(strAlert==null)
                    strAlert += num[1] + ", " + num[2] + " khong hop le";
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
        // Ham thuc hien cac phep xu li logic tren chuoi de hien ra ket qua cong 2 so nguyen
        #region Calculator
        public static string Calculator()
        {
            CheckSyntax();
            // Neu blnCheck=true, dung cu phap do do se thuc hien viec xu li chuoi
            if (blnCheck)
            {
                int intNho = 0; // Bien nho luc dau = 0
                int i = 0;
                // Dung 2 bien chuoi lua 2 chuoi nhap vao va xu li tren 2 bien nay
                // nham giu gia tri ban dau cua chuoi
                // khong co ki tu 0 dung truoc chuoi ngan hon (se xu li ben duoi)
                string str1 = num[1];
                string str2 = num[2];
                string strResult = null; // Bien chuoi luu ket qua
                // Neu chuoi 1 dai hon chuoi 2
                if (str1.Length >= str2.Length)
                {
                    i = str1.Length - 1;
                    string strTemp1 = null;
                    for (int j = 0; j < str1.Length - str2.Length; j++)
                    {
                        strTemp1 += "0";
                    }
                    str2 = strTemp1 + str2; // Cong vao truoc chuoi 2 cac ki tu 0
                }
                    // Nguoc lai neu chuoi 2 dai hon chuoi 1
                else
                {
                    i = str2.Length - 1;
                    string strTemp2 = null;
                    for (int j = 0; j < str2.Length - str1.Length; j++)
                    {
                        strTemp2 += "0";
                    }
                    str1 = strTemp2 + str1; // Cong vao truoc chuoi 1 cac ki tu 0
                }
                // Sau do thuc hien cong 2 chuoi
                string strTemp3 = null;
                while (i < str1.Length && i >= 0)
                {
                    /**
                     * Thuc hien cong tung ki tu, tu phai qua trai
                     * chuoi ket qua duoc luu theo chieu nguoc lai
                     * Thuat toan: chuyen tung ki tu ve ma ASCII va tru cho ma ki tu 0 (48) de duoc so nguyen
                     * sau do cong binh thuong nhu doi voi cac so nguyen
                     */
                    int intTemp1 = 0;
                    intTemp1 = (str1[i]) - 48 + (str2[i]) - 48 + intNho;
                    intNho = intTemp1 / 10;
                    intTemp1 = intTemp1 % 10;
                    strTemp3 += intTemp1.ToString();
                    i--;
                }
                // Ki tu str[0] duoc cong cuoi cung nen neu >=10 thi them so 1 sau chuoi (da dao nguoc)
                if (((str1[0]) - 48 + (str2[0]) - 48 + intNho) >= 10)
                {
                    strTemp3 += "1";
                }
                // Thuc hien dao chuoi va luu vao chuo strResult
                // dao chuoi tuong tu nhu cach tren
                int intTemp2 = strTemp3.Length - 1;
                while (intTemp2 < strTemp3.Length && intTemp2 >= 0)
                {
                    int intTemp3 = 0;
                    intTemp3 = strTemp3[intTemp2] - 48;
                    strResult += intTemp3.ToString();
                    intTemp2--;
                }
                // Tra ve mot chuoi hien thi input va output cua phep cong 
                return "\tKet qua: " + num[1] + "+" + num[2] + "=" + strResult;
            }
            else
                // Neu bien thong bao loi strAlert = false
                return "\tLoi: " + strAlert;
        }
        #endregion
    }
}
