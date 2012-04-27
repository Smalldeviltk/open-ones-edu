//////////////////////////////////////////////////////////////////////////
///
/// FileName: Program.cs
/// 
/// Version:  1.0
/// 
/// Created Date: 23/04/2012
/// 
/// Copyright: NMCTKS_Group50_Add2N
/// 
/// Modification Logs:
///     DATE            AUTHOR              DESCRIPTION
/// -----------------------------------------------------
///  23/04/2012     lê Phước Aí         Creating
///
//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace NMCTKS_Group50_Add2N
{
    class Program
    {
        static void Main(string[] args)
        {
            View view = new View(args);
            BigInteger bigInteger1 = new BigInteger();
            BigInteger bigInteger2 = new BigInteger();

            Console.WriteLine("*++++++++++++++++++++*");

            // Continue if have error
            if (view.IsHaveError(ref bigInteger1, ref bigInteger2))
            {
                return; // Exit
            }
            else
            {
                //Print result
                view.PrintResult(bigInteger1.BInteger, bigInteger2.BInteger, bigInteger1.Add2BigInteger(bigInteger2));
            }
        }
    }
}
