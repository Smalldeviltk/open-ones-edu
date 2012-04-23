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
        private string[] m_str;

        // Initialization
        public View(string[] _str)
        {
            m_str = _str;
        }

        /// <summary>
        /// Check error for input
        /// </summary>
        /// <param name="_bigInteger1"></param>
        /// <param name="_bigInteger2"></param>
        /// <returns></returns>
        public bool IsHaveError(ref BigInteger _bigInteger1, ref BigInteger _bigInteger2)
        {
            return true;
        }

        /// <summary>
        /// Export result for user
        /// </summary>
        /// <param name="_number1"> number 1 </param>
        /// <param name="_number2"> number 2 </param>
        /// <param name="_result"> result </param>
        public void ExportResult(string _number1, string _number2, string _result)
        {
        }
    }
}
