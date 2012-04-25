using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class Program
    {
        static void Main(string[] args)
        {
            Program ct = new Program();
            string text = "";
            string s1 = "";
            string s2 = "";
            int x;
            Console.WriteLine("xin moi chon lua : 1. cong hai so nguyen  2.thoat    Xin cam on");
           
            x=Int32.Parse(Console.ReadLine());
            #region
            switch (x)
            {
                case 1:
                    {
                        ct.Nhap(ref text, ref s1, ref s2);
                        string Sum = ct.Cong(s1, s2);
                        Console.Write("Tong la {0} ", Sum);
                        Console.ReadLine();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Xin Cam On");
                        Console.ReadLine();
                        break;
                    }
            }
            #endregion

        }
        public void Nhap(ref string text, ref string b, ref string c)
        {
            Console.WriteLine("xin nhap vao theo cu phap Add2N sothunhat sothuhai");
            Console.WriteLine("neu ban nhap ki tu se bao loi. Dong chuong trinh !");
            text = Console.ReadLine();
            text = text.Trim();
            #region //Kiem tra tinh hop le
               Program ct = new Program();
               string a = "";
         
                byte count = 0;
                ct.ChiaText(text, ref a, ref b, ref c, ref count);
                int kt1 = 0, kt2 = 0;
                foreach (char i in b)
                {
                    if (!Char.IsDigit(i))
                    {
                        kt1++;
                    }
                }
                foreach (char i in c)
                {
                    if (!Char.IsDigit(i))
                    {
                        kt1++;
                    }
                }
                if (a != "Add2N" || kt1 != 0 || kt2 != 0)
                {
                    Console.WriteLine("{0} {1} {2} ", a, b, c);
                   
                }
                if (count != 2)
                {
                    Console.WriteLine("Sai cu phap, kiem tra lai: Add2N <So thu nhat> <So thu hai>");
                }
            
#endregion
        }
        public void ChiaText(string text, ref string a, ref string b, ref string c, ref byte count)
        {

            int x = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    if (x == 0)
                    {
                        a = text.Substring(x, i);
                        x = i + 1;
                        count++;
                    }
                    if (x > 0 && i > x)
                    {
                        b = text.Substring(x, i - x);
                        x = i + 1;
                        count++;
                    }
                }
                if (i == text.Length - 1)
                {
                    c = text.Substring(x, text.Length - x);
                }
            }
        }
        public string Cong(string strX, string strX1)
        {
            string strResult = "";
            //---lưu kết quả nhớ hay không nhớ mỗi lần thực hiện:1-nhớ và 0-không nhớ-----------
            int rem = 0;
            for (int i = strX.Length - 1; i >= 0; i--)
            {
                //-------------Cộng 2 số (2 kí tự) tương ứng của 2 xâu và giá trị nhớ-----------       
                int nResult = int.Parse(strX[i].ToString()) + int.Parse(strX1[i].ToString()) + rem;
                if (i > 0)//---chưa phải là kí tự ở bên trái nhất--------
                {
                    if (nResult > 9)//----------------Nếu kết quả 2 chữ số---------------
                    {
                        rem = 1;//-------------Nhớ kết quả cho lần sau---------
                        nResult -= 10;//-----------Lấy hàng đơn vị:ví dụ:9+9=18=>18-10= 8 thui----
                    }
                    else
                        rem = 0;//-------------Không có nhớ-----------------
                }
                //-----------------gán giá trị cho xâu kết quả--------------
                strResult = nResult.ToString() + strResult;
            }
            return strResult;
        }  
    }
}
