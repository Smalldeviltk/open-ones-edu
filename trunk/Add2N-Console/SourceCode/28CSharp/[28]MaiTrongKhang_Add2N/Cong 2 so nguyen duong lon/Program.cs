using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cong_2_so_nguyen_duong_lon
{
    class Program
    {
        static void Main(string[] args)
        {

            string strOutput="";
            string strNumber1="",strNumber2="";
            View.Input(ref strNumber1, ref strNumber2);
            strOutput = View.Output(strNumber1, strNumber2);
                      
        }
        
    }
}
