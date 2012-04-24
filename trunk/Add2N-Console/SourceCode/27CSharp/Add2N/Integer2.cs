using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    /// <summary>
    /// Tran Khanh Duy
    /// </summary>
    public partial class Integer
    {
        /// <summary>
        /// Ham cong 2 chuoi so nguyen
        /// </summary>
        /// <param name="integer1">doi tuong co chuoi duoc cong voi chuoi cua doi tuong this</param>
        /// <returns>tra ve 1 doi tuong moi sau khi da cong 2 chuoi so nguyen</returns>
        /// <example>12345678 + 12 = 12345690</example>
        public Integer Sum(Integer integer1)
        {
            Integer integer2 = new Integer();
            int length = this.CompareSequence(integer1);
            int remainder = 0;

            for (int i = length - 1; i >= 0; --i)
                integer2.sequence.Add(this.SumInteger(integer1, i, ref remainder));

            if (remainder == 1)
                integer2.sequence.Add('1');

            this.ReduceSequence();
            integer1.ReduceSequence();

            return integer2;
        }

        /// <summary>
        /// Ham so sanh do dai cua 2 chuoi
        /// </summary>
        /// <param name="integer1">doi tuong co chuoi duoc so sanh do dai voi chuoi cua doi tuong this</param>
        /// <returns>tra ve do dai cua chuoi dai nhat</returns>
        public int CompareSequence(Integer integer1)
        {
            int var = this.sequence.Count - integer1.sequence.Count;

            if (var != 0)
            {
                if (var > 0)
                {
                    integer1.ChangeSequence(var);
                    return this.sequence.Count;
                }
                else
                {
                    this.ChangeSequence(var * -1);
                    return integer1.sequence.Count;
                }
            }
            return this.sequence.Count;
        }

        /// <summary>
        /// Ham cong tung phan tu cua 2 chuoi so nguyen voi nhau
        /// </summary>
        /// <param name="var">phan tu thu var cua 2 chuoi so nguyen duoc cong voi nhau</param>
        /// <param name="remainder">so du</param>
        /// <returns>tra ve ma ky tu ASCII cua so nguyen sau khi cong</returns>
        /// <example>"1" + "2" = "3"------>ma ASCII cua '3' la 51 </example>
        public char SumInteger(Integer integer1, int var, ref int remainder)
        {
            //ket qua sau khi cong
            int i = Calculate((int)this.sequence[var] - 48, (int)integer1.sequence[var] - 48, ref remainder);

            return Convert.ToChar(i + 48);
        }

        /// <summary>
        /// Ham thuc hien phep tinh cua 2 so nguyen
        /// </summary>
        /// <param name="var1">so nguyen 1</param>
        /// <param name="var2">so nguyen 2</param>
        /// <param name="remainder">so du</param>
        /// <returns>tra ve gia tri cua so nguyen sau khi duoc cong</returns>
        public int Calculate(int var1, int var2, ref int remainder)
        {
            int i = var1 + var2 + remainder;

            if (i < 10)
            {
                remainder = 0;
                return i;
            }
            else
            {
                remainder = 1;
                return i - 10;
            }
        }
    }
}
