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
    class Program
    {
        static void Main(string[] args)
        {
            char[] chr = new char[100];
            if (args != null && args.Length == 2)
            {
                try
                {
                    String res = Logic.Cong(args[0], args[1]);
                    chr = res.ToCharArray();
                    Console.WriteLine(res);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi:" + e.Message);
                }
                finally
                {
                    Console.ReadKey();
                }
            }
        }
    }
}
