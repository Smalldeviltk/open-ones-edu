using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    /// <summary>
    /// Le Van
    /// </summary>
    public partial class Integer
    {
        /// <summary>
        /// Ham rut gon chieu dai chuoi khi co ky tu '0' dung o dau
        /// </summary>
        /// <example>"00001234" -------> "1234"</example>
        public int ReduceSequence()
        {
            int count = this.sequence.Count;

            while (this.sequence.First<char>() == '0')
            {
                this.sequence.RemoveAt(0);
                count = this.sequence.Count;
                if (count == 0)
                    return 1;
            }
            return 0;
        }

        /// <summary>
        /// Ham dao nguoc chuoi so nguyen
        /// </summary>
        /// <example>"12345"-------->"54321"</example>
        public void InvertSequence()
        {
            List<char> sequence1;
            int count = this.sequence.Count;

            this.CopySequence(out sequence1);
            this.sequence = new List<char>();

            for (int i = count - 1; i >= 0; --i)
                this.sequence.Add(sequence1[i]);
        }

        /// <summary>
        /// Ham copy 1 chuoi so nguyen
        /// </summary>
        /// <param name="sequence1">chuoi so nguyen duoc sao chep tu chuoi so nguyen khac</param>
        public void CopySequence(out List<char> sequence1)
        {
            int count = this.sequence.Count;
            sequence1 = new List<char>();

            for (int i = 0; i < count; ++i)
                sequence1.Add(this.sequence[i]);
        }

        /// <summary>
        /// Ham them vao cac ky tu '0' vao dau chuoi, voi so luong ki tu them vao cho truoc
        /// </summary>
        /// <param name="var">so luong ky tu '0' duoc them vao</param>
        /// <example>var = 3, "1234" -------->"0001234"</example>
        public void ChangeSequence(int var)
        {
            int count;

            for (int i = 0; i < var; ++i)
            {
                this.sequence.Add('0');
                count = this.sequence.Count;

                for (int j = count - 1; j > 0; --j)
                {
                    this.sequence[j] = this.sequence[j - 1];
                }

                this.sequence[0] = '0';
            }
        }
    }
}
