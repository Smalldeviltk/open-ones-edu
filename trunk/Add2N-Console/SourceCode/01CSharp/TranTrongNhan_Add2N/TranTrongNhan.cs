static int Sum(char c1, char c2)
        {
            int a = (int) char.GetNumericValue(c1);
            int b = (int) char.GetNumericValue(c2);
            return (a + b);
        }
static string Sum(string st1, string st2)
        {
            string kq = "";
            int l1 = st1.Length;
            int l2 = st2.Length;
            int nho = 0, i = 0;
            while ((i < l1) && (i < l2))
            {
                int temp = Sum(st1[l1 - 1 - i], st2[l2 - 1 - i]) + nho;
                kq = (temp % 10).ToString() + kq;
                nho = temp / 10;
                i++;
            }
            while (i < l1)
            {
                int temp = Sum(st1[l1 - 1 - i], '0') + nho;
                kq = (temp % 10).ToString() + kq;
                nho = temp / 10;
                i++;
            }
            while (i < l2)
            {
                int temp = Sum(st1[l2 - 1 - i], '0') + nho;
                kq = (temp % 10).ToString() + kq;
                nho = temp / 10;
                i++;
            }
            if (nho != 0) kq = nho.ToString() + kq;
            return kq;
        }
