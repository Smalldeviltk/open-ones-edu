#region Copyright Group 19
//
// All rights are reserved. Reproduction or transmission in whole or // in part, in any form or by any means, electronic, mechanical or
// otherwise, is prohibited without the prior written consent of the // copyright owner.
//
// Filename: Program.cs
//
#endregion
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
