using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nhom36.Add2N
{
    // Class xu li 2 so nguyen.
    class Logic
    {
        static string[] number; 
        static string strtotal = null; 
        static string errorsentence; // Cau xuat ra noi xay ra loi.
        static bool error = false; // Bien bool kiem tra loi.

        // Ham kiem tra du lieu vao co dung khong.
        public static string Checker()
        {
            errorsentence = null;
            bool count = false; // Bieen bool kiem tra so nguyen thu 1 co dung khong.
            error = false; 
            number = View.InputNumber();
            if ( number.Length == 3) // Kiem tra neu co du 3 thanh phan.
            {
                if ( number[0] != "Add2N") // Kiem tra 'Add2N' co dung khong.
                {
                    errorsentence += number[0] + " khong dung. Ban phai nhap dung ma lenh la Add2N.\n";
                    error = true;
                }
                for (int i = 0; i < number[1].Length; i++)
                {
                    if (number[1][i] < 48 || number[1][i] > 57) // Neu so nguyen thu 1 nhap sai
                        count = true;
                }
                for (int i = 0; i < number[2].Length; i++)
                {
                    if (number[2][i] < 48 || number[2][i] > 57) // Neu so nguyen thu 2 nhap sai
                    {
                        if (count == false)
                        {
                            error = true;
                            errorsentence += number[2] + "khong hop le.\n"; // Thong bao neu chi so nguyen thu 2 nhap sai
                        }
                        else
                        {
                            errorsentence += number[1] + " va " + number[2] + " khong hop le.\n"; // Thong bao neu ca 2 so nguyen deu nhap sai
                            error = true;
                        }
                    }
                }
            }
            else
            {
                error = true;
                errorsentence = "Ban khong nhap du thanh phan.\n Xin nhap theo cau truc Add2N <sothu1> <sothu2>"; // Thong bao neu khong du 3 thanh phan
            }
            return errorsentence;
        }

        // Ham Tinh toan tong.
        public static string NumOutput()
        {
            Checker(); // Tien hanh kiem tra truoc khi tinh tong.
            int nho = 0; // Phan nho khi cong 2 so nguyen.
            int tong; // Luu ket qua.
            if (error == false) // Neu kiem tra khong co loi.
            {
                while (number[1].Length < number[2].Length) number[1] = '0' + number[1];
                while (number[2].Length < number[1].Length) number[2] = '0' + number[2];
                for (int i = number[1].Length - 1; i >= 0; i--)
                {
                    tong = number[1][i] + number[2][i] - 96 + nho;
                    strtotal = (char)((tong % 10) + 48) + strtotal;
                    nho = tong / 10;
                }
                while (nho > 0)
                {
                    strtotal = (char)(nho % 10 + 48) + strtotal;
                    nho /= 10;
                }
                return number[1] + " + " + number[2] + " = " + strtotal; // Tra ve ket qua.
            }
            else
                return errorsentence; // Tra ve thong bao loi.
        }
    }
    
}