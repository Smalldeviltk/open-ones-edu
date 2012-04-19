using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cong_2_so_nguyen_duong_lon
{
    class View
    {
        /// <summary>
        /// This method is use for generating number 1 and number 2 by requesting input string (under format) from the user 
        /// </summary>
        /// <param name="strNumber1"></param>
        /// <param name="strNumber2"></param>
        public static void Input(ref string strNumber1,ref string strNumber2)
        {
            string strError = " khong hop le";
            string strInput = "";
            bool blnError1 = true;
            bool blnError2 = true;
            Console.WriteLine("Cu phap Add2N <so thu nhat> <so thu hai>");
            Console.Write("Add2N ");
            strInput = Console.ReadLine();
            string[] strSplit = strInput.Split(new char[] { ' ' });
            if (strSplit.Length != 2)
                Console.WriteLine("Your Input format is not correct");
            blnError1 = Logic.isDigit(strSplit[0]);
            blnError2 = Logic.isDigit(strSplit[1]);
            if (!blnError1 && !blnError2)
            {
                Console.WriteLine(strSplit[0] + " , " + strSplit[1] + strError);
                return;
            }
            if (!blnError1)
            {
                Console.WriteLine(strSplit[0] + strError);
                return;
            }
            if (!blnError2)
            {
                Console.WriteLine(strSplit[1] + strError);
                return;
            }
            strNumber1 = strSplit[0];
            strNumber2 = strSplit[1];
        }
        /// <summary>
        /// this method is used for calculating output string from 2 input string strNumber1 and strNumber2
        /// </summary>
        /// <param name="strNumber1"></param>
        /// <param name="strNumber2"></param>
        /// <returns>stringOutput, which is the result of the calculation</returns>
        public static string Output(string strNumber1,string strNumber2)
        {
            string strOutput;
            strOutput = Logic.Add2N(strNumber1, strNumber2);
            Console.WriteLine(strNumber1 + " + " + strNumber2 + " = " + strOutput);
            Console.ReadLine();
            return strOutput;
        }
    }
}
