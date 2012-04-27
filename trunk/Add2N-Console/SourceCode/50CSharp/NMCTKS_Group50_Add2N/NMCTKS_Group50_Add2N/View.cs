//////////////////////////////////////////////////////////////////////////
///
/// FileName: View.cs
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
///  23/04/2012     Vũ Văn Hoàng           Creating
///                 Ngô An Ninh		   Creating
///
//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace NMCTKS_Group50_Add2N
{
    class View
    {

         // Input
        private string[] m_string;

        // Initialization
        public View(string[] _str)
        {
            m_string = _str;
        }

        /// <summary>
        ///  Remove first index before string (Exception number 0)
        /// </summary>
        /// <param name="_str"> String will be processed</param>
        public void Delete0InString(ref string _str)
        {
            for (int i = 0; i < _str.Length - 1; ++i)
            {
                if (_str[i] == '0')
                {
                    _str.Remove(0); //Remove First Index
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
        /// <param name="_str"> String will be reversed</param>
        /// <returns> String was reversed</returns>
        public string ReverseString(string _str)
        {
            char[] charArray = _str.ToCharArray(); // Convert string to array
            Array.Reverse( charArray ); // Reverse array
            return new string( charArray ); // Return string was reversed
        }

        /// <summary>
        /// Check error for input
        /// </summary>
        /// <param name="_bigInteger1"></param>
        /// <param name="_bigInteger2"></param>
        /// <returns></returns>
        public bool IsHaveError(ref BigInteger _bigInteger1, ref BigInteger _bigInteger2)
        {
            // Check syntax
            if (m_string.Length != 2)
            {
                Console.WriteLine("Sai cu phap, Cu phap la : Add2N <SoThu1> <SoThu2>");
                Console.WriteLine("*-----------------------------*");

                return true; // Return having error
            }
            else
            {
                bool error = false; // Check error
                Regex myRegex = new Regex(@"^\d{1,}$"); // Condition

                // Check error for number 1
                if (!myRegex.IsMatch(m_string[0]))
                {
                    error = true; // Having error
                    Console.Write(m_string[0] + " ");
                }

                // Check error for number 1
                if (!myRegex.IsMatch(m_string[1]))
                {
                    error = true; // Having error
                    Console.Write(m_string[1] + " ");
                }

                if (error)
                {
                    Console.WriteLine("Chua hop le");
                    Console.WriteLine("******************");

                    return true; // Return having error
                }
            }

            Delete0InString(ref m_string[0]);
            _bigInteger1.BInteger = ReverseString(m_string[0]);
            Delete0InString(ref m_string[1]);
            _bigInteger2.BInteger = ReverseString(m_string[1]);

            return false; // None having error
        }

        /// <summary>
        /// Print result for user
        /// </summary>
        /// <param name="_number1"> number 1 </param>
        /// <param name="_number2"> number 2 </param>
        /// <param name="_result"> result </param>
        public void PrintResult(string _number1, string _number2, string _result)
        {
            Console.WriteLine(ReverseString(_number1) +
                                " + " + 
                                ReverseString(_number2) + 
                                " = " + 
                                ReverseString(_result));
            Console.WriteLine("*+++++++++++++++++++++++++*");
        }
    }
    
}
