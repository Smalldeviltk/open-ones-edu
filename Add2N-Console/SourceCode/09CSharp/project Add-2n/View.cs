﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add_2n
{
    class View
    {
        private String s1;
        private String s2;

        public View()
        {
            s1 = "";
            s2 = "";
        }

        //Gan gia tri x, y cho gia tri s1, s2 cua lop (s1.Length > s2.Length)
        public void setNumber(String x, String y)
        {
            if (x.Length > y.Length)
            {
                this.s1 = x;
                this.s2 = y;
            }
            else
            {
                this.s1 = y;
                this.s2 = x;
            }
        }

        //  Hiển thị ra màn hình
        //  Lấy phương thức add2N của class Logic để tính toán
        
        public void showResult(String x, String y)
        {
            Logic bNumber = new Logic();
            String s = bNumber.add2N(this.s1, this.s2);
            Console.WriteLine("\n\tKet Qua: {0} + {1} = {2}", x, y, s);
        }

    }
}