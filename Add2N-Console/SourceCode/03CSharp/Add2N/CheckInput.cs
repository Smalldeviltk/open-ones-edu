using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    partial class Calculator
    {
        /* Khai bao chi tiet ham kiem tra chuoi nhap vao co 
         * hop le hay khong (nghia la nhung ki tu cua chuoi 
         * deu la 0 - 9 (Digit) */
        private bool CheckInput(String str)
        {

            for (int i = 0; i < str.Length; i++)
                /* Neu co bat ky ki tu nao trong chuoi str khong phai
                 * la Digit (so nguyen) thi ngay lap tuc tra ve false,
                 * ngung vong lap. */
                if (!Char.IsDigit(str[i])) 
                    return false;
            return true;
            /* Ket qua cua ham se la false neu chuoi khong hop le, true 
             * neu nguoc lai */
        }
    }
}
