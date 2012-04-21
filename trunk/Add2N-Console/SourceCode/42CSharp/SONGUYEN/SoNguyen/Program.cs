using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SONGUYEN
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string input;
            string number1; string number2;
            Begin();
            input = Console.ReadLine();
            while (Space(input) != 1)
            {
                Console.WriteLine("Bạn phải nhập <number 1>space<number 2>, vi du: 10 20");
                Console.ReadLine();
                Begin();
                input = Console.ReadLine();
            }            
            //Kiem tra cu phap                
             number1 = Cut(input, 0);
             number2 = Cut(input, 1);
             
            if (Number(number1, number2) == true)            
            Console.Write("{0} + {1} = {2}", number1, number2, tinhTong(number1, number2));
                     
            Console.ReadLine();
        }

        //Hàm khởi tạo Add2N ban đầu
        static void Begin()
        {
            Console.Clear();
            Console.WriteLine();
            Console.Write("Add2N ");            
        }
        static int Space(string input)
        {
            int cout = 0;
            char[] check = input.ToCharArray();
            for (int i = 0; i < check.Length; i++)
            {
                if (check[i].ToString() == " ")
                    cout++;
            }
            return cout;
        }
        //Hàm cắt chuỗi
        static string Cut(string input,int so)
        {
            string[] strSplit = input.Split(' ');
            return strSplit[so];           
        }
        //Hàm kiểm tra chuỗi là số hay kí tự
        static bool Check(string input)
        {
            char[] temp = input.ToCharArray();
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] > 57 || temp[i] < 48)
                    return false;
            }
            return true;
        }
        //Hàm xuất chuỗi nếu chuỗi là chuối kí tự
        //Trả về giá trị "true" nếu hai chuỗi đều là số
        //Trả về giá trị "false" nếu không phải là số
        //Gọi hàm này xong nếu "true" thì thực hiện phép cộng
        static bool Number(string number1, string number2)
        {
            int temp = 0;
            if (Check(number1) == false)
                {
                    Console.WriteLine("{0} nhap ko chinh xac",number1);
                    temp++;
                } 
             if (Check(number2) == false)
                {
                     Console.WriteLine("{0} nhap ko chinh xac",number2);
                     temp++;
                }
            if (temp == 0)
                return true;
            return false;
        }
        static void chuanHoaSo(ref string so1, ref string so2)
        {
            if (so1.Length > so2.Length)
            {so2 = "0" + so2;}
            else 
                if(so2.Length>so1.Length) 
                    so1 = "0" + so1;
            if(so1.Length != so2.Length)
            {chuanHoaSo(ref so1,ref so2);}
        }
        static string tinhTong(string so1, string so2)
        {
            string s;
            int t, a, b, nho = 0;
            int n;
            if (so1.Length != so2.Length)
            {
                chuanHoaSo(ref so1, ref so2);
            }
            //Console.Write("{0}  {1}    ", so1, so2);
            StringBuilder kq = new StringBuilder("");
            n = so1.Length - 1;
            while (n >= 0)
            {
                a = so1[n] - 48;
                b = so2[n] - 48;
                t = a + b + nho;
                s = t.ToString();
                if (s.Length == 1) s = "0" + s;
                nho = s[0] - 48;
                kq.Insert(0, s[1]);
                n--;
            }
            if (nho == 1) kq.Insert(0, "1");
            return kq.ToString();
        }
     

    }
}
