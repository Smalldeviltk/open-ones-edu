using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace ADD2N_NHOM29
{
    class CHECK_INPUT
    {
        public bool checkInput(string s1)
        {
            bool flag = true;
            Regex regexDou1 = new Regex(@"^[1-9]+[0-9]*\.{0,1}[0-9]*[1-9]+$");
            Regex regexDou2 = new Regex(@"^0{1}\.[0-9]*[1-9]+$");  //dang 0.

            Regex regexInt = new Regex(@"^[1-9]{1}[0-9]*$");
            Match m1 = regexInt.Match(s1);
            Match m3 = regexDou1.Match(s1);
            //Match m4 = regexDou1.Match(s2);
            Match m5 = regexDou2.Match(s1);
            //Match m6 = regexDou2.Match(s2);
            if (!m1.Success && !m3.Success && !m5.Success)
                flag = false;
            return flag;
        }
        public bool checkInput(string s1, string s2)
        {
            bool flag = true;
            Regex regexDou1 = new Regex(@"^[1-9]+[0-9]*\.{0,1}[0-9]*[1-9]+$");
            Regex regexDou2 = new Regex(@"^0{1}\.[0-9]*[1-9]+$");  //dang 0.

            Regex regexInt = new Regex(@"^[1-9]{1}[0-9]*$");
            Match m1 = regexInt.Match(s1);
            Match m2 = regexInt.Match(s2);
            Match m3 = regexDou1.Match(s1);
            Match m4 = regexDou1.Match(s2);
            Match m5 = regexDou2.Match(s1);
            Match m6 = regexDou2.Match(s2);

            if ((!m1.Success && !m3.Success && !m5.Success) ||
                                    (!m2.Success && !m4.Success && !m6.Success))
                flag = false;
            return flag;
        }
    }
}
