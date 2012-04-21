using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class View
    {
        public View()
        {
        }

        private bool IsValid(string strnumber)
        {
            for (int i = 0; i < strnumber.Count(); i++)
            {
                if (!((strnumber[i] < 58) && (strnumber[i] > 47)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
