 static void Main(string[] args)     //Mạnh và Trí code 
        {
            Console.Title = "CHUONG TRINH CONG HAI SO NGUYEN";
            string[] s = new string[3];
            BEGIN:
            while(true)
            {
                bool sign = true, flag = false; int index = 0;
                string temp;
 
                Console.WriteLine("\n\n*******************************************");
                Console.WriteLine("****  CHUONG TRINH CONG HAI SO NGUYEN  ****");
                Console.Write("- NHAP 2 SO CAN TINH TONG THEO LENH : Add2N ");
         
                temp = Console.ReadLine();
                temp = ConvertFormatString(temp);//chuyen cho cac chuoi chi con cach nhau bang mot dau cach
                temp.Trim();
                if(temp.Substring(0,1) == " ")
                    temp = temp.Substring(1, temp.Length - 1);
                
                s = temp.Split(' ');

                try//kiem tra trong phan tu mang s co rong hay khong
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (s[i].ToString() == "")
                        {
                            flag = true;
                            break;
                        }
                    }
                }
                catch (System.Exception) { }
                
                if (flag)//tinh do dai cua chuoi
                    index = s.Length - 1;
                else
                    index = s.Length;

                if (!CheckCountRef(index))//kiem tra so luong doi so
                {
                    sign = false;
                }

                foreach (string c in s)//kiem tra doi so co phai la so nguyen khong???
                    if (!CheckRef(c)) 
                    {
                        sign = false;
                    }

                if (sign)//neu thoa dieu kien thi thuc hien tinh tong
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("=====================================");
            Console.WriteLine(" ==>Ket Qua: {0} + {1} = {2}", s[0], s[1], Sum(s[0], s[1]));
            for (int i = 0; i < 2; i++)
                s[i] = "";
            goto BEGIN;
        }   
