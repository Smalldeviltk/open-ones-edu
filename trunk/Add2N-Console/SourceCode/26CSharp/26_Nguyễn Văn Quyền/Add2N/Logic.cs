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
                    ok = false;
                    if (fault == null)
                        fault += "\n" + In[2] + " khong hop le";
                    break;
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
            string[] temp = new string[3];
            temp[1] = In[1];
            temp[2] = In[2];
            string kq = "";
            while (temp[1].Length < temp[2].Length) temp[1] = '0' + temp[1];//thêm số 0 vào đằng trước các số ngắn hơn để dễ thực hiện phép cộng
            while (temp[2].Length < temp[1].Length) temp[2] = '0' + temp[2];//
            for (int i = temp[1].Length - 1; i >= 0; i--)
            {
                tong = temp[1][i] + temp[2][i] - 96 + nho;
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
