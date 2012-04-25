//////////////////////////////////////////////////////////////////////////
///
/// FileName: BigIntger.cs
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
///  25/04/2012     Pham Tan Long           Add Add2BigInteger Func
///  25/04/2012     Pham Tan Long           Edit coding convention
///  
//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class BigInteger
    {
        // string describe the big integer
        string strInteger;

        // Get and set variable strInteger
        public string StringInteger
        {
            get { return strInteger; }
            set { strInteger = value; }
        }

        // Construction
        public BigInteger()
        {
            strInteger = null;
        }

        /// <summary>
        /// Add 2 big integer number 
        /// </summary>
        /// <param name="bigInteger"> number will be added</param>
        /// <returns> result </returns>
        public string Add2BigInteger(BigInteger bigInteger)
        {
            StringBuilder result = new StringBuilder(); // Result of addition

            // Return string is most shortest
            int length = (StringInteger.Length > bigInteger.StringInteger.Length)
                         ? bigInteger.StringInteger.Length
                         : StringInteger.Length;

            // Save temp for addition
            int temp = 0;

            for (int i = 0; i < length; ++i)
            {
                // sum of 2 number
                int sum = Int32.Parse(strInteger[i].ToString()) +
                            Int32.Parse(bigInteger.StringInteger[i].ToString()) +
                            temp;

                temp = sum / 10; // temp of addition

                result.Insert(i, (sum % 10).ToString()); // Insert sum into result string
            }

            // Continue insert remain of longer string 
            if (StringInteger.Length > length)
            {
                for (int i = length; i < StringInteger.Length; ++i)
                {
                    int sum = Int32.Parse(strInteger[i].ToString()) + temp;
                    temp = sum / 10;
                    result.Insert(i, (sum % 10).ToString());
                }

                // Add temp into result string
                if (temp > 0)
                {
                    result.Insert(StringInteger.Length, temp.ToString());
                }
            }
            else
            {
                // Continue insert remain of longer string 
                if (bigInteger.StringInteger.Length > length)
                {
                    for (int i = length; i < bigInteger.StringInteger.Length; ++i)
                    {
                        int sum = Int32.Parse(bigInteger.StringInteger[i].ToString()) + temp;
                        temp = sum / 10;
                        result.Insert(i, (sum % 10).ToString());
                    }

                    // Add temp into result string
                    if (temp > 0)
                    {
                        result.Insert(bigInteger.StringInteger.Length, temp.ToString());
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

            return result.ToString(); // return result string
        }    
    }
}
