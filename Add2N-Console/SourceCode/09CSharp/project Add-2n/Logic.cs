

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace add_2n
{
    class Add2N
    {
        private String s3 = "";

        View view = new View();

        //Phuong thuc tinh tong 2 so nguyen lon (s1>s2)
        //  Du lieu vao: s1, s2 -> ket qua s3 cua lop
        public String add2N(String s1, String s2)
        {
            int[] s;
            s = new int[s1.Length + 1];     //Tao mang luu ket qua

            int j = s2.Length - 1, tam = 0, odd = 0;

            for (int i = s1.Length - 1; i >= 0; i--)
            {
                if (j < 0)      //Khi da het chuoi s2( s1>s2 )
                {
                    if (odd == 1)
                    {
                        s[i + 1] = int.Parse(s1[i].ToString()) + 1;     ///Cong them 1 neu soDu = 1
                        odd = 0;
                    }
                    else
                        s[i + 1] = int.Parse(s1[i].ToString());
                }
                else
                {
                    //Cong lan luot nhu cong bang tay (Cong tu cuoi chuoi den dau chuoi)
                    tam = int.Parse(s1[i].ToString()) + int.Parse(s2[j].ToString()) + odd;
                    if (tam < 10)
                    {
                        s[i + 1] = tam;         //Truong hop khong nho
                        odd = 0;
                    }
                    else
                    {
                        s[i + 1] = tam - 10;    //Truong hop co nho 1
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
                for (int i = 0; i < s1.Length + 1; i++)
                {
                    this.s3 = this.s3 + s[i].ToString();
                }
            }
            else
            {
                for (int i = 1; i < s1.Length + 1; i++)
                {
                    this.s3 = this.s3 + s[i].ToString();
                }
            }
            return this.s3; ///Tra ve
        }

        //Kiem tra du lieu nhap co hop le hay khong???
        //  Hop le tr ve true, nguoc lai la false
        public Boolean isNumber(String s)
        {
            foreach (Char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        
    }
}
