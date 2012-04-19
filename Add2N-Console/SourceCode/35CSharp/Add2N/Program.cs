using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    class Program
    {
        //Kiểm tra xem chuỗi số có hợp lệ hay không
        public static bool hople(string s, bool x)
        {
            int l = s.Length;
            //Kiểm tra từng phần tử của chuỗi
            for (int i = 0; i < l; i++)
            {
                if (s.Substring(i, 1).ToString().CompareTo("0") == 0 || s.Substring(i, 1).ToString().CompareTo("1") == 0 || s.Substring(i, 1).ToString().CompareTo("2") == 0 || s.Substring(i, 1).ToString().CompareTo("3") == 0 || s.Substring(i, 1).ToString().CompareTo("4") == 0 || s.Substring(i, 1).ToString().CompareTo("5") == 0 || s.Substring(i, 1).ToString().CompareTo("6") == 0 || s.Substring(i, 1).ToString().CompareTo("7") == 0 || s.Substring(i, 1).ToString().CompareTo("8") == 0 || s.Substring(i, 1).ToString().CompareTo("9") == 0 && s.Substring(i, 1).ToString() != "-" && s.Substring(i, 1).ToString() != ".") x = false;
                else
                {
                    x = true;
                    break;
                }
            }
            return x;
        }

        //Kiểm tra chuỗi nhập vào
        public static bool kiemtra(string s0, string s1, string s2, bool t)
        {
            bool x = false;
            //Chuỗi nhập vào phải đủ từ khóa, số thứ nhất, số thứ 2
            if(s0==""||s1==""||s2=="")
            {
                Console.WriteLine("Cu phap nhap vao co dang: Add2N <So thu nhat> <So thu hai>");
                t = false;
            }
            //Kiểm tra từ khóa Add2N
            else if (!(s0.ToString().CompareTo("Add2N") == 0))
            {
                Console.WriteLine("Cu phap nhap vao co dang: Add2N <So thu nhat> <So thu hai>");
                t = false;
            } 
            //Cả số thứ nhất và số thứ 2 đều không hợp lệ
            else if (hople(s1, x) && hople(s2, x))
            {
                Console.WriteLine(s1 + ", " + s2 + " khong hop le");
                t = false;
            }
            //Kiểm tra từng số có hợp lệ không
            else if (hople(s1, x) || hople(s2, x))
            {
                //Kiểm tra số thứ nhất
                if (hople(s1, x))
                {
                    Console.WriteLine(s1 + " khong hop le");
                    t = false;
                }
                //Kiểm tra số thứ 2
                else if (hople(s2, x))
                {
                    Console.WriteLine(s2 + " khong hop le");
                    t = false;
                }
            }
            else t = true;
            return t;
        }

        //Cộng 2 số
        public static string cong(string s1, string s2, string tong)
        {
            int l = 0;
            //Lấy độ dài của chuỗi dài nhất
            if (s1.Length >= s2.Length) l = s1.Length;
            else
            {
                l = s2.Length;
                //Mặc định chuỗi dài nhất là chuỗi 1
                string temp = s1;
                s1 = s2;
                s2 = temp;
            }
            //Gán độ dài cho tổng
            char[] sum = new char[l + 1];
            int t = 0, m = 0;
            //Đổi 2 số sang kiểu mảng
            char[] rs1 = s1.ToCharArray();
            char[] rs2 = s2.ToCharArray();
            //Đảo ngược 2 mảng
            Array.Reverse(rs1);
            Array.Reverse(rs2);
            //Cộng từng phần tử của 2 mảng với nhau
            for (int i = 0; i < rs2.Length; i++)
            {
                t = Convert.ToInt32(rs1[i].ToString()) + Convert.ToInt32(rs2[i].ToString()) + m;
                //Nếu tổng lớn hơn 9 thì lấy tổng trừ 10 rồi nhớ 1
                if (t > 9)
                {
                    t -= 10;
                    m = 1;
                }
                else m = 0;
                sum[i] = Convert.ToChar(t.ToString());
            }
            //Khi độ dài mảng 2 ngắn hơn mảng 1 thì cộng từng phần tử tiếp theo của mảng 1 vào tổng
            for (int i = s2.Length; i < s1.Length; i++)
            {
                t = Convert.ToInt32(rs1[i].ToString()) + m;
                if (t > 9)
                {
                    t -= 10;
                    m = 1;
                }
                else m = 0;
                sum[i] = Convert.ToChar(t.ToString());
            }
            //Nếu cộng xong mà có nhớ thì phần tử cuối cũng của tổng sẽ là 1
            if (m == 1) sum[sum.Length - 1] = Convert.ToChar("1");
            //Đuổi ngược mảng tổng
            Array.Reverse(sum);
            //Đuổi tổng sang kiểu chuỗi
            for (int i = 0; i < (sum.Length); i++) tong = tong + sum[i].ToString();
            tong.Trim();
            return tong;
        }
        
        public static void Main()
        {
            string s = "";
            string s0 = "", s1 = "", s2 = "", tong = "";
            //Tạo vòng lặp vô hạn để nhập chuỗi, thoát khi chuỗi nhập vào hợp lệ
            while (true)
            {
                bool t = false;
                //Nhập chuỗi
                s = Console.ReadLine();
                int l = s.Length;
                int t1 = 0, t2 = 0, count = 0;
                //Lấy từng chuỗi con
                //Lấy từ khóa
                for (int i = 0; i < l; i++)
                {
                    //Khi thấy khoảng trống đầu tiên thì lấy ra chuỗi con là từ khóa
                    if (s.Substring(i, 1) == " ")
                    {
                        t1 = i;
                        s0 = s.Substring(0, t1);
                        break;
                    }
                    //Nếu không thấy khoảng trống thì mặc định cả chuỗi nhập vào là từ khóa, số thứ nhất và số thứ 2 là NULL
                    else
                    {
                        t1 = i+1;
                        s0 = s.Substring(0, t1);
                        s1 = s2 = "";
                    }
                }
                //Lấy số thứ nhất
                for (int i = (t1 + 1); i < l; i++)
                {
                    //Khi thấy khoảng trống tiếp thì lấy ra số thứ nhất
                    if (s.Substring(i, 1) == " ")
                    {
                        count = 1;
                        t2 = i - t1 - 1;
                        s1 = s.Substring(t1 + 1, t2);
                        t1 = i;
                        break;
                    }
                    //Nếu không thấy khoản trống thì mặc định chuỗi con tiếp theo sau khoảng trống đầu tiên là số thứ nhất
                    else
                    {
                        t2 = i - t1;
                        s1 = s.Substring(t1 + 1, t2);
                    }
                }
                //Không có khoảng trống thì số thứ 2 là NULL
                if (count == 0)
                {
                    t1 = l;
                    s2 = "";
                }
                //Lấy số thứ 2
                for (int i = (t1 + 1); i < l; i++)
                {
                    //Khi thấy khoảng trống tiếp theo thì lấy ra số thứ 2
                    if (s.Substring(i, 1) == " ")
                    {
                        t2 = i - t1 - 1;
                        s2 = s.Substring(t1 + 1, t2);
                        break;
                    }
                    //Nếu không thấy khoảng trống thì mặc định chuỗi con từ khoảng trống thứ 2 đến hết chuỗi là số thứ 2
                    else
                    {
                        t2 = i - t1;
                        s2 = s.Substring(t1 + 1, t2);
                    }
                }
                //Kiểm tra chuỗi nhập vào, nếu đúng thì thoát vòng lặp
                if (kiemtra(s0, s1, s2, t)) break;
            }
            //Tính tổng
            tong = cong(s1, s2, tong);
            Console.WriteLine(s1 + " + " + s2 + " = " + tong);
            Console.ReadLine();
        }
    }
}