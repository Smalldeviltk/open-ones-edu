using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _41_Add2N
{
    class TinhToan
    {
        static string[] number;
        private static bool isNumber = true; // Biến tín hiệu, chuỗi nhập vào có đúng cú pháp, hay có phải là số hợp lệ hay không
        private static int tt = -1; // Biến dùng để đặt giá trị cho từng trường hợp, để có thông báo lỗi cụ thể

        // Hàm kiểm tra lỗi cú pháp, tính hợp lệ của số nhập vào
        public static void _KiemTra()
        {
            number = HienThi._NhapThongTin(); // Thực hiện nhập thông tin để kiểm tra

            if (number.Length == 3)
            {
                
                if (number[0].ToLowerInvariant().Equals("add2n") == false)
                {
                    isNumber = false;
                    tt = 0; // Lỗi cú pháp
                }
            }
            
            // Kiểm tra số thứ nhất nhập vào có hợp lệ hay không.
            for (int l = 0; l < number[1].Length; l++)
            {
                if (number[1][l] < 48 || number[1][l] > 57)
                {
                    isNumber = false;
                    tt = 1; // Số thứ 1 không hợp lệ
                }
            }

            // Kiểm tra số thứ hai nhập vào có hợp lệ hay không.
            for (int m = 0; m < number[2].Length; m++)
            {
                if (number[2][m] < 48 || number[2][m] > 57)
                {
                    isNumber = false;
                    if (tt == 1) tt = 3; // Cả 2 số không hợp lệ
                    else tt = 2; // Số thứ 2 không hợp lệ
                }
            }
            if (tt == 0)
            {
                Console.WriteLine("Cu phap khong hop le");
            }
            else
            {
                if (tt == 1)
                {
                    Console.WriteLine("{0} khong hop le.", number[1]);
                }
                else
                {
                    if (tt == 2)
                    {

                        Console.WriteLine("{0} khong hop le.", number[2]);
                    }
                    else if (tt == 3)
                    {
                        Console.WriteLine("{0} khong hop le.", number[1]);
                        Console.WriteLine("{0} khong hop le.", number[2]);
                    }
                }
            }

        }

        //Hàm cộng 2 số nguyên dương lớn
        public static string _Cong()
        {
            _KiemTra(); // Kiểm tra trước khi thực hiện Cộng

            string temp = null; // Biến chứa kết quả cộng trả về
           
            if (!isNumber)
            {
                return null; // Kết quả Null khi không cộng được các số không hợp lệ
            }
            else
            {

                int biennho = 0; // Biến nhớ khi thực hiện phép cộng
                int i = 0;
                // Thực hiện cân bằng chiều dài giữa 2 số - Trường hợp 1: Số thứ 1 dài hơn số thứ 2
                if (number[1].Length >= number[2].Length)
                {
                    i = number[1].Length - 1;
                    string t = null;
                    for (int j = 0; j < number[1].Length - number[2].Length; j++)
                    {
                        t += "0";


                    }

                    number[2] = t + number[2];
                }
                else // Thực hiện cân bằng chiều dài giữa 2 số - Trường hợp 2: Số thứ 2 dài hơn số thứ 1
                {
                    i = number[2].Length - 1;
                    string t = null;
                    for (int j = 0; j < number[2].Length - number[1].Length; j++)
                    {
                        t += "0";


                    }
                    number[1] = t + number[1];
                }
                while (i < number[1].Length && i >= 0) // Thực hiện phép cộng như tính toán bằng tay
                {
                    int t = 0;
                    t = (number[1][i]) - 48 + (number[2][i]) - 48 + biennho;
                    if (t >= 10)
                    {
                        biennho = 1;
                        t = t % 10;
                    }
                    else
                        biennho = 0;
                    
                    temp += t.ToString();

                    i--;

                }
                if (biennho != 0)
                {
                    int t = 1;
                    temp += t.ToString();
                }
            }
            return temp;            
        }

        public static string _KetQua()
        {
            string temp = _Cong(); // Biến lưu kết quả cộng
            if (temp == null)
            {
                return null;
            }
            else
            {
                char[] chrResult = new char[100];
                string strResult = number[1] + " + " + number[2] + " = ";
                chrResult = temp.ToCharArray(); 
                Array.Reverse(chrResult);
                strResult += new string(chrResult);
                return strResult;
            }
        }
    }

}
