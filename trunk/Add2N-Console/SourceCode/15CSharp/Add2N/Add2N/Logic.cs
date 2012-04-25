using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class Logic
    {
        public Logic()
        {
        }
        public string Add(string _number1, string _number2)
        {
            RepairNumber(ref _number1,ref  _number2);
            List<int> number1;
            List<int> number2;
            List<int> number3;
            int n = 0, temp = 0;
            string strtemp = "";
            number1 = new List<int>();
            number2 = new List<int>();
            number3 = new List<int>();
            for(int i=_number1.Length-1;i>=0;i--)number1.Add(Convert.ToInt32(Convert.ToString(_number1[i])));
            for (int i = _number2.Length - 1; i >= 0; i--) number2.Add(Convert.ToInt32(Convert.ToString(_number2[i])));
            for (int i = 0; i < number1.Count;i++ )
            {
                n = (number1[i] + number2[i] + temp) % 10;
                temp = (number1[i] + number2[i] + temp) / 10;
                number3.Add(n);
            }
            if (temp != 0) number3.Add(temp);
            for (int i = 0; i < number3.Count; i++) strtemp=strtemp.Insert(i, Convert.ToString(number3[number3.Count-i-1]));
            return strtemp;
        }
        public bool Check(string _number)//check for right format of number
        {
            foreach (char c in _number)
            {
                if (!char.IsNumber(c)) return false;
            }
            return true;
        }
        public void RepairNumber(ref string _number1,ref string _number2)//add 0 to have the same number of character in each number
        {
            if (_number1.Length != _number2.Length)
            {
                if (_number1.Length < _number2.Length)
                {
                    for (int i = _number1.Length; i < _number2.Length; i++)_number1= _number1.Insert(0, "0");
                }
                else
                {
                    for (int i = _number2.Length; i < _number1.Length; i++)_number2= _number2.Insert(0, "0");
                }
            }
        }
    }
}
