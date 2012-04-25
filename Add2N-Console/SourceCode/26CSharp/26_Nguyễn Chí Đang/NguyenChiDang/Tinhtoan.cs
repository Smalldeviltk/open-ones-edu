using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class TinhToan
    {
        static string[] number;
        static string KetQua;
        static bool KiemTra = true;
        static string CanhBao;

        public static void KiemTraPT()
        {
            number = null;
            KetQua = null;
            KiemTra = true;
            CanhBao = null;

            number = HienThi.PhepTinh();

            if (number.Length == 3)
            {
                if (number[0]!="Add2N")
                {
                    CanhBao += number[0] + " khong hop le";
                    KiemTra = false;
                }
                
                for (int i = 0; i < number[1].Length; i++)
                {
                    if (number[1][i] < 48 || number[1][i] > 57)
                    {
                        KiemTra = false;
                        if (CanhBao == null)
                        {
                            CanhBao += number[1] + " khong hop le";
                            break;
                        }
                        else
                        {
                            CanhBao += ", " + number[1] + " khong hop le";
                            break;
                        }
                    }
                }

                for (int i = 0; i < number[2].Length; i++)
                {
                    if (number[2][i] < 48 || number[2][i] > 57)
                    {
                        KiemTra = false;
                        if (CanhBao == null)
                        {
                            CanhBao += number[2] + " khong hop le";
                            break;
                        }
                        else
                        {
                            CanhBao += ", " + number[2] + " khong hop le";
                            break;
                        }
                    }
                }
            }
            else
            {
                CanhBao +="Sai cau truc. Nhap Lai";
                KiemTra = false;
            }
        }

        public static string KetQuaPT()
        {
            KiemTraPT();
            if (KiemTra)
            {
                int Nho = 0; 
                int Tong;
                string[] Tam = new string[3];
                Tam[1] = number[1];
                Tam[2] = number[2];

                while (Tam[1].Length < Tam[2].Length) Tam[1] = '0' + Tam[1];
                while (Tam[2].Length < Tam[1].Length) Tam[2] = '0' + Tam[2];

                for (int i = Tam[1].Length - 1; i >= 0; i--)
                {
                    Tong = Tam[1][i] + Tam[2][i] - 96 + Nho;
                    KetQua = (char)((Tong % 10) + 48) + KetQua;
                    Nho = Tong / 10;
                }
                while (Nho > 0)
                {
                    KetQua = (char)(Nho % 10 + 48) + KetQua;
                    Nho /= 10;
                }

                return "\tKET QUA: " + number[1] +" + " + number[2] + " = " + KetQua;
            }
            else
                return "\nTHONG BAO LOI:" + CanhBao;
        }
    }
}