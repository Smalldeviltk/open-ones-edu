using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add_2n
{
    class Logic
    {
        //Kiem tra du lieu nhap co hop le hay khong???
        //  Hop le tr ve true, nguoc lai la false
        public Boolean isNumber(String s)
        {
            foreach (Char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }
}
