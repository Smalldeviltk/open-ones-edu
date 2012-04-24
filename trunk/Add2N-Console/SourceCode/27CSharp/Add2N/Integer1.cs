using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add2N
{
    /// <summary>
    /// Tran Trung Tam.
    /// </summary>
    public partial class Integer
    {
        protected List<char> sequence;

        public List<char> Sequence
        {
            get { return this.sequence; }

            set { this.sequence = value; }
        }

        /// <summary>
        /// Ham tao mac dinh
        /// </summary>
        public Integer()
        {
            this.sequence = new List<char>();
        }

        /// <summary>
        /// Ham tao sao chep
        /// </summary>
        /// <param name="integer1">1 doi tuong can duoc sao chep</param>
        public Integer(Integer integer1)
        {
            integer1.CopySequence(out this.sequence);
        }

        /// <summary>
        /// Ham them 1 ky tu duoc nhap tu ban phim vao chuoi so nguyen
        /// </summary>
        /// <param name="c">ki tu nhap tu ban phim</param>
        public void Input(char c)
        {
            this.sequence.Add(c);
        }

        /// <summary>
        /// Ham gan chuoi o dang list sang chuoi o dang string
        /// </summary>
        /// <returns>tra ve 1 chuoi cac ki tu duoc sao chep tu list</returns>
        public string Output()
        {
            string s = " ";

            foreach (char Item in this.sequence)
            {

                s += Convert.ToString(Item);
            }
            return s;
        }

        /// <summary>
        /// Ham kiem tra ky tu khong hop le
        /// </summary>
        /// <returns>neu ky tu ko hop le tra ve kieu false, va nguoc lai</returns>
        public bool CheckErrorCharacter()
        {
            foreach (char Item in sequence)
            {
                if (((int)Item < 48) || ((int)Item > 57))
                    return false;
            }
            return true;
        }
    }
}
