//////////////////////////////////////////////////////////////////////////
///
/// FileName: Program.cs
/// 
/// Version:  1.0
/// 
/// Created Date: 23/04/2012
/// 
/// Copyright: DTHT.Group49
/// 
/// Modification Logs:
///     DATE            AUTHOR              DESCRIPTION
/// -----------------------------------------------------
///  23/04/2012     Nguyen Khac Trung       Creating
///  25/04/2012     Pham Tan Long           Edit coding convention
///  
//////////////////////////////////////////////////////////////////////////

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
            // Declare variants
            View view = new View(args);
            BigInteger bigInteger1 = new BigInteger();
            BigInteger bigInteger2 = new BigInteger();

            Console.WriteLine("*-----------------------------*");

            // Continue if having error
            if (view.IsHaveError(ref bigInteger1, ref bigInteger2))
            {
                // Do nothing
            }
            else
            {
                //Export result for user
                view.ExportResult(bigInteger1.StringInteger, bigInteger2.StringInteger, bigInteger1.Add2BigInteger(bigInteger2));
            }

            // Pause for debugging
            Console.Read();
        }
    }
}
