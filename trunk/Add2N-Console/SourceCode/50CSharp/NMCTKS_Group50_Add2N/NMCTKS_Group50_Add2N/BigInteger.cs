//////////////////////////////////////////////////////////////////////////
///
/// FileName: BigInteger.cs
/// 
/// Version:  1.0
/// 
/// Created Date: 22/04/2012
/// 
/// Copyright: NMCTKS_Group50_Add2N
/// 
/// Modification Logs:
///     DATE            AUTHOR              DESCRIPTION
/// -----------------------------------------------------
///  22/04/2012     Vũ Minh Tuấn       Creating
///                 Võ Thái Hòa
///
//////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace NMCTKS_Group50_Add2N
{
    class BigInteger
    {
        // Big Integer
        string m_bInteger;

        // Get and set variable m_bInteger
        public string BInteger
        {
            get { return m_bInteger; }
            set { m_bInteger = value; }
        }

        // Initialization
        public BigInteger()
        {
            m_bInteger = null;
        }

        /// <summary>
        /// Add 2 big integer number 
        /// </summary>
        /// <param name="_bigInteger"> Number will be added</param>
        /// <returns> result </returns>
        public string Add2BigInteger(BigInteger _bigInteger)
        {
            StringBuilder result = new StringBuilder(); // Result of addition
            // Return string is most shortest
            int length = (BInteger.Length > _bigInteger.BInteger.Length)
                         ? _bigInteger.BInteger.Length
                         : BInteger.Length;
            // Save temp for addition
            int temp = 0;

            for (int i = 0; i < length; ++i)
            {
                // sum  2 number
                int sum = Int32.Parse(m_bInteger[i].ToString()) +
                            Int32.Parse(_bigInteger.BInteger[i].ToString()) +
                            temp;

                temp = sum / 10; // temp of addition

                result.Insert(i, (sum % 10).ToString()); // Insert sum into result string
            }

            // Continue insert remain of longer string 
            if (BInteger.Length > length)
            {
                for (int i = length; i < BInteger.Length; ++i)
                {
                    int sum = Int32.Parse(m_bInteger[i].ToString()) + temp;
                    temp = sum / 10;
                    result.Insert(i, (sum % 10).ToString());
                }
                // Add temp into result string
                if (temp > 0)
                {
                    result.Insert(BInteger.Length, temp.ToString());
                }
            }
            else
            {
                // Continue insert remain of longer string 
                if (_bigInteger.BInteger.Length > length)
                {
                    for (int i = length; i < _bigInteger.BInteger.Length; ++i)
                    {
                        int sum = Int32.Parse(_bigInteger.BInteger[i].ToString()) + temp;
                        temp = sum / 10;
                        result.Insert(i, (sum % 10).ToString());
                    }
                    // Add temp into result string
                    if (temp > 0)
                    {
                        result.Insert(_bigInteger.BInteger.Length, temp.ToString());
                    }
                }
                else // 2 string's length equal
                {
                    // Add temp into result string
                    if (temp > 0)
                    {
                        result.Insert(length, temp.ToString());
                    }
                }
            }

            return result.ToString(); // return string result
        }
    }
}
