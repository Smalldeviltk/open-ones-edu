#region Copyright Group 19
//
// All rights are reserved. Reproduction or transmission in whole or 
// in part, in any form or by any means, electronic, mechanical or
// otherwise, is prohibited without the prior written consent of the 
// copyright owner.
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
            Console.Clear();
                try
                {
                    View.TitleIntro();
                    string strChoice;
                    do
                    {
                        View.Output(Logic.Calculator());
                        Console.WriteLine("\nBan co muon tiep tuc khong?");
                        Console.Write("\t\tChon (Yes=1/No=0): ");
                        strChoice=Console.ReadLine().Trim();
                    }
                    while (strChoice.Equals("1") || strChoice.ToLowerInvariant().Equals("yes"));
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
        ///<summary>
        ///<summary>
    }
}
