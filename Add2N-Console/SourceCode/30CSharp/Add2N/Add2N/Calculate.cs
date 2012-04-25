using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    /*
     * Class Calculate phục vụ tính toán
     */
    class Calculate
    {
        public Calculate()
        {
        }

        /*
         * Hàm tính tổng các số dưới dạng List
         */
        public List<int> Sum(List<int> listNumber1, List<int> listNumber2)
        {
            List<int> listSum = new List<int>();
            int max = (listNumber1.Count > listNumber2.Count ? listNumber1.Count : listNumber2.Count);
            int re = 0; // Số nhớ

            // Thêm dư ra một số 0 để phòng ngừa việc cộng có dư ở cột lớn nhất
            for (int i = listNumber1.Count; i <= max; i++)
                listNumber1.Add(0);
            for (int i = listNumber2.Count; i <= max; i++)
                listNumber2.Add(0);

            // Tiến hành cộng 2 list
            for (int i = 0; i <= max; i++)
            {
                int temp = listNumber1[i] + listNumber2[i] + re;
                re = 0;
                if (temp >= 10) // Nếu lớn hơn 10 thì nhớ 1
                {
                    temp = temp % 10;
                    re = 1;
                }
                listSum.Add(temp); // Thêm vào list kết quả
            }

            // Xóa đi số 0 dư (nếu có)
            if (listSum[listSum.Count - 1] == 0)
            {
                listSum.RemoveAt(listSum.Count - 1);
            }

            return listSum; // Trả về kết quả
        }
    }
}
