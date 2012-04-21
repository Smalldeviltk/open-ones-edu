using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class Calculate
    {
        public Calculate()
        {
        }
        public List<int> Sum(List<int> listNumber1, List<int> listNumber2)
        {
            List<int> listSum = new List<int>();
            int max = (listNumber1.Count > listNumber2.Count ? listNumber1.Count : listNumber2.Count);
            int re = 0;
            for (int i = listNumber1.Count; i <= max; i++)
                listNumber1.Add(0);
            for (int i = listNumber2.Count; i <= max; i++)
                listNumber2.Add(0);
            for (int i = 0; i <= max; i++)
            {
                int temp = listNumber1[i] + listNumber2[i] + re;
                re = 0;
                if (temp >= 10)
                {
                    temp = temp % 10;
                    re = 1;
                }
                listSum.Add(temp);
            }
            if (listSum[listSum.Count - 1] == 0)
            {
                listSum.RemoveAt(listSum.Count - 1);
            }

            return listSum;
        }
    }
}
