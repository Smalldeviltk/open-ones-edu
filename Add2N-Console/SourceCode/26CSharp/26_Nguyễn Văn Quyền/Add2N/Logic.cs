using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class Logic
    {
        static string fault;
        public static bool ok = true;
        public static string Test(string[] In)
        {
            fault = null;
            string s = "";
            ok = true;

            if (In.Length != 3)
            {
                ok = false;
                return ">>>> Cu phap sai ! yeu cau nhap theo dung cu phap o tren\n";
            }
            if (In[0] != "Add2N")
            {
                ok = false;
                return s = "Ma lenh khong dung ! Phai la Add2N\n";
                
            }
            for (int i = 0; i < In[1].Length; i++)
            {
                if (In[1][i] < 48 || In[1][i] > 57)
                // Kiểm tra chuỗi tham số nhập vào có phải là chuối ký tự số hay không
                // Các ký tự số 0 -> 9 dao động từ 48 -> 57 trong mã ASCII
                {
                    ok = false;                    
                    if (fault == null)
                            fault += "\n" + In[1] + " khong hop le\n";
                                         
                    break;
                }
            }
            for (int i = 0; i < In[2].Length; i++)
            {
                if (In[2][i] < 48 ||In[2][i] > 57)
                {
                    if (fault == null)
                        fault += "\n" + In[2] + " khong hop le";
                    if (fault.Contains(In[2] + " khong hop le") == false)
                        fault += In[2] + " khong hop le\n";
                    ok = false;
                    break;
                }
            }
            return fault;
        }
        public static string Out(string[] In)
        {
            int nho = 0, tong;
            string kq = "";
            while (In[1].Length < In[2].Length) In[1] = '0' + In[1];//thêm số 0 vào đằng trước các số ngắn hơn để dễ thực hiện phép cộng
            while (In[2].Length < In[1].Length) In[2] = '0' + In[2];//
            for (int i = In[1].Length - 1; i >= 0; i--)
            {
                tong = In[1][i] + In[2][i] - 96 + nho;
                kq = (char)((tong % 10) + 48) + kq;
                nho = tong / 10;
            }
            while (nho > 0)
            {
                kq = (char)(nho % 10 + 48) + kq;
                nho /= 10;
            }
            return kq;                  
        }        
    }
}
