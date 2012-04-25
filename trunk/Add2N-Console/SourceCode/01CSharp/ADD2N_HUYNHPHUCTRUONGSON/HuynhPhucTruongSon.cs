static bool CheckRef(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9' || c == '-')
                {
                    Console.WriteLine("<*> DOI SO '" + str + "' KHONG HOP LE ");
                    return false;
                }
            }
            return true;
        }

        static bool CheckCountRef(int index)
        {
            if (index > 2 )
            {
                Console.WriteLine("\n=========   THONG-BAO-LOI    ==========");
                Console.WriteLine("======   VUOT QUA HAI DOI SO   ========");
                return false;
            }
            else if (index == 1)
            {
                Console.WriteLine("=========   THONG-BAO-LOI    ==========");
                Console.WriteLine("======= MOT DOI SO SAO MA TINH ========");
                return false;
            }
            return true;
        }
