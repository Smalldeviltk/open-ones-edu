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
static string ConvertFormatString(string st)
        {
            Regex myRegex = new Regex(@"\s+");
            return myRegex.Replace(st, " ");
        }
