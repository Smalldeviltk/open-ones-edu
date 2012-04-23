using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strChuoiNhap = View.NhapChuoi();
            if (!Logic.KiemTraChuoi(strChuoiNhap)) return;
            View.XuatKetQua(strChuoiNhap[0], strChuoiNhap[1]);
        }
    }
}
