using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11__Add2N
{
    class Logic
    {
        static string[] number; // Bien nho 2 so nhap vao de thuc hien phep tinh
        static string result; // ket qua
        static bool check = true; // Bien kiem tra cau truc nhap vao dung hay sai
        static string warning; // Chuoi hien thi canh bao

        // Ham kiem tra cau truc nhap vao dung hay sai
        public static void KiemTra()
        {
            // Reset lai cac bien du lieu
            number = null;
            result = null;
            check = true;
            warning = null;

            // Lay thong tin so nhap vao
            number = View.NhapThongTin();

            // Kiem tra cau truc nhap vao dung hay sai
            if (number.Length == 3)
            {
                // Kiem tra tu khoa nhap vao. Neu sai thi tra ve check = false va luu canh bao
                if (number[0].ToLowerInvariant().Equals("add2n") == false)
                {
                    warning += number[0] + " khong hop le";
                    check = false;
                }

                // Kiem tra so thu nhat nhap vao> Neu sai thi tra ve check = false va luu canh bao
                for (int i = 0; i < number[1].Length; i++)
                {
                    if (number[1][i] < 48 || number[1][i] > 57)
                    {
                        check = false;
                        if (warning == null)
                            warning += "\n" + number[1] + " khong hop le";
                        else if (warning.Contains(number[1] + " khong hop le") == false)
                            warning += "\n" + number[1] + " khong hop le";
                    }
                }

                // Kiem tra so thu hai nhap vao. Neu sai thi tra ve check = false va luu canh bao
                for (int i = 0; i < number[2].Length; i++)
                {
                    if (number[2][i] < 48 || number[2][i] > 57)
                    {
                        check = false;
                        if (warning == null)
                            warning += "\n" + number[2] + " khong hop le";
                        else if (warning.Contains(number[2] + " khong hop le") == false)
                            warning += "\n" + number[2] + " khong hop le";
                    }
                }
            }
            else
            {
                warning += "\n" + "Nhap thong tin khong theo cau truc!";
                check = false;
            }
        }

        // Tinh toan ket qua phep tinh
        public static string Result()
        {
            // Kiem tra cau truc nhap vao dung hay sai
            KiemTra();
            // Neu khong co loi thi thuc hien tinh toan

            if (check)
            {
                int du = 0; // Luu so du khi cong
                int tong; // Luu ket qua

                int length = number[1].Length - number[2].Length;

                // tinh toan de lay ket qua phep tinh
                while (number[1].Length < number[2].Length) number[1] = '0' + number[1];
                while (number[2].Length < number[1].Length) number[2] = '0' + number[2];

                for (int i = number[1].Length - 1; i >= 0; i--)
                {
                    tong = number[1][i] + number[2][i] - 96 + du;
                    result = (char)((tong % 10) + 48) + result;
                    du = tong / 10;
                }
                while (du > 0)
                {
                    result = (char)(du % 10 + 48) + result;
                    du /= 10;
                }

                if (length > 0)
                {
                    string returnNum = null;
                    for (int i = 0; i < (number[1].Length - length); i++)
                    {
                        char charNum = number[2][(i + length)];
                        returnNum += Convert.ToString(charNum);
                    }
                    number[2] = returnNum;
                }
                else
                {
                    string returnNum = null;
                    for (int i = 0; i < (number[2].Length - Math.Abs(length)); i++)
                    {
                        char charNum = number[1][(i + Math.Abs(length))];
                         returnNum += Convert.ToString(charNum);
                    }
                    number[1] = returnNum;
                }
                return "\tKET QUA: " + number[1] + " + " + number[2] + " = " + result;
            }
            else
                return "\tTHONG BAO LOI:\t\t" + warning;
        }
    }
}
