using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Baitap_NMCTKS
{
    class Program
    {
        
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

        static string ConvertFormatString(string st)
        {
            Regex myRegex = new Regex(@"\s+");
            return myRegex.Replace(st, " ");
        }

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

        static void Main(string[] args)
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
    }
}
