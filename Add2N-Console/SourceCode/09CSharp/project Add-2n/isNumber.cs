
//----------------------------------------- ///
//  Class add_2n, co 2 phuong thuc:         ///
//          tinh toan va hien thi ket qua   ///
//------------------------------------------///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace add_2n
{

        //Kiem tra du lieu nhap co hop le hay khong???
        public void isNumber(String s)
        {
            int n;
            try
            {
                for (int i = 0; i < s.Length - 1; i++)
                {
                    n = int.Parse(s[i].ToString());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("{0} khong hop le.", s);
            }
        }
}
