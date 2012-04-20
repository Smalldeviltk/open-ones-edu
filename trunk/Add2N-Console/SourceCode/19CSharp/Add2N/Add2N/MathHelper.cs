using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Add2N
{
    static class MathHelper
    {
        public static bool CheckSyntax(string arg)
        {
            for (int i = 0; i < arg.Length; i++)
            {
                if (!Char.IsDigit(arg[i])) return false;
            }
            return true;
        }
    }
}
