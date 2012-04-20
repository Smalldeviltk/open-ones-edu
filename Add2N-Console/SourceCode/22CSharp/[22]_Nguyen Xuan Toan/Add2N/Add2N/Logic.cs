using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class Logic
    {
        public static bool kt = true;
        public static string KiemTra(string[] strInput)
        {
            string s = "";
            bool k = false;
            kt = true;
            if (strInput.Length == 1 && strInput[0] == "exit")
                return "exit";
            if (strInput.Length != 3) 
            {
                kt = false; return "Nhap ma lenh khong dung !!!. Phai co 3 tham so truyen vao. ex: Add2N 1 2";
            }
            if (strInput[0] != "Add2N")
            {
                s = "Ma lenh chuong trinh khong dung !!!. Phai ghi dung Add2N\n";
                kt = false;
            }
            for(int i=0; i< strInput[1].Length; i++)
            {
                if (strInput[1][i] < 48 || strInput[1][i] > 57) 
                {
                    s += "Tham so thu nhat khong dung!!!";
                    k = true;
                    kt = false;
                    break;
                }
            }
            for (int i = 0; i < strInput[2].Length; i++)
            {
                if (strInput[2][i] < 48 || strInput[2][i] > 57)
                {
                    if (k)
                        s += "Tham so thu nhat va thu hai khong dung !!!";
                    else 
                    s += "Tham so thu hai khong dung !!!";
                    kt = false;
                    break;
                }
            }
            return s;
        }
        public static string strOutput(string[] strInput)
        {
            int nho=0, tong;
            string  c = "";
	       
		    while (strInput[1].Length<strInput[2].Length) strInput[1]= '0'+strInput[1];
		    while (strInput[2].Length<strInput[1].Length) strInput[2]= '0'+strInput[2];
	        for(int i=strInput[1].Length-1; i>=0; i--)
	        {
		        tong = strInput[1][i] +strInput[2][i] -96 + nho;		
		        c=(char)((tong%10) + 48) + c;
		        nho=tong/10;
	        }
	        while (nho>0) 
	        {
		        c=(char)(nho%10+48) +c;
		        nho/=10; 
	        }
            return c;
        }

    }
}
