using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _56__ADD2N
{
    
    class View
    {
        //Thông báo cho người nhập số
        public static string[] NhapChuoi()
        {

            Console.WriteLine("\n\n\t\tChuong Trinh Tinh Tong 2 So Nguyen Rat Lon\n\t\tNhap 2 so theo dang:\n\n\t\t\tAdd2N <ST1> <ST2>");
            Console.Write("\n\t\t\tAdd2N ");
            string ChuoiNhap = Console.ReadLine();
            if (!ChuoiNhap.Contains(' ')) return null;
            else
            {
                while (ChuoiNhap[0] == ' ') ChuoiNhap = ChuoiNhap.Remove(0, 1);
                while (ChuoiNhap[ChuoiNhap.Length - 1] == ' ') ChuoiNhap = ChuoiNhap.Remove(ChuoiNhap.Length - 1, 1);
                int i = 0;
                while (i < ChuoiNhap.Length - 1)
                {
                    if (ChuoiNhap[i] == ' ' & ChuoiNhap[i + 1] == ' ') ChuoiNhap = ChuoiNhap.Remove(i, 1);
                    else i++;
                }

            }
            return ChuoiNhap.Split(' ');
            
        }

        // Thông báo khi có lỗi
        public static void BaoLoi(string ChuoiSai)
        {
            Console.Write("\n\t\t\t"+ ChuoiSai + " khong hop le\n");
        }

        //Thông báo kết quả
        public static void KetQua(string s1, string s2)
        {
            Console.Write("\t\t\t"+s1 + " + " + s2 + " = " + Logic.Add2N(s1, s2)+"\n");
            Console.ReadKey();
        }

        // Xét xem người dùng có cần tính lại không
        public static bool LapLai()
        {
 	    Console.Write("\n\t\t\tBan Co Muon Tinh Tiep Khong ?\n\t\t\t\tY     : de tiep tuc.\n\t\t\t\tEnter : de thoat.\n\t\t\t\t");
            if (Console.ReadLine() == "y") return true;
            else return false;           
        }

    }
}
