//////////////////////////////////////////////////////////////////////////
///
/// FileName: View.cs
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
///  24/04/2012     Truong Le Van Cuong     Add Delete0String and ReverseString Func
///  24/04/2012     Pham Van Tu             Add IsHaveError Func
///  25/04/2012     Phan Hoài               Add ExportResult Func
///  25/04/2012     Nguyen Khac Trung       Fix comment for Delete0String and ReverseString Func
///  25/04/2012     Pham Tan Long           Edit coding convention
///  
//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Add2N
{
    class View
    {
        // Input
        private string[] strInput;

        // Initialization
        public View(string[] str)
        {
            strInput = str;
        }


        /// <summary>
        ///  Delete zero before string (Exception number 0)
        /// </summary>
        /// <param name="str"> String will be processed</param>
        public void Delete0InString(ref string str)
        {
            for (int i = 0; i < str.Length - 1; ++i)
            {
                if (str[i] == '0')
                {
                    str.Remove(0); //Delete Zero
                }
                else
                {
                    return; // Exit loop
                }
            }
        }


        /// <summary>
        /// Reveres string
        /// </summary>
        /// <param name="str"> String will be reversed</param>
        /// <returns> String was reversed</returns>
        public string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray(); // Convert string to array
            Array.Reverse(charArray); // Reverse array
            return new string(charArray); // Return string was reversed
        }


        /// <summary>
        /// Check error for input
        /// </summary>
        /// <param name="bigInteger1">The first big number</param>
        /// <param name="bigInteger2">The second big number</param>
        /// <returns>The value number1 + number2</returns>
        public bool IsHaveError(ref BigInteger bigInteger1, ref BigInteger bigInteger2)
        {
            // Check syntax
            if (strInput.Length != 2)
            {
                Console.WriteLine("Sai cu phap! Cu phap: Add2N <SoThu1> <SoThu2>");
                Console.WriteLine("*-----------------------------*");

                return true; // Return having error
            }
            else
            {
                bool error = false; // Check error
                Regex myRegex = new Regex(@"^\d{1,}$"); // Condition

                // Check error for number 1
                if (!myRegex.IsMatch(strInput[0]))
                {
                    error = true; // Having error
                    Console.Write(strInput[0] + " ");
                }

                // Check error for number 1
                if (!myRegex.IsMatch(strInput[1]))
                {
                    error = true; // Having error
                    Console.Write(strInput[1] + " ");
                }

                if (error)
                {
                    Console.WriteLine("Khong hop le!");
                    Console.WriteLine("*-----------------------------*");

                    return true; // Return having error
                }
            }
            Delete0InString(ref strInput[0]);
            bigInteger1.StringInteger = ReverseString(strInput[0]);
            Delete0InString(ref strInput[1]);
            bigInteger2.StringInteger = ReverseString(strInput[1]);

            return false; // None having error
        }


        /// <summary>
        /// Export result for user
        /// </summary>
        /// <param name="number1"> number 1 </param>
        /// <param name="number2"> number 2 </param>
        /// <param name="result"> result </param>
        public void ExportResult(string number1, string number2, string result)
        {
            Console.WriteLine(ReverseString(number1) +
                                " + " +
                                ReverseString(number2) +
                                " = " +
                                ReverseString(result));
            Console.WriteLine("*-----------------------------*");
        }
    }
}
