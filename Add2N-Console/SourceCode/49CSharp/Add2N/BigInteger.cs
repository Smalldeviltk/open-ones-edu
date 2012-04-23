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
        /// <param name="_bigInteger"> number will be added</param>
        /// <returns> result </returns>
        public string Add2BigInteger(BigInteger _bigInteger)
        {
            return null;
        }    
    }
}
