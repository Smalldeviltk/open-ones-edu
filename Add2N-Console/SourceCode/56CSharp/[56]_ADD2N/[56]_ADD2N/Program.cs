using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _56__ADD2N
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat;
            do
            {
                string[] ChuoiNhap = View.NhapChuoi();
                if (Logic.KiemTraChuoi(ChuoiNhap)) View.KetQua(ChuoiNhap[0], ChuoiNhap[1]);
                repeat = View.LapLai();              
            } while (repeat);
        }
    }
}
