
//----------------------------------------- ///
//  Class add_2n, co 2 phuong thuc:         ///
//          tinh toan va hien thi ket qua   ///
//------------------------------------------///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace add_2n
{
    class bigNumber
    {
        private String s1;
        private String s2;
        private String s3 = "";

        //Constructor
        public bigNumber()
        {
            s1 = "";
            s2 = "";
        }

        //Dat gia tri cho class (s1 > s2)
        public void setNumber(String s1, String s2)
        {
            this.s1 = s1;
            this.s2 = s2;
        }

        //Lay ket qua
        public String getResult()
        {
            return this.s3;
        }
        
        //Phuong thuc hien thi ket qua
        public void showResult(String x, String y)
        {
            Console.WriteLine("Ket qua: {0} + {1} = {2}", x, y, this.s3);
        }

        //Phuong thuc tinh tong 2 so nguyen lon (s1>s2)
        public String add2N()
        {
            int[] s;
            s = new int[this.s1.Length +1];     //Tao mang luu ket qua

            int j = this.s2.Length - 1, tam = 0, odd = 0;
            
            for (int i = this.s1.Length - 1; i >= 0; i--)
            {
                if (j < 0)      //Khi da het chuoi s2( s1>s2 )
                {
                    if (odd == 1)
                    {
                        s[i+1] = int.Parse(this.s1[i].ToString()) + 1;     ///Cong them 1 neu soDu = 1
                        odd = 0;
                    }
                    else
                        s[i+1] = int.Parse(this.s1[i].ToString());
                }
                else
                {
                    //Cong lan luot nhu cong bang tay (Cong tu cuoi chuoi den dau chuoi)
                    tam = int.Parse(this.s1[i].ToString()) + int.Parse(this.s2[j].ToString()) + odd;
                    if (tam < 10)
                    {
                        s[i+1] = tam;         //Truong hop khong nho
                        odd = 0;
                    }
                    else
                    {
                        s[i+1] = tam - 10;    //Truong hop co nho 1
                        odd = 1;
                    }
                }
                j--;
            }

            //Chuyen mang s sang kieu chuoi
            if (odd == 1)
            {                
                //Neu so du cuoi cung la 1, them 1 vao dau ket qua.
                s[0] = 1;
                for (int i = 0; i < this.s1.Length + 1; i++)
                {
                    this.s3 = this.s3 + s[i].ToString();
                }
            }
            else
            {
                for (int i = 1; i < this.s1.Length + 1; i++)
                {
                    this.s3 = this.s3 + s[i].ToString();
                }
            }
            return this.s3; ///Tra ve
        }

        //Kiem tra du lieu nhap co hop le hay khong???
        public void isNumber(String s)
        {
            int n;
            try
            {
                for (int i = 0; i < s.Length - 1; i++)
                {
                    n = int.Parse(s[i].ToString());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("{0} khong hop le.", s);
            }
        }
    }
}
