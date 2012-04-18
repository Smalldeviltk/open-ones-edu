using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoNguyen
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string input="";
            string number1=""; string number2="";  
            Begin();            
            while (input != "x")
            {
                input = Console.ReadLine();
               // if (input == "x") continue;
                int j = 0;
                Cut(input, ref number1, ref number2, ref j);
                if (j != 2)
                {
                    Console.WriteLine("Nhap dung cu phap <so1> <so2>");
                    Console.ReadLine();
                }
                else
                {

                    if (Number(number1, number2) == true)
                    {
                        Console.Write("{0} + {1} = {2}", number1, number2, tinhTong(number1, number2));
                        Console.ReadLine();
                    }
                    else
                        Console.ReadLine();
                }
                Begin();
            }
            
        }

        //Hàm khởi tạo Add2N ban đầu
        static void Begin()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Chuong trinh cong 2 so lon (dang string)");
            Console.WriteLine("1. Cu' phap Add2N <so1> <s2>");
            Console.WriteLine("2. Nhap x & enter de ket thuc \n");
            Console.Write("Add2N ");            
        }
       
        //Hàm cắt chuỗi
        static void Cut(string input,ref string num1, ref string num2,ref int j)
        {          
           // input = " " + input + " ";
            string[] strSplit = input.Split(' ');
            string[] Chuoiso =new string[strSplit.Length]; 
            for (int i = 0; i < strSplit.Length; i++)
            {
                //neu kho phai la khoan trong thi la kytu nhap vao number1 va 2
                if (strSplit[i] != "")
                {                  
                    Chuoiso[j] = strSplit[i];
                    j++;//neu j len qua' 2 so thi bao j ve va kt j ko 2 so thi loi
                }
            }
            if (j == 2)
            {
                num1 = Chuoiso[0];
                num2 = Chuoiso[1];
            }
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
            if (Check(number1) == false && Check(number2) == false)
            {
                Console.Write("{0},{1} nhap ko chinh xac", number1, number2);
                temp++;
            }
            else
            {
                if (Check(number1) == false)
                {
                    Console.WriteLine("{0} nhap ko chinh xac", number1);
                    temp++;
                }

                if (Check(number2) == false)
                {
                    Console.WriteLine("{0} nhap ko chinh xac", number2);
                    temp++;
                }
            }
            if (temp == 0)
               return true;
              return false;
               
        }
        //Ham chuanhoaso dua so dang nhu  5 + 15 thi dua ve 05 + 15
        static void chuanHoaSo(ref string so1, ref string so2)
        {
            if (so1.Length > so2.Length)
            {so2 = "0" + so2;}
            else 
                if(so2.Length>so1.Length) 
                    so1 = "0" + so1;
            if(so1.Length != so2.Length)
            {chuanHoaSo(ref so1,ref so2);
        }
        }
        //Ham cong 
        static string tinhTong(string so1, string so2)
        {
            string s;
            int t, a, b, nho = 0;
            int n;
            if (so1.Length != so2.Length)
            {
                chuanHoaSo(ref so1, ref so2);
            }
            
            StringBuilder kq = new StringBuilder("");
            n = so1.Length - 1;
            while (n >= 0)
            {
                a = so1[n] - 48;
                b = so2[n] - 48;
                t = a + b + nho;
                s = t.ToString();
                if (s.Length == 1) s = "0" + s;
                //Cong neu < 10 thi them 0 -> nho' 0 neu cong lon hon 10(2chu so) lay so thap phan nho'
                nho = s[0] - 48;
                //So don vi con lai cho vao ket qua
                kq.Insert(0, s[1]);
                n--;
            }
            if (nho == 1) kq.Insert(0, "1");
            return kq.ToString();
        }    
    }
}
