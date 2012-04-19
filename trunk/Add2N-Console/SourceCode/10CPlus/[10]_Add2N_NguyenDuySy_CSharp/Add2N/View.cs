using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class View
    {
        public static string[] NhapChuoi()
        {
            Console.WriteLine("Nhap 2 so theo dang: Add2N <so nguyen thu 1> <so nguyen thu 2>");
            Console.Write("Add2N ");
            string strChuoiNhap = Console.ReadLine();
            if (!strChuoiNhap.Contains(' ')) return null;
            else
            {
                while (strChuoiNhap[0] == ' ') strChuoiNhap = strChuoiNhap.Remove(0, 1);
                while (strChuoiNhap[strChuoiNhap.Length - 1] == ' ') strChuoiNhap = strChuoiNhap.Remove(strChuoiNhap.Length - 1, 1);
                int i = 0;
                while (i < strChuoiNhap.Length - 1)
                {
                    if (strChuoiNhap[i] == ' ' & strChuoiNhap[i + 1] == ' ') strChuoiNhap = strChuoiNhap.Remove(i, 1);
                    else i++;
                }

            }
            return strChuoiNhap.Split(' ');
        }

        public static void XuatThongBao(string strChuoiSai)
        {
            Console.Write(strChuoiSai + " khong hop le");
            Console.ReadKey();
        }

        public static void XuatKetQua(string s1, string s2)
        {
            Console.Write(s1 + " + " + s2 + " = " + Logic.add2N(s1,s2));
            Console.ReadKey();
        }
    }
}
